using Newtonsoft.Json;

namespace MyFirstProjectApi
{
    public class ProductData
    {
        public List<Product> Data { get; set; }
    }

    public class Product
    {
        public string id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public string inventoryStatus { get; set; }
        public string category { get; set; }
        public string image { get; set; }
        public int rating { get; set; }
    }
}