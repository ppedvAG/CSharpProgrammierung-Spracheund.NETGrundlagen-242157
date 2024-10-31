namespace M100_HttpClient.JsonData
{
    public class Rootobject
    {
        public Product[] Products { get; set; }
        public int Total { get; set; }
        public int Skip { get; set; }
        public int Limit { get; set; }
    }

}
