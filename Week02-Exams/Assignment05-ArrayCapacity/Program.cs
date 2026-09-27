using System.Xml;

string[] cities = new string[4];
int cityCount = 0;
int choice = 1;
string city;
while (choice != 3)
{
    Console.Clear();
    System.Console.Write("=== Şehir Listesi === \n" +
                        "1 - Şehir ekle\n" +
                        "2 - Listele\n" +
                        "3 - Çıkış\n" +
                        "Seçiminiz: ");

    try
    {
        choice = int.Parse(Console.ReadLine() ?? "0");
    }
    catch (FormatException)
    {
        Console.Clear();
        System.Console.WriteLine("Geçersiz seçim");
        System.Console.Write("Devam etmek icin Enter'a basin.");
        Console.ReadLine();
        continue;
    }
    catch (OverflowException)
    {
        Console.WriteLine("HATA-> Lütfen 1-4 arasında bir değer giriniz.");
        System.Console.Write("\nDevam etmek icin Enter'a basin.");
        Console.ReadLine();
        continue;
    }

    switch (choice)
    {
        case 1:
            Console.Clear();
            try
            {
                if (cityCount > cities.Length - 1)
                {
                    throw new IndexOutOfRangeException("Hata: Maksimum şehir sayısına ulaşıldı (4).");
                }
                else
                {
                    System.Console.Write("Şehir Adını Giriniz: ");
                    city = Console.ReadLine()!;
                    if (string.IsNullOrWhiteSpace(city))
                    {
                        throw new FormatException("Hata: Şehir adı boş olamaz.");
                    }
                    else
                    {
                        cities[cityCount] = city;
                        cityCount++;
                    }
                    Console.Clear();
                }
            }
            catch (FormatException ex)
            {
                Console.Clear();
                System.Console.WriteLine(ex.Message);
                System.Console.Write("\nDevam etmek icin Enter'a basin.");
                Console.ReadLine();
                break;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.Clear();
                System.Console.WriteLine(ex.Message);
                System.Console.Write("\nDevam etmek icin Enter'a basin.");
                Console.ReadLine();
                break;
            }
            break;
        case 2:
            Console.Clear();
            if (cityCount > 0)
            {
                for (int i = 0; i < cityCount; i++)
                {
                    System.Console.Write($"{i + 1}. {cities[i]}\n");
                }
                System.Console.Write("Devam etmek icin Enter'a basin.");
                Console.ReadLine();

            }
            else
            {
                Console.Clear();
                System.Console.Write("(Henüz şehir yok) \n" +
                                        "Devam Etmek icin Enter'a basin.");
                Console.ReadLine();
                Console.Clear();
            }
            break;
        case 3:
            Console.Clear();
            System.Console.WriteLine("Cikis yapildi.");
            break;
        default:
            Console.Clear();
            Console.WriteLine("Geçersiz seçim");
            System.Console.Write("Devam etmek icin Enter'a basin.");
            Console.ReadLine();
            break;
    }
}