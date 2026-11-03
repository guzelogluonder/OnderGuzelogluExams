using System;
using Odev8_Nullable.Models;

namespace Odev8_Nullable.Services;

public class CustomerRepository
{
    List<Customer> _customers = new()
    {
        new() {Id = 1, Name = "Önder", Email = "onder@email.com", BirthDate = new DateTime(1997, 2, 4)},
        new() {Id = 2, Name = "Ali",   Email = "ali@email.com", BirthDate = new DateTime(1966, 1, 1)},
        new() {Id = 3, Name = "Soner", Email = null, BirthDate = new DateTime(1993, 6, 12)},
        new() {Id = 4, Name = "Fidan", Email = "fidan@email.com", BirthDate = null}
    };


    public Customer? FindByName(string name)
    {
        return _customers.FirstOrDefault(customer => customer.Name == name);
    }
}
