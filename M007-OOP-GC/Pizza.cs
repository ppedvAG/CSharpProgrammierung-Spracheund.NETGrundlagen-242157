namespace M007_OOP_GC
{
    public class Pizza : IDisposable
    {
        // Felder sind i. d. R. "lowercase" und private
        private string belag;

        // Der Vorteil am Underscore "_" prefix ist, dass wir das Member gleich als private und Feld identifizieren koennen
        private string _belag;

        // Eigenschaften und Methoden sind i. d. R. "Uppercase"
        public string Name { get; }

        // Anzahl an existenten Pizzen
        // Da static ist dieser Wert Instanzuebergreifend
        public static int TotalPizzaCount { get; set; }

        // Konstruktor sieht wie eine Methode ohne Return-Wert aus.
        public Pizza(string name, string belag)
        {
            Console.WriteLine($"Pizza {name} mit {belag} wurde erstellt.");

            TotalPizzaCount++;

            Name = name;

            // Um auf das Feld "belag" zuzugreifen verwenden wir das this Keyword
            // this bezieht sich auf die aktuelle Objekt-Instanz.
            this.belag = belag;
        }

        // Destruktor hat eine Tilde "~" am Anfang.
        ~Pizza()
        {
            Console.WriteLine($"Pizza {Name} wurde gegessen.");

            TotalPizzaCount--;
        }

        public void Dispose()
        {
            Console.WriteLine($"Pizza {Name} wurde gegessen.");
            TotalPizzaCount--;

            GC.SuppressFinalize(this);
        }

        public void Bake()
        {
            Console.WriteLine($"Pizza {Name} wurde gebacken.");
        }

        public static void ShowTotalPizzaCount()
        {
            Console.WriteLine($"Aktuelle Anzahl an Pizzas die noch nicht gegessen wurden: {TotalPizzaCount}");
        }
    }
}
