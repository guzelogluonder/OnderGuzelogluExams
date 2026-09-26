using System.Diagnostics.Metrics;


string currentPassword = "123456";
int counter = 0;
while (counter < 3)
{
    System.Console.Write("Şifrenizi giriniz: ");
    string entryPassword = Console.ReadLine()!;
    if (entryPassword == currentPassword)
    {
        Console.Clear();
        System.Console.WriteLine("Giriş başarılı. \nHoş geldiniz.");
        break;
    }
    else
    {
        Console.Clear();
        System.Console.WriteLine("Hatalı şifre! \nTekrar Deneyiniz.");
        counter++;
    }
}
if (counter >= 3)
{
    Console.Clear();
    System.Console.WriteLine("Hesabınız geçici olarak kilitlendi.");
}
