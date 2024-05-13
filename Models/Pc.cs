using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerWinkel.Models
{
    public class Pc
    {
        private Geheugen _geheugen;
        private Moederbord _moederbord;
        private Processor _processor;
        private GrafischeKaart _grafischeKaart;

        public Geheugen Geheugen
        {
            get { return _geheugen; }
            set { _geheugen = value; }
        }
        public Moederbord Moederbord
        {
            get { return _moederbord; }
            set { _moederbord = value; }
        }
        public Processor Processor
        {
            get { return _processor; }
            set { _processor = value; }
        }

        public GrafischeKaart GrafischeKaart
        {
            get { return _grafischeKaart; }
            set { _grafischeKaart = value; }
        }

        public bool ControleerOnderdelen()
        {
            if (Moederbord.Socket != Processor.Socket)
                return false;

            if (Moederbord.GeheugenType != Geheugen.Type)
                return false;

            return true;
        }

        public bool PcIsCompleet()
        {
            return Geheugen != null && Moederbord != null && Processor != null && GrafischeKaart != null;
        }

        public void VerwijderOnderdelen()
        {
            Geheugen = null;
            Moederbord = null;
            Processor = null;
            GrafischeKaart = null;
        }

        public double TotaalPrijs()
        {
            return Geheugen.Prijs + Moederbord.Prijs + Processor.Prijs + GrafischeKaart.Prijs;
        }

        public override string ToString()
        {
            return $"Geheugen: {Geheugen}\nMoederbord: {Moederbord}\nProcessor: {Processor}\nGrafische kaart: {GrafischeKaart}\nPrijs PC: {TotaalPrijs():N2} euro";
        }
    }
}
