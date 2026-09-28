int menuChoice = 1;
int piece = 0;
string product = "";
string[] productNames = new string[15];
int[] quantities = new int[15];
decimal[] lineTotals = new decimal[15];
int orderCount = 0;
decimal price = 0m;
decimal totalPrice = 0m;
while (menuChoice != 6)
{

    System.Console.Write(" === RESTORAN MENUSU === \n " +
                            "1 - Hamburger      250 TL\n " +
                            "2 - Pizza          300 TL\n " +
                            "3 - Makarna        200 TL\n " +
                            "4 - Salata         120 TL\n " +
                            "5 - Siparişleri listele \n" +
                            " 6 - Çıkış \n" +
                            "Seciminiz: ");
    menuChoice = int.Parse(Console.ReadLine()!);
    try
    {
        if (menuChoice != 5 && menuChoice >= 1 && menuChoice < 5)
        {
            System.Console.Write("Adet: ");
            string pieceStr = Console.ReadLine()!;
            bool num = int.TryParse(pieceStr, out int result);
            if (num && int.Parse(pieceStr) > 0)
            {
                piece = int.Parse(pieceStr);
            }
            else
            {
                throw new FormatException("Gecersiz Adet secimi");
            }
        }
        Console.Clear();
        if (orderCount < productNames.Length || menuChoice == 5 || menuChoice == 6)
        {
            switch (menuChoice)
            {
                case 1:
                    price = 250 * piece;
                    product = "Hamburger";
                    break;
                case 2:
                    price = 300 * piece;
                    product = "Pizza";
                    break;
                case 3:
                    price = 200 * piece;
                    product = "Makarna";
                    break;
                case 4:
                    price = 120 * piece;
                    product = "Salata";
                    break;
                case 5:
                    if (orderCount > 0)
                    {
                        Console.Clear();
                        System.Console.WriteLine("=== SİPARİŞLER ===");
                        for (int i = 0; i < orderCount; i++)
                        {
                            System.Console.Write($"{i + 1}. {productNames[i]} x {quantities[i]} = {lineTotals[i]} \n");
                            totalPrice += lineTotals[i];
                        }
                        System.Console.WriteLine($"Genel Toplam: {totalPrice}");
                        totalPrice = 0m;
                        System.Console.Write("Devam etmek icin Enter'a basin.");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        System.Console.WriteLine("Henuz siparis alinmamistir.");
                        System.Console.Write("Devam etmek icin Enter'a basin.");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    break;
                case 6:
                    System.Console.Write("Cikis Yaptiniz.");
                    break;
                default:
                    Console.Clear();
                    System.Console.WriteLine("Geçersiz menü seçimi");
                    System.Console.Write("Devam etmek icin Enter'a basin.");
                    Console.ReadLine();
                    Console.Clear();
                    break;

            }
            if (menuChoice >= 1 && menuChoice <= 4)
            {
                productNames[orderCount] = product;
                lineTotals[orderCount] = price;
                quantities[orderCount] = piece;
                orderCount++;
            }
        }
        else
        {
            throw new OutOfMemoryException("Hata: Maksimum işlem sayısına ulaşıldı (15).");
        }
    }
    catch (FormatException ex)
    {
        Console.Clear();
        System.Console.WriteLine(ex.Message);
        System.Console.Write("Devam etmek icin Enter'a basin.");
        Console.ReadLine();
        Console.Clear();
    }
    catch (OutOfMemoryException ex)
    {
        Console.Clear();
        System.Console.WriteLine(ex.Message);
        System.Console.Write("Devam etmek icin Enter'a basin.");
        Console.ReadLine();
        Console.Clear();
    }
}