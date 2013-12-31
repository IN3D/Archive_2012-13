using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
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
        public static Belief belief = new Belief();
        /*
        Province prov1 = new Province();
        Province prov2 = new Province("Jarnhal");
        */

        public feudalMainForm()
        {
            InitializeComponent();

            dc.AdviseParent += new devConsole.AdviseParentEventHandler(changeMainFormText);//added dev console

            lblYearDate.Text = year.ToString();

        }

        private void feudalMainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'feudalDatabaseDataSet.Province_Information' table. You can move, or remove it, as needed.
            //this.province_InformationTableAdapter.Fill(this.feudalDatabaseDataSet.Province_Information);
            
            
            //button1.Text = prov1.ProvinceName;
            //button2.Text = prov2.ProvinceName;

            #region provinceArray
            Province[] provinces = {
            new Province("Province 1", .9, 1, 1000, .25, Color.Maroon, belief.setProtestantC),
            new Province("Province 2", .8, 1, 1005, .35, Color.Red, belief.setProtestantC),
            new Province("Province 3", .75, .9, 995, .15, Color.Brown, belief.setFundamentalist),
            new Province("Province 4", .8, 1, 1020, .3, Color.Firebrick, belief.setProtestantC),
            new Province("Province 5", .85, .9, 1010, .3, Color.IndianRed, belief.setProtestantL),
            new Province("Province 6", .9, 1, 1050, .45, Color.DarkGoldenrod, belief.setProtestantL),
            new Province("Province 7", .8, .9, 990, .2, Color.Goldenrod, belief.setProtestantC),
            new Province("Province 8", .9, 1, 1065, .35, Color.Gold, belief.setProtestantL),
            new Province("Province 9", .85, .9, 1000, .3, Color.Khaki, belief.setProtestantL),
            new Province("Province 10", .8, .9, 1015, .4, Color.Yellow, belief.setProtestantC),
            new Province("Province 11", .75, 1, 1010, .25, Color.DarkOliveGreen, belief.setProtestantC),
            new Province("Province 12", .85, .95, 1005, .2, Color.OliveDrab, belief.setProtestantC),
            new Province("Province 13", .8, .95, 1095, .15, Color.YellowGreen, belief.setFundamentalist),
            new Province("Province 14", .85, .9, 1010, .2, Color.LimeGreen, belief.setFundamentalist),
            new Province("Province 15", .8, .9, 1020, .15, Color.PaleGreen, belief.setFundamentalist),
            new Province("Province 16", .8, .85, 1025, .2, Color.DarkSlateGray, belief.setProtestantL),
            new Province("Province 17", .85, .9, 1010, .3, Color.Teal, belief.setProtestantL),
            new Province("Province 18", .8, .9, 1015, .35, Color.LightSeaGreen, belief.setCatholic),
            new Province("Province 19", .9, 1, 1000, .4, Color.MediumSeaGreen, belief.setCatholic),
            new Province("Province 20", .8, .9, 1010, .3, Color.MediumTurquoise, belief.setCatholic),
            new Province("Province 21", .85, .9, 1005, .25, Color.Indigo, belief.setOrthodox),
            new Province("Province 22", .9, .9, 1055, .45, Color.DarkViolet, belief.setOrthodox),
            new Province("Province 23", .8, .85, 1025, .35, Color.DarkOrchid, belief.setOrthodox),
            new Province("Province 24", .8, .85, 1010, .3, Color.MediumPurple, belief.setCatholic),
            new Province("Province 25", .85, .9, 1015, .35, Color.Thistle, belief.setCatholic)};
            #endregion
            #region buttonTextSet
            province1.Text = provinces[0].ProvinceName;
            province2.Text = provinces[1].ProvinceName;
            province3.Text = provinces[2].ProvinceName;
            province1.Text = provinces[3].ProvinceName;
            province2.Text = provinces[4].ProvinceName;
            province3.Text = provinces[5].ProvinceName;
            province1.Text = provinces[6].ProvinceName;
            province2.Text = provinces[7].ProvinceName;
            province3.Text = provinces[8].ProvinceName;
            province1.Text = provinces[9].ProvinceName;
            province2.Text = provinces[10].ProvinceName;
            province3.Text = provinces[11].ProvinceName;
            province1.Text = provinces[12].ProvinceName;
            province2.Text = provinces[13].ProvinceName;
            province3.Text = provinces[14].ProvinceName;
            province1.Text = provinces[15].ProvinceName;
            province2.Text = provinces[16].ProvinceName;
            province3.Text = provinces[17].ProvinceName;
            province1.Text = provinces[18].ProvinceName;
            province2.Text = provinces[19].ProvinceName;
            province3.Text = provinces[20].ProvinceName;
            province1.Text = provinces[21].ProvinceName;
            province2.Text = provinces[22].ProvinceName;
            province3.Text = provinces[23].ProvinceName;
            province1.Text = provinces[24].ProvinceName;
            #endregion

        }

        #region MenuStripItems
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

        private void devConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dc.ShowDialog();//added dev console
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mainMenu = new Feudal.Forms.mainMenu();
            mainMenu.Show();
            // TODO: This line of code loads data into the 'feudalDatabaseDataSet.Province_Information' table. You can move, or remove it, as needed.
        }

        private void endTurnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEndTurn.PerformClick();
        }
        #endregion

        #region onClickEvents
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

        private void button1_Click(object sender, EventArgs e)
        {
            /*lblOwner.Text = prov1.ProvinceName;
            lblGovtLeader.Text = prov1.Population.ToString();
            lblGovtType.Text = prov1.Wealth.ToString();
            lblReligon.Text = prov1.ProvReligionName;
            provReligPicBox.Image = prov1.ProvReligionIcon;*/

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*lblOwner.Text = prov2.ProvinceName;
            lblGovtLeader.Text = prov2.Population.ToString();
            lblGovtType.Text = prov2.Wealth.ToString();
            lblReligon.Text = prov2.ProvReligionName;
            provReligPicBox.Image = prov2.ProvReligionIcon;*/
        }

        /*
        private void pbxMap_Click(object sender, EventArgs e)
        {
            var mapfrm = new Feudal.Forms.Map();
            mapfrm.Show();
        }*/
        #endregion

        #region Methods
        private void changeMainFormText(string text)//added dev console
        {
            lblMoney.Text = text;
        }
        #endregion



    }
}