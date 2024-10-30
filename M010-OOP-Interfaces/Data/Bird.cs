using M010_OOP_Interfaces.Contracts;

namespace M009_OOP_Poly.Data
{
    public class Bird : AbstractCreatureBase, ICanFly
    {
        // Spezialisierung eines Lebewesens
        public Bird(string breed) : base(breed)
        {

        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Trill");
        }

        public void Fly()
        {
            Console.WriteLine("Flap");
        }

        public override AbstractCreatureBase Reproduce(string childName)
        {
            return new Bird(Name + " Junior");
        }
    }

}
