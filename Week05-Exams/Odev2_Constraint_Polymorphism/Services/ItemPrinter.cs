using Odev2_Constraint_Polymorphism.Contracts;

namespace Odev2_Constraint_Polymorphism.Services;

public class ItemPrinter
{
    public void PrintDescriptions<T>(List<T> items) where T : IDescribable
    {
        foreach (T item in items)
        {
            System.Console.WriteLine(item.Describe());
        }

    }

    public void PrintIds<T>(List<T> items) where T : IIdentifiable
    {
        foreach (T item in items)
        {
            System.Console.WriteLine(item.Id);
        }
    }
}
