using System;
using System.IO;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using Microsoft.Win32;

namespace NetworkL
{
    public enum TriggerMethod
    {
        INVALID = 0,
        CONNECTED_AP = 1,
        AVAILABLE_AP = 2,
        GATEWAY_MAC = 3,
        SERVER_REACHABLE = 4
    }

    struct INetRefresh
    {
        [DllImport("wininet.dll")]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);

        public static int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        public static int INTERNET_OPTION_REFRESH = 37;

        public static void Refresh()
        {
            InternetSetOption(IntPtr.Zero,
                INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            InternetSetOption(IntPtr.Zero,
                INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
        }
    }

    [Serializable]
    public class Network
    {
        public string Name = "";
        public const ushort CURRENT_DATA_VERSION = 2;
        public ushort DataVersion = CURRENT_DATA_VERSION;

        public TriggerMethod TriggerMethod = TriggerMethod.INVALID;
        public string TriggerQuery;

        public bool? EnableProxy = null;
        public bool EnableAutoConfig, LocalException, UseCommonProxy;
        public string HttpProxy, HttpsProxy, FtpProxy, SocksProxy;
        public ushort HttpPort, HttpsPort, FtpPort, SocksPort;

        public string ProxyExceptions, AutoConfigScript;
        public string ConnectScript, DisconnectScript;

        private static XmlSerializer serializer =
            new XmlSerializer(typeof(Network));

        public Network() { }

        // from http://stackoverflow.com/a/26273084
        // by https://stackoverflow.com/users/146457/131
        public void SetIEProxy()
        {
            if (EnableProxy == null) return;
            
            const string subkey = @"Software\Microsoft\Windows\CurrentVersion\Internet Settings";
            RegistryKey key = Registry.CurrentUser.CreateSubKey(subkey);

            if (EnableAutoConfig)
            {
                if (!String.IsNullOrEmpty(AutoConfigScript))
                    key.SetValue("AutoConfigURL", AutoConfigScript);

                key.SetValue("ProxyEnable", 0);
            }
            else
            {
                key.DeleteValue("AutoConfigURL", false);

                string proxyServerValue = "";
                if (UseCommonProxy)
                {
                    proxyServerValue = String.Format("{0}:{1}", HttpProxy, HttpPort);
                }
                else
                {

                    List<string> proxyParts = new List<string>();
                    if (!String.IsNullOrEmpty(HttpProxy))
                        proxyParts.Add(String.Format("http={0}:{1}", HttpProxy, HttpPort));
                    if (!String.IsNullOrEmpty(HttpsProxy))
                        proxyParts.Add(String.Format("https={0}:{1}", HttpsProxy, HttpsPort));
                    if (!String.IsNullOrEmpty(FtpProxy))
                        proxyParts.Add(String.Format("ftp={0}:{1}", FtpProxy, FtpPort));
                    if (!String.IsNullOrEmpty(SocksProxy))
                        proxyParts.Add(String.Format("socks={0}:{1}", SocksProxy, SocksPort));

                    proxyServerValue = String.Join(";", proxyParts.ToArray());
                }
                key.SetValue("ProxyServer", proxyServerValue);
                key.SetValue("ProxyEnable", (EnableProxy == true) ? 1 : 0);

                string proxyExceptionsValue = "";
                if (!String.IsNullOrEmpty(ProxyExceptions))
                    proxyExceptionsValue += ProxyExceptions;
                if (LocalException)
                {
                    if (proxyExceptionsValue.Length > 0)
                        proxyExceptionsValue += ";";
                    proxyExceptionsValue += "<local>";
                }

                key.SetValue("ProxyOverride", proxyExceptionsValue);
            }
            key.Close();

            // Refresh IE proxy settings
            INetRefresh.Refresh();
        }

        public void OnConnect()
        {
            if (!String.IsNullOrEmpty(ConnectScript))
                System.Diagnostics.Process.Start(ConnectScript);

            SetIEProxy();
        }

        public void OnDisconnect()
        {
            if (!String.IsNullOrEmpty(DisconnectScript))
                System.Diagnostics.Process.Start(DisconnectScript);
        }

        public bool TestForTrigger()
        {
            SimpleWifi.Wifi wlan = new SimpleWifi.Wifi();
            switch (TriggerMethod)
            {
                case TriggerMethod.CONNECTED_AP:
                    foreach (SimpleWifi.AccessPoint ap in wlan.GetAccessPoints())
                    {
                        if (ap.IsConnected && ap.Name == TriggerQuery)
                            return true;
                    }
                    return false;

                case TriggerMethod.AVAILABLE_AP:
                    foreach (SimpleWifi.AccessPoint ap in wlan.GetAccessPoints())
                    {
                        if (ap.Name == TriggerQuery)
                            return true;
                    }
                    return false;

                case TriggerMethod.GATEWAY_MAC:
                    return false;

                case TriggerMethod.SERVER_REACHABLE:
                    PingReply reply = (new Ping()).Send(TriggerQuery);
                    return reply.Status == IPStatus.Success;

                default:
                    return false;
            }
        }

        public void Save()
        {
            FileStream stream = File.Create(GetFileName(Name));
            serializer.Serialize(stream, this);
            stream.Close();
        }

        public void Delete()
        {
            File.Delete(GetFileName(Name));
        }

        public static string GetFolder()
        {
            string folder = Environment.GetFolderPath(
                Environment.SpecialFolder.ApplicationData);
            string myFolder = Path.Combine(folder, @"AutoProxy\Networks");

            if (!Directory.Exists(myFolder))
                Directory.CreateDirectory(myFolder);

            return myFolder;
        }

        public static string GetFileName(string name)
        {
            char[] invalids = Path.GetInvalidFileNameChars();
            name = String.Join("_", name.Split(invalids,
                StringSplitOptions.RemoveEmptyEntries)).TrimEnd('.');
            string filename = String.Format("{0}.xml", name);

            return Path.Combine(GetFolder(), filename);
        }

        public static List<Network> LoadNetworks()
        {
            List<Network> list = new List<Network>();
            XmlSerializer serializer =
                new XmlSerializer(typeof(Network));
            FileStream stream;

            bool foundDefault = false;
            foreach (string file in Directory.GetFiles(GetFolder()))
            {
                if (Path.GetExtension(file) == ".xml")
                {
                    try
                    {
                        stream = File.Open(file, FileMode.Open);
                        Network nw = (Network)serializer.Deserialize(stream);
                        stream.Close();
                        if (nw == null || nw.DataVersion < Network.CURRENT_DATA_VERSION)
                            continue;

                        if (nw.Name == "default")
                            foundDefault = true;
                        list.Add(nw);
                    }
                    catch (IOException) { }
                }
            }

            if (!foundDefault)
            {
                Network defaultNw = new Network();
                defaultNw.Name = "default";
                list.Add(defaultNw);
            }

            return list;
        }

        public static Network CheckNetworks(List<Network> list)
        {
            Network defaultNetwork = null;
            foreach (Network nw in list)
            {
                if (nw.Name == "default")
                {
                    defaultNetwork = nw;
                    continue;
                }

                if (nw.TestForTrigger())
                {
                    return nw;
                }
            }
            return defaultNetwork;
        }
    }
}
