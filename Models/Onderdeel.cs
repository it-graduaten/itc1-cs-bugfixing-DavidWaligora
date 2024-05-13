using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerWinkel.Models
{
    public class Onderdeel
    {
        private double _prijs;

        public double Prijs
        {
            get { return Prijs; }
            set { _prijs = value; }
        }

        public Onderdeel(double prijs)
        {
            Prijs = prijs;
        }
    }
}