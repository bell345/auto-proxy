namespace AutoProxy
{
    partial class MainConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newNetworkButton = new System.Windows.Forms.Button();
            this.networkNameBox = new System.Windows.Forms.ComboBox();
            this.triggerGroup = new System.Windows.Forms.GroupBox();
            this.triggerQueryBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.triggerMethodCombo = new System.Windows.Forms.ComboBox();
            this.proxyGroup = new System.Windows.Forms.GroupBox();
            this.proxyAutoConfigBox = new System.Windows.Forms.TextBox();
            this.proxyAutoConfigCheckbox = new System.Windows.Forms.CheckBox();
            this.proxyLocalBypassCheckbox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.proxyExceptionsBox = new System.Windows.Forms.TextBox();
            this.proxyPortUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.proxyUrlBox = new System.Windows.Forms.TextBox();
            this.sharedProxyCheckbox = new System.Windows.Forms.CheckBox();
            this.proxyTypeCombo = new System.Windows.Forms.ComboBox();
            this.automaticProxyButton = new System.Windows.Forms.RadioButton();
            this.disableProxyButton = new System.Windows.Forms.RadioButton();
            this.enableProxyButton = new System.Windows.Forms.RadioButton();
            this.scriptGroup = new System.Windows.Forms.GroupBox();
            this.disconnectScriptButton = new System.Windows.Forms.Button();
            this.connectScriptButton = new System.Windows.Forms.Button();
            this.disconnectScriptBox = new System.Windows.Forms.TextBox();
            this.connectScriptBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.connectFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.disconnectFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.removeNetworkButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.triggerGroup.SuspendLayout();
            this.proxyGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proxyPortUpDown)).BeginInit();
            this.scriptGroup.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.removeNetworkButton);
            this.groupBox1.Controls.Add(this.newNetworkButton);
            this.groupBox1.Controls.Add(this.networkNameBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select/Create Network";
            // 
            // newNetworkButton
            // 
            this.newNetworkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newNetworkButton.Location = new System.Drawing.Point(123, 18);
            this.newNetworkButton.Name = "newNetworkButton";
            this.newNetworkButton.Size = new System.Drawing.Size(52, 23);
            this.newNetworkButton.TabIndex = 1;
            this.newNetworkButton.Text = "New";
            this.newNetworkButton.UseVisualStyleBackColor = true;
            this.newNetworkButton.Click += new System.EventHandler(this.newNetworkButton_Click);
            // 
            // networkNameBox
            // 
            this.networkNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.networkNameBox.FormattingEnabled = true;
            this.networkNameBox.Location = new System.Drawing.Point(7, 20);
            this.networkNameBox.Name = "networkNameBox";
            this.networkNameBox.Size = new System.Drawing.Size(110, 21);
            this.networkNameBox.TabIndex = 0;
            this.networkNameBox.SelectedIndexChanged += new System.EventHandler(this.networkNameBox_SelectedIndexChanged);
            // 
            // triggerGroup
            // 
            this.triggerGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.triggerGroup.Controls.Add(this.triggerQueryBox);
            this.triggerGroup.Controls.Add(this.label2);
            this.triggerGroup.Controls.Add(this.label1);
            this.triggerGroup.Controls.Add(this.triggerMethodCombo);
            this.triggerGroup.Location = new System.Drawing.Point(13, 81);
            this.triggerGroup.Name = "triggerGroup";
            this.triggerGroup.Size = new System.Drawing.Size(262, 68);
            this.triggerGroup.TabIndex = 1;
            this.triggerGroup.TabStop = false;
            this.triggerGroup.Text = "Network Trigger";
            // 
            // triggerQueryBox
            // 
            this.triggerQueryBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.triggerQueryBox.Location = new System.Drawing.Point(71, 41);
            this.triggerQueryBox.Name = "triggerQueryBox";
            this.triggerQueryBox.Size = new System.Drawing.Size(185, 20);
            this.triggerQueryBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Query";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Method";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // triggerMethodCombo
            // 
            this.triggerMethodCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.triggerMethodCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.triggerMethodCombo.FormattingEnabled = true;
            this.triggerMethodCombo.Items.AddRange(new object[] {
            "Wireless AP (connected)",
            "Wireless AP (available)",
            "Gateway MAC Address",
            "Server is available"});
            this.triggerMethodCombo.Location = new System.Drawing.Point(71, 20);
            this.triggerMethodCombo.Name = "triggerMethodCombo";
            this.triggerMethodCombo.Size = new System.Drawing.Size(185, 21);
            this.triggerMethodCombo.TabIndex = 0;
            // 
            // proxyGroup
            // 
            this.proxyGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proxyGroup.Controls.Add(this.proxyAutoConfigBox);
            this.proxyGroup.Controls.Add(this.proxyAutoConfigCheckbox);
            this.proxyGroup.Controls.Add(this.proxyLocalBypassCheckbox);
            this.proxyGroup.Controls.Add(this.label5);
            this.proxyGroup.Controls.Add(this.proxyExceptionsBox);
            this.proxyGroup.Controls.Add(this.proxyPortUpDown);
            this.proxyGroup.Controls.Add(this.label4);
            this.proxyGroup.Controls.Add(this.proxyUrlBox);
            this.proxyGroup.Controls.Add(this.sharedProxyCheckbox);
            this.proxyGroup.Controls.Add(this.proxyTypeCombo);
            this.proxyGroup.Location = new System.Drawing.Point(13, 186);
            this.proxyGroup.Name = "proxyGroup";
            this.proxyGroup.Size = new System.Drawing.Size(262, 208);
            this.proxyGroup.TabIndex = 2;
            this.proxyGroup.TabStop = false;
            this.proxyGroup.Text = "Proxy Settings";
            // 
            // proxyAutoConfigBox
            // 
            this.proxyAutoConfigBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proxyAutoConfigBox.Enabled = false;
            this.proxyAutoConfigBox.Location = new System.Drawing.Point(7, 181);
            this.proxyAutoConfigBox.Name = "proxyAutoConfigBox";
            this.proxyAutoConfigBox.Size = new System.Drawing.Size(250, 20);
            this.proxyAutoConfigBox.TabIndex = 12;
            // 
            // proxyAutoConfigCheckbox
            // 
            this.proxyAutoConfigCheckbox.AutoSize = true;
            this.proxyAutoConfigCheckbox.Location = new System.Drawing.Point(11, 157);
            this.proxyAutoConfigCheckbox.Name = "proxyAutoConfigCheckbox";
            this.proxyAutoConfigCheckbox.Size = new System.Drawing.Size(168, 17);
            this.proxyAutoConfigCheckbox.TabIndex = 11;
            this.proxyAutoConfigCheckbox.Text = "Automatic Configuration Script";
            this.proxyAutoConfigCheckbox.UseVisualStyleBackColor = true;
            this.proxyAutoConfigCheckbox.CheckedChanged += new System.EventHandler(this.proxyAutoConfigCheckbox_CheckedChanged);
            // 
            // proxyLocalBypassCheckbox
            // 
            this.proxyLocalBypassCheckbox.AutoSize = true;
            this.proxyLocalBypassCheckbox.Location = new System.Drawing.Point(11, 134);
            this.proxyLocalBypassCheckbox.Name = "proxyLocalBypassCheckbox";
            this.proxyLocalBypassCheckbox.Size = new System.Drawing.Size(156, 17);
            this.proxyLocalBypassCheckbox.TabIndex = 10;
            this.proxyLocalBypassCheckbox.Text = "Bypass for Local Addresses";
            this.proxyLocalBypassCheckbox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Exceptions (separated by semicolons):";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // proxyExceptionsBox
            // 
            this.proxyExceptionsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proxyExceptionsBox.Location = new System.Drawing.Point(7, 93);
            this.proxyExceptionsBox.Multiline = true;
            this.proxyExceptionsBox.Name = "proxyExceptionsBox";
            this.proxyExceptionsBox.Size = new System.Drawing.Size(250, 35);
            this.proxyExceptionsBox.TabIndex = 8;
            // 
            // proxyPortUpDown
            // 
            this.proxyPortUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.proxyPortUpDown.Location = new System.Drawing.Point(195, 45);
            this.proxyPortUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.proxyPortUpDown.Name = "proxyPortUpDown";
            this.proxyPortUpDown.Size = new System.Drawing.Size(62, 20);
            this.proxyPortUpDown.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "URL/Port";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // proxyUrlBox
            // 
            this.proxyUrlBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proxyUrlBox.Location = new System.Drawing.Point(73, 46);
            this.proxyUrlBox.Name = "proxyUrlBox";
            this.proxyUrlBox.Size = new System.Drawing.Size(116, 20);
            this.proxyUrlBox.TabIndex = 5;
            // 
            // sharedProxyCheckbox
            // 
            this.sharedProxyCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sharedProxyCheckbox.AutoSize = true;
            this.sharedProxyCheckbox.Location = new System.Drawing.Point(173, 21);
            this.sharedProxyCheckbox.Name = "sharedProxyCheckbox";
            this.sharedProxyCheckbox.Size = new System.Drawing.Size(84, 17);
            this.sharedProxyCheckbox.TabIndex = 4;
            this.sharedProxyCheckbox.Text = "All Protocols";
            this.sharedProxyCheckbox.UseVisualStyleBackColor = true;
            this.sharedProxyCheckbox.CheckedChanged += new System.EventHandler(this.sharedProxyCheckbox_CheckedChanged);
            // 
            // proxyTypeCombo
            // 
            this.proxyTypeCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proxyTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.proxyTypeCombo.FormattingEnabled = true;
            this.proxyTypeCombo.Items.AddRange(new object[] {
            "HTTP",
            "HTTPS",
            "FTP",
            "SOCKS"});
            this.proxyTypeCombo.Location = new System.Drawing.Point(7, 19);
            this.proxyTypeCombo.Name = "proxyTypeCombo";
            this.proxyTypeCombo.Size = new System.Drawing.Size(160, 21);
            this.proxyTypeCombo.TabIndex = 3;
            this.proxyTypeCombo.DropDown += new System.EventHandler(this.updateNetworkFromUI);
            this.proxyTypeCombo.SelectedIndexChanged += new System.EventHandler(this.reloadUI);
            // 
            // automaticProxyButton
            // 
            this.automaticProxyButton.AutoSize = true;
            this.automaticProxyButton.Checked = true;
            this.automaticProxyButton.Location = new System.Drawing.Point(203, 159);
            this.automaticProxyButton.Name = "automaticProxyButton";
            this.automaticProxyButton.Size = new System.Drawing.Size(72, 17);
            this.automaticProxyButton.TabIndex = 2;
            this.automaticProxyButton.TabStop = true;
            this.automaticProxyButton.Text = "Automatic";
            this.automaticProxyButton.UseVisualStyleBackColor = true;
            this.automaticProxyButton.CheckedChanged += new System.EventHandler(this.radioCheckedChanged);
            // 
            // disableProxyButton
            // 
            this.disableProxyButton.AutoSize = true;
            this.disableProxyButton.Location = new System.Drawing.Point(137, 159);
            this.disableProxyButton.Name = "disableProxyButton";
            this.disableProxyButton.Size = new System.Drawing.Size(60, 17);
            this.disableProxyButton.TabIndex = 1;
            this.disableProxyButton.TabStop = true;
            this.disableProxyButton.Text = "Disable";
            this.disableProxyButton.UseVisualStyleBackColor = true;
            this.disableProxyButton.CheckedChanged += new System.EventHandler(this.radioCheckedChanged);
            // 
            // enableProxyButton
            // 
            this.enableProxyButton.AutoSize = true;
            this.enableProxyButton.Location = new System.Drawing.Point(73, 159);
            this.enableProxyButton.Name = "enableProxyButton";
            this.enableProxyButton.Size = new System.Drawing.Size(58, 17);
            this.enableProxyButton.TabIndex = 0;
            this.enableProxyButton.TabStop = true;
            this.enableProxyButton.Text = "Enable";
            this.enableProxyButton.UseVisualStyleBackColor = true;
            this.enableProxyButton.CheckedChanged += new System.EventHandler(this.radioCheckedChanged);
            // 
            // scriptGroup
            // 
            this.scriptGroup.Controls.Add(this.disconnectScriptButton);
            this.scriptGroup.Controls.Add(this.connectScriptButton);
            this.scriptGroup.Controls.Add(this.disconnectScriptBox);
            this.scriptGroup.Controls.Add(this.connectScriptBox);
            this.scriptGroup.Controls.Add(this.label7);
            this.scriptGroup.Controls.Add(this.label6);
            this.scriptGroup.Location = new System.Drawing.Point(13, 400);
            this.scriptGroup.Name = "scriptGroup";
            this.scriptGroup.Size = new System.Drawing.Size(262, 71);
            this.scriptGroup.TabIndex = 3;
            this.scriptGroup.TabStop = false;
            this.scriptGroup.Text = "Scripts";
            // 
            // disconnectScriptButton
            // 
            this.disconnectScriptButton.Location = new System.Drawing.Point(228, 40);
            this.disconnectScriptButton.Name = "disconnectScriptButton";
            this.disconnectScriptButton.Size = new System.Drawing.Size(28, 20);
            this.disconnectScriptButton.TabIndex = 13;
            this.disconnectScriptButton.Text = "...";
            this.disconnectScriptButton.UseVisualStyleBackColor = true;
            this.disconnectScriptButton.Click += new System.EventHandler(this.disconnectScriptButton_Click);
            // 
            // connectScriptButton
            // 
            this.connectScriptButton.Location = new System.Drawing.Point(228, 19);
            this.connectScriptButton.Name = "connectScriptButton";
            this.connectScriptButton.Size = new System.Drawing.Size(28, 20);
            this.connectScriptButton.TabIndex = 12;
            this.connectScriptButton.Text = "...";
            this.connectScriptButton.UseVisualStyleBackColor = true;
            this.connectScriptButton.Click += new System.EventHandler(this.connectScriptButton_Click);
            // 
            // disconnectScriptBox
            // 
            this.disconnectScriptBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.disconnectScriptBox.Location = new System.Drawing.Point(99, 41);
            this.disconnectScriptBox.Name = "disconnectScriptBox";
            this.disconnectScriptBox.ReadOnly = true;
            this.disconnectScriptBox.Size = new System.Drawing.Size(123, 20);
            this.disconnectScriptBox.TabIndex = 10;
            // 
            // connectScriptBox
            // 
            this.connectScriptBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectScriptBox.Location = new System.Drawing.Point(99, 19);
            this.connectScriptBox.Name = "connectScriptBox";
            this.connectScriptBox.ReadOnly = true;
            this.connectScriptBox.Size = new System.Drawing.Size(123, 20);
            this.connectScriptBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(7, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "On Disconnect";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(7, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "On Connect";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // connectFileDialog
            // 
            this.connectFileDialog.FileName = "connect.bat";
            this.connectFileDialog.Filter = "VBScript files|*.vbs;*.vbe|JScript files|*.js;*.jse|WSH files|*.wsf;*.wsh|Batch f" +
    "iles|*.bat;*.cmd|Executable files|*.com;*.exe";
            // 
            // disconnectFileDialog
            // 
            this.disconnectFileDialog.FileName = "disconnect.vbs";
            this.disconnectFileDialog.Filter = "VBScript files|*.vbs;*.vbe|JScript files|*.js;*.jse|WSH files|*.wsf;*.wsh|Batch f" +
    "iles|*.bat;*.cmd|Executable files|*.com;*.exe";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(287, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.Location = new System.Drawing.Point(12, 477);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(182, 23);
            this.applyButton.TabIndex = 5;
            this.applyButton.Text = "Save";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkButton.Location = new System.Drawing.Point(200, 477);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(75, 23);
            this.checkButton.TabIndex = 7;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // removeNetworkButton
            // 
            this.removeNetworkButton.Location = new System.Drawing.Point(181, 18);
            this.removeNetworkButton.Name = "removeNetworkButton";
            this.removeNetworkButton.Size = new System.Drawing.Size(75, 23);
            this.removeNetworkButton.TabIndex = 2;
            this.removeNetworkButton.Text = "Remove";
            this.removeNetworkButton.UseVisualStyleBackColor = true;
            this.removeNetworkButton.Click += new System.EventHandler(this.removeNetworkButton_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Proxy: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 518);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.scriptGroup);
            this.Controls.Add(this.proxyGroup);
            this.Controls.Add(this.triggerGroup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.enableProxyButton);
            this.Controls.Add(this.automaticProxyButton);
            this.Controls.Add(this.disableProxyButton);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainConfig";
            this.Text = "Auto Proxy";
            this.groupBox1.ResumeLayout(false);
            this.triggerGroup.ResumeLayout(false);
            this.triggerGroup.PerformLayout();
            this.proxyGroup.ResumeLayout(false);
            this.proxyGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proxyPortUpDown)).EndInit();
            this.scriptGroup.ResumeLayout(false);
            this.scriptGroup.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button newNetworkButton;
        private System.Windows.Forms.ComboBox networkNameBox;
        private System.Windows.Forms.GroupBox triggerGroup;
        private System.Windows.Forms.TextBox triggerQueryBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox triggerMethodCombo;
        private System.Windows.Forms.GroupBox proxyGroup;
        private System.Windows.Forms.RadioButton automaticProxyButton;
        private System.Windows.Forms.RadioButton disableProxyButton;
        private System.Windows.Forms.RadioButton enableProxyButton;
        private System.Windows.Forms.NumericUpDown proxyPortUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox proxyUrlBox;
        private System.Windows.Forms.CheckBox sharedProxyCheckbox;
        private System.Windows.Forms.ComboBox proxyTypeCombo;
        private System.Windows.Forms.CheckBox proxyAutoConfigCheckbox;
        private System.Windows.Forms.CheckBox proxyLocalBypassCheckbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox proxyExceptionsBox;
        private System.Windows.Forms.GroupBox scriptGroup;
        private System.Windows.Forms.Button disconnectScriptButton;
        private System.Windows.Forms.Button connectScriptButton;
        private System.Windows.Forms.TextBox disconnectScriptBox;
        private System.Windows.Forms.TextBox connectScriptBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog connectFileDialog;
        private System.Windows.Forms.OpenFileDialog disconnectFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox proxyAutoConfigBox;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button removeNetworkButton;
        private System.Windows.Forms.Label label3;
    }
}

