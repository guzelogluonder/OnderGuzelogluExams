using System;

namespace Odev8_Nullable.Models;

public class Customer
{
    
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Email { get; set; }
    public DateTime? BirthDate { get; set; }

    public Customer()
    {

    }
    public Customer(int id, string name, string? email, DateTime? birthDate)
    {
        Id = id;
        Name = name;
        Email = email;
        BirthDate = birthDate;
    }


}
