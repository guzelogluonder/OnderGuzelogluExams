using System;
using System.ComponentModel.DataAnnotations;

namespace Odev6_Uye_Servisi.Services;

public class GymMember
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;


    public GymMember(int id, string name, string email)
    {
        Id = id;
        Name = name;
        Email = email;
    }
    public GymMember()
    {
    }
    public void Display()
    {
        System.Console.WriteLine($"[{Id} {Name} - {Email}]");
    }

    public string GetSummary()
    {
        return $"{Name} {Email}";
    }

}
