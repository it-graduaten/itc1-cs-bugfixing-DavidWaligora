using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ComputerWinkel.Models
{
    public class Software
    {
        private string _naam;
        private double _prijs;

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        public double Prijs
        {
            get { return _prijs; }
            set { _prijs = value; }
        }

        public Software(string naam, double prijs)
        {
            Naam = naam;
            Prijs = prijs;
        }

        public override string ToString()
        {
            return $"Naam {Naam}";
        }
    }
}