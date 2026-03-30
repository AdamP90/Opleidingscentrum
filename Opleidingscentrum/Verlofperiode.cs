namespace Opleidingscentrum;

public class Verlofperiode
{
    public string Naam { get; }
    public DateOnly Begindatum { get; }
    public DateOnly Einddatum { get; }

    public Verlofperiode(string naam, DateOnly begindatum, DateOnly einddatum)
    {
        if (string.IsNullOrWhiteSpace(naam))
            throw new ArgumentException("Naam is verplicht.");

        if (einddatum < begindatum)
            throw new ArgumentException("Einddatum mag niet vóór begindatum liggen.");

        Naam = naam;
        Begindatum = begindatum;
        Einddatum = einddatum;
    }

    public override string ToString()
    {
        return $"Verlofperiode {Naam}: {Begindatum:d/M/yyyy} - {Einddatum:d/M/yyyy}";
    }
}