using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ComputerWinkel.Models
{
    public class Aankoop
    {
        private Pc _pc;
        private List<Accessoire> _accessoires;
        private List<Software> _software;

        public Pc Pc
        {
            get { return _pc; }
            set { _pc = value; }
        }

        public List<Accessoire> Accessoires
        {
            get { return _accessoires; }
            private set { _accessoires = value; }
        }

        public List<Software> Software
        {
            get { return _software; }
            private set { _software = value; }
        }

        public Aankoop()
        {
            Accessoires = new List<Accessoire>();
            Software = new List<Software>();
        }

        public void VoegAccessoireToe(Accessoire accessoire)
        {
            if (accessoire == null)
                return;

            Accessoires.Add(accessoire);
        }

        public void VoegSoftwareToe(Software software)
        {
            if (software != null)
                Software.Add(software);

            
        }

        public double BerekenTotalePrijs()
        {
            double totalePrijs = Pc.TotaalPrijs();
            Accessoires.ForEach(a => totalePrijs += a.Prijs);
            Software.ForEach(s => totalePrijs += s.Prijs);
            return totalePrijs;
        }
    }
}