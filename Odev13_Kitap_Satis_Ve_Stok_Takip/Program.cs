string bookName = "";
int numberOfPrintedBook = 0;
decimal price = 0m;
int salesTarget = 0;
int currentSalesTarget = 0;
int bookOrder;
int currentStock = 0;
int currentSoldBook = 0;
decimal earnedMoney = 0m;
int menuChoice;
bool flag = true;
string customerAddress;
while (flag)
{
    Console.Clear();
    System.Console.Write("=== ONLINE KITAP === \n" +
                        "Kitap Basım Siparişi / Detay --> 1 \n" +
                        "Kitap Satın Al --> 2\n" +
                        "Çıkış --> 3 \n" +
                        "Merhaba Lütfen Giriş Türünü Seçiniz: ");
    int loginType = int.Parse(Console.ReadLine()!);
    Console.Clear();
    if (loginType == 1)
    {

        System.Console.Write("=== ONLINE KITAP === \n" +
                                "Yeni Kitap Başvurusu --> 1\n" +
                                "Kitap Satış Detay --> 2\n" +
                                "Merhaba! Lütfen Seçimizi giriniz: ");
        menuChoice = int.Parse(Console.ReadLine()!);
        Console.Clear();
        switch (menuChoice)
        {
            case 1:
                System.Console.Write("Kitabinizin Adini Giriniz: ");
                bookName = Console.ReadLine()!;
                System.Console.Write("Kitabınızın Basım Adedini Giriniz: ");
                numberOfPrintedBook = int.Parse(Console.ReadLine()!);
                currentStock = numberOfPrintedBook;
                System.Console.Write("Kitabınızın Fiyatını Giriniz: ");
                price = decimal.Parse(Console.ReadLine()!);
                System.Console.Write("Kitap Satış Hedefiniz: ");
                salesTarget = int.Parse(Console.ReadLine()!);
                currentSalesTarget = salesTarget;
                Console.Clear();
                break;
            case 2:
                if (bookName == "")
                {
                    System.Console.Write("Stokta kitap bulunmamaktadır. Ana Menüye Dönmek için Enter'a Basın.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    string target = currentSalesTarget <= 0 ? $"Tebrikler Hedefinize ulaştınız..\n" : $"Hedefinize {currentSalesTarget} adet kalmıştır.\n";
                    System.Console.Write($"Kitabınız {numberOfPrintedBook} Adet Basılmıştır.\n" +
                                             $"Kitabınız {currentSoldBook} Adet Satılmıştır.\n" +
                                             $"Kitap satış Hedefiniz {salesTarget} adettir.\n" +
                                             target +
                                             $"Mevcut Kitap Geliriniz: {earnedMoney} TL\n" +
                                             "Ana menüye dönmek için Enter'a basın..");


                    Console.ReadLine();
                }

                break;
            default:
                System.Console.Write("Hatalı Seçim Yaptınız. Ana Menüye Dönmek için Enter'a Basın.");
                Console.ReadLine();
                Console.Clear();
                break;
        }
    }
    else if (loginType == 2)
    {
        if (bookName != "")
        {
            System.Console.Write(" === Online Kitap === \n" +
                                    "Sipariş Adedini giriniz: ");
            bookOrder = int.Parse(Console.ReadLine()!);
            if (currentStock >= bookOrder)
            {
                currentSalesTarget -= bookOrder;

                if (currentStock >= bookOrder)
                {
                    currentStock -= bookOrder;
                }
                currentSoldBook += bookOrder;
                earnedMoney = currentSoldBook * price;
                System.Console.Write("Gönderilecek Adresi Giriniz: ");
                customerAddress = Console.ReadLine()!;
                Console.Clear();
                System.Console.Write("Siparişiniz Başarıyla Tamamlanmıştır!\n" +
                                        $"Gönderilen Kitap adedi: {bookOrder}\n" +
                                        $"Gönderilen Adres: {customerAddress}\n" +
                                        "Ana Menüye Dönmek İçin Lütfen Enter'a Basın..");
                Console.ReadLine();
                Console.Clear();

            }
            else
            {
                System.Console.Write($"Stok'ta yeteri kadar kitap bulunmamaktadır.\n Mevcut Stok: {currentStock} Ana Menüye Dönmek İçin Lütfen Enter'a Basın..");
                Console.ReadLine();
            }
        }
        else
        {
            System.Console.Write("Stokta kitap bulunmamaktadır. Ana Menüye Dönmek için Enter'a Basın.");
            Console.ReadLine();
            Console.Clear();
        }

    }
    else if (loginType == 3)
    {
        System.Console.Write("Çıkış Yapıldı. İyi Günler Dileriz..");
        flag = false;
    }
    else
    {
        System.Console.Write("Hatalı Seçim Yaptınız. Ana Menüye dönmek için Lütfen Enter'a Basın.");
        Console.ReadLine();
    }
}
