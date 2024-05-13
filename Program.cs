//Hoofdprogramma
ToonTitle("PC Samenstellen");

Aankoop aankoop = null;
aankoop.Pc = new Pc();

while (!aankoop.Pc.PcIsCompleet())
{
    aankoop.Pc.Moederbord = KiesMoederbord();
    aankoop.Pc.Processor = KiesProcessor();
    aankoop.Pc.Geheugen = KiesGeheugen();
    aankoop.Pc.GrafischeKaart = KiesGrafischeKaart();

    bool isSuccesvolleSamenstelling = aankoop.Pc.ControleerOnderdelen();

    if (!isSuccesvolleSamenstelling)
    {
        aankoop.Pc.VerwijderOnderdelen();
        Console.WriteLine("Onderdelen niet compatibel!\nOnderdelen werden verwijderd. Druk op enter om opnieuw te beginnen.");
        Console.ReadLine();
    }
}

Console.WriteLine();
Console.WriteLine("Jouw pc:");
Console.WriteLine(aankoop.Pc);
Console.WriteLine();

ToonTitel("Accessoires Samenstellen");
Console.WriteLine();

string optieMuis = KeuzeOptie("muis");
while (optieMuis.ToLower() == "ja")
{
    Muis muis = KiesMuis();
    aankoop.VoegAccessoireToe(muis);

    Console.WriteLine();
}

Console.WriteLine();

string optieToetsenbord = KeuzeOptie("toetsenbord");
while (optieToetsenbord.ToLower() == "ja")
{
    Toetsenbord toetsenbord = KiesToetsenbord();
    aankoop.VoegAccessoireToe(toetsenbord);

    Console.WriteLine();

    optieToetsenbord = KeuzeOptie("toetsenbord");
}

ToonOverzichtAccessoiresMetPrijs();

ToonTitel("Softwarepakket Samenstellen");
Console.WriteLine();

string optieSoftware = KeuzeOptie("software");
while (optieSoftware.ToLower() == "ja")
{
    Software software = KiesSoftware();
    if (software is Game game && aankoop.Pc.GrafischeKaart.IsGameSpeelbaar(game))
        aankoop.VoegSoftwareToe(software);
    else if (software is Software s)
        aankoop.VoegSoftwareToe(s);
    else
        Console.WriteLine("Deze game is niet speelbaar op uw PC!");

    Console.WriteLine();

    optieSoftware = KeuzeOptie("software");
}

ToonOverzichtSoftwareMetPrijs();

Console.WriteLine();
Console.WriteLine($"Totale prijs aankoop: {aankoop.BerekenTotalePrijs()}");

//Methodes
void ToonTitel(string titel)
{
    Console.WriteLine(titel);
    Console.WriteLine(new string('=', titel.Length));
}
void ToonOverzichtAccessoiresMetPrijs()
{
    double prijsAccessoires = 0;
    Console.WriteLine();
    Console.WriteLine("Jouw accessoires:");
    foreach (Accessoire item in aankoop.Accessoires)
    {
        prijsAccessoires += item.Prijs;
        Console.WriteLine(item);
    }
    Console.WriteLine($"Prijs accesoires: {prijsAccessoires:N2}");
    Console.WriteLine();
}

void ToonOverzichtSoftwareMetPrijs()
{
    double prijsSoftware = 0;
    Console.WriteLine();
    Console.WriteLine("Jouw softwarepakket:");
    foreach (Software item in aankoop.Software)
    {
        prijsSoftware += item.Prijs;
        Console.WriteLine(item);
    }
    Console.WriteLine($"Prijs software: {prijsSoftware:N2}");
    Console.WriteLine();
}

Moederbord KiesMoederbord()
{
    ToonKeuzeTitel("processor");

    List<Moederbord> moederborden = FileOperations.FilterProcessoren();

    for (int i = 0; i < moederborden.Count; i++)
        Console.WriteLine($"{i + 1}. {moederborden[i]}");

    Console.WriteLine();

    return moederborden[VraagKeuzeMetMaximum(moederborden.Count) - 1];
}

Processor KiesProcessor()
{
    ToonKeuzeTitel("processor");

    List<Processor> processoren = FileOperations.FilterProcessoren();

    for (int i = 0; i < processoren.Count; i++)
        Console.WriteLine($"{i + 1}. {processoren[i]}");

    Console.WriteLine();

    return processoren[VraagKeuzeMetMaximum(processoren.Count) - 1];
}

Geheugen KiesGeheugen()
{
    ToonKeuzeTitel("geheugen");

    List<Geheugen> geheugen = FileOperations.FilterGeheugen();

    for (int i = 0; i < geheugen.Count; i++)
        Console.WriteLine($"{i + 1}. {geheugen[i]}");

    Console.WriteLine();

    return geheugen[VraagKeuzeMetMaximum(geheugen.Count) - 1];
}

GrafischeKaart KiesGrafischeKaart()
{
    ToonKeuzeTitel("grafische kaart");

    List<GrafischeKaart> grafischeKaarten = FileOperations.FilterGrafischeKaarten();

    for (int i = 0; i < grafischeKaarten.Count; i++)
        Console.WriteLine($"{i + 1}. {grafischeKaarten[i]}");

    Console.WriteLine();

    return grafischeKaarten[VraagKeuzeMetMaximum(grafischeKaarten.Count) - 1];
}

string KeuzeOptie(string optie)
{
    string invoer;
    do
    {
        Console.Write($"Wilt u een {optie} toevoegen? ");
        invoer = Console.ReadLine();
    } while (string.IsNullOrWhiteSpace(invoer) || (invoer.ToLower() != "ja" && invoer.ToLower() != "nee"));
    return invoer;
}

Muis KiesMuis()
{
    ToonKeuzeTitel("muis");

    List<Muis> muizen = FileOperations.FilterMuizen();

    for (int i = 0; i < muizen.Count; i++)
        Console.WriteLine($"{i + 1}. {muizen[i]}");

    Console.WriteLine();

    return muizen[VraagKeuzeMetMaximum(muizen.Count) - 1];
}

Toetsenbord KiesToetsenbord()
{
    ToonKeuzeTitel("toetsenbord");

    List<Toetsenbord> toetsenborden = FileOperations.FilterToetsenborden();

    for (int i = 0; i < toetsenborden.Count; i++)
        Console.WriteLine($"{i + 1}. {toetsenborden[i]}");

    Console.WriteLine();

    return toetsenborden[VraagKeuzeMetMaximum(toetsenborden.Count) - 1];
}

Software KiesSoftware()
{
    ToonKeuzeTitel("software");

    List<Software> softwareLijst = FileOperations.LeesSoftware();

    for (int i = 0; i < softwareLijst.Count; i++)
        Console.WriteLine($"{i + 1}. {softwareLijst[i + 1]}");

    Console.WriteLine();

    return softwareLijst[VraagKeuzeMetMaximum(softwareLijst.Count) - 1];
}

int VraagKeuzeMetMaximum(int maximum)
{
    string invoer;
    int keuze;
    do
    {
        Console.Write("Uw keuze: ");
        invoer = Console.ReadLine();
    } while (!int.TryParse(invoer, out keuze) || (keuze < 1 && keuze > maximum));
    return keuze;
}

void ToonKeuzeTitel(string type)
{
    Console.WriteLine();
    Console.WriteLine($"Kies een {type}:");
    Console.WriteLine();
}