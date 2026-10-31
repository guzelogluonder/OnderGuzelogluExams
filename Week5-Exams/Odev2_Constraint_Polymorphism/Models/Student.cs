using Odev2_Constraint_Polymorphism.Contracts;

namespace Odev2_Constraint_Polymorphism.Models;

public class Student : IDescribable, IIdentifiable
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;

    public string Describe()
    {
        return $"Ogrenci: {FullName}";
    }

}
