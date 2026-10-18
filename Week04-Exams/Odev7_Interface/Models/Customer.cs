using System;

namespace Odev7_Interface.Models;

public class Customer : IIdentifiable
{
    public int Id { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public string GetDisplayName()
    {
        return $" {Id} {CustomerName}";
    }
}
