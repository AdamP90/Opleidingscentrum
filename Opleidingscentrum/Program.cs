using Opleidingscentrum;


// Set the background color to Red
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("This is white text on a red background.\n");
        Console.ResetColor();



Personeelslid.VoegVerlofperiodeToe(
    new Verlofperiode(
        "Kerstmis",
        new DateOnly(2020, 12, 25),
        new DateOnly(2021, 1, 1)));

Personeelslid.VoegVerlofperiodeToe(
    new Verlofperiode(
        "Zomervakantie",
        new DateOnly(2020, 7, 1),
        new DateOnly(2020, 7, 31)));

Console.WriteLine("Collectieve verlofperiodes:");
foreach (Verlofperiode verlofperiode in Personeelslid.Verlofperiodes)
{
    Console.WriteLine(verlofperiode);
}

Console.WriteLine();
Console.WriteLine("Kosten personeel en infrastructuur:");
Console.WriteLine();

IKost[] items =
[
    new Instructeur("Jansen", "Jan", 1500m, Vakgebied.Ontwikkeling, "ongeldig"),
    new Instructeur("Roosen", "Roos", 1600m, Vakgebied.Netwerkbeheer, "roos.roosen@vdab.be"),
    new Medewerker("Peeters", "Piet", 1550m, 10),
    new Gebouw("Einstein", 1500m),
    new Gebouw("Newton", 2500m)
];

decimal totaal = 0m;

foreach (IKost item in items)
{
    item.GegevensTonen();
    totaal += item.Maandkost;
    Console.WriteLine();
}

Console.WriteLine($"Totale maandkost (personeel + infrastructuur): {totaal:0.##} euro");
Console.WriteLine("Press any key to continue...");
Console.ReadKey();

Console.WriteLine("Einde van het programma.");