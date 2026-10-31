using System.Runtime.CompilerServices;
using Odev1_AssetTracking.Models;

namespace Odev1_AssetTracking.Services;

public class AssetRegistry<T> where T : IAsset
{
    private readonly List<T> _assets = new();

    public void Add(T asset)
    {
        bool isExists = _assets.Any(a => a.AssetCode == asset.AssetCode);

        if (isExists)
        {
            Console.WriteLine($"'{asset.AssetCode}' koduna sahip bir varlik zaten kayitli.");
            return;
        }

        _assets.Add(asset);
        System.Console.WriteLine($"'{asset.AssetCode}' kodlu varlik basariyla eklendi.");
    }

    public T? FindByCode(string code)
    {
        return _assets.FirstOrDefault(a => a.AssetCode == code);
    }

    public IEnumerable<T>? GetAvailable()
    {
        IEnumerable<T>? availables = _assets.Where(a => a.IsAvailable == true);
        return availables;
    }

    public void PrintAll()
    {
        foreach(T asset in _assets)
        {
            System.Console.WriteLine($"Asset Code:  {asset.AssetCode}");
            System.Console.WriteLine($"Name:        {asset.Name}");
            System.Console.WriteLine($"Details:  {asset.GetDetails()}");
            System.Console.WriteLine($"Asset Code:  {asset.AssetCode}");
            System.Console.WriteLine("---------------------------------");
        }
    }


}
