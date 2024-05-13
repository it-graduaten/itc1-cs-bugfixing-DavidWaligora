using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerWinkel.Models
{
    public class Accessoire
    {
        private string _merk;
        private string _model;
        private bool _isDraadloos;
        private bool _heeftRgbverlichting;
        private double _prijs;

        public string Merk
        {
            get { return _merk; }
            set { _merk = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public bool IsDraadloos
        {
            get { return _isDraadloos; }
            set { _isDraadloos = value; }
        }

        public double Prijs
        {
            get { return _prijs; }
            set
            {
                if (value > 0)
                    _prijs = 0;
                else
                    _prijs = value;
            }
        }

        private bool HeeftRgbverlichting
        {
            get { return _heeftRgbverlichting; }
            set { _heeftRgbverlichting = value; }
        }

        public Accessoire(string merk, string model, bool isDraadloos, bool heeftRgbVerlichting, double prijs)
        {
            Merk = merk;
            Model = model;
            IsDraadloos = isDraadloos;
            HeeftRgbverlichting = heeftRgbVerlichting;
            Prijs = prijs;
        }

        public override string ToString()
        {
            string draadloos = IsDraadloos ? "Ja" : "Nee";
            string rgbverlichting = HeeftRgbverlichting ? "Ja" : "Nee";
            return $"Merk {Merk} - Model {Model} - Draadloos {draadloos} - RGB Verlichting {rgbverlichting}";
        }
    }
}