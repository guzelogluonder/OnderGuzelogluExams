using System;
using System.Runtime.CompilerServices;

namespace Odev6_Uye_Servisi.Services;

public class GymService
{
    private readonly List<GymMember> _members = new();
    private int _nextId = 1;

    public void AddMember(string name, string email)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            System.Console.WriteLine("[HATA:] Ad boş olamaz!");
            return;
        }
        if (string.IsNullOrWhiteSpace(email))
        {
            System.Console.WriteLine("[HATA:] email boş olamaz!");
            return;
        }
        GymMember gymMember = new GymMember(_nextId, name, email);
        _nextId++;
        _members.Add(gymMember);
    }

    public void ListMembers()
    {
        System.Console.WriteLine("\n --- Üye Listesi ---");
        if (_members.Count == 0)
        {
            System.Console.WriteLine("Kayıtlı üye yok!");
            return;
        }
        foreach (GymMember member in _members)
        {
            member.Display();
        }
    }

    public GymMember? FindByName(string search)
    {
        System.Console.WriteLine($"\n---- '{search}' Arama Sonucu ----");
        foreach (GymMember member in _members)
        {
            if (member.Name.Contains(search, StringComparison.InvariantCultureIgnoreCase))
            {
                return member;
            }
        }
        return null;

    }
}
