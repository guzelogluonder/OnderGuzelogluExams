using System.Formats.Tar;
using Odev1_Generic_Metotlar.Services;

namespace Odev1_Generic_Metotlar;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = [99, 1, 66, 12];
        List<string> names = ["Ali", "Veli", "Ayşe"];
        List<decimal> prices = [9.99m, 12.45m, 0.99m];

        ListHelper listHelper = new ListHelper();

        System.Console.WriteLine(" === GENERIC METOTLAR ===");
        System.Console.WriteLine($"Son sayi: {listHelper.GetLast(numbers)}");
        System.Console.WriteLine($"Isim Sayisi: {listHelper.CountItems(names)}");
        Console.WriteLine($"Ters Fiyatlar: {string.Join(", ", listHelper.Reverse(prices))}");
    }
    // Soru: Aynı işi object kullanarak yapsaydık hangi sorunla karşılaşırdık?
    // Tip guvenligini kaybederdik. Deger tiplerinde boxing/unboxing olusabilir.
    // Bazi hatalar compile time de ortaya cikabilir.
}
