namespace Feudal
{
    partial class feudalMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(feudalMainForm));
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabGovt = new System.Windows.Forms.TabPage();
            this.pbxFlag = new System.Windows.Forms.PictureBox();
            this.tabEco = new System.Windows.Forms.TabPage();
            this.tabMil = new System.Windows.Forms.TabPage();
            this.tabTech = new System.Windows.Forms.TabPage();
            this.tabTrade = new System.Windows.Forms.TabPage();
            this.tabDip = new System.Windows.Forms.TabPage();
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.lbxInfo = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblMonthDate = new System.Windows.Forms.Label();
            this.lblYearDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblGovtType = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblGovtLeader = new System.Windows.Forms.Label();
            this.btnChangeGovt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblGovtStability = new System.Windows.Forms.Label();
            this.lbxProvStability = new System.Windows.Forms.ListBox();
            this.mainTabControl.SuspendLayout();
            this.tabGovt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFlag)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabGovt);
            this.mainTabControl.Controls.Add(this.tabEco);
            this.mainTabControl.Controls.Add(this.tabMil);
            this.mainTabControl.Controls.Add(this.tabTech);
            this.mainTabControl.Controls.Add(this.tabTrade);
            this.mainTabControl.Controls.Add(this.tabDip);
            this.mainTabControl.Location = new System.Drawing.Point(12, 102);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(872, 386);
            this.mainTabControl.TabIndex = 0;
            // 
            // tabGovt
            // 
            this.tabGovt.Controls.Add(this.lbxProvStability);
            this.tabGovt.Controls.Add(this.lblGovtStability);
            this.tabGovt.Controls.Add(this.label7);
            this.tabGovt.Controls.Add(this.btnChangeGovt);
            this.tabGovt.Controls.Add(this.lblGovtLeader);
            this.tabGovt.Controls.Add(this.label6);
            this.tabGovt.Controls.Add(this.label5);
            this.tabGovt.Controls.Add(this.lblGovtType);
            this.tabGovt.Controls.Add(this.pbxFlag);
            this.tabGovt.Location = new System.Drawing.Point(4, 22);
            this.tabGovt.Name = "tabGovt";
            this.tabGovt.Padding = new System.Windows.Forms.Padding(3);
            this.tabGovt.Size = new System.Drawing.Size(864, 360);
            this.tabGovt.TabIndex = 0;
            this.tabGovt.Text = "Government";
            this.tabGovt.UseVisualStyleBackColor = true;
            // 
            // pbxFlag
            // 
            this.pbxFlag.Image = ((System.Drawing.Image)(resources.GetObject("pbxFlag.Image")));
            this.pbxFlag.InitialImage = null;
            this.pbxFlag.Location = new System.Drawing.Point(7, 7);
            this.pbxFlag.Name = "pbxFlag";
            this.pbxFlag.Size = new System.Drawing.Size(200, 150);
            this.pbxFlag.TabIndex = 0;
            this.pbxFlag.TabStop = false;
            // 
            // tabEco
            // 
            this.tabEco.Location = new System.Drawing.Point(4, 22);
            this.tabEco.Name = "tabEco";
            this.tabEco.Padding = new System.Windows.Forms.Padding(3);
            this.tabEco.Size = new System.Drawing.Size(864, 360);
            this.tabEco.TabIndex = 1;
            this.tabEco.Text = "Economy";
            this.tabEco.UseVisualStyleBackColor = true;
            // 
            // tabMil
            // 
            this.tabMil.Location = new System.Drawing.Point(4, 22);
            this.tabMil.Name = "tabMil";
            this.tabMil.Size = new System.Drawing.Size(864, 360);
            this.tabMil.TabIndex = 2;
            this.tabMil.Text = "Military";
            this.tabMil.UseVisualStyleBackColor = true;
            // 
            // tabTech
            // 
            this.tabTech.Location = new System.Drawing.Point(4, 22);
            this.tabTech.Name = "tabTech";
            this.tabTech.Size = new System.Drawing.Size(864, 360);
            this.tabTech.TabIndex = 3;
            this.tabTech.Text = "Technology";
            this.tabTech.UseVisualStyleBackColor = true;
            // 
            // tabTrade
            // 
            this.tabTrade.Location = new System.Drawing.Point(4, 22);
            this.tabTrade.Name = "tabTrade";
            this.tabTrade.Size = new System.Drawing.Size(864, 360);
            this.tabTrade.TabIndex = 4;
            this.tabTrade.Text = "Trade";
            this.tabTrade.UseVisualStyleBackColor = true;
            // 
            // tabDip
            // 
            this.tabDip.Location = new System.Drawing.Point(4, 22);
            this.tabDip.Name = "tabDip";
            this.tabDip.Size = new System.Drawing.Size(864, 360);
            this.tabDip.TabIndex = 5;
            this.tabDip.Text = "Diplomacy";
            this.tabDip.UseVisualStyleBackColor = true;
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.Location = new System.Drawing.Point(782, 27);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(98, 69);
            this.btnEndTurn.TabIndex = 2;
            this.btnEndTurn.Text = "Advance Month\r\n(End Turn)";
            this.btnEndTurn.UseVisualStyleBackColor = true;
            // 
            // lbxInfo
            // 
            this.lbxInfo.FormattingEnabled = true;
            this.lbxInfo.Location = new System.Drawing.Point(157, 27);
            this.lbxInfo.Name = "lbxInfo";
            this.lbxInfo.Size = new System.Drawing.Size(619, 69);
            this.lbxInfo.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(896, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 498);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(896, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(57, 17);
            this.toolStripStatusLabel.Text = "Waiting...";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Money:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Month:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Extra:";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(64, 27);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(19, 13);
            this.lblMoney.TabIndex = 10;
            this.lblMoney.Text = "$0";
            // 
            // lblMonthDate
            // 
            this.lblMonthDate.AutoSize = true;
            this.lblMonthDate.Location = new System.Drawing.Point(64, 40);
            this.lblMonthDate.Name = "lblMonthDate";
            this.lblMonthDate.Size = new System.Drawing.Size(58, 13);
            this.lblMonthDate.TabIndex = 11;
            this.lblMonthDate.Text = "September";
            // 
            // lblYearDate
            // 
            this.lblYearDate.AutoSize = true;
            this.lblYearDate.Location = new System.Drawing.Point(64, 53);
            this.lblYearDate.Name = "lblYearDate";
            this.lblYearDate.Size = new System.Drawing.Size(31, 13);
            this.lblYearDate.TabIndex = 12;
            this.lblYearDate.Text = "2012";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "temp";
            // 
            // lblGovtType
            // 
            this.lblGovtType.AutoSize = true;
            this.lblGovtType.Location = new System.Drawing.Point(338, 30);
            this.lblGovtType.Name = "lblGovtType";
            this.lblGovtType.Size = new System.Drawing.Size(61, 13);
            this.lblGovtType.TabIndex = 1;
            this.lblGovtType.Text = "Democracy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Govt Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Leader:";
            // 
            // lblGovtLeader
            // 
            this.lblGovtLeader.AutoSize = true;
            this.lblGovtLeader.Location = new System.Drawing.Point(338, 10);
            this.lblGovtLeader.Name = "lblGovtLeader";
            this.lblGovtLeader.Size = new System.Drawing.Size(41, 13);
            this.lblGovtLeader.TabIndex = 4;
            this.lblGovtLeader.Text = "Obama";
            // 
            // btnChangeGovt
            // 
            this.btnChangeGovt.Location = new System.Drawing.Point(213, 25);
            this.btnChangeGovt.Name = "btnChangeGovt";
            this.btnChangeGovt.Size = new System.Drawing.Size(53, 23);
            this.btnChangeGovt.TabIndex = 5;
            this.btnChangeGovt.Text = "Change";
            this.btnChangeGovt.UseVisualStyleBackColor = true;
            this.btnChangeGovt.Click += new System.EventHandler(this.btnChangeGovt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Stability:";
            // 
            // lblGovtStability
            // 
            this.lblGovtStability.AutoSize = true;
            this.lblGovtStability.Location = new System.Drawing.Point(338, 50);
            this.lblGovtStability.Name = "lblGovtStability";
            this.lblGovtStability.Size = new System.Drawing.Size(33, 13);
            this.lblGovtStability.TabIndex = 7;
            this.lblGovtStability.Text = "100%";
            // 
            // lbxProvStability
            // 
            this.lbxProvStability.FormattingEnabled = true;
            this.lbxProvStability.HorizontalScrollbar = true;
            this.lbxProvStability.Items.AddRange(new object[] {
            "test province four-85%",
            "test province one-100%",
            "test province three-99%",
            "test province two-94%"});
            this.lbxProvStability.Location = new System.Drawing.Point(7, 163);
            this.lbxProvStability.Name = "lbxProvStability";
            this.lbxProvStability.Size = new System.Drawing.Size(130, 95);
            this.lbxProvStability.TabIndex = 8;
            // 
            // feudalMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 520);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblYearDate);
            this.Controls.Add(this.lblMonthDate);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lbxInfo);
            this.Controls.Add(this.btnEndTurn);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "feudalMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feudal";
            this.mainTabControl.ResumeLayout(false);
            this.tabGovt.ResumeLayout(false);
            this.tabGovt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFlag)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabGovt;
        private System.Windows.Forms.TabPage tabEco;
        private System.Windows.Forms.TabPage tabMil;
        private System.Windows.Forms.Button btnEndTurn;
        private System.Windows.Forms.ListBox lbxInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.TabPage tabTech;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.TabPage tabTrade;
        private System.Windows.Forms.TabPage tabDip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblMonthDate;
        private System.Windows.Forms.Label lblYearDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbxFlag;
        private System.Windows.Forms.Label lblGovtLeader;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblGovtType;
        private System.Windows.Forms.Button btnChangeGovt;
        private System.Windows.Forms.Label lblGovtStability;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbxProvStability;
    }
}

