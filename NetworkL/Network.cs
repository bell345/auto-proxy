using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
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

        public static void refresh()
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
        public string name;
        public TriggerMethod triggerMethod = TriggerMethod.INVALID;
        public string triggerQuery;

        public bool enableProxy, enableAutoConfig, localException, useCommonProxy;
        public string httpProxy, httpsProxy, ftpProxy, socksProxy;
        public ushort httpPort, httpsPort, ftpPort, socksPort;

        public string proxyExceptions, autoConfigScript;
        public string connectScript, disconnectScript;

        public Network() { }

        // from http://stackoverflow.com/a/26273084
        // by https://stackoverflow.com/users/146457/131
        public void setIEProxy()
        {
            const string userRoot = "HKEY_CURRENT_USER";
            const string subkey = @"Software\Microsoft\Windows\CurrentVersion\Internet Settings";
            const string keyName = userRoot + "\\" + subkey;

            if (enableAutoConfig)
            {
                if (!String.IsNullOrEmpty(autoConfigScript))
                    Registry.SetValue(keyName, "AutoConfigURL", autoConfigScript);

                Registry.SetValue(keyName, "ProxyEnable", 0);
            }
            else
            {
                string proxyServerValue = "";
                if (useCommonProxy)
                {
                    proxyServerValue = String.Format("{0}:{1}", httpProxy, httpPort);
                }
                else
                {

                    List<string> proxyParts = new List<string>();
                    if (!String.IsNullOrEmpty(httpProxy))
                        proxyParts.Add(String.Format("http={0}:{1}", httpProxy, httpPort));
                    if (!String.IsNullOrEmpty(httpsProxy))
                        proxyParts.Add(String.Format("https={0}:{1}", httpsProxy, httpsPort));
                    if (!String.IsNullOrEmpty(ftpProxy))
                        proxyParts.Add(String.Format("ftp={0}:{1}", ftpProxy, ftpPort));
                    if (!String.IsNullOrEmpty(socksProxy))
                        proxyParts.Add(String.Format("socks={0}:{1}", socksProxy, socksPort));

                    proxyServerValue = String.Join(";", proxyParts.ToArray());
                }
                Registry.SetValue(keyName, "ProxyServer", proxyServerValue);
                Registry.SetValue(keyName, "ProxyEnable", enableProxy ? 1 : 0);

                string proxyExceptionsValue = "";
                if (!String.IsNullOrEmpty(proxyExceptions))
                    proxyExceptionsValue += proxyExceptions;
                if (localException)
                {
                    if (proxyExceptionsValue.Length > 0)
                        proxyExceptionsValue += ";";
                    proxyExceptionsValue += "<local>";
                }

                Registry.SetValue(keyName, "ProxyOverride", proxyExceptionsValue);
            }

            // Refresh IE proxy settings
            INetRefresh.refresh();
        }

        public bool testForTrigger()
        {
            SimpleWifi.Wifi wlan = new SimpleWifi.Wifi();
            switch (triggerMethod)
            {
                case TriggerMethod.CONNECTED_AP:
                    foreach (SimpleWifi.AccessPoint ap in wlan.GetAccessPoints())
                    {
                        if (ap.IsConnected && ap.Name == triggerQuery)
                            return true;
                    }
                    return false;

                case TriggerMethod.AVAILABLE_AP:
                    foreach (SimpleWifi.AccessPoint ap in wlan.GetAccessPoints())
                    {
                        if (ap.Name == triggerQuery)
                            return true;
                    }
                    return false;

                case TriggerMethod.GATEWAY_MAC:
                    return false;

                case TriggerMethod.SERVER_REACHABLE:
                    PingReply reply = (new Ping()).Send(triggerQuery);
                    return reply.Status == IPStatus.Success;

                default:
                    return false;
            }
        }
    }
}
