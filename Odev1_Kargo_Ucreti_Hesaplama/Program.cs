
using System.Runtime.InteropServices;

int addNewOrStop = 0;
while (addNewOrStop != 2)
{
    Console.Clear();

    int cargoFee = 0;
    string location = "Şehir içi";
    const string currencyCode = "₺";
    System.Console.Write("=== Kargo Ücretlendirme Servisi === \n " +
                    "Kargo Ücreti Hesaplama --> 1 \n" +
                    " Çıkış -------------------> 2 \n" +
                     " Seçiminiz: ");

    addNewOrStop = int.Parse(Console.ReadLine()!);
    if (addNewOrStop == 1)
    {
        Console.Write("Göndericinin Adı : ");
        string senderName = Console.ReadLine()!;
        Console.Write("Paket Ağırlığı : ");
        int weight = int.Parse(Console.ReadLine()!);
        Console.Write("Gönderi Tipi (Şehir içi -> 1 / Şehir -> 2) : ");
        int sendedLocation = int.Parse(Console.ReadLine()!);
        if (weight > 0 && weight <= 2)
        {
            cargoFee += 100;
        }
        else if (weight > 2 && weight <= 5)
        {
            cargoFee += 150;
        }
        else
        {
            cargoFee += 250;
        }

        if (sendedLocation == 2)
        {
            cargoFee += 75;
            location = "Şehir Dışı";
        }

        System.Console.WriteLine($"=== Kargo Ucreti === \n"
        + $"Gönderici: {senderName} \n Paket Ağırlığı: {weight} \n"
        + $"Gonderi Tipi: {location} \n Kargo Ücreti: {cargoFee}{currencyCode}");
        Console.Write("Yeni kargo girmek çin Enter'a basınız...");
        Console.ReadLine();
    }
    else
    {
        System.Console.WriteLine("Çıkış yapıldı.");
    }
}

