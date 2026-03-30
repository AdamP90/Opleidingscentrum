namespace Opleidingscentrum;

public class Gebouw : IKost
{
    private string naam;
    private decimal huurprijsPerMaand;

    public string Naam
    {
        get => naam;
    }

    public decimal HuurprijsPerMaand
    {
        get => huurprijsPerMaand;
    }

    public decimal Maandkost => HuurprijsPerMaand;

    public Gebouw(string naam, decimal huurprijsPerMaand)
    {
        if (string.IsNullOrWhiteSpace(naam))
            throw new ArgumentException("Naam is verplicht.");

        if (huurprijsPerMaand < 0m)
            throw new ArgumentException("Huurprijs per maand mag niet negatief zijn.");

        this.naam = naam;
        this.huurprijsPerMaand = huurprijsPerMaand;
    }

    public string GetInfo()
    {
        return $"Gebouw {Naam} - Huurprijs per maand: {HuurprijsPerMaand:0.##} euro\n" +
               $"Maandelijkse kost: {Maandkost:0.##} euro";
    }

    public void GegevensTonen()
    {
        Console.WriteLine(GetInfo());
    }
}