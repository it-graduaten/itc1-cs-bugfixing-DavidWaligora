using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerWinkel.Models
{
    public class Toetsenbord : Accessoire
    {
        private string _layout;
        private bool _isMechanisch;

        public string Layout
        {
            get { return _layout; }
            set { _layout = value; }
        }

        public bool IsMechanisch
        {
            get { return _isMechanisch; }
            set { _isMechanisch = value; }
        }

        public Toetsenbord(string merk, string model, bool isDraadloos, bool heeftRgbverlichting, double prijs, string layout, bool isMechanisch)
            : base(merk, model, isDraadloos, heeftRgbverlichting, prijs)
        {
            Layout = layout;
            IsMechanisch = isMechanisch;
        }

        public override string ToString()
        {
            string mechanisch = IsMechanisch ? "Ja" : "Nee";
            return $"Toetsenbord: {base.ToString()} - Prijs {Prijs} - Layout {Layout} - Mechanisch {mechanisch}";
        }
    }
}