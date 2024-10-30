using M010_OOP_Interfaces.Contracts;

namespace M009_OOP_Poly.Data
{
    public class Human : AbstractCreatureBase, ICanWork
    {
        public string Job { get; set; }

        public Human(string name, string job) : base(name)
        {
            Job = job;
        }

        public void DoWork()
        {
            Console.WriteLine($"{Name} geht als {Job} arbeiten.");
        }

        public override AbstractCreatureBase Reproduce(string childName)
        {
            return new Human(childName, "Aufwachsen");
        }
    }
}
