namespace Opleidingscentrum;

public sealed class Instructeur : Personeelslid
{
    private string emailadres = "onbekend e-mailadres";

    public Vakgebied Vakgebied { get; }

    public string Emailadres
    {
        get => emailadres;
        private set
        {
            if (!string.IsNullOrWhiteSpace(value) && value.Contains('@'))
                emailadres = value;
            else
                emailadres = "onbekend e-mailadres";
        }
    }

    public Instructeur(
        string familienaam,
        string voornaam,
        decimal brutoMaandloon,
        Vakgebied vakgebied,
        string emailadres)
        : base(familienaam, voornaam, brutoMaandloon)
    {
        Vakgebied = vakgebied;
        Emailadres = emailadres;
    }

    public override string GetInfo()
    {
        return base.GetInfo() + "\n" +
               $"Instructeur {Vakgebied} (e-mail:{Emailadres})\n" +
               $"Maandelijkse kost: {Maandkost:0.##} euro";
    }

    public override void GegevensTonen()
    {
        Console.WriteLine(GetInfo());
    }
}