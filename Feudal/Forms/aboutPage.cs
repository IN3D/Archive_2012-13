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
    public partial class aboutPage : Form
    {
        public aboutPage()
        {
            InitializeComponent();
            /* NO CODE FOR YOU!
            this.Text = String.Format("About {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.textBoxDescription.Text = AssemblyDescription;
             */
            //this.label3.Text = String.Format("Version {0}", AssemblyVersion);
        }

        private void pbxLogo_Click(object sender, EventArgs e)
        {
            //var feuFrm = new feudalMainForm();
            //feuFrm.devConsoleToolStripMenuItem.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
