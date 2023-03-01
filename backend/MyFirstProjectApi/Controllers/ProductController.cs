using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace MyFirstProjectApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        public ProductController()
        {
        }

        [HttpGet(Name = "GetProducts")]
        public IEnumerable<Product> Get()
        {
            using (StreamReader r = new StreamReader(@"Data\products-small.json"))
            {
                string json = r.ReadToEnd();
                var data = JsonSerializer.Deserialize<List<Product>>(json);
                return data ?? new List<Product>();
            }
        }
    }
}