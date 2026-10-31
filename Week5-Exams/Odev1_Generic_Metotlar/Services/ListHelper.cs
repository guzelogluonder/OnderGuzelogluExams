namespace Odev1_Generic_Metotlar.Services;

public class ListHelper
{
    public T GetLast<T>(List<T> items)
    {
        return items.LastOrDefault()!;
    }

    public int CountItems<T>(List<T> items)
    {
        return items.Count;
    }

    public List<T> Reverse<T>(List<T> items)
    {
        return items.AsEnumerable().Reverse().ToList();
    }
}
