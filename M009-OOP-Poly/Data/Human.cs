namespace M009_OOP_Poly.Data
{
    public class Human : CreatureBase
    {
        public string Job { get; set; }

        public Human(string name, int age) : base(name, age)
        {
        }

        public void DoWork()
        {
            Console.WriteLine($"{Name} geht als {Job} arbeiten.");
        }
    }
}
