using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Forms;
using Microsoft.Win32;
using NetworkL;
using System.IO;

namespace AutoProxy
{
    static class Program
    {

        static string GetFileName(string name)
        {
            char[] invalids = Path.GetInvalidFileNameChars();
            name = String.Join("_", name.Split(invalids, 
                StringSplitOptions.RemoveEmptyEntries)).TrimEnd('.');
            string filename = String.Format("{0}.xml", name);

            string folder = Environment.GetFolderPath(
                Environment.SpecialFolder.ApplicationData);
            string myFolder = Path.Combine(folder, @"AutoProxy\Networks");

            if (!Directory.Exists(myFolder))
                Directory.CreateDirectory(myFolder);

            return Path.Combine(myFolder, filename);
        }

        static void HandleException(Exception ex)
        {
            string typ = ex.GetType().Name;
            string whatHappened = String.Format(
                "An error occured: {0}",
                ex.Message);
            
            string caption = String.Format("AutoProxy: {0}", typ);
            MessageBox.Show(whatHappened, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            XmlSerializer serializer =
                new XmlSerializer(typeof(Network));
            FileStream stream;
            Network nw = null;

            try
            {
                stream = File.Open(GetFileName("abcdef"), FileMode.Open);
                nw = (Network)serializer.Deserialize(stream);
            }
            catch (FileNotFoundException) { }
            catch (IOException ex)
            {
                HandleException(ex);
                return;
            }

            if (nw == null)
            {
                nw = new Network();
                nw.name = "abcdef";
                nw.triggerMethod = TriggerMethod.CONNECTED_AP;
                nw.triggerQuery = "SWIRELESS-2.4";
            }
            bool trigres = nw.testForTrigger();
            if (trigres)
                Console.Out.WriteLine("Trigger success");
            else
                Console.Out.WriteLine("Trigger failure");
            
            try
            {
                stream = File.Create(GetFileName(nw.name));
                serializer.Serialize(stream, nw);
                stream.Close();
            }
            catch (IOException ex)
            {
                HandleException(ex);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainConfig());
        }
    }
}
