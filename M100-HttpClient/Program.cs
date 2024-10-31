using M100_HttpClient.JsonData;
using System.Net.Http.Json;

namespace M100_HttpClient
{
    internal class Program
    {
        const string API_URL = "https://dummyjson.com/products";

        static void Main(string[] args)
        {
            int pageSize = 10;
            int pageNumber = 2;
            string fields = "title,price";

            // Klassen Erstellen: JSON struktur kopieren und
            // "Edit > Paste Special > Paste JSON as Classes"
            // >> erzeugt JsonData.Rootobject, Product usw.
            Rootobject? page = GetProductData(pageSize, pageNumber, fields).ConfigureAwait(false).GetAwaiter().GetResult();

            foreach (var item in page.Products)
            {
                Console.WriteLine($"{item.title}\t\tPreis: {item.price}");
            }

            Console.ReadKey();
        }

        // async/await Pattern
        private static async Task<Rootobject?> GetProductData(int pageSize, int page, string fields)
        {
            // Wir verwenden using weil HttpClient eine IDisposable Objekt ist, d. h. wir wollen es nach der Verbindung wieder schliessen und zerstoeren.
            using var client = new HttpClient();

            // Wir senden einen Request an die Adresse und erhalten einen Response
            var response = await client.GetAsync($"{API_URL}?limit={pageSize}&skip={(page - 1) * pageSize}&select={fields}");

            // Response enthaelt Daten wie Header und Content
            var content = response.Content;
            return await content.ReadFromJsonAsync<Rootobject>();
        }
    }

}
