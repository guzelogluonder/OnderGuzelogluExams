using System.Data.Common;
using System.Net;
using Odev2_Constraint_Polymorphism.Contracts;
using Odev2_Constraint_Polymorphism.Models;
using Odev2_Constraint_Polymorphism.Services;

namespace Odev2_Constraint_Polymorphism;

class Program
{
    static void Main(string[] args)
    {
        ItemPrinter itemPrinter = new();

        Book book1 = new Book()
        {
            Id = 1,
            Title = "Ince Memed",
            Author = "Yasar Kemal"
        };
        Book book2 = new Book()
        {
            Id = 2,
            Title = "Karamazov Kardesler",
            Author = "Dostoyevski"
        };


        List<Book> books = [book1, book2];

        Course course1 = new Course()
        {
            Id = 1,
            Name = "Fotografcilik Temelleri",
            DurationHours = "(120 saat)"
        };

        Course course2 = new Course()
        {
            Id = 2,
            Name = "Acunmedya Akademi Backend Egitimi",
            DurationHours = "(140 saat)"
        };
        List<Course> courses = [course1, course2];

        Student student1 = new Student()
        {
            Id = 1,
            FullName = "Onder Guzeloglu"
        };

        Student student2 = new Student()
        {
            Id = 2,
            FullName = "Soner Guzeloglu"
        };
        List<Student> students = [student1, student2];

        itemPrinter.PrintDescriptions(books);
        itemPrinter.PrintIds(books);

        itemPrinter.PrintDescriptions(courses);
        itemPrinter.PrintIds(courses);

        itemPrinter.PrintDescriptions(students);
        itemPrinter.PrintIds(students);

        List<IDescribable> describables = new()
        {
            book1,
            course1,
            student1
        };

        System.Console.WriteLine("=== KARISIK LISTE ===");
        Console.Write(
            string.Join("\n", describables.Select(x => x.Describe()))
        );
    }
}
