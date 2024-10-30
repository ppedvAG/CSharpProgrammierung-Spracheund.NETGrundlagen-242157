using System.Text;

namespace Fahrzeugpark
{
    class Program
    {
        static void Main(string[] args)
        {
            //�ndern des durch Console verwendeten Zeichensatzes auf Unicode (damit das �-Zeichen angezeigt werden kann)
            Console.OutputEncoding = Encoding.UTF8;


            var corolla = new Auto("Toyota Corolla", 250, 23e3, 5);
            var airbus = new Flugzeug("Airbus A380", 350, 30e6, 9800);
            var faehre = new Schiff("Color Line Cruises AS", 41, 35e5, Schiff.SchiffsTreibstoff.Diesel);

            BeladeFahrzeug(faehre, faehre);
            BeladeFahrzeug(corolla, airbus);
            BeladeFahrzeug(corolla, faehre);
            BeladeFahrzeug(airbus, faehre);

            Console.WriteLine();
            Console.WriteLine(faehre.Info());

            faehre.Entlade();

            Console.ReadKey();
        }

        private static void BeladeFahrzeug(Fahrzeug ladung, Fahrzeug fahrzeug)
        {
            // Test ob fahrzeug beladbar ist
            if (fahrzeug is IBeladbar transporter)
            {
                transporter.Belade(ladung);
            } 
            else
            {
                Console.WriteLine($"{fahrzeug.Name} ist nicht beladbar!");
            }
        }
    }
}