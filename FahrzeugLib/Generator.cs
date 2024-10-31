using Bogus;
using Fahrzeugpark;

namespace FahrzeugLib
{
    public class Generator
    {
        static readonly Faker faker = new Faker 
        { 
            // Wir setzen den Seed auf 42 um immer wieder die gleichen Zufallsdaten zu erzeugen
            Random = new Randomizer(42) 
        };

        public static Fahrzeug Fahrzeug()
        {
            var name = $"{faker.Vehicle.Manufacturer()} {faker.Vehicle.Model()}";
            var topSpeed = faker.Random.Int(50, 300);
            var price = Math.Round(faker.Random.Double(1e4, 1e5));
            return new Fahrzeug(name, topSpeed, price);
        }
    }
}
