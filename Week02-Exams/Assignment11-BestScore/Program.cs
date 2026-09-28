int[] scores = new int[5];
int score;
int totalScore = 0;
for (int i = 0; i < scores.Length; i++)
{
    System.Console.Write($"{i + 1}. tur : ");
    try
    {
        score = int.Parse(Console.ReadLine() ?? "0");
        scores[i] = score;
        totalScore += score;
    }
    catch (FormatException)
    {
        Console.WriteLine("HATA-> Gecersiz bir değer girdiniz.");
        i--;
        continue;
    }
    catch (OverflowException)
    {
        Console.WriteLine("HATA-> Gecersiz bir değer girdiniz.");
        i--;
        continue;
    }
}
int biggestIndex = 0;

for (int i = 1; i < scores.Length; i++)
{
    if (scores[i] > scores[biggestIndex])
    {
        biggestIndex = i;
    }
}
Array.Sort(scores);
System.Console.WriteLine($"Toplam Puan: {totalScore}\n" +
                        $"Ortalama {totalScore / scores.Length}\n" +
                        $"En Yüksek: {scores[scores.Length - 1]} ({biggestIndex + 1}. turda)\n" +
                        $"En Dusuk: {scores[0]}");