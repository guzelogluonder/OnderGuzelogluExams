using System.Runtime.InteropServices;
using Odev7_Interface.Models;

namespace Odev7_Interface;

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new()
        {
            Id = 1,
            CustomerName = "Onder"
        };
        Product product = new()
        {
            Id = 1,
            ProductName = "Telefon"
        };

        System.Console.WriteLine(customer.GetDisplayName());
        System.Console.WriteLine(product.GetDisplayName());
    }
}
