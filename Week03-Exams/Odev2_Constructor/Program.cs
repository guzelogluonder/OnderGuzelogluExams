using Odev2_Constructor.Models;

namespace Odev2_Constructor;

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student(1, "Onder", "399");
        Student student2 = new Student(2, "Ali", "66");
        Student student3 = new Student();
        student3.Id = 3;
        student3.FullName = "Soner";
        student3.StudentNumber = "93";

        Student student4 = new()
        {
            Id = 4,
            FullName = "Arda",
            StudentNumber = "23"
        };
        System.Console.WriteLine("=== ÖĞRENCİLER ===");
        student1.Display();
        student2.Display();
        student3.Display();
        student4.Display();
    }   
}
