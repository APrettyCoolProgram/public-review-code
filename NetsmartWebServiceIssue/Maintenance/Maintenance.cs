// ====================================================================================================================
//    FILENAME: Maintenance.cs
//       BUILD: 20190909
//     PROJECT: Avatool (https://github.com/APrettyCoolProgram/Avatool)
//     AUTHORS: development@aprettycoolprogram.com
//   COPYRIGHT: Copyright 2019 A Pretty Cool Program
//     LICENSE: Apache License, Version 2.0
// ====================================================================================================================

/* Maintenance code.
 */

using Du;
using static Avatool.Main;

namespace Avatool
{
    public class Maintenance
    {
        public static void DeleteFiles(string targetPath = "", bool allFiles = false)
        {
            /* Files in the targetPath will be deleted. If the targetPath parameter is omitted, the targetPath becomes
             * the myAvatool temporary folder.
             *
             * By default, files in the FilesToKeep list are not deleted. Passing "true" in the allFiles parameter will
             * delete all files, even those in FilesToKeep.
             */
            if (targetPath == "")
            {
                targetPath = Cfg.TempDir;
            }

            if (allFiles)
            {
                DuDirectory.DeleteFiles(targetPath);
            }
            else
            {
                DuDirectory.DeleteFiles(targetPath, Cfg.FilesToKeep);
            }
        }
    }
}