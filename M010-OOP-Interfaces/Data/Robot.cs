using M010_OOP_Interfaces.Contracts;

namespace M009_OOP_Poly.Data
{
    public class Robot : ICanWork
    {
        public string Id { get; }

        public string Job { get; set; }

        public Robot()
        {
            Id = Guid.NewGuid().ToString().Substring(0, 5);
        }

        public void DoWork()
        {
            Console.WriteLine($"Roboter mit der ID {Id} arbeitet als {Job}.");
        }
    }

    public class Drone : Robot, ICanFly
    {
        public void Fly()
        {
            Console.WriteLine("Bzzz...");
        }
    }
}
