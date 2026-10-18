using System;

namespace Odev7_Interface.Models;

public class Product : IIdentifiable
{
    public int Id { get; set; }
    public string? ProductName { get; set; }

    public string GetDisplayName()
    {
        return $"{Id} {ProductName}";
    }
}
