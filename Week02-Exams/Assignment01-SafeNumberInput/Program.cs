int num = 1;
while (num != 0)
{
    try
    {
        System.Console.Write("Bir Sayi Girin (Cikis icin 0): ");
        num = int.Parse(Console.ReadLine()!);
        if (num != 0)
        {
            System.Console.WriteLine($"Girdiginiz Sayi: {num}");
        }
    }
    catch (FormatException)
    {
        System.Console.WriteLine("Hata: Lütfen geçerli bir tam sayı girin.");
    }

}
System.Console.Write("Program Sonlandi.");