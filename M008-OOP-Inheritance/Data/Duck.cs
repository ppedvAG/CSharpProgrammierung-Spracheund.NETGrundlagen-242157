namespace M008_OOP_Inheritance.Data
{
    public class Duck : Bird
    {
        // Weitere Spezialisierung eines Vogels
        public Duck(int age) 
            // Mit base() wird der Basis-Konstruktur aufgerufen welcher die Eigenschaften initialisiert
            : base("Duck", age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Quack");
        }
    }

}
