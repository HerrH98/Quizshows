using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizshow.Class
{
    public class Artikel
    {
        private int index;
        private decimal kosten;
        private decimal gebot;
        private string player;
        private string path;

        public Artikel(int index, decimal kosten)
        {
            this.index = index;
            this.path = @"..\\..\\..\\Quizfragen\\Was kostet die Welt\\Bilder\\Artikel "+this.index+".PNG";
            this.kosten = kosten;
            this.gebot = 0;
            this.player = "";
        }
        public string getPath()
        {
            return this.path;
        }
        public string getPlayer()
        {
            return this.player;
        }
        public void ersteigert(string Player, decimal gebot)
        {
            this.gebot = gebot;
            this.player = Player;
        }
        public float getDifference()
        {
            float difference = (float)this.kosten;
            difference -= (float)this.gebot;
            return difference;
        }
        public decimal getKosten()
        {
            return this.kosten;
        }
    }
}
