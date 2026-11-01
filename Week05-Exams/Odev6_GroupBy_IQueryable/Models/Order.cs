namespace Odev6_GroupBy_IQueryable.Models;

public class Order
{
    public Order()
    {

    }
    public Order(int id, string customerName, string category, decimal amount, DateTime orderDate)
    {
        Id = id;
        CustomerName = customerName;
        Category = category;
        Amount = amount;
        OrderDate = orderDate;
    }

    public int Id { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public DateTime OrderDate { get; set; }
}
