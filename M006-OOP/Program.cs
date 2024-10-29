namespace M006_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Creature unkown = new Creature();
            // animal._name; // geht nicht weil Feld geschuetzt

            // Auf members (d. h. Felder, Eigenschaften, Methoden) greifen wir mit '.' zu zugreifen
            unkown.Talk();

            Creature duck = new Creature("Duck");
            duck.FavoriteFood = "Worms";
            duck.Talk();

            // Statische Methoden gelten fuer die gesamte Klasse
            var bunny = Creature.Create("Bunny");
            bunny.FavoriteFood = "Carrots";
            bunny.Talk();
            bunny.Grow();

            Console.WriteLine($"Groesse von {bunny.Name} ist {bunny.Size}"); // 2
            Console.WriteLine($"Groesse von {duck.Name} ist {duck.Size}"); // 1 weil jede Instanz ihre eigenen Felder hat

            Console.ReadKey();
         }
    }
}
