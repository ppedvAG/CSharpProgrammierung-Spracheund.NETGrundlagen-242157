namespace M009_OOP_Poly.Data
{
    public class Bird : CreatureBase
    {
        // Spezialisierung eines Lebewesens
        public Bird(string breed, int age) : base(breed, age)
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

        public override CreatureBase Reproduce(string childName)
        {
            return new Bird(Name + " Junior", 0);
        }
    }

}
