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
        //TODO: I feel like these variables should go somewhere else -Eric
        //declare variables
        int counter = 0;
        //added so that the year display is no longer static
        int year = 2012;
        Turns turns = new Turns();

        #region ClassDeclarations
        private devConsole dc = new devConsole();//added dev console
        public static Belief belief = new Belief();
        public static Maps maps = new Maps();
        public static  AI ai = new AI();
        //FOR TEST
        Character player = new Character(100.00, 100.00, 100.00, belief.setProtestantC);
        #endregion

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
            
            #region buttonTextSet
            province1.Text = maps.getProvinceName(0);
            province2.Text = maps.getProvinceName(1);
            province3.Text = maps.getProvinceName(2);
            province4.Text = maps.getProvinceName(3);
            province5.Text = maps.getProvinceName(4);
            province6.Text = maps.getProvinceName(5);
            province7.Text = maps.getProvinceName(6);
            province8.Text = maps.getProvinceName(7);
            province9.Text = maps.getProvinceName(8);
            province10.Text = maps.getProvinceName(9);
            province11.Text = maps.getProvinceName(10);
            province12.Text = maps.getProvinceName(11);
            province13.Text = maps.getProvinceName(12);
            province14.Text = maps.getProvinceName(13);
            province15.Text = maps.getProvinceName(14);
            province16.Text = maps.getProvinceName(15);
            province17.Text = maps.getProvinceName(16);
            province18.Text = maps.getProvinceName(17);
            province19.Text = maps.getProvinceName(18);
            province20.Text = maps.getProvinceName(19);
            province21.Text = maps.getProvinceName(20);
            province22.Text = maps.getProvinceName(21);
            province23.Text = maps.getProvinceName(22);
            province24.Text = maps.getProvinceName(23);
            province25.Text = maps.getProvinceName(24);
            #endregion

            #region FOR_THE_AI_TEST
            
            maps.setProvinceOwnerID(0, player.getID);
            province1.BackColor = maps.getProvinceColor(player.CapitalProvID);
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

            //
            ai.ComputeMove(player);

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
            lblOwner.Text = maps.getProvinceName(0);
            lblGovtLeader.Text = maps.getProvincePopulation(0).ToString();
            lblGovtType.Text = maps.getProvinceWealth(0).ToString();
            lblGovtStability.Text = maps.getProvinceStability(0).ToString();
            lblReligon.Text = maps.provinces[0].ProvReligionName;
            provReligPicBox.Image = maps.provinces[0].ProvReligionIcon;

            label12.Text = maps.getProvinceOwnerID(0).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblOwner.Text = maps.getProvinceName(1);
            lblGovtLeader.Text = maps.getProvincePopulation(1).ToString();
            lblGovtType.Text = maps.getProvinceWealth(1).ToString();
            lblGovtStability.Text = maps.getProvinceStability(1).ToString();
            lblReligon.Text = maps.provinces[1].ProvReligionName;
            provReligPicBox.Image = maps.provinces[1].ProvReligionIcon;

            label12.Text = maps.getProvinceOwnerID(1).ToString();
        }

        private void province3_Click(object sender, EventArgs e)
        {
            lblOwner.Text = maps.getProvinceName(2);
            lblGovtLeader.Text = maps.getProvincePopulation(2).ToString();
            lblGovtType.Text = maps.getProvinceWealth(2).ToString();
            lblGovtStability.Text = maps.getProvinceStability(2).ToString();
            lblReligon.Text = maps.provinces[2].ProvReligionName;
            provReligPicBox.Image = maps.provinces[2].ProvReligionIcon;

            label12.Text = maps.getProvinceOwnerID(2).ToString();
        }

        private void province4_Click(object sender, EventArgs e)
        {
            lblOwner.Text = maps.getProvinceName(3);
            lblGovtLeader.Text = maps.getProvincePopulation(3).ToString();
            lblGovtType.Text = maps.getProvinceWealth(3).ToString();
            lblGovtStability.Text = maps.getProvinceStability(3).ToString();
            lblReligon.Text = maps.provinces[3].ProvReligionName;
            provReligPicBox.Image = maps.provinces[3].ProvReligionIcon;

            label12.Text = maps.getProvinceOwnerID(3).ToString();
        }

        private void province5_Click(object sender, EventArgs e)
        {
            lblOwner.Text = maps.getProvinceName(4);
            lblGovtLeader.Text = maps.getProvincePopulation(4).ToString();
            lblGovtType.Text = maps.getProvinceWealth(4).ToString();
            lblGovtStability.Text = maps.getProvinceStability(4).ToString();
            lblReligon.Text = maps.provinces[4].ProvReligionName;
            provReligPicBox.Image = maps.provinces[4].ProvReligionIcon;

            label12.Text = maps.getProvinceOwnerID(4).ToString();
        }

        private void province6_Click(object sender, EventArgs e)
        {
            lblOwner.Text = maps.getProvinceName(5);
            lblGovtLeader.Text = maps.getProvincePopulation(5).ToString();
            lblGovtType.Text = maps.getProvinceWealth(5).ToString();
            lblGovtStability.Text = maps.getProvinceStability(5).ToString();
            lblReligon.Text = maps.provinces[5].ProvReligionName;
            provReligPicBox.Image = maps.provinces[5].ProvReligionIcon;

            label12.Text = maps.getProvinceOwnerID(5).ToString();
        }

        private void province7_Click(object sender, EventArgs e)
        {
            lblOwner.Text = maps.getProvinceName(6);
            lblGovtLeader.Text = maps.getProvincePopulation(6).ToString();
            lblGovtType.Text = maps.getProvinceWealth(6).ToString();
            lblGovtStability.Text = maps.getProvinceStability(6).ToString();
            lblReligon.Text = maps.provinces[6].ProvReligionName;
            provReligPicBox.Image = maps.provinces[6].ProvReligionIcon;

            label12.Text = maps.getProvinceOwnerID(6).ToString();
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