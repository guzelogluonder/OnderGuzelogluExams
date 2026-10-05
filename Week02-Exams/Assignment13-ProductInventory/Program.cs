string[] productNames = new string[10];
decimal[] prices = new decimal[10];
int[] quantities = new int[10];
int productCount = 0;
int menuChoice = 0;
decimal totalStock = 0;
while (menuChoice != 4)
{
    System.Console.Write("=== ÜRÜN ENVANTERİ ===\n" +
                             "1 - Ürün ekle\n" +
                             "2 - Envanter listele\n" +
                             "3 - Toplam stok değeri\n" +
                             "4 - Çıkış\n" +
                             "Seciminiz: ");
    try
    {
        string strMenuChoice = Console.ReadLine() ?? "";
        if (strMenuChoice != "")
        {
            menuChoice = int.Parse(strMenuChoice);
        }
        else
        {
            throw new FormatException("Urun adi bos birakilamaz.");
        }
    }
    catch (FormatException ex)
    {

        System.Console.WriteLine(ex.Message);
    }

    switch (menuChoice)
    {
        case 1:
            try
            {
                if (productCount < 10)
                {
                    Console.Clear();
                    System.Console.Write("Urun Adi: ");
                    string productName = Console.ReadLine() ?? "";
                    if (productName == "")
                    {
                        throw new FormatException("Urun adi bos birakilamaz.");
                    }
                    System.Console.Write("Urun Fiyati: ");
                    string strPrice = Console.ReadLine() ?? "";
                    bool productPrice = decimal.TryParse(strPrice, out decimal price);
                    if (!productPrice || price <= 0)
                    {
                        throw new FormatException("Hata: Fiyat Sıfırdan büyük bir sayı olmalı.");
                    }
                    System.Console.Write("Urun Adedi: ");
                    string strquantity = Console.ReadLine() ?? "";
                    bool productQuantity = int.TryParse(strquantity, out int quantity);
                    if (!productPrice || quantity <= 0)
                    {
                        throw new FormatException("Hata: Adet Sıfırdan büyük bir sayı olmalı.");
                    }
                    productNames[productCount] = productName;
                    prices[productCount] = price;
                    quantities[productCount] = quantity;
                    productCount++;

                }
                else
                {
                    throw new ArgumentException("Hata: Maksimum ürün sayısına ulaşıldı (10).");
                }

            }
            catch (FormatException ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            break;
        case 2:
            if (productCount > 0)
            {
                for (int i = 0; i < productCount; i++)
                {
                    System.Console.Write($"{i + 1}. {productNames[i]} — {prices[i]} TL x {quantities[i]} = {prices[i] * quantities[i]} TL\n");
                }
            }
            else
            {
                System.Console.WriteLine("(Henüz ürün yok)");
            }
            break;
        case 3:
            totalStock = 0;
            for (int i = 0; i < productCount; i++)
            {
                totalStock += prices[i] * quantities[i];
            }
            System.Console.WriteLine($"Toplam Stok Değeri: {totalStock} TL");
            break;
        case 4:
            System.Console.WriteLine("Çıkış yapıldı.");
            break;
        default:
            System.Console.Write("Hatali menu secimi.");
            break;
    }
}