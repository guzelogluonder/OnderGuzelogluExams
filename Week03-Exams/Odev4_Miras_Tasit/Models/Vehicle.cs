using System.ComponentModel.DataAnnotations;

namespace Odev4_Miras_Tasit.Models;

public class Vehicle
{
    public int Id { get; set; }
    public string Brand { get; set; } = string.Empty;

    public virtual void Display()
    {
        System.Console.Write($"Otomobil [{Id}] {Brand}");
    }
}
