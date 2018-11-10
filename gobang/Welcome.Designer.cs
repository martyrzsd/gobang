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
            this.competitve = new System.Windows.Forms.Button();
            this.singlePlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dualPlayer
            // 
            this.dualPlayer.Location = new System.Drawing.Point(50, 50);
            this.dualPlayer.Name = "dualPlayer";
            this.dualPlayer.Size = new System.Drawing.Size(100, 100);
            this.dualPlayer.TabIndex = 0;
            this.dualPlayer.Text = "Dual player";
            this.dualPlayer.UseVisualStyleBackColor = true;
            this.dualPlayer.Click += new System.EventHandler(this.dualPlayer_Click);
            // 
            // competitve
            // 
            this.competitve.Location = new System.Drawing.Point(200, 50);
            this.competitve.Name = "competitve";
            this.competitve.Size = new System.Drawing.Size(100, 100);
            this.competitve.TabIndex = 1;
            this.competitve.Text = "Compatetive";
            this.competitve.UseVisualStyleBackColor = true;
            this.competitve.Click += new System.EventHandler(this.competitve_Click);
            // 
            // singlePlayer
            // 
            this.singlePlayer.Location = new System.Drawing.Point(350, 50);
            this.singlePlayer.Name = "singlePlayer";
            this.singlePlayer.Size = new System.Drawing.Size(100, 100);
            this.singlePlayer.TabIndex = 2;
            this.singlePlayer.Text = "Single player";
            this.singlePlayer.UseVisualStyleBackColor = true;
            this.singlePlayer.Click += new System.EventHandler(this.singlePlayer_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 229);
            this.Controls.Add(this.singlePlayer);
            this.Controls.Add(this.competitve);
            this.Controls.Add(this.dualPlayer);
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Your Game Mode";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dualPlayer;
        private System.Windows.Forms.Button competitve;
        private System.Windows.Forms.Button singlePlayer;
    }
}

