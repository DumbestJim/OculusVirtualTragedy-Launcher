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
            Console.WriteLine($"Press any key to the {InAppTitle} download demo");
            Console.ReadKey(PressedKey);
            if (PressedKey == true);
            {
                Console.Clear();
                Console.Title = $"{InAppTitle} - Downloading...";
                Console.WriteLine("Starting Download...");
                Thread.Sleep(3000);
                Console.WriteLine("Download: 50%");
                Thread.Sleep(5000);
                Console.WriteLine("Download: 75%");
                Thread.Sleep(2500);
                Console.WriteLine("Download Done!");
                Console.WriteLine("(this has just been a demo. no game has been downloaded.)");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                // exit code 1 im gonna try make mean
                // it exited due to a good reason, like
                // closing after downloading (like here)
                Environment.Exit(1);
            }
        }
    }
}
