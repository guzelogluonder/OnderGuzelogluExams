using Odev6_Uye_Servisi.Services;

namespace Odev6_Uye_Servisi;

class Program
{
    static void Main(string[] args)
    {
        GymMember member = new();
        GymService service = new GymService();
        service.AddMember("Onder", "onder@gmail.com");
        service.AddMember("ali", "ali@gmail.com");
        service.AddMember("veli", "veli@gmail.com");
        service.AddMember("cem", "cem@gmail.com");
        service.AddMember("can", "can@gmail.com");
        service.ListMembers();
        
        member = service.FindByName("Onder");
        if (member != null)
        {
            System.Console.WriteLine($"{member.Name} isimli kayit bulunmaktadir.");
        }
        else
        {
            System.Console.WriteLine("Kayit bulunamadi.");
        }

        member = service.FindByName("cemil");
        if (member != null)
        {
            System.Console.WriteLine($"{member.Name} isimli kayit bulunmaktadir.");
        }
        else
        {
            System.Console.WriteLine("Kayit bulunamadi.");
        }
    }
}
