namespace M012_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte eine Zahl eingeben:");

            var number = ReadNumberFromConsole();

            Console.WriteLine($"\nDie Zahl ist {number}");

            Console.WriteLine("Taste druecken zum Beenden");
            Console.ReadKey();
        }

        private static float? ReadNumberFromConsole()
        {
            // Fragezeichen am Ende macht den Typen nullable
            float? number = null;

            do
            {
                try
                {

                    checked // prueft auf Overflow Exception
                    {
                        string eingabe = Console.ReadLine();
                        number = float.Parse(eingabe);

                        CheckForEvilNumber(number);
                    }

                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Bitte eine numerische Zahl eingeben.\n" + ex.Message);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Die eingegebene Zahl ist zu gross.");
                }
                catch (EvilNumberException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Wird immer ausgefuehrt.");
                }
            }
            while (number == null);

            return number;
        }

        private static void CheckForEvilNumber(float? number)
        {
            if (number == 13)
            {
                var ex = new EvilNumberException();
                throw ex;
            }
        }
    }

    public class EvilNumberException : Exception
    {
        public EvilNumberException() 
            : base("Die Zahl bringt Unglueck.")
        {
        }
    }
}
