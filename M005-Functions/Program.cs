namespace M005_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ganzahlen addieren
            var result1 = Add(1, 2);
            Console.WriteLine($"Addition der Integers 1 und 2: {result1}");

            // Gleitkommazahlen addieren
            var result2 = Add(1f, .78, 1e-6);
            Console.WriteLine($"Addition von 3 Gleitkommazahlen: {result2}");

            // Zahlenkette addieren
            var result3 = Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine($"Addition der Zahlenkette von 1 bis 10: {result3}");

            // Durch 0 teilen
            string error;
            var result4 = Divide(1, 0, out error);

            // Kurzform
            var result5 = Divide(1, 0, out string error2);

            if (error2 != string.Empty)
            {
                Console.WriteLine(error2);
            } 
            else
            {
                Console.WriteLine(result5);
            }

            Console.WriteLine("Bitte Zahl eingeben");
            var input = Console.ReadLine();

            // Wenn ein Buchstabe eingeben wird, tritt eine System.FormatException auf.
            //var number = int.Parse(input);

            bool success = int.TryParse(input, out int number);
            if (success)
            {
                Console.WriteLine($"Du hast {number} korrekt eingegeben");
            }
            else
            {
                Console.WriteLine($"Eingabe '{input}' ist keine Zahl");
            }
        }

        static int Add(int a, int b, int c = 0)
        {
            var result = a + b + c;
            return result;
        }

        // Methoden koennen ueberladen werden; der Compiler 'findet' die richtige Implementierung.
        static double Add(double a, double b, double c = 0)
        {
            var result = a + b + c;
            return result;
        }

        static int Sum(params int[] numbers)
        {
            int result = 0;

            foreach (var number in numbers)
            {
                result += number; // Kurzform: result = result + number
            }

            return result;
        }

        static double Divide(double a, double b, out string error)
        {
            if (b == 0)
            {
                error = "Division durch 0 ist nicht erlaubt";
                return 0;
            }

            error = string.Empty;
            return a / b;
        }
    }
}
