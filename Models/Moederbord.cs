using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerWinkel.Models
{
    public class Moederbord : Onderdeel
    {
        private string _socket;
        private string _chipset;
        private string _formFactor;
        private string _geheugenType;

        public string Socket { 
            get { return _socket; }
            set { _socket = value; }
        }
        public string Chipset
        {
            get { return _chipset; }
            set { _chipset = value; }
        }
        public string FormFactor
        {
            get { return _formFactor; }
            set { _formFactor = value; }
        }
        public string GeheugenType
        {
            get { return _geheugenType; }
            set { _geheugenType = value; }
        }

        public Moederbord(string socket, string chipset, string formFactor, string geheugenType, double prijs) : base(prijs)
        {
            Socket = socket;
            Chipset = chipset;
            FormFactor = formFactor;
            GeheugenType = geheugenType;
        }

        public override string ToString()
        {
            return $"Moederbord: Socket {Socket} - Chipset {Chipset} - Formfactor {FormFactor} - Geheugentype {GeheugenType}";
        }
    }
}
