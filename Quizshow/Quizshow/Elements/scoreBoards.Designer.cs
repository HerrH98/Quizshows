namespace Quizshow.Elements
{
    partial class scoreBoards
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
            this.Spieler = new System.Windows.Forms.TextBox();
            this.score = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.score)).BeginInit();
            this.SuspendLayout();
            // 
            // Spieler
            // 
            this.Spieler.Location = new System.Drawing.Point(0, 0);
            this.Spieler.Name = "Spieler";
            this.Spieler.Size = new System.Drawing.Size(100, 23);
            this.Spieler.TabIndex = 0;
            // 
            // score
            // 
            this.score.Location = new System.Drawing.Point(94, 0);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(46, 23);
            this.score.TabIndex = 1;
            // 
            // scoreBoards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.score);
            this.Controls.Add(this.Spieler);
            this.Name = "scoreBoards";
            this.Size = new System.Drawing.Size(140, 23);
            ((System.ComponentModel.ISupportInitialize)(this.score)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Spieler;
        private NumericUpDown score;
    }
}
