using Odev4_Miras_Tasit.Models;

namespace Odev4_Miras_Tasit;

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new()
        {
            Id = 1,
            Brand = "Toyota",
            Model = "Corolla",
            Year = 2020
        };
        Car car2 = new()
        {
            Id = 2,
            Brand = "Lamborghini",
            Model = "Gallardo",
            Year = 2021
        };
        car1.Display();
        car2.Display();
    }
}
