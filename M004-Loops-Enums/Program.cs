internal class Program
{
    enum Wochentag
    {
        Montag = 1,
        Dienstag = 2,
        Mittwoch = 4,
        Donnerstag = 8,
        Freitag = 16,
        Samstag = 32,
        Sonntag = 64
    }

    private static void Main(string[] args)
    {
        #region Loop

        int start = 0, end = 10;

        // Kopfgesteuerte Schleife weil wir erst die Bedingung pruefen und dann die Schleife ausfuehren.
        while (start < end)
        {
            Console.WriteLine("While " + start);
            start++; // start + 1
        }
        Console.WriteLine();

        start = 0;

        // Endlossschleife
        while (true)
        {
            // Hier wird 'continue' weiter ausgefuehrt

            // Das Statement in den geschweiften Klammern nennt sich "Block"
            {
                start++; // start + 1
            }

            if (start == 5)
            {
                continue; // Springe zum Start der Schleife
            }

            Console.WriteLine("Start " + start);

            if (start >= end)
            {
                break; // Bei break ueberspringt das Programm den aktuellen Block
            }

        }

        // Beispiel fuer fussgesteuerte Schleife
        ConsoleKeyInfo endLoop;
        do
        {
            Console.WriteLine("Escape druecken um Programm fortzusetzen");

            endLoop = Console.ReadKey();
        }
        while (endLoop.Key != ConsoleKey.Escape);
        Console.WriteLine();

        int[] numbers = [34, 39, 10];

        // For-Schleife besteht aus 3 Segmenten: Initialisierung, Bedingung, Iteration
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Aktuelle Nummer des arrays an der Position {i} ist " + numbers[i]);
        }
        Console.WriteLine( );

        var names = new string[] { "Hugo", "Max", "Julia" };

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        // Durch enum iterieren
        foreach (var day in Enum.GetValues(typeof(Wochentag)))
        {
            Console.WriteLine($"#{(int)day} ist {day}");
        }

        #endregion

        #region Switch 

        var someDay = Wochentag.Donnerstag;

        switch (someDay)
        {
            case Wochentag.Montag:
                Console.WriteLine("I hate Mondays");
                break; // break; ist notwendig sonst wuerden die nachfolgendes cases ebenfalls ausgefuehrt werden

            case Wochentag.Dienstag:
            case Wochentag.Donnerstag:
                Console.WriteLine("Beginnen mit D");
                break;

            case Wochentag.Freitag:
                Console.WriteLine("Fast Wochenende");
                break;

            default: // wie else bei if-else
                Console.WriteLine("Kein Case spezifiziert");
                break;
        }

        #endregion


        Console.ReadKey();
    }
}