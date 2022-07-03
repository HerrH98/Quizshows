namespace Quizshow.Elements
{
    partial class auctionBoard
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Player = new System.Windows.Forms.TextBox();
            this.geld = new System.Windows.Forms.Label();
            this.buy = new System.Windows.Forms.Button();
            this.gebot = new System.Windows.Forms.NumericUpDown();
            this.artikel1 = new System.Windows.Forms.PictureBox();
            this.artikel2 = new System.Windows.Forms.PictureBox();
            this.artikel3 = new System.Windows.Forms.PictureBox();
            this.artikel4 = new System.Windows.Forms.PictureBox();
            this.artikel5 = new System.Windows.Forms.PictureBox();
            this.artikel10 = new System.Windows.Forms.PictureBox();
            this.artikel9 = new System.Windows.Forms.PictureBox();
            this.artikel8 = new System.Windows.Forms.PictureBox();
            this.artikel7 = new System.Windows.Forms.PictureBox();
            this.artikel6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gebot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikel10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikel6)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.Dock = System.Windows.Forms.DockStyle.Top;
            this.Player.Location = new System.Drawing.Point(0, 0);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(223, 23);
            this.Player.TabIndex = 0;
            // 
            // geld
            // 
            this.geld.Location = new System.Drawing.Point(3, 29);
            this.geld.Name = "geld";
            this.geld.Size = new System.Drawing.Size(87, 23);
            this.geld.TabIndex = 11;
            this.geld.Text = "Geld";
            this.geld.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buy
            // 
            this.buy.Location = new System.Drawing.Point(166, 29);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(54, 23);
            this.buy.TabIndex = 12;
            this.buy.Text = "Kaufen";
            this.buy.UseVisualStyleBackColor = true;
            this.buy.Click += new System.EventHandler(this.buy_Click);
            // 
            // gebot
            // 
            this.gebot.Location = new System.Drawing.Point(88, 29);
            this.gebot.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.gebot.Name = "gebot";
            this.gebot.Size = new System.Drawing.Size(76, 23);
            this.gebot.TabIndex = 13;
            // 
            // artikel1
            // 
            this.artikel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.artikel1.Location = new System.Drawing.Point(3, 55);
            this.artikel1.Name = "artikel1";
            this.artikel1.Size = new System.Drawing.Size(43, 39);
            this.artikel1.TabIndex = 14;
            this.artikel1.TabStop = false;
            // 
            // artikel2
            // 
            this.artikel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.artikel2.Location = new System.Drawing.Point(47, 55);
            this.artikel2.Name = "artikel2";
            this.artikel2.Size = new System.Drawing.Size(43, 39);
            this.artikel2.TabIndex = 15;
            this.artikel2.TabStop = false;
            // 
            // artikel3
            // 
            this.artikel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.artikel3.Location = new System.Drawing.Point(91, 55);
            this.artikel3.Name = "artikel3";
            this.artikel3.Size = new System.Drawing.Size(43, 39);
            this.artikel3.TabIndex = 16;
            this.artikel3.TabStop = false;
            // 
            // artikel4
            // 
            this.artikel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.artikel4.Location = new System.Drawing.Point(135, 55);
            this.artikel4.Name = "artikel4";
            this.artikel4.Size = new System.Drawing.Size(43, 39);
            this.artikel4.TabIndex = 17;
            this.artikel4.TabStop = false;
            // 
            // artikel5
            // 
            this.artikel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.artikel5.Location = new System.Drawing.Point(179, 55);
            this.artikel5.Name = "artikel5";
            this.artikel5.Size = new System.Drawing.Size(43, 39);
            this.artikel5.TabIndex = 18;
            this.artikel5.TabStop = false;
            // 
            // artikel10
            // 
            this.artikel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.artikel10.Location = new System.Drawing.Point(179, 98);
            this.artikel10.Name = "artikel10";
            this.artikel10.Size = new System.Drawing.Size(43, 39);
            this.artikel10.TabIndex = 23;
            this.artikel10.TabStop = false;
            // 
            // artikel9
            // 
            this.artikel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.artikel9.Location = new System.Drawing.Point(135, 98);
            this.artikel9.Name = "artikel9";
            this.artikel9.Size = new System.Drawing.Size(43, 39);
            this.artikel9.TabIndex = 22;
            this.artikel9.TabStop = false;
            // 
            // artikel8
            // 
            this.artikel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.artikel8.Location = new System.Drawing.Point(91, 98);
            this.artikel8.Name = "artikel8";
            this.artikel8.Size = new System.Drawing.Size(43, 39);
            this.artikel8.TabIndex = 21;
            this.artikel8.TabStop = false;
            // 
            // artikel7
            // 
            this.artikel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.artikel7.Location = new System.Drawing.Point(47, 98);
            this.artikel7.Name = "artikel7";
            this.artikel7.Size = new System.Drawing.Size(43, 39);
            this.artikel7.TabIndex = 20;
            this.artikel7.TabStop = false;
            // 
            // artikel6
            // 
            this.artikel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.artikel6.Location = new System.Drawing.Point(3, 98);
            this.artikel6.Name = "artikel6";
            this.artikel6.Size = new System.Drawing.Size(43, 39);
            this.artikel6.TabIndex = 19;
            this.artikel6.TabStop = false;
            // 
            // auctionBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.artikel10);
            this.Controls.Add(this.artikel9);
            this.Controls.Add(this.artikel8);
            this.Controls.Add(this.artikel7);
            this.Controls.Add(this.artikel6);
            this.Controls.Add(this.artikel5);
            this.Controls.Add(this.artikel4);
            this.Controls.Add(this.artikel3);
            this.Controls.Add(this.artikel2);
            this.Controls.Add(this.artikel1);
            this.Controls.Add(this.gebot);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.geld);
            this.Controls.Add(this.Player);
            this.Name = "auctionBoard";
            this.Size = new System.Drawing.Size(223, 140);
            ((System.ComponentModel.ISupportInitialize)(this.gebot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikel10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikel6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Player;
        private Label geld;
        private Button buy;
        private NumericUpDown gebot;
        private PictureBox artikel1;
        private PictureBox artikel2;
        private PictureBox artikel3;
        private PictureBox artikel4;
        private PictureBox artikel5;
        private PictureBox artikel10;
        private PictureBox artikel9;
        private PictureBox artikel8;
        private PictureBox artikel7;
        private PictureBox artikel6;
    }
}
