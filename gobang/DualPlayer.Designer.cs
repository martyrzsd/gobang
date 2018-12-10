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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DualPlayer));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.competitiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.robotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gOFirstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goSecondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Recover = new System.Windows.Forms.Button();
            this.Attemptation = new System.Windows.Forms.Button();
            this.ReStart = new System.Windows.Forms.Button();
            this.CommentBox = new System.Windows.Forms.TextBox();
            this.Comment = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Previous = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1292, 40);
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
            this.playBackToolStripMenuItem.Click += new System.EventHandler(this.playBackToolStripMenuItem_Click);
            this.playBackToolStripMenuItem.MouseEnter += new System.EventHandler(this.playBackToolStripMenuItem_MouseEnter);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soundToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(113, 36);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // soundToolStripMenuItem
            // 
            this.soundToolStripMenuItem.Name = "soundToolStripMenuItem";
            this.soundToolStripMenuItem.Size = new System.Drawing.Size(183, 38);
            this.soundToolStripMenuItem.Text = "Sound";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(183, 38);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(183, 38);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 36);
            this.toolStripMenuItem1.Text = "`` ";
            // 
            // Recover
            // 
            this.Recover.BackColor = System.Drawing.Color.Transparent;
            this.Recover.FlatAppearance.BorderSize = 0;
            this.Recover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Recover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Recover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Recover.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recover.ForeColor = System.Drawing.Color.DimGray;
            this.Recover.Location = new System.Drawing.Point(722, 106);
            this.Recover.Name = "Recover";
            this.Recover.Size = new System.Drawing.Size(135, 106);
            this.Recover.TabIndex = 1;
            this.Recover.Text = "Recover";
            this.Recover.UseVisualStyleBackColor = false;
            this.Recover.Click += new System.EventHandler(this.Recover_Click);
            // 
            // Attemptation
            // 
            this.Attemptation.BackColor = System.Drawing.Color.Transparent;
            this.Attemptation.FlatAppearance.BorderSize = 0;
            this.Attemptation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Attemptation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Attemptation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Attemptation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attemptation.ForeColor = System.Drawing.Color.DimGray;
            this.Attemptation.Location = new System.Drawing.Point(722, 240);
            this.Attemptation.Name = "Attemptation";
            this.Attemptation.Size = new System.Drawing.Size(135, 110);
            this.Attemptation.TabIndex = 2;
            this.Attemptation.Text = "Attemptation";
            this.Attemptation.UseVisualStyleBackColor = false;
            this.Attemptation.Click += new System.EventHandler(this.Attemptation_Click);
            // 
            // ReStart
            // 
            this.ReStart.BackColor = System.Drawing.Color.Transparent;
            this.ReStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReStart.FlatAppearance.BorderSize = 0;
            this.ReStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ReStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ReStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReStart.ForeColor = System.Drawing.Color.DimGray;
            this.ReStart.Location = new System.Drawing.Point(722, 386);
            this.ReStart.Name = "ReStart";
            this.ReStart.Size = new System.Drawing.Size(135, 105);
            this.ReStart.TabIndex = 3;
            this.ReStart.Text = "ReStart";
            this.ReStart.UseVisualStyleBackColor = false;
            this.ReStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // CommentBox
            // 
            this.CommentBox.BackColor = System.Drawing.Color.Black;
            this.CommentBox.Enabled = false;
            this.CommentBox.ForeColor = System.Drawing.Color.White;
            this.CommentBox.Location = new System.Drawing.Point(932, 222);
            this.CommentBox.Multiline = true;
            this.CommentBox.Name = "CommentBox";
            this.CommentBox.Size = new System.Drawing.Size(211, 187);
            this.CommentBox.TabIndex = 4;
            this.CommentBox.Visible = false;
            // 
            // Comment
            // 
            this.Comment.BackColor = System.Drawing.Color.Transparent;
            this.Comment.BackgroundImage = global::gobang.Properties.Resources.Comment;
            this.Comment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Comment.Enabled = false;
            this.Comment.FlatAppearance.BorderSize = 0;
            this.Comment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Comment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Comment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comment.ForeColor = System.Drawing.Color.DimGray;
            this.Comment.Location = new System.Drawing.Point(932, 678);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(211, 80);
            this.Comment.TabIndex = 5;
            this.Comment.Text = "Comment";
            this.Comment.UseVisualStyleBackColor = false;
            this.Comment.Visible = false;
            this.Comment.Click += new System.EventHandler(this.Comment_Click);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.Transparent;
            this.Next.BackgroundImage = global::gobang.Properties.Resources.InGameButton2;
            this.Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Next.Enabled = false;
            this.Next.FlatAppearance.BorderSize = 0;
            this.Next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.ForeColor = System.Drawing.Color.DarkGray;
            this.Next.Location = new System.Drawing.Point(1061, 501);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(129, 118);
            this.Next.TabIndex = 7;
            this.Next.Text = "    Next";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Visible = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Previous
            // 
            this.Previous.BackColor = System.Drawing.Color.Transparent;
            this.Previous.BackgroundImage = global::gobang.Properties.Resources.InGameButton2;
            this.Previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Previous.Enabled = false;
            this.Previous.FlatAppearance.BorderSize = 0;
            this.Previous.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Previous.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Previous.ForeColor = System.Drawing.Color.DarkGray;
            this.Previous.Location = new System.Drawing.Point(896, 501);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(147, 118);
            this.Previous.TabIndex = 8;
            this.Previous.Text = "Previous";
            this.Previous.UseVisualStyleBackColor = false;
            this.Previous.Visible = false;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(1157, 718);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 9;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DualPlayer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.BackgroundImage = global::gobang.Properties.Resources.my1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1292, 833);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Comment);
            this.Controls.Add(this.CommentBox);
            this.Controls.Add(this.ReStart);
            this.Controls.Add(this.Attemptation);
            this.Controls.Add(this.Recover);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DualPlayer";
            this.Text = "DualPlay";
            this.Load += new System.EventHandler(this.DualPlayer_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DualPlayer_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DualPlayer_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
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
        private System.Windows.Forms.TextBox CommentBox;
        private System.Windows.Forms.Button Comment;
        private System.Windows.Forms.ToolStripMenuItem soundToolStripMenuItem;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}