﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Feudal
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// Sean 09-12-13
        /// Test change
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new feudalMainForm());
        }
    }
}
