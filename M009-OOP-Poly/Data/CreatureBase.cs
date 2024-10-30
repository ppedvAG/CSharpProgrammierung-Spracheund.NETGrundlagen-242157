namespace M009_OOP_Poly.Data
{
    // Wir definieren diese Klasse als abstrakt. Das verhindert, dass eine Instanz der Klasse erstellt werden kann.
    public abstract class CreatureBase // : object
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

        // Wenn wir Methoden abstract machen, muessen ableitendende Klassen diese Methoden implementieren
        public abstract CreatureBase Reproduce(string childName);
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
                return $"{Name} ist {Age} Jahre alt und mag {FavoriteFood}.";
            }
            return $"{Name} ist {Age} Jahre alt.";
        }
    }

}
