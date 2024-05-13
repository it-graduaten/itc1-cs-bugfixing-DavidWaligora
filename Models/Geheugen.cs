using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerWinkel.Models
{
    public class Geheugen : Onderdeel
    {
        private string _type;
        private int _moduleGrootte;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public int ModuleGrootte
        {
            get { return _moduleGrootte; }
            set { _moduleGrootte = value; }
        }

        public Geheugen(string type, int moduleGrootte, double prijs) : base(prijs)
        {
            Type = type;
            ModuleGrootte = moduleGrootte;
        }

        public override string ToString()
        {
            return $"Geheugen: {Type} - {ModuleGrootte}GB";
        }
    }
}