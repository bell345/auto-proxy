using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using NetworkL;

namespace AutoProxy
{
    public partial class MainConfig : Form
    {
        public List<Network> networkList;
        public string currentNetworkName = null;

        public Network activeNetwork = null;
        public Timer networkCheckTimer = new Timer();

        private bool updatingFields = false;

        private static Dictionary<TriggerMethod, string> triggerMethodMap = null;

        public MainConfig()
        {
            InitializeComponent();
            networkList = Network.LoadNetworks();
            if (triggerMethodMap == null)
            {
                triggerMethodMap = new Dictionary<TriggerMethod, string>();
                triggerMethodMap[TriggerMethod.CONNECTED_AP] = "Wireless AP (connected)";
                triggerMethodMap[TriggerMethod.AVAILABLE_AP] = "Wireless AP (available)";
                triggerMethodMap[TriggerMethod.GATEWAY_MAC] = "Gateway MAC Address";
                triggerMethodMap[TriggerMethod.SERVER_REACHABLE] = "Server is available";
            }
            triggerMethodCombo.DataSource = new BindingSource(triggerMethodMap, null);
            triggerMethodCombo.DisplayMember = "Value";
            triggerMethodCombo.ValueMember = "Key";

            networkNameBox.Items.AddRange(networkList
                .Select(nw => nw.Name).ToArray());

            currentNetworkName = "default";
            networkNameBox.SelectedItem = "default";

            networkCheckTimer.Interval = 5000; // 5 seconds
            networkCheckTimer.Tick += CheckActiveNetwork;
            networkCheckTimer.Start();
        }

        public Network GetCurrentNetwork()
        {
            foreach (Network nw in networkList)
            {
                if (nw.Name == currentNetworkName)
                    return nw;
            }

            Network newNetwork = CreateNetwork(networkNameBox.Text);
            networkList.Add(newNetwork);
            return newNetwork;
        }

        public Network CreateNetwork(string name)
        {
            Network nw = new Network();
            nw.Name = name;
            networkList.Add(nw);
            networkNameBox.Items.Add(nw.Name);
            return nw;
        }

        public void RemoveNetwork(string name)
        {
            if (name == "default")
            {
                MessageBox.Show(this, "Cannot remove default network.", "AutoProxy");
                return;
            }

            if (networkList.Count <= 1)
            {
                MessageBox.Show(this, "Cannot remove final network.", "AutoProxy");
                return;
            }

            if (MessageBox.Show(this, 
                    "Are you sure you want to remove this network? This action cannot be undone.", 
                    "AutoProxy", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Exclamation) != DialogResult.Yes)
            {
                return;
            }

            currentNetworkName = "default";

            Network network = networkList.Find(nw => (nw.Name == name));
            if (network == null)
            {
                UpdateFields(GetCurrentNetwork());
                return;
            }

            networkList.Remove(network);
            networkNameBox.Text = "default";
            networkNameBox.Items.Remove(name);
            network.Delete();

            UpdateFields(GetCurrentNetwork());
        }

        public Network UpdateNetwork(Network nw)
        {
            if (updatingFields)
                return nw;

            if (nw.Name != "default")
            {
                nw.TriggerMethod = ((KeyValuePair<TriggerMethod, string>)triggerMethodCombo.SelectedItem).Key;
                nw.TriggerQuery = triggerQueryBox.Text;
            }

            RadioButton proxyRadioChecked = this.Controls.OfType<RadioButton>()
                                                .FirstOrDefault(r => r.Checked);
            if (proxyRadioChecked == enableProxyButton)
                nw.EnableProxy = true;
            else if (proxyRadioChecked == disableProxyButton)
                nw.EnableProxy = false;
            else
                nw.EnableProxy = null;
            
            string proxy = proxyUrlBox.Text;
            ushort port = (ushort)proxyPortUpDown.Value;
            if (sharedProxyCheckbox.Checked)
            {
                nw.UseCommonProxy = true;
                nw.HttpProxy = proxy;
                nw.HttpPort = port;
            } else
            {
                nw.UseCommonProxy = false;
                switch (proxyTypeCombo.Text)
                {
                    case "HTTPS":
                        nw.HttpsProxy = proxy;
                        nw.HttpsPort = port;
                        break;
                    case "FTP":
                        nw.FtpProxy = proxy;
                        nw.FtpPort = port;
                        break;
                    case "SOCKS":
                        nw.SocksProxy = proxy;
                        nw.SocksPort = port;
                        break;

                    case "HTTP":
                    default:
                        nw.HttpProxy = proxy;
                        nw.HttpPort = port;
                        break;
                }
            }

            nw.ProxyExceptions = proxyExceptionsBox.Text;
            nw.LocalException = proxyLocalBypassCheckbox.Checked;
            nw.EnableAutoConfig = proxyAutoConfigCheckbox.Checked;
            nw.AutoConfigScript = proxyAutoConfigBox.Text;

            if (nw.Name != "default")
            {
                nw.ConnectScript = connectScriptBox.Text;
                nw.DisconnectScript = disconnectScriptBox.Text;
            }
            return nw;
        }

        public void UpdateFields(Network nw)
        {
            updatingFields = true;
            if (nw.Name != "default" && nw.TriggerMethod != TriggerMethod.INVALID)
            {
                triggerMethodCombo.SelectedItem = new KeyValuePair<TriggerMethod, string>(
                    nw.TriggerMethod, triggerMethodMap[nw.TriggerMethod]);
                triggerQueryBox.Text = nw.TriggerQuery;
            }
            triggerGroup.Enabled = (nw.Name != "default");

            if (nw.EnableProxy == true)
                enableProxyButton.Checked = true;
            else if (nw.EnableProxy == false)
                disableProxyButton.Checked = true;
            else
                automaticProxyButton.Checked = true;

            proxyGroup.Enabled = (nw.EnableProxy == true);

            sharedProxyCheckbox.Checked = nw.UseCommonProxy;
            switch (proxyTypeCombo.Text)
            {
                case "HTTPS":
                    proxyUrlBox.Text = nw.HttpsProxy;
                    proxyPortUpDown.Value = nw.HttpsPort;
                    break;
                case "FTP":
                    proxyUrlBox.Text = nw.FtpProxy;
                    proxyPortUpDown.Value = nw.FtpPort;
                    break;
                case "SOCKS":
                    proxyUrlBox.Text = nw.SocksProxy;
                    proxyPortUpDown.Value = nw.SocksPort;
                    break;

                case "HTTP":
                default:
                    proxyUrlBox.Text = nw.HttpProxy;
                    proxyPortUpDown.Value = nw.HttpPort;
                    break;
            }

            proxyExceptionsBox.Text = nw.ProxyExceptions;
            proxyLocalBypassCheckbox.Checked = nw.LocalException;
            proxyAutoConfigCheckbox.Checked = nw.EnableAutoConfig;
            proxyAutoConfigBox.Text = nw.AutoConfigScript;

            if (nw.Name != "default")
            {
                connectScriptBox.Text = nw.ConnectScript;
                disconnectScriptBox.Text = nw.DisconnectScript;
            }

            scriptGroup.Enabled = (nw.Name != "default");
            updatingFields = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new About()).ShowDialog(this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitOptionallySaving();
        }

        private void networkNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentNetworkName = networkNameBox.Text;
            UpdateFields(GetCurrentNetwork());
        }

        private void updateNetworkFromUI(object sender, EventArgs e)
        {
            UpdateNetwork(GetCurrentNetwork());
        }

        private void reloadUI(object sender, EventArgs e)
        {
            UpdateFields(GetCurrentNetwork());
        }

        private void radioCheckedChanged(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            if (button == enableProxyButton && button.Checked)
            {
                proxyGroup.Enabled = true;
            } else
            {
                proxyGroup.Enabled = false;
            }
        }

        private void sharedProxyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateNetwork(GetCurrentNetwork());
            if (((CheckBox)sender).Checked)
            {
                proxyTypeCombo.Text = "HTTP";
                proxyTypeCombo.Enabled = false;
            } else
            {
                proxyTypeCombo.Enabled = true;
            }
        }

        private void newNetworkButton_Click(object sender, EventArgs e)
        {
            currentNetworkName = networkNameBox.Text;
            UpdateFields(GetCurrentNetwork());
        }

        private void removeNetworkButton_Click(object sender, EventArgs e)
        {
            currentNetworkName = networkNameBox.Text;
            RemoveNetwork(currentNetworkName);
        }

        private void connectScriptButton_Click(object sender, EventArgs e)
        {
            connectFileDialog.ShowDialog(this);
            connectScriptBox.Text = connectFileDialog.FileName;
            UpdateNetwork(GetCurrentNetwork());
        }

        private void disconnectScriptButton_Click(object sender, EventArgs e)
        {
            disconnectFileDialog.ShowDialog(this);
            disconnectScriptBox.Text = disconnectFileDialog.FileName;
            UpdateNetwork(GetCurrentNetwork());
        }

        private void proxyAutoConfigCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            proxyAutoConfigBox.Enabled = (proxyAutoConfigCheckbox.Checked);
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            UpdateNetwork(GetCurrentNetwork());
            foreach (Network nw in networkList)
            {
                try
                {
                    nw.Save();
                } catch (Exception ex)
                {
                    MessageBox.Show(this, String.Format("Failed to save {0}: {1}",
                        Network.GetFileName(nw.Name), ex.Message), "AutoProxy");
                }
            }
            MessageBox.Show(this, "Saved successfully.", "AutoProxy");
            CheckActiveNetwork(null, null);
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            UpdateNetwork(GetCurrentNetwork());
            activeNetwork = null;
            CheckActiveNetwork(null, null);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            exitOptionallySaving();
        }

        private void MainConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();
                e.Cancel = true;
                notifyIcon.ShowBalloonTip(2000);
            }
        }

        private void openConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void exitOptionallySaving()
        {
            UpdateNetwork(GetCurrentNetwork());
            /*if (MessageBox.Show(this, 
                "Would you like to save the configuration before you exit?",
                "AutoProxy",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Asterisk) != DialogResult.Yes)
            {
                Application.Exit();
            }*/

            foreach (Network nw in networkList)
            {
                try
                {
                    nw.Save();
                } catch (Exception ex)
                {
                    MessageBox.Show(this, String.Format("Failed to save {0}: {1}",
                        Network.GetFileName(nw.Name), ex.Message), "AutoProxy");
                    //return;
                }
            }
            //MessageBox.Show(this, "Saved successfully.", "AutoProxy");
            Application.Exit();
        }

        private void CheckActiveNetwork(object sender, EventArgs e)
        {
            Network nw = Network.CheckNetworks(networkList);
            if (nw != activeNetwork)
            {
                if (activeNetwork != null && nw != null && nw.Name == activeNetwork.Name)
                    return;

                if (activeNetwork != null)
                {
                    activeNetwork.OnDisconnect();
                }

                if (nw != null)
                {
                    nw.OnConnect();
                    activeNetwork = nw;
                    notifyIcon.ShowBalloonTip(2000, "AutoProxy", 
                        String.Format("Connected to {0}", nw.Name), 
                        ToolTipIcon.Info);
                }
            }
        }
    }
}
