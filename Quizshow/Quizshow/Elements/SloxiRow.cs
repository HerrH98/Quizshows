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
    public partial class SloxiRow : UserControl
    {
        private Sloxikon currentgame;
        private int index;
        private int anzahl;
        private CheckBox[] boxes;
        public SloxiRow(int index, int anzahl, Sloxikon game)
        {
            InitializeComponent();
            this.currentgame = game;
            this.index = index;
            this.anzahl = anzahl;
            this.Player.Text = "Player " + index;
            this.boxes = new CheckBox[this.anzahl];
            addCheckboxes();
        }
        private void addCheckboxes()
        {
            for (int i = 0; i < this.boxes.Length; i++)
            {
                this.Controls.Remove(this.boxes[i]);
                this.Controls.Remove(this.boxes[i]);
            }
            int locx = 65;
            int locy = 60;
            for (int i =0; i<this.anzahl; i++)
            {
                this.boxes[i] = new CheckBox()
                {
                    Location = new Point(locx, locy),
                };
                this.Controls.Add(boxes[i]);
                locy += 60;
            }
        }
        public String getName()
        {
            return this.Player.Text;
        }
    }
}
