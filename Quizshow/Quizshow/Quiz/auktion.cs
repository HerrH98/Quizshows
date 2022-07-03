using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quizshow.Class;
using Quizshow.Elements;

namespace Quizshow.Quiz
{
    public partial class auktion : Form
    {
        private Artikel[] artikel;
        private auctionBoard[] boards;
        private int aktuelleIndex;
        private decimal maxGeld;
        public auktion()
        {
            InitializeComponent();
            string path = "..\\..\\..\\Quizfragen\\Was kostet die Welt\\Artikeldaten\\ArtikelListe.txt";
            StreamReader sr = new StreamReader(path);
            string line = sr.ReadLine();
            this.maxGeld = Convert.ToDecimal(line);
            this.artikel = new Artikel[10];
            this.boards = new auctionBoard[0];
            for (int i = 0; i < this.artikel.Length; i++)
            {
                line = sr.ReadLine();
                this.artikel[i] = new Artikel(i+1, Convert.ToDecimal(line));
            }
            sr.Close(); 
            this.aktuelleIndex = 0;
            this.artikelPic.ImageLocation = this.artikel[this.aktuelleIndex].getPath();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < this.boards.Length; i++)
            {
                this.Controls.Remove(this.boards[i]);
            }
            this.boards = new auctionBoard[(int)this.numericUpDown1.Value];
            int locx = 240;
            int locy = 820;
            for (int i = 0; i < this.boards.Length; i++)
            {
                this.boards[i] = new auctionBoard(this,"Player " + (i + 1), this.maxGeld)
                {
                    Location = new Point(locx, locy)
                };
                this.Controls.Add(this.boards[i]);
                locx += 250;
            }
        }
        public Artikel Kaufen()
        {
            Artikel gekauft = this.artikel[this.aktuelleIndex];
            this.aktuelleIndex++;
            try { 
                this.artikelPic.ImageLocation = this.artikel[this.aktuelleIndex].getPath(); 
            }catch { };
            return gekauft;
        }

        private void showValues_Click(object sender, EventArgs e)
        {
            this.showDifference.Visible = true;
            this.next.Visible = true;
            this.aktuelleIndex = 0;
            this.artikelPic.ImageLocation = this.artikel[this.aktuelleIndex].getPath();
            if (this.artikel[this.aktuelleIndex].getDifference()>0)
            {
                this.differences.Text = this.artikel[this.aktuelleIndex].getKosten()+" (+ " +this.artikel[this.aktuelleIndex].getDifference().ToString()+")";
                this.differences.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                this.differences.Text = this.artikel[this.aktuelleIndex].getKosten() + " (" + this.artikel[this.aktuelleIndex].getDifference().ToString() + ")";
                this.differences.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void showDifference_CheckedChanged(object sender, EventArgs e)
        {
            if (this.showDifference.Checked)
            {
                this.differences.Visible = true;
            }
            else
            {
                this.differences.Visible = false;
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            try
            {
                string user = this.artikel[this.aktuelleIndex].getPlayer();
                for (int i = 0; i < this.boards.Length; i++)
                {
                    if (this.boards[i].getName()==user)
                    {
                        this.boards[i].addDifference(this.artikel[this.aktuelleIndex].getKosten());
                    }
                }
            }
            catch { }
            this.showDifference.Checked = false;
            this.aktuelleIndex++;
            try
            {
                this.artikelPic.ImageLocation = this.artikel[this.aktuelleIndex].getPath();
            }
            catch { };
            if (this.artikel[this.aktuelleIndex].getDifference() > 0)
            {
                this.differences.Text = this.artikel[this.aktuelleIndex].getKosten() + " (+ " + this.artikel[this.aktuelleIndex].getDifference().ToString() + ")";
                this.differences.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                this.differences.Text = this.artikel[this.aktuelleIndex].getKosten() + " (" + this.artikel[this.aktuelleIndex].getDifference().ToString() + ")";
                this.differences.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
