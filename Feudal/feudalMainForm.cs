using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Feudal.Forms;//add dev Console

namespace Feudal
{
    public partial class feudalMainForm : Form
    {   
        //declare variables
        int counter = 0;
        //added so that the year display is no longer static
        int year = 2012;
        Turns turns = new Turns();

        private devConsole dc = new devConsole();//added dev console

        public feudalMainForm()
        {
            InitializeComponent();

            dc.AdviseParent += new devConsole.AdviseParentEventHandler(changeMainFormText);//added dev console

            lblYearDate.Text = year.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Closes the program
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Shows the about form
            var abtfrm = new Feudal.Forms.aboutPage();
            abtfrm.Show();
        }

        private void btnChangeGovt_Click(object sender, EventArgs e)
        {
            // Shows the change government form
            var chngGovt = new changeGovernment();
            chngGovt.Show();
        }
        
        private void feudalMainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'feudalDatabaseDataSet.Province_Information' table. You can move, or remove it, as needed.
            //this.province_InformationTableAdapter.Fill(this.feudalDatabaseDataSet.Province_Information);

        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Advancing Turn";
            if (counter == 12)
            {
                counter = 0;
                //increment the year value, and reassign the new number
                year++;
                lblYearDate.Text = year.ToString();

                lblMonthDate.Text = turns.getMonth(counter);
                counter++;
            }
            else
            {
                lblMonthDate.Text = turns.getMonth(counter);
                counter++;
            }
            toolStripStatusLabel.Text = "Waiting...";

        }

        private void endTurnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEndTurn.PerformClick();
        }

        private void pbxMap_Click(object sender, EventArgs e)
        {
            var mapfrm = new Feudal.Forms.Map();
            mapfrm.Show();
        }

        private void devConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dc.ShowDialog();//added dev console
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mainMenu = new Feudal.Forms.mainMenu();
            mainMenu.Show();
        }

        private void changeMainFormText(string text)//added dev console
        {
            lblMoney.Text = text;
        }
    }
}
