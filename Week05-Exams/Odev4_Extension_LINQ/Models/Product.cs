namespace Odev4_Extension_LINQ.Models;

public class Product
{
    public Product(int id, string name, decimal price, int stock)
    {
        Id = id;
        Name = name;
        Price = price;
        Stock = stock;
    }

    public int Id { get; }
    public string Name { get; } = string.Empty;
    public decimal Price { get; }
    public int Stock { get; }
}
