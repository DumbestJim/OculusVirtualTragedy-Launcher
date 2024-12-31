using System;
using System.IO;
using credits;

internal static class ProgramHelpersHelpers
{

    private static object Main(string[] args, Credits credits)
    {
        // Check for first launch and analytics consent
        bool isFirstLaunch = !File.Exists(analyticsFilePath);
        if (isFirstLaunch)
        {
            ShowAnalyticsPopup();
        }

        // Display ASCII Art Banner
        string AsciiLogo1 = @"
   ____             _            __      ___      _               _   _______                       _       
  / __ \           | |           \ \    / (_)    | |             | | |__   __|                     | |      
 | |  | | ___ _   _| |_   _ ___   \ \  / / _ _ __| |_ _   _  __ _| |    | |_ __ __ _  __ _  ___  __| |_   _ 
 | |  | |/ __| | | | | | | / __|   \ \/ / | | '__| __| | | |/ _` | |    | | '__/ _` |/ _` |/ _ \/ _` | | | |
 | |__| | (__| |_| | | |_| \__ \    \  /  | | |  | |_| |_| | (_| | |    | | | | (_| | (_| |  __/ (_| | |_| |
  \____/ \___|\__,_|_|\__,_|___/     \/   |_|_|   \__|\__,_|\__,_|_|    |_|_|  \__,_|\__, |\___|\__,_|\__, |
                                                                                      __/ |            __/ |
                                                                                     |___/            |___/  
            ";

        int Version = 0;
        bool IsDev = true;
        string BuildType = @"DevOnly";

        Console.WriteLine("bigmoneybigmoneybigmoneybigmoneybigmoney");
        Console.Clear();
        Console.WriteLine(AsciiLogo1);

        // Ensure necessary directories exist
        Directory.CreateDirectory(modFolderPath);

        Console.WriteLine("1. Check for Updates");
        Console.WriteLine("2. Launch Game");
        Console.WriteLine("3. Credits");
        Console.WriteLine("4. Exit");
        // idfk why i put these here. These are just for me to know what version
        // a user is using if an error happens. Stupid fucking shit, man.
        if (IsDev == true)
        {
            Console.WriteLine("(Verison Type:" + BuildType + ". Build Version:" + Version + ")");
        }
        else
        {
            Console.WriteLine("(version:" + Version + ")");
        }
        Console.Write("Enter your choice: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                CheckForUpdates();
                break;
            case "2":
                LaunchGame();
                break;
            case "3":
                credits.DoCredits; // calls credits, just testing because me being a stupid fuck broke it
                break;
            case "4":
                Console.WriteLine("Goodbye!");
                break;
        }
    }
}