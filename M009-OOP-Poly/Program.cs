using M009_OOP_Poly.Data;

namespace M009_OOP_Poly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreatureBase hugo = CreateCreature("Hugo", "Koch");

            // Hier kann es zu einem Laufzeitfehler kommen, eine sog. InvalidCastException
            //Human hugoAsHuman = (Human)hugo;

            CheckForHumanCreatureToDoSomeWork(hugo);

            CreatureBase duck = CreateCreature("Duck");
            CheckForHumanCreatureToDoSomeWork(duck);

            // Wir koennen keine Instanz der abstrakten Klasse erstellen
            //var unknownCreature = new CreatureBase();

            Console.ReadKey();
        }

        // Beispiele um Polymorphismus waehrend Laufzeit zu pruefen
        static void CheckForHumanCreatureToDoSomeWork(CreatureBase creature)
        {
            // Loesung: Wir muessen pruefen ob hugo tatsaechlich ein Human ist
            // Variante 1 mit GetType() zur Laufzeit (aelteste Methode)
            if (creature.GetType() == typeof(Human))
            {
                Human hugoAsHuman = (Human)creature;
                hugoAsHuman.DoWork();
            }

            // Variante 2 der Ueberpruefung mit 'as' als cast
            {
                // Compiler versucht zu casten und wenn es nicht geht erhalten wir null
                Human human = creature as Human;

                // null ist ein Zustand einer Referenz-Variablen welche keine Adresse enthaelt
                if (human != null)
                {
                    human.DoWork();
                }
            }

            // Variante 3 der Ueberpruefung mit 'is' als cast (neueste Methode)
            {
                if (creature is Human human)
                {
                    human.DoWork();
                }
            }
        }

        static CreatureBase CreateCreature(string name, string job = null)
        {
            if (job == null)
            {
                return new Bird(name, Random.Shared.Next(1, 2));
            }
            else
            {
                return new Human(name, job);
            }
        }
    }
}
