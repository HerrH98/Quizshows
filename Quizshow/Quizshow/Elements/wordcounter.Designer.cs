namespace Quizshow.Elements
{
    partial class wordcounter
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
            this.Text = new System.Windows.Forms.TextBox();
            this.zeichenAnzahl = new System.Windows.Forms.Label();
            this.Player = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Text
            // 
            this.Text.Location = new System.Drawing.Point(85, 3);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(274, 23);
            this.Text.TabIndex = 1;
            this.Text.TextChanged += new System.EventHandler(this.Text_TextChanged);
            // 
            // zeichenAnzahl
            // 
            this.zeichenAnzahl.Location = new System.Drawing.Point(378, 6);
            this.zeichenAnzahl.Name = "zeichenAnzahl";
            this.zeichenAnzahl.Size = new System.Drawing.Size(90, 15);
            this.zeichenAnzahl.TabIndex = 2;
            this.zeichenAnzahl.Text = "0 Zeichen";
            this.zeichenAnzahl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Player
            // 
            this.Player.Location = new System.Drawing.Point(3, 3);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(76, 23);
            this.Player.TabIndex = 3;
            this.Player.TextChanged += new System.EventHandler(this.Player_TextChanged);
            // 
            // wordcounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Player);
            this.Controls.Add(this.zeichenAnzahl);
            this.Controls.Add(this.Text);
            this.Name = "wordcounter";
            this.Size = new System.Drawing.Size(483, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox Text;
        private Label zeichenAnzahl;
        private TextBox Player;
    }
}
