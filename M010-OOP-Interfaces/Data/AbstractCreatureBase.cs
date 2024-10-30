using M010_OOP_Interfaces.Contracts;

namespace M009_OOP_Poly.Data
{
    // Wir definieren diese Klasse als abstrakt. Das verhindert, dass eine Instanz der Klasse erstellt werden kann.
    public abstract class AbstractCreatureBase : ICanEat
    {
        public string Name { get; }

        public string FavoriteFood { get; set; }

        // Konstruktor der basis
        protected AbstractCreatureBase(string name)
        {
            Name = name;
        }

        protected AbstractCreatureBase()
        {
        }

        // Wenn wir Methoden abstract machen, muessen ableitendende Klassen diese Methoden implementieren
        public abstract AbstractCreatureBase Reproduce(string childName);
        //{
        //    // Das funktioniert nicht mehr weil die Klasse abstrakt wurde
        //    //return new CreatureBase(childName, 0);
        //}

        // Jede klasse leitet von object ab.
        // jedes object hat eine ToString-Methode
        public override string ToString()
        {
            if (FavoriteFood != null)
            {
                return $"{Name} mag {FavoriteFood}.";
            }
            return $"{Name} ist mein Name.";
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} isst gerade {FavoriteFood}.");
        }
    }

}
