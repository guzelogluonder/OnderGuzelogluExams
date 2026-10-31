using System;
using Odev2_Constraint_Polymorphism.Contracts;

namespace Odev2_Constraint_Polymorphism.Models;

public class Course : IDescribable, IIdentifiable
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string DurationHours { get; set; } = string.Empty;

    public string Describe()
    {
        return $"Kurs: {Name} - {DurationHours}";
    }
}
