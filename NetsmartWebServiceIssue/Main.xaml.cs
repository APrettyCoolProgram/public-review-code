// ====================================================================================================================
//    FILENAME: Main.xaml.cs
//       BUILD: 20190909
//     PROJECT: Avatool (https://github.com/APrettyCoolProgram/Avatool)
//     AUTHORS: development@aprettycoolprogram.com
//   COPYRIGHT: Copyright 2019 A Pretty Cool Program
//     LICENSE: Apache License, Version 2.0
// ====================================================================================================================

/* This is the main window/code of the project.
 */
using System.Windows;

namespace Avatool
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public static Configuration Cfg;

        public Main()
        {
            InitializeComponent();
            DevMode.LaunchThenQuit(false);
            DevMode.Testing(false);
        }

        /// <summary>
        /// Applies customizations to the Main() window when the application launches.
        /// </summary>
        private void SetupWindow()
        {
            /* Any window customizations go here.
             */
        }

        /// <summary>
        /// Initializes a project.
        /// </summary>
        private void Start()
        {
            /* Initialization code goes here.
             */
        }

        /// <summary>
        /// DevMode Action Button 01 is clicked
        /// </summary>
        private static void DevModeActionButton01Click()
        {
            UserManagement.DoesUserExistInUat();
        }

        /* Event handlers.
         */
        private void DevModeActionButton01_Click(object sender, RoutedEventArgs e) => DevModeActionButton01Click();
    }
}