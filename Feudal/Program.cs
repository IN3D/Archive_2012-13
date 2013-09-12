using System;
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
        /// test 1
        /// 
        ///Eric 09-12-2013
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new feudalMainForm());
        }
    }
}
