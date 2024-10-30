namespace Fahrzeugpark
{
    // Aufgabe 1: Interface erstellen
    public interface IBeladbar
    {
        Fahrzeug Ladung { get; set; }

        bool Belade(Fahrzeug fahrzeug);

        Fahrzeug Entlade();
    }
}