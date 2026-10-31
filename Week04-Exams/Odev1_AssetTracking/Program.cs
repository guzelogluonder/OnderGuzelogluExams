using Odev1_AssetTracking.Models;
using Odev1_AssetTracking.Services;

namespace Odev1_AssetTracking;

class Program
{
    static void Main(string[] args)
    {

AssetRegistry<Laptop> laptopRegistry = new();

Laptop laptop1 = new()
{
    AssetCode = "LP001",
    Name = "Lenovo ThinkPad",
    IsAvailable = true
};

Laptop laptop2 = new()
{
    AssetCode = "LP002",
    Name = "Dell Latitude",
    IsAvailable = false
};

laptopRegistry.Add(laptop1);
laptopRegistry.Add(laptop2);

Laptop duplicateLaptop = new()
{
    AssetCode = "LP001",
    Name = "HP EliteBook",
    IsAvailable = true
};

laptopRegistry.Add(duplicateLaptop);

Console.WriteLine("=== LAPTOP KAYITLARI ===");
laptopRegistry.PrintAll();

Laptop? foundLaptop = laptopRegistry.FindByCode("LP002");

Console.WriteLine(foundLaptop != null
    ? $"Bulunan laptop: {foundLaptop.Name}"
    : "Laptop bulunamadı.");

Laptop? missingLaptop = laptopRegistry.FindByCode("LP999");

Console.WriteLine(missingLaptop != null
    ? $"Bulunan laptop: {missingLaptop.Name}"
    : "LP999 kodlu laptop bulunamadı.");

Console.WriteLine("=== KULLANILABİLİR LAPTOPLAR ===");

foreach (var laptop in laptopRegistry.GetAvailable()!)
{
    Console.WriteLine($"{laptop.AssetCode} - {laptop.Name}");
}

AssetRegistry<Camera> cameraRegistry = new();

Camera camera1 = new()
{
    AssetCode = "CM001",
    Name = "Canon EOS",
    IsAvailable = true
};

Camera camera2 = new()
{
    AssetCode = "CM002",
    Name = "Sony Alpha",
    IsAvailable = false
};

cameraRegistry.Add(camera1);
cameraRegistry.Add(camera2);

Console.WriteLine("=== KAMERA KAYITLARI ===");
cameraRegistry.PrintAll();
    }
}
