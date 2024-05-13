using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerWinkel.Models
{
    public class Muis : Accessoire
    {
        private int _aantalInstellingen;
        private int _maxDpi;

        public int AantalInstellingen
        {
            get { return _aantalInstellingen; }
            set { _aantalInstellingen = value; }
        }

        public int MaxDpi
        {
            get { return _maxDpi; }
            set { _maxDpi = value; }
        }

        public Muis(string merk, string model, bool isDraadloos, bool heeftRgbVerlichting, double prijs, int aantalInstellingen, int max_Dpi)
            : base(model, merk, isDraadloos, heeftRgbVerlichting, prijs)
        {
            AantalInstellingen = aantalInstellingen;
            MaxDpi = max_Dpi;
        }

        public override string ToString()
        {
            return $"Muis: {base.ToString()} - Aantal instellingen {AantalInstellingen} - Max DPI {MaxDpi} - Prijs {Prijs} euro";
        }
    }
}