using M009_OOP_Poly.Data;
using M010_OOP_Interfaces.Contracts;

namespace M010_OOP_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Interfaces sind sozusagen Contracts, also Vorschriften oder Rollen die ein Objekt erfuellen muss

            ICanWork worker = CreateWorker("Programmierer", "Hans");
            Console.WriteLine("Was bin ich?\t" + worker.GetType().Name);
            worker.DoWork();
            CheckRuntimeAbilities(worker);
            Console.WriteLine();

            var namelessWorker = CreateWorker("KI");
            Console.WriteLine("Was bin ich?\t" + namelessWorker.GetType().Name);
            namelessWorker.DoWork();
            CheckRuntimeAbilities(namelessWorker);
            Console.WriteLine();

            var flyableRobot = new Drone()
            {
                Job = "Überwachen",
            };
            Console.WriteLine("Was bin ich?\t" + flyableRobot.GetType().Name);
            flyableRobot.DoWork();
            CheckRuntimeAbilities(flyableRobot);
            Console.WriteLine();


            Console.ReadKey();
        }

        static void CheckRuntimeAbilities(object obj)
        {
            // Was wir sehen ist, dass z. B. Hans zur Laufzeit ein Mensch bleibt.
            // ABER: Zur Compilerzeit kann er "polymorph" sein, d. h. verschiedene Typen annehmen: Creature, Human, ICanEat, ICanWork
            // Wir tun das, um uns auf wesentliche Funktionen der Objekte zu beschraenken wie ICanWork.DoWork().

            Console.WriteLine("Is Creature?\t" + (obj.GetType() == typeof(AbstractCreatureBase)));
            Console.WriteLine("Is Human?\t" + (obj.GetType() == typeof(Human)));
            Console.WriteLine("Is Robot?\t" + (obj.GetType() == typeof(Robot)));
            Console.WriteLine("Is Drone?\t" + (obj.GetType() == typeof(Drone)));
            Console.WriteLine("Is Bird?\t" + (obj.GetType() == typeof(Bird)));
            Console.WriteLine("Needs Food?\t" + (obj.GetType() == typeof(ICanEat)));
            Console.WriteLine("Can Fly?\t" + (obj.GetType() == typeof(ICanFly)));
            Console.WriteLine("Can Work?\t" + (obj.GetType() == typeof(ICanWork)));
        }

        static ICanWork CreateWorker(string job, string name = null)
        {
            if (name == null)
            {
                return new Robot() 
                { 
                    Job = job 
                };
            }
            else
            {
                return new Human(name, job);
            }
        }
    }
}
