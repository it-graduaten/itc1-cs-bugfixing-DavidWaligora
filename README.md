# itc1-csharp-bugfixing
Deze applicatie bevat de startcode voor een opdracht onder het OPO IT Challenges 1.

## Studenten
- David Waligora (r0989841)
- Jander Alenteyns (r100150)

## Opgeloste fouten
Maak hier een lijst van de fouten die je opgelost hebt. Noteer bij elke fout het bestand en de regelnummer (ongeveer is goed) waar je een aanpassing hebt gedaan. 
Bijvoorbeeld `Program.cs:20` (Het woord opgove aangepast naar opgave)

0. Program.cs:20 - Het woord opgove aangepast naar opgave
2. Program.cs:ToonTitle("PC Samenstellen"); veranderd in ToonTitel("PC Samenstellen");
118. Program.cs:List<Moederbord> moederborden = FileOperations.FilterProcessoren(); naar List<Moederbord> moederborden = FileOperations.FilterMoederborden();
26. Program.cs:heeftRgbverlichting, prijs veranderd van plaats
4. Program.cs:Aankoop aankoop = new Aankoop(); verandering van null naar new Aankoop();
15. Onderdeel: get { return _prijs; } aanpassing van Prijs naar _prijs
55. Merk = merk; Socket = socket; AantalCores = aantalCores; AantalThreads = aantalThreads; KlokFrequentie = klokFrequentie; hoofdletter switch
23. geheugen: set { _moduleGrootte = ModuleGrootte; } ModuleGrootte naar value;
23. grafische kaart: set { value = _werkgeheugen; } omwisseling value met werkgeheugen.
154. fileoperations://string watDoetDitHier = accessoireGegevens[8];
138. fileoperations: lijn weg
146. fileoperations: Accessoire accessoire = null; toevoeging
39. program.cs: optieMuis = KeuzeOptie("muis");
40. accesoires: if (value < 0) aanpassing groter dan naar kleiner dan
36. toetsenbord: return $"Toetsenbord: {base.ToString()} - Prijs {Prijs} - Layout {Layout} - Mechanisch {mechanisch}"; prijs toegevoegd.
217. program.cs: Console.WriteLine($"{i + 1}. {softwareLijst[i]}"); +1 weggehaald.
29. software: Naam = naam; aanpassing switchen van beiden.
37. aankoop:             Software = new List<Software>(); toegevoegd
59. aankoop: Accessoires.ForEach(a => totalePrijs += a.Prijs); Software.ForEach(s => totalePrijs += s.Prijs); + toegevoegd.
117. program.cs     ToonKeuzeTitel("Moederbord"); aanpassing titel

## Screenshots
Het overzicht van de **moederborden** moet er als volgt uit zien:
```
Kies een moederbord:

1. Moederbord: Socket AM4 - Chipset AMD B550 - Formfactor ATX - Geheugentype DDR4
2. Moederbord: Socket AM7 - Chipset AMD B550 - Formfactor ATX - Geheugentype DDR4
3. Moederbord: Socket AM9 - Chipset AMD B550 - Formfactor ATX - Geheugentype DDR5
4. Moederbord: Socket AM3 - Chipset AMD B550 - Formfactor ATX - Geheugentype DDR5
```

Het overzicht van de **Processoren** moet er als volgt uit zien:
```
Kies een processor:

1. Processor: Merk AMD - Socket AM4 - 8 cores  - 12 threads - 34 MHz
2. Processor: Merk AMD - Socket AM5 - 8 cores  - 12 threads - 34 MHz
3. Processor: Merk AMD - Socket AM5 - 8 cores  - 12 threads - 38 MHz
4. Processor: Merk AMD - Socket AM5 - 0 cores  - 16 threads - 50 MHz
5. Processor: Merk AMD - Socket AM5 - 8 cores  - 12 threads - 34 MHz
6. Processor: Merk AMD - Socket AM7 - 8 cores  - 12 threads - 34 MHz
7. Processor: Merk AMD - Socket AM7 - 4 cores  - 12 threads - 40 MHz
8. Processor: Merk AMD - Socket AM7 - 8 cores  - 8 threads - 38 MHz
```

Het overzicht van de **geheugens** moet er als volgt uit zien:
```
Kies een geheugen:

1. Geheugen: DDR4 - 16GB
2. Geheugen: DDR4 - 8GB
3. Geheugen: DDR5 - 16GB
```

Het overzicht van de grafische kaarten moet er als volgt uit zien:
```
Kies een grafische kaart:

1. Chipset: NVIDIA GeForce GTX 1650 - Werkgeheugen 4GB
2. Chipset: Gigabyte GeForce RTX 4080 - Werkgeheugen 16GB
```

Na het kiezen van alle onderdelen (optie 1 bij alles), moet je deze output krijgen:
```
Jouw pc:
Geheugen: Geheugen: DDR4 - 16GB
Moederbord: Moederbord: Socket AM4 - Chipset AMD B550 - Formfactor ATX - Geheugentype DDR4
Processor: Processor: Merk AMD - Socket AM4 - 8 cores  - 12 threads - 34 MHz
Grafische kaart: Chipset: NVIDIA GeForce GTX 1650 - Werkgeheugen 4GB
Prijs PC: 18.979,00 euro
```

Het overizicht van de muizen moet er als volgt uit zien:
```
Kies een muis:

1. Muis: Merk Trust - Model Carve - Draadloos Nee - RGB Verlichting Nee - Prijs: 799 euro - Aantal instellingen 1 - Max DPI 1200
2. Muis: Merk Logitech - Model M705 - Draadloos Ja - RGB Verlichting Nee - Prijs: 3499 euro - Aantal instellingen 1 - Max DPI 900
3. Muis: Merk Steelseries - Model Rival 600 - Draadloos Nee - RGB Verlichting Ja - Prijs: 6120 euro - Aantal instellingen 5 - Max DPI 12000
4. Muis: Merk Razer - Model DeathAdder V2 - Draadloos Nee - RGB Verlichting Ja - Prijs: 6299 euro - Aantal instellingen 5 - Max DPI 20000
5. Muis: Merk Corsair - Model Nightsword - Draadloos Nee - RGB Verlichting Ja - Prijs: 8490 euro - Aantal instellingen 5 - Max DPI 18000
```

Het overzicht van de toetsenborden moet er als volgt uit zien:
```
Kies een toetsenbord:

1. Toetsenbord: Merk Steelseries - Model Apex 3 TKL - Draadloos Nee - RGB Verlichting Ja - Prijs: 3999 euro - Layout QWERTY - Mechanisch Nee
2. Toetsenbord: Merk Fuegobird - Model K3 - Draadloos Ja - RGB Verlichting Ja - Prijs: 4050 euro - Layout QWERTY - Mechanisch Ja
3. Toetsenbord: Merk Razer - Model Huntsman mini - Draadloos Nee - RGB Verlichting Ja - Prijs: 11995 euro - Layout QWERTY - Mechanisch Nee
4. Toetsenbord: Merk Corsair - Model K55 RGB Pro - Draadloos Nee - RGB Verlichting Ja - Prijs: 6490 euro - Layout QWERTY - Mechanisch Nee
```

Na het kiezen van een muis en toetsenbord (optie 1 bij elk), moet je deze output krijgen:
```
Jouw accessoires:
Muis: Merk Trust - Model Carve - Draadloos Nee - RGB Verlichting Nee - Prijs: 799 euro - Aantal instellingen 1 - Max DPI 1200
Toetsenbord: Merk Steelseries - Model Apex 3 TKL - Draadloos Nee - RGB Verlichting Ja - Prijs: 3999 euro - Layout QWERTY - Mechanisch Nee
Prijs accesoires: 4.798,00
```

Het overizicht van de software moet er als volgt uit zien:
```
Kies een software:

1. Naam Photoshop elements
2. Naam Microsoft office 2019
3. Naam Norton antivirus 360 Deluxe
4. Naam Baldur's gate 3 - Aantal spelers 1 - Minimaal werkgeheugen 8GB
5. Naam God of war - Aantal spelers 1 - Minimaal werkgeheugen 4GB
6. Naam Age of empires IV - Aantal spelers 4 - Minimaal werkgeheugen 4GB
```

Na het kiezen van software (optie 1 is gekozen), moet je deze output krijgen:
```
Jouw softwarepakket:
Naam Photoshop elements
Prijs software: 9.999,00
```

Op het einde van de applicatie krijg je de totaalprijs te zien:
```
Totale prijs aankoop: 33776
```

**OPGELET**: Indien je verschillen opmerkt met punten en komma's, mag je deze negeren. Bij twijfel vraag je de docent om even mee te kijken.