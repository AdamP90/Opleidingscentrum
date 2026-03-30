namespace Opleidingscentrum;

public sealed class Medewerker : Personeelslid
{
    private int aantalCursisten;

    public int AantalCursisten
    {
        get => aantalCursisten;
        private set
        {
            if (value < 0)
                throw new ArgumentException("Aantal cursisten mag niet negatief zijn.");

            aantalCursisten = value;
        }
    }

    public Medewerker(
        string familienaam,
        string voornaam,
        decimal brutoMaandloon,
        int aantalCursisten)
        : base(familienaam, voornaam, brutoMaandloon)
    {
        AantalCursisten = aantalCursisten;
    }

    public override string GetInfo()
    {
        return base.GetInfo() + "\n" +
               $"Medewerker: {AantalCursisten} cursisten\n" +
               $"Maandelijkse kost: {Maandkost:0.##} euro";
    }

    public override void GegevensTonen()
    {
        Console.WriteLine(GetInfo());
    }
}