int[] steps = new int[7];
int totalSteps = 0;
int targetCounter = 0;
double avgTotalSteps = 0;
for (int i = 0; i < steps.Length; i++)
{
    try
    {
        System.Console.Write($"{i + 1}. gün:  ");
        steps[i] = int.Parse(Console.ReadLine()!);
        if (steps[i] > 0)
        {
            if (steps[i] >= 8000)
            {
                targetCounter++;
            }
            totalSteps += steps[i];
        }
        else
        {
            throw new FormatException();
        }
    }
    catch (FormatException)
    {
        System.Console.WriteLine("Hatali giris yapildi.");
        i--;
    }
}
avgTotalSteps = totalSteps / steps.Length;
string result = avgTotalSteps > 8000 ? "Bu hafta hedefe ulaştınız." : "Bu hafta hedefe ulaşamadınız.";
System.Console.Write(" === HAFTALIK ADIM ===\n" +
                        $"Toplam: {totalSteps}\n" +
                        $"Ortalama: {avgTotalSteps}\n" +
                        $"Hedef üstü gün sayısı: {targetCounter}\n" +
                        result);