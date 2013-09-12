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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.govtTab = new System.Windows.Forms.TabPage();
            this.ecoTab = new System.Windows.Forms.TabPage();
            this.milTab = new System.Windows.Forms.TabPage();
            this.techTab = new System.Windows.Forms.TabPage();
            this.endTurnButton = new System.Windows.Forms.Button();
            this.infoBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.resourceBox = new System.Windows.Forms.ListBox();
            this.mainTabControl.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.govtTab);
            this.mainTabControl.Controls.Add(this.ecoTab);
            this.mainTabControl.Controls.Add(this.milTab);
            this.mainTabControl.Controls.Add(this.techTab);
            this.mainTabControl.Location = new System.Drawing.Point(12, 102);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(872, 386);
            this.mainTabControl.TabIndex = 0;
            // 
            // govtTab
            // 
            this.govtTab.Location = new System.Drawing.Point(4, 22);
            this.govtTab.Name = "govtTab";
            this.govtTab.Padding = new System.Windows.Forms.Padding(3);
            this.govtTab.Size = new System.Drawing.Size(864, 360);
            this.govtTab.TabIndex = 0;
            this.govtTab.Text = "Government";
            this.govtTab.UseVisualStyleBackColor = true;
            // 
            // ecoTab
            // 
            this.ecoTab.Location = new System.Drawing.Point(4, 22);
            this.ecoTab.Name = "ecoTab";
            this.ecoTab.Padding = new System.Windows.Forms.Padding(3);
            this.ecoTab.Size = new System.Drawing.Size(864, 360);
            this.ecoTab.TabIndex = 1;
            this.ecoTab.Text = "Economy";
            this.ecoTab.UseVisualStyleBackColor = true;
            // 
            // milTab
            // 
            this.milTab.Location = new System.Drawing.Point(4, 22);
            this.milTab.Name = "milTab";
            this.milTab.Size = new System.Drawing.Size(864, 360);
            this.milTab.TabIndex = 2;
            this.milTab.Text = "Military";
            this.milTab.UseVisualStyleBackColor = true;
            // 
            // techTab
            // 
            this.techTab.Location = new System.Drawing.Point(4, 22);
            this.techTab.Name = "techTab";
            this.techTab.Size = new System.Drawing.Size(864, 360);
            this.techTab.TabIndex = 3;
            this.techTab.Text = "Technology";
            this.techTab.UseVisualStyleBackColor = true;
            // 
            // endTurnButton
            // 
            this.endTurnButton.Location = new System.Drawing.Point(782, 27);
            this.endTurnButton.Name = "endTurnButton";
            this.endTurnButton.Size = new System.Drawing.Size(98, 69);
            this.endTurnButton.TabIndex = 2;
            this.endTurnButton.Text = "Advance Month\r\n(End Turn)";
            this.endTurnButton.UseVisualStyleBackColor = true;
            // 
            // infoBox
            // 
            this.infoBox.FormattingEnabled = true;
            this.infoBox.Location = new System.Drawing.Point(157, 27);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(619, 69);
            this.infoBox.TabIndex = 3;
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
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 498);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(896, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(57, 17);
            this.toolStripStatusLabel1.Text = "Waiting...";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // resourceBox
            // 
            this.resourceBox.FormattingEnabled = true;
            this.resourceBox.Location = new System.Drawing.Point(12, 27);
            this.resourceBox.Name = "resourceBox";
            this.resourceBox.Size = new System.Drawing.Size(139, 69);
            this.resourceBox.TabIndex = 6;
            // 
            // feudalMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 520);
            this.Controls.Add(this.resourceBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.endTurnButton);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "feudalMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feudal";
            this.mainTabControl.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage govtTab;
        private System.Windows.Forms.TabPage ecoTab;
        private System.Windows.Forms.TabPage milTab;
        private System.Windows.Forms.Button endTurnButton;
        private System.Windows.Forms.ListBox infoBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ListBox resourceBox;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.TabPage techTab;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}

