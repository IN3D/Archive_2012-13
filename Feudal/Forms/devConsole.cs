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
        public delegate void AdviseParentEventHandler(string text);//added dev console
        public event AdviseParentEventHandler AdviseParent;//added dev console

        public devConsole()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            labelChange(txbxCommand.Text);//added dev console  
            txbxCommand.Clear();
            txbxCommand.Focus();
        }

        public void labelChange(string text)//added dev console
        {
            if (AdviseParent != null)
            {
                AdviseParent(text);
            }
        }
    }
}
