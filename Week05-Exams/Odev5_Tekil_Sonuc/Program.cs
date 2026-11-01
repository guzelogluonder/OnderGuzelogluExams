using Odev5_Tekil_Sonuc.Models;

namespace Odev5_Tekil_Sonuc;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees =
        [
            new Employee(1,"Onder","Yazılım",100000m),
            new Employee(2,"Soner","Satış",200000m),
            new Employee(3,"Arda","IT",80000m),
            new Employee(4,"Ali","IT",400000m),
            new Employee(5,"Fidan","Satış",450000m),
            new Employee(6,"Abuzer","IT",65000m),
            new Employee(7,"Mehmet","Yazılım",95000m),
            new Employee(8,"Sude","Yazılım",95000m)
        ];

        var SEemployee = employees.Where(p => p.Department == "Yazılım").FirstOrDefault();
        System.Console.WriteLine($"Ilk Yazilimci: {SEemployee?.Name}");
        var findByIdEmployee = employees.Where(p => p.Id == 3).SingleOrDefault();
        System.Console.WriteLine($"Id= {findByIdEmployee?.Id}: {findByIdEmployee?.Name}");
        var isExistsById = employees.Where(p => p.Id == 99).SingleOrDefault();
        System.Console.WriteLine(isExistsById?.Name ?? "Id = 99: Calisan bulunamadi");
        try
        {
            var sameDepartment = employees.Where(p => p.Department == "Yazılım").SingleOrDefault();
        }
        catch (System.Exception e)
        {
            System.Console.WriteLine($"Hata: {e.Message}");
        }
        // Id unique bir ozelliktir her calisanin kendisine ait bir idsi bulunur.
        //  Bu nedenle SingleOrDefault ile aramak daha uygundur cunku id ile yapilan her aramada 1 adet sonuc donulur.
        // bir departmanda birden fazla calisan olabilecegi icin coklu sonuc donulebilir SingleOrDefault ile yalnizca 1 adet sonuc uretilir bu da diger verileri kaybetmemize neden olabilir.

        var startWithLetterA = employees.Where(p => p.Name.StartsWith('A')).ToList();
        System.Console.Write("A ile Baslayanlar: ");
        foreach (var item in startWithLetterA)
        {
            System.Console.Write($" {item.Name}");
            if (startWithLetterA.Last() != item)
            {
                System.Console.Write(", ");
            }
        }

        var employee = employees.Select(e => new
        {
            e.Name,
            SalaryLabel = $"{e.Salary} TL"
        }).ToList();

        foreach (var item in employee)
        {
            System.Console.WriteLine($"Isim: {item.Name}\n Maas: {item.SalaryLabel}");
        }

        var salaryCheck = employees.Any(p => p.Salary > 100000);

        System.Console.WriteLine($"100.000 TL ustu kazanan var mi: {salaryCheck}");
    }
}
