using Odev6_Uye_Servisi.Services;

namespace Odev8_Dictionary_GetById;

class Program
{
    static void Main(string[] args)
    {
        GymService service = new GymService();
        GymMember member = new GymMember();
        service.AddMember("Onder", "onder@gmail.com");
        service.AddMember("Ali", "ali@gmail.com");
        service.AddMember("Veli", "veli@gmail.com");

        member = service.GetById(1)!;
        if (member is not null)
        {
            System.Console.WriteLine($"{member.Id} {member.Name} ");
        }
        else
        {
            System.Console.WriteLine("Üye bulunamadı.");
        }

        member = service.GetById(99)!;
        if (member is not null)
        {
            System.Console.WriteLine($"{member.Id} {member.Name} ");
        }
        else
        {
            System.Console.WriteLine("Üye bulunamadı.");
        }
    }
}
