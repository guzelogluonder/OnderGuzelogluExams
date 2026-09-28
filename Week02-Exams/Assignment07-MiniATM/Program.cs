using System.Reflection.Metadata;

decimal balance = 8000m;
decimal amount = 0m;
int choice = 1;
int transactionCount = 0;
string[] transactionHistory = new string[8];
while (choice != 4)
{
    Console.Clear();
    System.Console.Write(" === ATM === \n" +
                            "1 - Para Cek\n" +
                            "2 - Islem Gecmisi\n" +
                            "3 - Bakiye Gonder\n" +
                            "4 - Cikis\n" +
                            "Seciminiz: ");

    choice = int.Parse(Console.ReadLine()!);
    switch (choice)
    {
        case 1:
            try
            {
                Console.Clear();
                if (transactionCount < transactionHistory.Length)
                {
                    System.Console.Write("Çekmek istediğiniz tutarı girin: ");
                    string amountStr = Console.ReadLine()!;
                    bool isDecimal = decimal.TryParse(amountStr, out decimal num);
                    if (isDecimal)
                    {
                        amount = decimal.Parse(amountStr);
                        if (amount > 0)
                        {
                            balance -= amount;
                            string transactionDesc = $"{amount} TL cekildi.\n Yeni Bakiye: {balance} TL";
                            transactionHistory[transactionCount] = transactionDesc;
                            transactionCount++;
                        }
                        else
                        {
                            throw new ArgumentException("Gecersiz Tutar.");
                        }
                    }
                    else
                    {
                        throw new FormatException("Gecersiz karakter girdiniz.");
                    }
                }
                else
                {
                    throw new OutOfMemoryException("Hata: Maksimum işlem sayısına ulaşıldı (8).");
                }
            }
            catch (FormatException ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.Write("Devam etmek icin Enter'a basin.");
                Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.Write("Devam etmek icin Enter'a basin.");
                Console.ReadLine();
            }
            catch (OutOfMemoryException ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.Write("Devam etmek icin Enter'a basin.");
                Console.ReadLine();
            }
            break;
        case 2:
            Console.Clear();
            if (transactionCount > 0)
            {
                for (int i = 0; i < transactionCount; i++)
                {
                    System.Console.Write($"{transactionHistory[i]}\n");
                }
            }
            else
            {
                System.Console.WriteLine("(Henüz işlem yok)");

            }
            System.Console.Write("Devam etmek icin Enter'a basin.");
            Console.ReadLine();
            break;
        case 3:
            Console.Clear();
            if (transactionCount > 0)
            {
                System.Console.WriteLine($"{transactionHistory[transactionCount - 1]}");
            }
            else
            {
                System.Console.WriteLine($"Bakiye: {balance}");
            }
            System.Console.Write("Devam etmek icin Enter'a basin.");
            Console.ReadLine();
            break;
        case 4:
            Console.Clear();
            System.Console.WriteLine("Cikis yapildi.");
            break;
        default:
            System.Console.Write("Gecersiz Secim.\n");
            System.Console.Write("Devam etmek icin Enter'a basin.");
            Console.ReadLine();
            break;
    }
}