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

        #region ClassDeclarations
        private devConsole dc = new devConsole();//added dev console
        public static Belief belief = new Belief();
        public static Maps maps = new Maps();
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