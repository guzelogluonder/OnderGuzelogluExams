Random rnd = new();
int guessCount = 0;
bool isTrue = true;
int num = rnd.Next(1, 10);
System.Console.Write("=== Sayı Tahmin Oyunu === \n Tahmininiz: ");
int guess = int.Parse(Console.ReadLine()!);
Console.Clear();
while (isTrue)
{
    if (guess < num)
    {
        System.Console.Write($"\nTahmininiz: {guess} \n Daha Büyük Bir Sayı Girin. ");
        guessCount++;
    }
    else if (guess > num)
    {
        System.Console.Write($"\nTahmininiz: {guess} \n Daha Küçük Bir Sayı Giriniz: ");
        guessCount++;
    }
    else
    {
        System.Console.Write($"\nTebrikler, doğru tahmin! \n {guessCount} tahminde doğru bildiniz.");
        isTrue = false;
    }
    guess = int.Parse(Console.ReadLine()!);
}