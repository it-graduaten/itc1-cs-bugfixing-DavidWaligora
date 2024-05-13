using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerWinkel.Models
{
    public static class FileOperations
    {
        public static string BestandOnderdelen = "onderdelen.txt";
        public static string BestandAccessoires = "accessoires.txt";
        public static string BestandSoftware = "software.txt";

        public static List<Onderdeel> LeesOnderdelen()
        {
            List<Onderdeel> onderdelen = new List<Onderdeel>();

            using (StreamReader reader = new StreamReader(BestandOnderdelen))
            {
                while (!reader.EndOfStream)
                {
                    string[] onderdeelGegevens = reader.ReadLine().Split(';');
                    Onderdeel onderdeel = null;

                    string onderdeelType = onderdeelGegevens[0];

                    switch (onderdeelType)
                    {
                        case "geheugen":
                            string type = onderdeelGegevens[1];
                            int moduleGrootte = int.Parse(onderdeelGegevens[2]);
                            double prijsGeheugen = double.Parse(onderdeelGegevens[3]);

                            onderdeel = new Geheugen(type, moduleGrootte, prijsGeheugen);
                            break;

                        case "moederbord":
                            string socketMoederbord = onderdeelGegevens[1];
                            string chipsetMoederbord = onderdeelGegevens[2];
                            string formFactor = onderdeelGegevens[3];
                            string geheugenType = onderdeelGegevens[4];
                            double prijsMoederbord = double.Parse(onderdeelGegevens[5]);

                            onderdeel = new Moederbord(socketMoederbord, chipsetMoederbord, formFactor, geheugenType, prijsMoederbord);
                            break;

                        case "processor":
                            string merk = onderdeelGegevens[1];
                            string socketProcessor = onderdeelGegevens[2];
                            int aantalCores = int.Parse(onderdeelGegevens[3]);
                            int aantalThreads = int.Parse(onderdeelGegevens[4]);
                            double klokFrequentie = double.Parse(onderdeelGegevens[5]);
                            double prijsProcessor = double.Parse(onderdeelGegevens[6]);

                            onderdeel = new Processor(merk, socketProcessor, aantalCores, aantalThreads, klokFrequentie, prijsProcessor);
                            break;

                        case "grafischeKaart":
                            string chipsetGrafischeKaart = onderdeelGegevens[1];
                            int werkgeheugen = int.Parse(onderdeelGegevens[2]);
                            double prijsGrafischeKaart = double.Parse(onderdeelGegevens[3]);

                            onderdeel = new GrafischeKaart(chipsetGrafischeKaart, werkgeheugen, prijsGrafischeKaart);
                            break;
                    }
                    onderdelen.Add(onderdeel);
                }
            }
            return onderdelen;
        }

        public static List<Moederbord> FilterMoederborden()
        {
            List<Onderdeel> onderdelen = LeesOnderdelen();
            List<Moederbord> moederborden = new List<Moederbord>();

            foreach (var item in onderdelen)
            {
                if (item is Moederbord m)
                    moederborden.Add(m);
            }

            return moederborden;
        }

        public static List<Geheugen> FilterGeheugen()
        {
            List<Onderdeel> onderdelen = LeesOnderdelen();
            List<Geheugen> geheugen = new List<Geheugen>();

            foreach (var item in onderdelen)
            {
                if (item is Geheugen g)
                    geheugen.Add(g);
            }

            return geheugen;
        }

        public static List<Processor> FilterProcessoren()
        {
            List<Onderdeel> onderdelen = LeesOnderdelen();
            List<Processor> processoren = new List<Processor>();

            foreach (var item in onderdelen)
            {
                if (item is Processor p)
                    processoren.Add(p);
            }

            return processoren;
        }

        public static List<GrafischeKaart> FilterGrafischeKaarten()
        {
            List<Onderdeel> onderdelen = LeesOnderdelen();
            List<GrafischeKaart> grafischeKaarten = new List<GrafischeKaart>();

            foreach (var item in onderdelen)
            {
                if (item is GrafischeKaart gk)
                    grafischeKaarten.Add(gk);
            }

            return grafischeKaarten;
        }

        public static List<Accessoire> LeesAccesoires()
        {
            List<Accessoire> accessoires = new List<Accessoire>();

            using (StreamReader reader = new StreamReader(BestandAccessoires))
            {
                while (!reader.EndOfStream)
                {
                    string[] accessoireGegevens = reader.ReadLine().Split(';');

                    string accessoireType = accessoireGegevens[0];

                    string merk = accessoireGegevens[1];
                    string model = accessoireGegevens[2];
                    bool isDraadloos = bool.Parse(accessoireGegevens[3]);
                    double prijs = double.Parse(accessoireGegevens[4]);
                    bool heeftRgbverlichting = bool.Parse(accessoireGegevens[5]);
                    Accessoire accessoire = null;
                    switch (accessoireType)
                    {
                        case "muis":
                            int aantalInstellingen = int.Parse(accessoireGegevens[6]);
                            int maxDpi = int.Parse(accessoireGegevens[7]);
                            //string watDoetDitHier = accessoireGegevens[8];

                            accessoire = new Muis(merk, model, isDraadloos, heeftRgbverlichting, prijs, aantalInstellingen, maxDpi);
                            break;

                        case "toetsenbord":
                            string layout = accessoireGegevens[6];
                            bool isMechanisch = bool.Parse(accessoireGegevens[7]);

                            accessoire = new Toetsenbord(merk, model, isDraadloos, heeftRgbverlichting, prijs, layout, isMechanisch);
                            break;
                    }
                    accessoires.Add(accessoire);
                }
            }

            return accessoires;
        }

        public static List<Muis> FilterMuizen()
        {
            List<Accessoire> accessoires = LeesAccesoires();
            List<Muis> muizen = new List<Muis>();

            foreach (var item in accessoires)
            {
                if (item is Muis m)
                    muizen.Add(m);
            }

            return muizen;
        }

        public static List<Toetsenbord> FilterToetsenborden()
        {
            List<Accessoire> accessoires = LeesAccesoires();
            List<Toetsenbord> toetsenborden = new List<Toetsenbord>();

            foreach (var item in accessoires)
            {
                if (item is Toetsenbord t)
                    toetsenborden.Add(t);
            }

            return toetsenborden;
        }

        public static List<Software> LeesSoftware()
        {
            List<Software> softwareLijst = new List<Software>();
            using (StreamReader reader = new StreamReader(BestandSoftware))
            {
                while (!reader.EndOfStream)
                {
                    string[] softwareGegevens = reader.ReadLine().Split(';');
                    Software software = null;

                    string softwareType = softwareGegevens[0];

                    string naam = softwareGegevens[1];
                    double prijs = double.Parse(softwareGegevens[2]);

                    switch (softwareType)
                    {
                        case "software":
                            software = new Software(naam, prijs);
                            break;

                        case "game":
                            int aantalSpelers = int.Parse(softwareGegevens[3]);
                            int minimaleWerkgeheugen = int.Parse(softwareGegevens[4]);

                            software = new Game(aantalSpelers, minimaleWerkgeheugen, naam, prijs);
                            break;
                    }
                    softwareLijst.Add(software);
                }
            }
            return softwareLijst;
        }

        public static List<Game> FilterGames()
        {
            List<Software> software = LeesSoftware();
            List<Game> games = new List<Game>();

            foreach (var item in software)
            {
                if (item is Game g)
                    games.Add(g);
            }

            return games;
        }
    }
}