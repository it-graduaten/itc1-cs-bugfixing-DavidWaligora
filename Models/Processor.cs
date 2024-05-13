using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerWinkel.Models
{
    public class Processor : Onderdeel
    {
        private string _merk;
        private string _socket;
        private int _aantalCores;
        private int _aantalThreads;
        private double _klokFrequentie;

        public string Merk
        {
            get { return _merk; }
            set { _merk = value; }
        }

        public string Socket
        {
            get { return _socket; }
            set { _socket = value; }
        }

        public int AantalCores
        {
            get { return _aantalCores; }
            set
            {
                if (value < 0)
                    _aantalCores = 0;
                else
                    _aantalCores = value;
            }
        }

        public int AantalThreads
        {
            get { return _aantalThreads; }
            set { _aantalThreads = value; }
        }

        public double KlokFrequentie
        {
            get { return _klokFrequentie; }
            set { _klokFrequentie = value; }
        }

        public Processor(string merk, string socket, int aantalCores, int aantalThreads, double klokFrequentie, double prijs) : base(prijs)
        {
            _merk = merk;
            _socket = socket;
            _aantalCores = aantalCores;
            _aantalThreads = aantalThreads;
            _klokFrequentie = klokFrequentie;
        }

        public override string ToString()
        {
            return $"Processor: Merk {Merk} - Socket {Socket} - {AantalCores} cores  - {AantalThreads} threads - {KlokFrequentie} MHz";
        }
    }
}