namespace M009_OOP_Poly.Data
{
    public class CreatureBase // : object
    {
        public string Name { get; }

        public string FavoriteFood { get; set; }

        public int Age { get; }

        // Konstruktor der basis
        protected CreatureBase(string name, int age)
        {
            Name = name;
            Age = age;
        }

        protected CreatureBase()
        {
        }

        public virtual CreatureBase Reproduce(string childName)
        {
            return new CreatureBase(childName, 0);
        }

        // Jede klasse leitet von object ab.
        // jedes object hat eine ToString-Methode
        public override string ToString()
        {
            if (FavoriteFood != null)
            {
                return $"{Name} ist {Age} Jahre alt und mag {FavoriteFood}.";
            }
            return $"{Name} ist {Age} Jahre alt.";
        }
    }

}
