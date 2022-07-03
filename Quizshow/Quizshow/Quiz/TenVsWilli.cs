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
    public partial class TenVsWilli : Form
    {
        WilliRow[] wrows;
        scoreBoards[] scbo;
        public TenVsWilli()
        {
            InitializeComponent();
            wrows = new WilliRow[0];
            scbo = new scoreBoards[0];
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < wrows.Length; i++)
            {
                this.Controls.Remove(wrows[i]);
                this.Controls.Remove(scbo[i]);
            }
            int locx = 240;
            int locy = 265;
            wrows = new WilliRow[(int) numericUpDown1.Value];
            scbo = new scoreBoards[wrows.Length];
            for(int i = 0; i <  wrows.Length; i++)
            {
                wrows[i] = new WilliRow(i + 1, this)
                {
                    Location = new Point(locx, locy)
                };
                this.Controls.Add(wrows[i]);
                locx += 160;
            }
            createScores();
        }
        private void createScores()
        {
            int locx =240;
            int locy =720;
            for(int i = 0; i < this.scbo.Length; i++)
            {
                this.scbo[i] = new scoreBoards(wrows[i].getName(), 0)
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

        private void endRound_Click(object sender, EventArgs e)
        {
            int[] points = new int[this.wrows.Length];
            int i = 0;
            foreach (WilliRow wrow in this.wrows)
            {
                if (!wrow.getWilli())
                {
                    points[i]=wrow.getPoints();
                }
                else
                {
                    points[i] = 0;
                }
                i++;
            }
            int highest = points[0];
            for (int j =0; j<points.Length;j++)
            {
                if (points[j]>highest)
                {
                    highest= points[j];
                }
            }
            for (int k=0; k<this.scbo.Length;k++)
            {
                if (this.wrows[k].getWilli())
                {
                    this.scbo[k].addToScore(highest);
                }
                else
                {
                    this.scbo[k].addToScore(points[k]);
                }
            }
        }
    }
}
