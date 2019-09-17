// ====================================================================================================================
//    FILENAME: Startup.xaml.cs
//       BUILD: 20190909
//     PROJECT: Avatool (https://github.com/APrettyCoolProgram/Avatool)
//     AUTHORS: development@aprettycoolprogram.com
//   COPYRIGHT: Copyright 2019 A Pretty Cool Program
//     LICENSE: Apache License, Version 2.0
// ====================================================================================================================

/* This is the optional project startup.
 */

using System;
using System.Windows;

namespace Avatool
{
    /// <summary>
    /// Interaction logic for Startup.xaml
    /// </summary>
    public partial class Startup : Window
    {
        public Startup()
        {
            InitializeComponent();
            SetupWindow();
        }

        /// <summary>
        /// Applies customizations to the Startup window when it launches.
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
        /// ExitButton is clicked.
        /// </summary>
        private static void ExitButtonClick()
        {
            /* This is not a graceful exit!
             */
            Environment.Exit(0);
        }

        /// <summary>
        /// The ContinueButton is clicked.
        /// </summary>
        private void ActionButton01Click()
        {
            switch (ActionButton01.Content)
            {
                case "Action":
                    Start();
                    break;

                case "Continue":
                    Close();
                    break;
            }
        }

        /* Event handlers.
         */
        private void ActionButton01_Click(object sender, RoutedEventArgs e) => ActionButton01Click();
        private void ExitButton_Click(object sender, RoutedEventArgs e)     => ExitButtonClick();
    }
}