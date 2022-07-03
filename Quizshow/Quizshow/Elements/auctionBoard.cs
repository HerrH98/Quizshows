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
using Quizshow.Class;

namespace Quizshow.Elements
{
    public partial class auctionBoard : UserControl
    {
        private auktion currentGame;
        private List<Artikel> artikel;
        private int artikelIndex;

        public auctionBoard(auktion game,string name, decimal geld)
        {
            InitializeComponent();
            this.currentGame = game;
            this.Player.Text = name;
            this.geld.Text = geld.ToString();
            this.artikelIndex = 1;
            this.artikel = new List<Artikel>();
        }

        private void buy_Click(object sender, EventArgs e)
        {
            Artikel gekauft = this.currentGame.Kaufen();
            this.artikel.Add(gekauft);
            this.geld.Text = (Convert.ToDecimal(this.geld.Text) - this.gebot.Value).ToString();
            PictureBox newArtikel;
            switch (this.artikelIndex){
                case 1: newArtikel = this.artikel1; break;
                case 2: newArtikel = this.artikel2; break;
                case 3: newArtikel = this.artikel3; break;
                case 4: newArtikel = this.artikel4; break;
                case 5: newArtikel = this.artikel5; break;
                case 6: newArtikel = this.artikel6; break;
                case 7: newArtikel = this.artikel7; break;
                case 8: newArtikel = this.artikel8; break;
                case 9: newArtikel = this.artikel9; break;
                case 10: newArtikel = this.artikel10; break;
                default: newArtikel = this.artikel1; break;
            }
            newArtikel.BackgroundImage = new Bitmap(this.artikel[this.artikelIndex - 1].getPath());
            this.artikel[this.artikelIndex - 1].ersteigert(this.Player.Text, this.gebot.Value);
            this.gebot.Value = 0;
            this.artikelIndex++;
        }
        public string getName()
        {
            return this.Player.Text;
        }
        public void addDifference(decimal Kosten)
        {
            this.geld.Text = (Convert.ToDecimal(this.geld.Text) + Kosten).ToString();
        }
    }
}
