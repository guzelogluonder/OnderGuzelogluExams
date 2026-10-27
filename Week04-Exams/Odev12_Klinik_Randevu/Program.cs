using Odev12_Klinik_Randevu.Services;

namespace Odev12_Klinik_Randevu;

class Program
{
    static void Main(string[] args)
    {
        ClinicService clinicService = new ClinicService();
        int choice = 0;

        while (choice != 5)
        {
            System.Console.WriteLine("=== KLINIK ===\n" +
                         "1 - Randevu ekle\n" +
                         "2 - Randevuları listele\n" +
                         "3 - Randevu iptal (id)\n" +
                         "4 - Aktif randevu sayısı\n" +
                         "5 - Çıkış\n");
            Console.Write("Seçiminiz: ");
            try
            {
                string? input = Console.ReadLine();
                choice = int.Parse(input ?? "0");
            }
            catch (FormatException)
            {
                Console.WriteLine("[HATA: ] Lütfen sadece sayı girin!");
                continue;
            }
            catch (OverflowException)
            {
                Console.WriteLine("[HATA: ] Çok büyük ya da çok küçük bir sayı girdiniz.");
                continue;
            }
            switch (choice)
            {
                case 1:
                    System.Console.Write("Hasta Adi: ");
                    string patientName = Console.ReadLine()!;
                    System.Console.Write("Doktor Adi: ");
                    string doctorName = Console.ReadLine()!;
                    clinicService.AddAppointment(patientName, doctorName, DateTime.Now.ToString());
                    Console.Clear();
                    break;
                case 2:
                    clinicService.ListAppointment();
                    break;

                case 3:
                    System.Console.WriteLine("Iptal etmek istediginiz randevuyu giriniz : ");
                    int id = int.Parse(Console.ReadLine()!);
                    clinicService.CancelAppointment(id);
                    break;

                case 4:
                    int activeCount = clinicService.GetActiveCount();
                    System.Console.WriteLine($"Toplam aktif randevu sayisi: {activeCount}");
                    break;

                case 5:

                    break;
                default:
                    Console.WriteLine("Geçersiz seçim. 1-5 arası bir değer girin.");
                    break;
            }
        }
        Console.WriteLine($"Klinik Randevu sistemi sona erdi...");
    }
}
