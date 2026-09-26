decimal totalPrice = 0m;
int ticketCount = 0;
int choice = 1;
while (choice != 3)
{
    Console.Clear();
    System.Console.Write("=== SİNEMA BİLET SİSTEMİ === \n" +
                            "1 - Tam Bilet \n" +
                            "2 - Öğrenci Bileti \n" +
                            "3 - Çıkış\n" +
                            "Seciminiz: ");
    choice = int.Parse(Console.ReadLine()!);
    switch (choice)
    {
        case 1:
            System.Console.Write("Bilet Adedi: ");
            ticketCount = int.Parse(Console.ReadLine()!);
            totalPrice = 250 * ticketCount;
            break;
        case 2:
            System.Console.Write("Bilet Adedi: ");
            ticketCount = int.Parse(Console.ReadLine()!);
            totalPrice = 150 * ticketCount;
            break;
        case 3:
            Console.Clear();
            System.Console.WriteLine("Çıkış Yapıldı.");
            break;
        default:
            Console.Clear();
            Console.Write("gecersiz secim \n Bilet Secimine Dönmek İçin Enter'a Basın..");
            Console.ReadLine();
            break;
    }
    if (choice != 3 && choice >= 1 && choice < 3)
    {
        Console.Clear();
        string ticketType = choice == 1 ? "Tam" : "Öğrenci";
        System.Console.WriteLine($"Bilet Türü: {ticketType}\n" +
                                $"Bilet Adedi: {ticketCount}\n" +
                                $"Toplam: {totalPrice}\n");
        System.Console.Write("Yeniden bilet seçimi için Enter'a Basınız..");
        Console.ReadLine();
    }
}