using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Feudal
{
    public partial class feudalMainForm : Form
    {
        //declare variables
        int counter = 0;
        //Eric 09-14-2013
        //added so that the year display is no longer static
        int year = 2012;
        Turns turns = new Turns();

        //province Classes
        public static Belief belief = new Belief();
        Province prov1 = new Province();
        Province prov2 = new Province("Jarnhal");


        public feudalMainForm()
        {
            InitializeComponent();
            
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
            var abtfrm = new aboutPage();
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
            button1.Text = prov1.ProvinceName;
            button2.Text = prov2.ProvinceName;
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
        /*
        private void pbxMap_Click(object sender, EventArgs e)
        {
            var mapfrm = new Feudal.Forms.Map();
            mapfrm.Show();
        }
         */

        private void button1_Click(object sender, EventArgs e)
        {
            lblOwner.Text = prov1.ProvinceName;
            lblGovtLeader.Text = prov1.Population.ToString();
            lblGovtType.Text = prov1.Wealth.ToString();
            lblReligon.Text = prov1.ProvReligionName;
            provReligPicBox.Image = prov1.ProvReligionIcon;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblOwner.Text = prov2.ProvinceName;
            lblGovtLeader.Text = prov2.Population.ToString();
            lblGovtType.Text = prov2.Wealth.ToString();
            lblReligon.Text = prov2.ProvReligionName;
            provReligPicBox.Image = prov2.ProvReligionIcon;
        }
    }
}
