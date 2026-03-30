namespace Opleidingscentrum;

public abstract class Personeelslid : IKost
{
    private static int volgendPersoneelsnummer = 1;
    private static readonly List<Verlofperiode> verlofperiodes = new();

    private string familienaam;
    private string voornaam;
    private decimal brutoMaandloon;

    public int Personeelsnummer { get; }

    public string Familienaam
    {
        get => familienaam;
    }

    public string Voornaam
    {
        get => voornaam;
    }

    public decimal BrutoMaandloon
    {
        get => brutoMaandloon;
    }

    public static IReadOnlyList<Verlofperiode> Verlofperiodes => verlofperiodes.AsReadOnly();

    public decimal Maandkost => BrutoMaandloon * 0.60m;

    protected Personeelslid(string familienaam, string voornaam, decimal brutoMaandloon)
    {
        if (string.IsNullOrWhiteSpace(familienaam))
            throw new ArgumentException("Familienaam is verplicht.");

        if (string.IsNullOrWhiteSpace(voornaam))
            throw new ArgumentException("Voornaam is verplicht.");

        if (brutoMaandloon < 0m)
            throw new ArgumentException("Brutomaandloon mag niet negatief zijn.");

        Personeelsnummer = volgendPersoneelsnummer++;
        this.familienaam = familienaam;
        this.voornaam = voornaam;
        this.brutoMaandloon = brutoMaandloon;
    }

    public static void VoegVerlofperiodeToe(Verlofperiode verlofperiode)
    {
        if (verlofperiode is null)
            throw new ArgumentNullException(nameof(verlofperiode));

        verlofperiodes.Add(verlofperiode);
    }

    public virtual string GetInfo()
    {
        return $"Personeelsnummer: {Personeelsnummer}\n" +
               $"Naam: {Voornaam} {Familienaam}\n" +
               $"Brutomaandloon: {BrutoMaandloon:0.##}";
    }

    public abstract void GegevensTonen();
}