using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Threading;

namespace Oculus_Virtual_Tragedy___Launcher
{
    internal class Program
    {
        static void Main(String[] args)
        {
            // variables
            bool IsDemo = true;
            bool IsDevBuild = true;
            float BuildNum = 0.01f;
            string BuildNumString = "Demo";
            string Build = $"{BuildNum} ({BuildNumString})";
            string BuildDetail = $"IsDevBuild = {IsDevBuild}. IsDemo = {IsDemo}";
            string Title = "Oculus Virtual Tragedy Launcher";
            string InAppTitle = "OVT Launcher";
            bool PressedKey = false;
            bool ExitTwo = false;
            //ignore these pls, for testing
            string DownloadURL = "https://cdn.discordapp.com/attachments/1293277703746883687/1308909737307410452/Oculus-VT.zip?ex=677cf66f&is=677ba4ef&hm=eaced9e0ed59a8d2840213b83d1cab05f8ba2f15ef6b3c08224a132a95081112&";

            // logos
            string Logo1 = @"
   ____             _            __      ___      _               _   _______                       _       
  / __ \           | |           \ \    / (_)    | |             | | |__   __|                     | |      
 | |  | | ___ _   _| |_   _ ___   \ \  / / _ _ __| |_ _   _  __ _| |    | |_ __ __ _  __ _  ___  __| |_   _ 
 | |  | |/ __| | | | | | | / __|   \ \/ / | | '__| __| | | |/ _` | |    | | '__/ _` |/ _` |/ _ \/ _` | | | |
 | |__| | (__| |_| | | |_| \__ \    \  /  | | |  | |_| |_| | (_| | |    | | | | (_| | (_| |  __/ (_| | |_| |
  \____/ \___|\__,_|_|\__,_|___/     \/   |_|_|   \__|\__,_|\__,_|_|    |_|_|  \__,_|\__, |\___|\__,_|\__, |
                                                                                      __/ |            __/ |
                                                                                     |___/            |___/ ";

            // config ig
            Console.Title = $"{InAppTitle} - Welcome!";

            // starting the program
            Console.WriteLine($"{Logo1}");
            Console.WriteLine("=============================================================================================================");
            Console.WriteLine($"{Build}");
            Console.WriteLine($"{BuildDetail}");
            Console.WriteLine($"Press any key to download Oulus Virtual Tragedy");
            Console.ReadKey(PressedKey);
            if (PressedKey == true);
            {
                Console.Clear();
                if (DownloadURL == "")
                {
                    // more config, yay
                    Console.Title = $"{InAppTitle} - Error";

                    Console.WriteLine("Error! Download URL is invalid!");
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey(ExitTwo);
                    if (ExitTwo == true)
                    {
                        Environment.Exit(1);
                    }
                }
                else
                {
                    OvtDownload.Download();
                }
            }
        }
    }
}
