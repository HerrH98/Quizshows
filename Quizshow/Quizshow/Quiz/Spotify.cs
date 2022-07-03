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
    public partial class Spotify : Form
    {
        private scoreBoards[] boards;
        private string band = "";
        private string[] titels = new string[10];
        public Spotify()
        {
            InitializeComponent();
            this.boards = new scoreBoards[0];
            loadQuiz(new object(), new EventArgs());
        }

        private void loadQuiz(object sender, EventArgs e)
        {
            this.checkBox2.Checked = false;
            this.checkBox3.Checked = false;
            this.checkBox4.Checked = false;
            this.checkBox5.Checked = false;
            this.checkBox6.Checked = false;
            this.checkBox7.Checked = false;
            this.checkBox8.Checked = false;
            this.checkBox9.Checked = false;
            this.checkBox10.Checked = false;
            this.checkBox11.Checked = false;
            this.showBand.Checked = false;
            string path = "..\\..\\..\\Quizfragen\\Spotify\\Spotify.txt";
            StreamReader sr = new StreamReader(path);
            string line = sr.ReadLine();
            this.band = line;
            for (int i = 0; i < 10; i++)
            {
                line = sr.ReadLine();
                if(line!=null)
                {
                    this.titels[i] = line;
                }
                else
                {
                    this.titels[i] = "Fehler! Da ist was schief gelaufen";
                }
            }
            sr.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < this.boards.Length; i++)
            {
                this.Controls.Remove(this.boards[i]);
            }
            this.boards = new scoreBoards[(int)this.numericUpDown1.Value];
            int locx = 240;
            int locy = 720;
            for (int i = 0; i < this.boards.Length; i++)
            {
                this.boards[i] = new scoreBoards("Player "+(i+1), 0)
                {
                    Location = new Point(locx, locy)
                };
                this.Controls.Add(this.boards[i]);
                locx += 160;
            }
        }

        private void showBand_CheckedChanged(object sender, EventArgs e)
        {
            if (this.showBand.Checked)
            {
                this.Band.Text = this.band;
            }
            else
            {
                this.Band.Text = "";
            }
        }

        private void titelCheckBox(object sender, EventArgs e)
        {
            CheckBox send = (CheckBox)sender;
            switch (send.Name)
            {
                case "checkBox2": if (send.Checked) { this.titel.Text = this.titels[0]; } else { this.titel.Text = "Titel 1"; } ;
                    break;
                case "checkBox3":
                    if (send.Checked) { this.titel2.Text = this.titels[1]; } else { this.titel2.Text = "Titel 2"; };
                    break;
                case "checkBox4":
                    if (send.Checked) { this.titel3.Text = this.titels[2]; } else { this.titel3.Text = "Titel 3"; };
                    break;
                case "checkBox5":
                    if (send.Checked) { this.titel4.Text = this.titels[3]; } else { this.titel4.Text = "Titel 4"; };
                    break;
                case "checkBox6":
                    if (send.Checked) { this.titel5.Text = this.titels[4]; } else { this.titel5.Text = "Titel 5"; };
                    break;
                case "checkBox7":
                    if (send.Checked) { this.titel6.Text = this.titels[5]; } else { this.titel6.Text = "Titel 6"; };
                    break;
                case "checkBox8":
                    if (send.Checked) { this.titel7.Text = this.titels[6]; } else { this.titel7.Text = "Titel 7"; };
                    break;
                case "checkBox9":
                    if (send.Checked) { this.titel8.Text = this.titels[7]; } else { this.titel8.Text = "Titel 8"; };
                    break;
                case "checkBox10":
                    if (send.Checked) { this.titel9.Text = this.titels[8]; } else { this.titel9.Text = "Titel 9"; };
                    break;
                case "checkBox11":
                    if (send.Checked) { this.titel10.Text = this.titels[9]; } else { this.titel10.Text = "Titel 10"; };
                    break;

            }
        }
    }
}
