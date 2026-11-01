using System.Runtime.CompilerServices;
using Odev6_GroupBy_IQueryable.Models;

namespace Odev6_GroupBy_IQueryable;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new()
        {
            new() { Id = 1, CustomerName = "Ali", Category = "Elektronik", Amount = 15000m, OrderDate = new DateTime(2026, 1, 10) },
            new() { Id = 2, CustomerName = "Ayşe", Category = "Giyim", Amount = 2500m, OrderDate = new DateTime(2026, 1, 15) },
            new() { Id = 3, CustomerName = "Mehmet", Category = "Kitap", Amount = 450m, OrderDate = new DateTime(2026, 2, 5) },
            new() { Id = 4, CustomerName = "Ali", Category = "Giyim", Amount = 1800m, OrderDate = new DateTime(2026, 2, 12) },
            new() { Id = 5, CustomerName = "Ayşe", Category = "Elektronik", Amount = 22000m, OrderDate = new DateTime(2026, 3, 3) },
            new() { Id = 6, CustomerName = "Mehmet", Category = "Giyim", Amount = 3200m, OrderDate = new DateTime(2026, 3, 18) },
            new() { Id = 7, CustomerName = "Ali", Category = "Kitap", Amount = 750m, OrderDate = new DateTime(2026, 4, 8) },
            new() { Id = 8, CustomerName = "Ayşe", Category = "Kitap", Amount = 600m, OrderDate = new DateTime(2026, 4, 20) },
            new() { Id = 9, CustomerName = "Mehmet", Category = "Elektronik", Amount = 8500m, OrderDate = new DateTime(2026, 5, 6) },
            new() { Id = 10, CustomerName = "Ali", Category = "Elektronik", Amount = 12000m, OrderDate = new DateTime(2026, 5, 22) }
        };

        var groupOrders = orders.GroupBy(p => p.Category).Select(group => new
        {
            Category = group.Key,
            ProductCount = group.Count(),
            TotalPrice = group.Sum(amount => amount.Amount),
            AveragePrice = group.Average(amount => amount.Amount)
        });
        System.Console.WriteLine("=== KATEGORİ RAPORU ===");
        foreach (var item in groupOrders)
        {
            System.Console.WriteLine($"{item.Category}: {item.ProductCount} siparis, {item.TotalPrice:N2} TL, Ortalama {item.AveragePrice:N2} TL");
        }

        var customer = orders.OrderByDescending(order => order.Amount).First();

        System.Console.WriteLine($"En cok harcayan: {customer.CustomerName} ({customer.Amount:N2})");

        IEnumerable<Order> enumerableOrders = orders
        .Where(order => order.Amount > 100)
        .OrderBy(order => order.OrderDate);

        System.Console.WriteLine("\n === IEnumerable Sonuclari ===");

        foreach (var order in enumerableOrders)
        {
            System.Console.WriteLine($"{order.CustomerName} - {order.Amount:N2} TL - {order.OrderDate}");

        }

        IQueryable<Order> queryableOrders = orders
            .AsQueryable()
            .Where(order => order.Amount > 100)
            .OrderBy(order => order.OrderDate);

        System.Console.WriteLine("\n === IQueryable  Sonuclari ===");

        foreach (var order in enumerableOrders)
        {
            System.Console.WriteLine($"{order.CustomerName} - {order.Amount:N2} TL - {order.OrderDate}");

        }

        // IEnumrable : Bellekteki collectionlar icin , LINQ to Object seklinde calisir
        // IQueryable : Ozellikle veritabani sorgulari icin 
    }

}
