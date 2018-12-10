namespace gobang
{
    partial class Welcome
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
            this.dualPlayer = new System.Windows.Forms.Button();
            this.singlePlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dualPlayer
            // 
            this.dualPlayer.BackColor = System.Drawing.Color.Transparent;
            this.dualPlayer.BackgroundImage = global::gobang.Properties.Resources.Button1;
            this.dualPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dualPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dualPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dualPlayer.ForeColor = System.Drawing.SystemColors.Control;
            this.dualPlayer.Location = new System.Drawing.Point(134, 288);
            this.dualPlayer.Name = "dualPlayer";
            this.dualPlayer.Size = new System.Drawing.Size(238, 160);
            this.dualPlayer.TabIndex = 0;
            this.dualPlayer.Text = " Dual\r\nplayer";
            this.dualPlayer.UseVisualStyleBackColor = false;
            this.dualPlayer.Click += new System.EventHandler(this.dualPlayer_Click);
            // 
            // singlePlayer
            // 
            this.singlePlayer.BackColor = System.Drawing.Color.Transparent;
            this.singlePlayer.BackgroundImage = global::gobang.Properties.Resources.Button1;
            this.singlePlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.singlePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.singlePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singlePlayer.ForeColor = System.Drawing.SystemColors.Control;
            this.singlePlayer.Location = new System.Drawing.Point(498, 291);
            this.singlePlayer.Name = "singlePlayer";
            this.singlePlayer.Size = new System.Drawing.Size(233, 160);
            this.singlePlayer.TabIndex = 2;
            this.singlePlayer.Text = "Single\r\nPlayer";
            this.singlePlayer.UseVisualStyleBackColor = false;
            this.singlePlayer.Click += new System.EventHandler(this.singlePlayer_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.BackgroundImage = global::gobang.Properties.Resources.Welcome;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 573);
            this.Controls.Add(this.singlePlayer);
            this.Controls.Add(this.dualPlayer);
            this.DoubleBuffered = true;
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Your Game Mode";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dualPlayer;
        private System.Windows.Forms.Button singlePlayer;
    }
}

