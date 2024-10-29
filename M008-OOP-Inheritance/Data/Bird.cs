namespace M008_OOP_Inheritance.Data
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
    }

}
