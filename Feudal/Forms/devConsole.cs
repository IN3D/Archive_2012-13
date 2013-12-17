using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Feudal.Forms
{
    public partial class devConsole : Form
    {
        public devConsole()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            txbxCommand.Focus();
            string command = txbxCommand.Text;
            txbxCommand.Clear();
            var dvp = new devConParsing();
            dvp.parseCommand(command);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fu = new feudalMainForm();
            fu.lblMoney.Text = "FUCK YOU";
        }
    }
}
