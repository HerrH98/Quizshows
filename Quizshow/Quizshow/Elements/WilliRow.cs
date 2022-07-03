using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quizshow.Quiz;

namespace Quizshow.Elements
{
    public partial class WilliRow : UserControl
    {
        TenVsWilli currentGame;
        int index;
        public WilliRow(int counter, TenVsWilli currentGame)
        {
            InitializeComponent();
            this.currentGame = currentGame;
            this.Spieler.Text = "Player " + counter;
            this.index = counter;
        }

        public int getPoints()
        {
            int points = 0;
            for (int i=1; i<11; i++)
            {
                switch (i)
                {
                    case 1:
                        if (cb1.Checked) { points++; cb1.Checked = false; }
                        break;
                    case 2:
                        if (cb2.Checked) { points++; cb2.Checked = false; }
                        break;
                    case 3:
                        if (cb3.Checked) { points++; cb3.Checked = false; }
                        break;
                    case 4:
                        if (cb4.Checked) { points++; cb4.Checked = false; }
                        break;
                    case 5:
                        if (cb5.Checked) { points++; cb5.Checked = false; }
                        break;
                    case 6:
                        if (cb6.Checked) { points++; cb6.Checked = false; }
                        break;
                    case 7:
                        if (cb7.Checked) { points++; cb7.Checked = false; }
                        break;
                    case 8:
                        if (cb8.Checked) { points++; cb8.Checked = false; }
                        break;
                    case 9:
                        if (cb9.Checked) { points++; cb9.Checked = false; }
                        break;
                    case 10:
                        if (cb10.Checked) { points++; cb10.Checked = false; }
                        break;
                }
            }
            return points;
        }
        public Boolean getWilli()
        {
            return this.isWilli.Checked;
        }
        public string getName()
        {
            return this.Spieler.Text;
        }

        private void Spieler_TextChanged(object sender, EventArgs e)
        {
            currentGame.changeName(this.Spieler.Text, this.index-1);
        }
    }
}
