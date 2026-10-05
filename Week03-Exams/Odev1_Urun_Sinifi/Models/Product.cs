using System.Runtime.CompilerServices;

namespace Odev1_Urun_Sinifi.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }

    public void Display()
    {
        System.Console.Write($"Ürün #{Id}: {Name} — {Price} TL\n");
    }
}
