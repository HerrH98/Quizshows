namespace Quizshow
{
    partial class Quizshows
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tenVsWilli = new System.Windows.Forms.Button();
            this.longest = new System.Windows.Forms.Button();
            this.costs = new System.Windows.Forms.Button();
            this.sloxikon = new System.Windows.Forms.Button();
            this.spotify = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tenVsWilli
            // 
            this.tenVsWilli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tenVsWilli.AutoSize = true;
            this.tenVsWilli.Location = new System.Drawing.Point(249, 60);
            this.tenVsWilli.Name = "tenVsWilli";
            this.tenVsWilli.Size = new System.Drawing.Size(307, 40);
            this.tenVsWilli.TabIndex = 0;
            this.tenVsWilli.Text = "10 gegen Willi";
            this.tenVsWilli.UseVisualStyleBackColor = true;
            this.tenVsWilli.Click += new System.EventHandler(this.tenVsWilli_Click);
            // 
            // longest
            // 
            this.longest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.longest.AutoSize = true;
            this.longest.Location = new System.Drawing.Point(249, 119);
            this.longest.Name = "longest";
            this.longest.Size = new System.Drawing.Size(307, 41);
            this.longest.TabIndex = 1;
            this.longest.Text = "Wer hat den Längsten?";
            this.longest.UseVisualStyleBackColor = true;
            this.longest.Click += new System.EventHandler(this.longest_Click);
            // 
            // costs
            // 
            this.costs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.costs.AutoSize = true;
            this.costs.Location = new System.Drawing.Point(249, 177);
            this.costs.Name = "costs";
            this.costs.Size = new System.Drawing.Size(307, 41);
            this.costs.TabIndex = 2;
            this.costs.Text = "Was kostet die Welt?";
            this.costs.UseVisualStyleBackColor = true;
            this.costs.Click += new System.EventHandler(this.costs_Click);
            // 
            // sloxikon
            // 
            this.sloxikon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sloxikon.AutoSize = true;
            this.sloxikon.Location = new System.Drawing.Point(249, 235);
            this.sloxikon.Name = "sloxikon";
            this.sloxikon.Size = new System.Drawing.Size(307, 41);
            this.sloxikon.TabIndex = 3;
            this.sloxikon.Text = "Sloxikon-Quiz";
            this.sloxikon.UseVisualStyleBackColor = true;
            this.sloxikon.Click += new System.EventHandler(this.sloxikon_Click);
            // 
            // spotify
            // 
            this.spotify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.spotify.AutoSize = true;
            this.spotify.Location = new System.Drawing.Point(249, 292);
            this.spotify.Name = "spotify";
            this.spotify.Size = new System.Drawing.Size(307, 41);
            this.spotify.TabIndex = 4;
            this.spotify.Text = "Spotify-Quiz";
            this.spotify.UseVisualStyleBackColor = true;
            this.spotify.Click += new System.EventHandler(this.spotify_Click);
            // 
            // close
            // 
            this.close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.close.AutoSize = true;
            this.close.Location = new System.Drawing.Point(249, 349);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(307, 41);
            this.close.TabIndex = 5;
            this.close.Text = "Beenden";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Quizshows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.Controls.Add(this.close);
            this.Controls.Add(this.spotify);
            this.Controls.Add(this.sloxikon);
            this.Controls.Add(this.costs);
            this.Controls.Add(this.longest);
            this.Controls.Add(this.tenVsWilli);
            this.Name = "Quizshows";
            this.Text = "Quizshows";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button tenVsWilli;
        private Button longest;
        private Button costs;
        private Button sloxikon;
        private Button spotify;
        private Button close;
    }
}