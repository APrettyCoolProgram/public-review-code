// ====================================================================================================================
//    FILENAME: Configuration.cs
//       BUILD: 20190909
//     PROJECT: Avatool (https://github.com/APrettyCoolProgram/Avatool)
//     AUTHORS: development@aprettycoolprogram.com
//   COPYRIGHT: Copyright 2019 A Pretty Cool Program
//     LICENSE: Apache License, Version 2.0
// ====================================================================================================================

/* Configuration stuff.
 */
using Du;
using System.Collections.Generic;
using System.IO;

namespace Avatool
{
    public class Configuration
    {
        public bool         DevMode;
        public string       RootDir;
        public string       TempDir;
        public string       RuntimeDir;
        public List<string> FilesToKeep;

         /// <summary>
        /// Initialize a new Avatool.json configuration file.
        /// </summary>
        public static void Initialize()
        {
            /* This will create a new Avatool.json configuration file. You'll need to do this when you make changes to
             * the configuration.cs properties. In order for this to work:
             *  1. You must be using the Avatool development branch
             *  2. DevMode must be enabled
             *  3. Main.xaml.cs must have the following line in Main():
             *
             *      DevMode.LaunchThenQuit(true)
             *
             * When the above requirements are met, and Avatool is launched, Configuration.Initialize() will be
             * called. This will delete the current Avatool.json file in "AppData/Configuration/", and
             * replace it with a newly-built configuration file. Then Avatool will quit.
             *
             * You will then have a new, updated Avatool.json file in in "AppData/Configuration/".
             *
             * Next, remove the current "/AppData/RuntimeFiles/Avatool.json" file, and replace it with the
             * new Avatool.json file in "/AppData/Configuration".
             *
             * Remember to disable DevMode, and return the DevMode.LaunchThanQuit(false) line when done.
             */
            var cfg = new Configuration
            {
                DevMode     = false,
                RootDir     = @"AppData/",
                TempDir     = @"AppData/Temp/",
                RuntimeDir  = @"AppData/Runtime/",
                FilesToKeep = new List<string>
                {
                    "About-this-folder.txt"
                },
            };

            /* These settings are more complex, and need to be created after the main cfg is complete.
             */

            /* Save the configuration file.
             */
            const string configPath = @"AppData/Config/Avatool.json";
            DuJson.Save(configPath, cfg, true);
        }

        /// <summary>
        /// Loads the Avatool.json configuration file.
        /// </summary>
        public static Configuration Load()
        {
            /* The path to Avatool.json needs to be hardcoded since the configuration file hasn't been loaded yet.
             */
            if (!File.Exists("AppData/Config/Avatool.json"))
            {
                DuFile.Copy("AppData/RuntimeFiles/Avatool.json", "AppData/Config/Avatool.json", true);
            }

            return DuJson.Load<Configuration>("AppData/Config/Avatool.json");
        }
    }
}