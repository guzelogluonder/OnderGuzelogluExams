int possitiveNum = 0;
int negativeNum = 0;
int zeroNum = 0;
int sumPositive = 0;
int sumNegative = 0;
for (int i = 1; i <= 10; i++)
{
    System.Console.Write($"{i}. Sayiyi girin: ");
    int enteredNum = int.Parse(Console.ReadLine()!);
    if (enteredNum < 0)
    {
        negativeNum++;
        sumNegative += enteredNum;
    }
    else if (enteredNum > 0)
    {
        possitiveNum++;
        sumPositive += enteredNum;
    }
    else
    {
        zeroNum++;
    }
}
Console.Clear();
System.Console.WriteLine(" === SONUÇ === \n\n" +
                        $"Pozitif Sayı Adedi: {possitiveNum}\n" +
                        $"Negatif Sayı Adedi: {negativeNum}\n" +
                        $"Sıfır Adedi: {zeroNum}\n" +
                        $"Pozitif Toplamı: {sumPositive}\n" +
                        $"Negatif Adedi: {sumNegative}");