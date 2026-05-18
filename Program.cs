using System;
using Newtonsoft.Json;

namespace ProgramNameSpace
{

  public class Product
  {
    public string Name { get; set; }
    public decimal Price { get; set; }
    public List<string> Tags { get; set; }
  }
  public class Program
  {
    static void Main(string[] args)
    {
      var product = new Product
      {
        Name = "Laptop",
        Price = 999.99m,
        Tags = new List<string> { "Electronics", "Computers" }
      };

      string json = JsonConvert.SerializeObject(product, Formatting.Indented);
      Console.WriteLine(json);

      var deserializedProduct = JsonConvert.DeserializeObject<Product>(json);
      Console.WriteLine($"Name: {deserializedProduct.Name}, Price: {deserializedProduct.Price}, Tags: {string.Join(", ", deserializedProduct.Tags)}");
    }
  }
}
