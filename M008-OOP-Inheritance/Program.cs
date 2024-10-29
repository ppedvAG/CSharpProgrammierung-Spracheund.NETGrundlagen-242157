using M008_OOP_Inheritance.Data;

namespace M008_OOP_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ich kann keine Instanz der Basisklasse erzeugen weil Konstruktor nicht public ist
            //var creature = new CreatureBase();

            var duck = new Duck(2);
            duck.MakeSound();
            Console.WriteLine(duck.ToString());

            var dog = new Mammal("Beagel", 5);
            var puppy = dog.Reproduce("Welpe");

            Console.WriteLine($"{puppy}"); // .ToString() wird implizit durch string interpolation aufgerufen


            Console.ReadKey();
        }
    }

}
