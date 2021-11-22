﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sandwich_Shop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // Needed for splash screen
             Application.EnableVisualStyles();
             Application.SetCompatibleTextRenderingDefault(false);
             SplashScreen splashScreen = new SplashScreen();
             splashScreen.ShowDialog();
             Application.Run(new LoginForm());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
