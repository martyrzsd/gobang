namespace gobang
{
    partial class DualPlayer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.competitiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.robotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gOFirstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goSecondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Recover = new System.Windows.Forms.Button();
            this.Attemptation = new System.Windows.Forms.Button();
            this.ReStart = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameModeToolStripMenuItem,
            this.playBackToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameModeToolStripMenuItem
            // 
            this.gameModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dualToolStripMenuItem,
            this.competitiveToolStripMenuItem,
            this.robotsToolStripMenuItem});
            this.gameModeToolStripMenuItem.Name = "gameModeToolStripMenuItem";
            this.gameModeToolStripMenuItem.Size = new System.Drawing.Size(75, 36);
            this.gameModeToolStripMenuItem.Text = "New";
            // 
            // dualToolStripMenuItem
            // 
            this.dualToolStripMenuItem.Name = "dualToolStripMenuItem";
            this.dualToolStripMenuItem.Size = new System.Drawing.Size(244, 38);
            this.dualToolStripMenuItem.Text = "Dual";
            this.dualToolStripMenuItem.Click += new System.EventHandler(this.dualToolStripMenuItem_Click_1);
            // 
            // competitiveToolStripMenuItem
            // 
            this.competitiveToolStripMenuItem.Name = "competitiveToolStripMenuItem";
            this.competitiveToolStripMenuItem.Size = new System.Drawing.Size(244, 38);
            this.competitiveToolStripMenuItem.Text = "Competitive";
            this.competitiveToolStripMenuItem.Click += new System.EventHandler(this.competitiveToolStripMenuItem_Click);
            // 
            // robotsToolStripMenuItem
            // 
            this.robotsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gOFirstToolStripMenuItem,
            this.goSecondToolStripMenuItem});
            this.robotsToolStripMenuItem.Name = "robotsToolStripMenuItem";
            this.robotsToolStripMenuItem.Size = new System.Drawing.Size(244, 38);
            this.robotsToolStripMenuItem.Text = "Robots";
            // 
            // gOFirstToolStripMenuItem
            // 
            this.gOFirstToolStripMenuItem.Name = "gOFirstToolStripMenuItem";
            this.gOFirstToolStripMenuItem.Size = new System.Drawing.Size(230, 38);
            this.gOFirstToolStripMenuItem.Text = "Go First";
            // 
            // goSecondToolStripMenuItem
            // 
            this.goSecondToolStripMenuItem.Name = "goSecondToolStripMenuItem";
            this.goSecondToolStripMenuItem.Size = new System.Drawing.Size(230, 38);
            this.goSecondToolStripMenuItem.Text = "Go Second";
            // 
            // playBackToolStripMenuItem
            // 
            this.playBackToolStripMenuItem.Name = "playBackToolStripMenuItem";
            this.playBackToolStripMenuItem.Size = new System.Drawing.Size(119, 36);
            this.playBackToolStripMenuItem.Text = "PlayBack";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(113, 36);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 36);
            this.toolStripMenuItem1.Text = "`` ";
            // 
            // Recover
            // 
            this.Recover.Location = new System.Drawing.Point(550, 50);
            this.Recover.Name = "Recover";
            this.Recover.Size = new System.Drawing.Size(75, 23);
            this.Recover.TabIndex = 1;
            this.Recover.Text = "Recover";
            this.Recover.UseVisualStyleBackColor = true;
            this.Recover.Click += new System.EventHandler(this.Recover_Click);
            // 
            // Attemptation
            // 
            this.Attemptation.Location = new System.Drawing.Point(550, 100);
            this.Attemptation.Name = "Attemptation";
            this.Attemptation.Size = new System.Drawing.Size(75, 23);
            this.Attemptation.TabIndex = 2;
            this.Attemptation.Text = "Attemptation";
            this.Attemptation.UseVisualStyleBackColor = true;
            this.Attemptation.Click += new System.EventHandler(this.Attemptation_Click);
            // 
            // ReStart
            // 
            this.ReStart.Location = new System.Drawing.Point(550, 150);
            this.ReStart.Name = "ReStart";
            this.ReStart.Size = new System.Drawing.Size(75, 23);
            this.ReStart.TabIndex = 3;
            this.ReStart.Text = "ReStart";
            this.ReStart.UseVisualStyleBackColor = true;
            this.ReStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // DualPlayer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(774, 529);
            this.Controls.Add(this.ReStart);
            this.Controls.Add(this.Attemptation);
            this.Controls.Add(this.Recover);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DualPlayer";
            this.Text = "DualPlay";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DualPlayer_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem competitiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem robotsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gOFirstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goSecondToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button Recover;
        private System.Windows.Forms.Button Attemptation;
        private System.Windows.Forms.Button ReStart;
    }
}