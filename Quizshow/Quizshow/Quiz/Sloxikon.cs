using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quizshow.Elements;

namespace Quizshow.Quiz
{
    public partial class Sloxikon : Form
    {
        private SloxiRow[] slorow;
        private TextBox[] answers;
        private scoreBoards[] scbo;
        public Sloxikon()
        {
            InitializeComponent();
            this.slorow = new SloxiRow[0];
            this.answers = new TextBox[0];
            this.scbo = new scoreBoards[0];
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < this.slorow.Length; i++)
            {
                this.Controls.Remove(this.slorow[i]);
                this.Controls.Remove(this.answers[i]);
            }
            int locx = 150;
            int locy = 265;
            this.slorow = new SloxiRow[(int)numericUpDown1.Value];
            this.answers = new TextBox[this.slorow.Length+1];
            this.scbo = new scoreBoards[this.slorow.Length];
            for (int j =0; j< this.answers.Length;j++)
            {
                this.answers[j] = new TextBox()
                {
                    Location = new Point(locx, locy),
                    Size = new System.Drawing.Size(250,23)
                };
                this.Controls.Add(this.answers[j]);
                locy += 60;
            }
            locy = 205;
            locx += 280;
            for (int i = 0; i < this.slorow.Length; i++)
            {
                this.slorow[i] = new SloxiRow(i + 1, this.answers.Length, this)
                {
                    Location = new Point(locx, locy)
                };
                this.Controls.Add(this.slorow[i]);
                locx += 160;
            }
            createScores();
        }
        private void createScores()
        {
            int locx = 240;
            int locy = 720;
            for (int i = 0; i < this.scbo.Length; i++)
            {
                this.scbo[i] = new scoreBoards(this.slorow[i].getName(), 0)
                {
                    Location = new Point(locx, locy)
                };
                this.Controls.Add(scbo[i]);
                locx += 160;
            }
        }
        public void changeName(String newName, int index)
        {
            try
            {
                if (this.scbo[index] != null)
                {
                    this.scbo[index].setName(newName);
                }
            }
            catch { }
        }
    }
}
