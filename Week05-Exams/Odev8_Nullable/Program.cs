using Odev8_Nullable.Models;
using Odev8_Nullable.Services;

namespace Odev8_Nullable;

class Program
{
    static void Main(string[] args)
    {
        CustomerRepository customerRepository = new CustomerRepository();
        string customer1 = customerRepository.FindByName("Önder")?.Name ?? "Müşteri bulunamadı.";
        System.Console.WriteLine($"Bulunan: {customer1}");
        string customer2 = customerRepository.FindByName("Osman")?.Name ?? "Müşteri bulunamadı.";
        System.Console.WriteLine($"{customer2}");

        Customer? customer3 = customerRepository.FindByName("Önder");

        if (customer1 != null)
        {
            System.Console.WriteLine($"{customer3?.Name}");
        }
        else
        {
            System.Console.WriteLine("Müşteri bulunamadı.");
        }

        Customer? customer4 = customerRepository.FindByName("Osman");

        if (customer4 != null)
        {
            System.Console.WriteLine($"{customer4.Name}");
        }
        else
        {
            System.Console.WriteLine("Müşteri bulunamadı.");
        }

        Customer? email1 = customerRepository.FindByName("Önder");
        if (email1?.Email != null)
        {
            System.Console.WriteLine($"{email1.Name} -> {email1.Email}");

        }
        else
        {
            System.Console.WriteLine($"{email1?.Name} -> E-posta yok.");
        }

        Customer? email2 = customerRepository.FindByName("Soner");

        if (email2?.Email != null)
        {
            System.Console.WriteLine($"{email2.Name} -> {email2.Email}");

        }
        else
        {
            System.Console.WriteLine($"{email2?.Name} -> E-posta yok.");
        }

        Customer? customerBirthDate = customerRepository.FindByName("Önder");
        if (customerBirthDate?.BirthDate != null)
        {
            System.Console.WriteLine($"Doğum yılı: {customerBirthDate.BirthDate?.Year}");
        }
        else
        {
            System.Console.WriteLine("Doğum Tarihi girilmemiş.");
        }

        Customer? customerBirthDate2 = customerRepository.FindByName("Fidan");
        if (customerBirthDate2?.BirthDate != null)
        {
            System.Console.WriteLine($"Doğum yılı: {customerBirthDate2.BirthDate?.Year}");
        }
        else
        {
            System.Console.WriteLine("Doğum Tarihi girilmemiş.");
        }
        //CS0103
        // null değer gelebileceği uyarısını ! ile suspend edebiliriz. Ancak bu değerin null değer alabileceği anlamına gelmiyor bu nedenle null exception yönetimi konusunda kullanımı tehlikelidir.
    }
}
