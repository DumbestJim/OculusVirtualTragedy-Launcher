using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oculus_Virtual_Tragedy___Launcher
{
    class OvtDownload
    {
        public static void Download()
        {
            // just clears
            Console.Clear();

            //variables
            bool ExitTwo = false;
            string InAppTitle = "OVT Launcher";
            string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string InstallFolder = Path.Combine(AppData, "OculusVirtualTragedy", "OVT", "Mod");

            // config
            Console.Title = $"{InAppTitle} - Download";

            // actual stuff
            if (!Directory.Exists(InstallFolder))
            {
                DownloadReal();
            }
            else
            {
                Directory.CreateDirectory(InstallFolder);
                DownloadReal();
            }
        }

        public static void DownloadReal()
        {

        }
    }
}
