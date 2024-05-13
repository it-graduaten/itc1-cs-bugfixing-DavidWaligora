using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerWinkel.Models
{
    public class GrafischeKaart : Onderdeel
    {
        private string _chipset;
        private int _werkgeheugen;

        public string Chipset
        {
            get { return _chipset; }
            set { _chipset = value; }
        }

        public int Werkgeheugen
        {
            get { return _werkgeheugen; }
            set { value = _werkgeheugen; }
        }

        public GrafischeKaart(string chipset, int werkgeheugen, double prijs) : base(prijs)
        {
            Chipset = chipset;
            Werkgeheugen = werkgeheugen;
        }

        public bool IsGameSpeelbaar(Game game)
        {
            if (Werkgeheugen >= game.MinimaleWerkgeheugen)
                return true;

            return false;
        }

        public override string ToString()
        {
            return $"Chipset: {Chipset} - Werkgeheugen {Werkgeheugen}GB";
        }
    }
}