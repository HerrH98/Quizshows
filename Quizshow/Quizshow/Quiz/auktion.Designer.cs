namespace Quizshow.Quiz
{
    partial class auktion
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.artikelPic = new System.Windows.Forms.PictureBox();
            this.next = new System.Windows.Forms.Button();
            this.differences = new System.Windows.Forms.Label();
            this.showValues = new System.Windows.Forms.Button();
            this.showDifference = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikelPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Anzahl Spieler";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AutoSize = true;
            this.numericUpDown1.Location = new System.Drawing.Point(98, 12);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // artikelPic
            // 
            this.artikelPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.artikelPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.artikelPic.Location = new System.Drawing.Point(273, 59);
            this.artikelPic.Margin = new System.Windows.Forms.Padding(300);
            this.artikelPic.Name = "artikelPic";
            this.artikelPic.Size = new System.Drawing.Size(1021, 480);
            this.artikelPic.TabIndex = 6;
            this.artikelPic.TabStop = false;
            // 
            // next
            // 
            this.next.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.next.Location = new System.Drawing.Point(1338, 270);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 7;
            this.next.Text = "Nächster";
            this.next.UseVisualStyleBackColor = true;
            this.next.Visible = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // differences
            // 
            this.differences.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.differences.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.differences.Location = new System.Drawing.Point(273, 542);
            this.differences.Name = "differences";
            this.differences.Size = new System.Drawing.Size(652, 45);
            this.differences.TabIndex = 9;
            this.differences.Text = "Differenzen";
            this.differences.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.differences.Visible = false;
            // 
            // showValues
            // 
            this.showValues.Location = new System.Drawing.Point(1338, 14);
            this.showValues.Name = "showValues";
            this.showValues.Size = new System.Drawing.Size(75, 23);
            this.showValues.TabIndex = 8;
            this.showValues.Text = "Auflösung";
            this.showValues.UseVisualStyleBackColor = true;
            this.showValues.Click += new System.EventHandler(this.showValues_Click);
            // 
            // showDifference
            // 
            this.showDifference.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showDifference.AutoSize = true;
            this.showDifference.Location = new System.Drawing.Point(273, 542);
            this.showDifference.Name = "showDifference";
            this.showDifference.Size = new System.Drawing.Size(15, 14);
            this.showDifference.TabIndex = 10;
            this.showDifference.UseVisualStyleBackColor = true;
            this.showDifference.Visible = false;
            this.showDifference.CheckedChanged += new System.EventHandler(this.showDifference_CheckedChanged);
            // 
            // auktion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1448, 671);
            this.Controls.Add(this.showDifference);
            this.Controls.Add(this.differences);
            this.Controls.Add(this.showValues);
            this.Controls.Add(this.next);
            this.Controls.Add(this.artikelPic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "auktion";
            this.Text = "Was kostet die Welt?";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikelPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDown1;
        private PictureBox artikelPic;
        private Button next;
        private Label differences;
        private Button showValues;
        private CheckBox showDifference;
    }
}