namespace M008_OOP_Inheritance.Data
{
    public class Mammal : CreatureBase
    {
        public Mammal(string name, int age)
            // Mit base() wird der Basis-Konstruktur aufgerufen welcher die Eigenschaften initialisiert
            : base(name, age)
        {
        }

        public override CreatureBase Reproduce(string childName)
        {
            var child = base.Reproduce(childName);
            child.FavoriteFood = "Muttermilch";
            return child;
        }
    }

}
