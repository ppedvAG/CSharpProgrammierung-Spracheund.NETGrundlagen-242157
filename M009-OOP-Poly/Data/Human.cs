namespace M009_OOP_Poly.Data
{
    public class Human : CreatureBase
    {
        public string Job { get; set; }

        public Human(string name, string job) : base(name, Random.Shared.Next(18, 88))
        {
            Job = job;
        }

        public void DoWork()
        {
            Console.WriteLine($"{Name} geht als {Job} arbeiten.");
        }

        public override CreatureBase Reproduce(string childName)
        {
            return new Human(childName, "Aufwachsen");
        }
    }
}
