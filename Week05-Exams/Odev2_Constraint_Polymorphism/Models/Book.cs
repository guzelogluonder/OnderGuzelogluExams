using System;
using Odev2_Constraint_Polymorphism.Contracts;

namespace Odev2_Constraint_Polymorphism.Models;

public class Book : IDescribable, IIdentifiable
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;

    public string Describe()
    {
        return $"Kitap: {Title} - {Author}";
    }

}

