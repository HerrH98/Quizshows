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
    public partial class wordcounter : UserControl
    {
        Longest currentGame;
        int index;
        public wordcounter(int index, Longest currentGame)
        {
            InitializeComponent();
            this.currentGame = currentGame;
            this.index = index;
            this.Player.Text = "Player " + index;
        }

        private void Text_TextChanged(object sender, EventArgs e)
        {
            this.zeichenAnzahl.Text = this.Text.Text.Replace(" ", string.Empty).Length + " Zeichen";
        }

        public int getZeichenAnzahl()
        {
            return this.Text.Text.Replace(" ", string.Empty).Length;
        }

        public void setName(String neuerName)
        {
            this.Player.Text = neuerName;
        }
        public String getName()
        {
            return this.Player.Text;
        }

        private void Player_TextChanged(object sender, EventArgs e)
        {
            currentGame.changeName(this.Player.Text, this.index-1);
        }
        public void clear()
        {
            this.Text.Text = "";
        }
    }
}
