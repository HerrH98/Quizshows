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
    public partial class Longest : Form
    {
        wordcounter[] wc;
        scoreBoards[] boards;
        public Longest()
        {
            InitializeComponent();
            wc = new wordcounter[0];
            boards = new scoreBoards[0];
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < this.wc.Length; i++)
            {
                this.Controls.Remove(this.wc[i]);
                this.Controls.Remove(this.boards[i]);
            }
            int locx = 240;
            int locy = 265;
            this. wc = new wordcounter[(int)numericUpDown1.Value];
            this.boards = new scoreBoards[this.wc.Length];
            for (int i = 0; i < this.wc.Length; i++)
            {
                this.wc[i] = new wordcounter(i + 1, this)
                {
                    Location = new Point(locx, locy)
                };
                this.Controls.Add(this.wc[i]);
                locy += 60;
            }
            createScores();
        }
        private void createScores()
        {
            int locx = 240;
            int locy = 720;
            for (int i = 0; i < this.boards.Length; i++)
            {
                this.boards[i] = new scoreBoards(this.wc[i].getName(), 0)
                {
                    Location = new Point(locx, locy)
                };
                this.Controls.Add(this.boards[i]);
                locx += 160;
            }
        }
        public void changeName(String newName, int index)
        {
            try
            {
                if (this.boards[index] != null)
                {
                    this.boards[index].setName(newName);
                }
            }
            catch { }
        }

        private void endRound_Click(object sender, EventArgs e)
        {
            int highestCount = 0;
            int[] index = new int[this.wc.Length];
            for(int i=0; i < this.wc.Length; i++)
            {
                if (this.wc[i].getZeichenAnzahl()>highestCount)
                {
                    highestCount=this.wc[i].getZeichenAnzahl();
                }
            }
            for(int j = 0; j < this.wc.Length; j++)
            {
                if (this.wc[j].getZeichenAnzahl() == highestCount)
                {
                    this.boards[j].addToScore(1);
                }
                this.wc[j].clear();
            }

        }
    }
}
