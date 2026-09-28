System.Console.Write("Ürün Adı: ");
string productName = Console.ReadLine()!;
System.Console.Write("Fiyat: ");
string productPrice = Console.ReadLine()!;
bool isCorrectInput = true;
while (isCorrectInput)
{
    isCorrectInput = decimal.TryParse(productPrice, out decimal price);
    if (isCorrectInput)
    {
        System.Console.WriteLine("=== ÜRÜN === \n" +
                                $"ürün: {productName}" +
                                $"Fiyat: {price}");
    }
    else
    {
        System.Console.WriteLine("Hata: Fiyat sayı olmalı. Örnek: 1500 veya 1500.50");
        throw new ArgumentException("Sayı girmediniz.");
    }
}