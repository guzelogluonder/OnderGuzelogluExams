using System.Globalization;
using System.Reflection.Metadata;
using Odev4_Extension_LINQ.Extesion;
using Odev4_Extension_LINQ.Models;

namespace Odev4_Extension_LINQ;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products =
        [
            new Product(1,"Laptop", 25000m, 5),
            new Product(2,"Mouse", 350m, 0),
            new Product(3,"Klavye", 1200m, 8),
            new Product(4,"Monitör", 7500m, 3),
            new Product(5,"Kulaklık", 850m, 0),
            new Product(6,"USB Kablo", 150m, 12)
        ];

        bool hasOutOfStock = products.HasAny(p => p.Stock == 0);

        System.Console.WriteLine($"Stokta olmayan ürün var mı: {hasOutOfStock}");

        string expensiveProducts = products
        .Where(p => p.Price > 500m)
        .Select(p => p.Name)
        .OrderBy(name => name)
        .JoinForDisplay(name => name);

        System.Console.WriteLine($"Pahalı ürünler: {expensiveProducts}");

        int inStockCount = products.Count(p => p.Stock > 0);

        System.Console.WriteLine($"Stokta olan ürün sayısı: {inStockCount}");

        CultureInfo tr = new CultureInfo("tr-TR");

        decimal total = 1234.5m;

        string totalPrice = products
            .Select(p => p.Price)
            .SumFormatted(price => $"{price.ToString("N2", tr)} TL");

        Console.WriteLine($"Toplam fiyat: {totalPrice}");
    }
}
