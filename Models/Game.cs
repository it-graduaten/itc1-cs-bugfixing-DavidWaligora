using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerWinkel.Models
{
    public class Game : Software
    {
        private int _aantalSpelers;
        private int _minimaleWerkgeheugen;

        public int AantalSpelers
        {
            get { return _aantalSpelers; }
            set { _aantalSpelers = value; }
        }

        public int MinimaleWerkgeheugen
        {
            get { return _minimaleWerkgeheugen; }
            set { _minimaleWerkgeheugen = value; }
        }

        public Game(int aantalSpelers, int minimaleWerkgeheugen, string naam, double prijs) : base(naam, prijs)
        {
            AantalSpelers = aantalSpelers;
            MinimaleWerkgeheugen = minimaleWerkgeheugen;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - Aantal spelers {AantalSpelers} - Minimaal werkgeheugen {MinimaleWerkgeheugen}GB";
        }
    }
}
