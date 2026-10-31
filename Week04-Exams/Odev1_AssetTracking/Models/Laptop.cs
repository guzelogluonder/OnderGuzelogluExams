using System;

namespace Odev1_AssetTracking.Models;

public class Laptop : IAsset
{
    public string AssetCode { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public bool IsAvailable { get; set; }
    public string Brand { get; set; } = string.Empty;
    public string Models { get; set; } = string.Empty;
    public string GetDetails()
    {
        return $"Laptop: {Brand} {Models}";
    }
}
