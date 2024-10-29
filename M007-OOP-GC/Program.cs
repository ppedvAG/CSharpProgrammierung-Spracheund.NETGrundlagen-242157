namespace M007_OOP_GC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GarbageCollectionExample();

            // Wir sollten lieber IDispose statt dem Garbage-Collector verwenden
            Console.WriteLine("\n\nDispose Beispiel");
            DisposeExample();
        }

        private static void GarbageCollectionExample()
        {
            // Die Liste speichert die Referenzen von Pizza-Objekten, d. h. die Adressen auf den Speicherbereich
            var pizzaBox = new List<Pizza>();

            pizzaBox.Add(new Pizza("Margarita", "Tomate, Kaese"));
            pizzaBox.Add(new Pizza("Hawaii", "Tomate, Ananas, Kaese"));
            pizzaBox.Add(new Pizza("Quattro Formaggi", "4 Kaese"));

            Console.WriteLine();
            Pizza.ShowTotalPizzaCount(); // sollten 3 Pizzas drin sein
            Console.WriteLine();

            pizzaBox.RemoveAt(1); // Pizza "Hawaii" entfernt

            Console.WriteLine();
            Pizza.ShowTotalPizzaCount(); // sind noch 2 Pizzas uebrig?

            // Um den Speicher freizugeben muessen wir den Garbage-Collector aufrufen, quasi das Muellauto holen
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Pizza.ShowTotalPizzaCount(); // Jetzt sind noch 2 Pizzas

            Console.ReadKey();
        }

        private static void DisposeExample()
        {
            // Die Liste speichert die Referenzen von Pizza-Objekten, d. h. die Adressen auf den Speicherbereich
            var pizzaBox = new List<Pizza>();

            pizzaBox.Add(new Pizza("Margarita", "Tomate, Kaese"));
            pizzaBox.Add(new Pizza("Hawaii", "Tomate, Ananas, Kaese"));
            pizzaBox.Add(new Pizza("Quattro Formaggi", "4 Kaese"));

            Console.WriteLine();
            Pizza.ShowTotalPizzaCount(); // sollten 3 Pizzas drin sein
            Console.WriteLine();

            pizzaBox[1].Dispose();
            pizzaBox.RemoveAt(1); // Pizza "Hawaii" entfernt

            Console.WriteLine();
            Pizza.ShowTotalPizzaCount(); // Jetzt sind noch 2 Pizzas

            Console.ReadKey();
        }
    }
}
