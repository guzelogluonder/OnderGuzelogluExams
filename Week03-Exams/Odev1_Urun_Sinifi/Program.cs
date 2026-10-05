using Odev1_Urun_Sinifi.Models;
namespace Odev1_Urun_Sinifi;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new()
        {
            Id = 1,
            Name = "Kalem",
            Price = 100
        };

        Product product2 = new Product();
        product2.Id = 2;
        product2.Name = "Telefon";
        product2.Price = 50000;

        Product vehicle = new()
        {
            Id = 3,
            Name = "Mercedes",
            Price = 12000000
        };
        System.Console.WriteLine("=== ÜRÜNLER ===");
        product1.Display();
        product2.Display();
        vehicle.Display();
    }
}