int[] temperatures = new int[7];
int dayCount = 0;
int coldDay = 0;
int casualDay = 0;
int hotDay = 0;
int totalTempreture = 0;
while (dayCount < temperatures.Length)
{
    try
    {

        switch (dayCount)
        {
            case 0:
                System.Console.Write($"{dayCount + 1}. gün: ");
                temperatures[dayCount] = int.Parse(Console.ReadLine()!);
                break;
            case 1:
                System.Console.Write($"{dayCount + 1}. gün: ");
                temperatures[dayCount] = int.Parse(Console.ReadLine()!);
                break;
            case 2:
                System.Console.Write($"{dayCount + 1}. gün: ");
                temperatures[dayCount] = int.Parse(Console.ReadLine()!);
                break;
            case 3:
                System.Console.Write($"{dayCount + 1}. gün: ");
                temperatures[dayCount] = int.Parse(Console.ReadLine()!);
                break;
            case 4:
                System.Console.Write($"{dayCount + 1}. gün: ");
                temperatures[dayCount] = int.Parse(Console.ReadLine()!);
                break;
            case 5:
                System.Console.Write($"{dayCount + 1}. gün: ");
                temperatures[dayCount] = int.Parse(Console.ReadLine()!);
                break;
            case 6:
                System.Console.Write($"{dayCount + 1}. gün: ");
                temperatures[dayCount] = int.Parse(Console.ReadLine()!);
                break;
            default:
                System.Console.Write("Hatali giris");
                break;
        }
        totalTempreture += temperatures[dayCount];
        dayCount++;

    }
    catch (FormatException)
    {
        System.Console.WriteLine("Lutfen sayi giriniz.");
    }
}
Console.Clear();
for (int i = 0; i < temperatures.Length; i++)
{
    if (temperatures[i] >= 0 && temperatures[i] <= 15)
    {
        System.Console.Write($"{i + 1}. gün:{temperatures[i]} (Soğuk)\n");
        coldDay++;
    }
    else if (temperatures[i] >= 16 && temperatures[i] <= 25)
    {
        System.Console.Write($"{i + 1}. gün:{temperatures[i]} (Normal)\n");
        casualDay++;
    }
    else
    {
        System.Console.Write($"{i + 1}. gün:{temperatures[i]} (Sıcak)\n");
        hotDay++;
    }
}
System.Console.Write($"Soğuk Gün: {coldDay}\n" +
                        $"Normal Gün: {casualDay}\n" +
                        $"Sıcak Gün: {hotDay}\n\n" +
                        $"Haftalık Ortalama: {totalTempreture / temperatures.Length} °C");