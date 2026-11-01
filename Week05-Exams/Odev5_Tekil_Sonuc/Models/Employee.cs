namespace Odev5_Tekil_Sonuc.Models;

public class Employee
{
    public Employee()
    {
    }
    public Employee(int id, string name, string department, decimal salary)
    {
        Id = id;
        Name = name;
        Department = department;
        Salary = salary;
    }

    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
    public decimal Salary { get; set; }

}
