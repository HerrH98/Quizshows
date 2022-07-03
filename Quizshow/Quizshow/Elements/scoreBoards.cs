using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizshow.Elements
{
    public partial class scoreBoards : UserControl
    {
        public scoreBoards(String player, int score)
        {
            InitializeComponent();
            this.Spieler.Text = player;
            this.score.Value = score;
        }
        public int getScore()
        {
            return (int)this.score.Value;
        }
        public void addToScore(int points)
        {
            this.score.Value += points;
        }
        public void setName(String newName)
        {
            this.Spieler.Text = newName;
        }
        public String getName()
        {
           return this.Spieler.Text;
        }
    }
}
