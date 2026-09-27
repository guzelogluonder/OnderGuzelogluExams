int[] grades = new int[5];
for (int i = 0; i < grades.Length; i++)
{
    try
    {
        grades[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        System.Console.WriteLine("Hata: Lütfen geçerli bir sayı girin.");
        i--;
    }
}
for (int i = 0; i < grades.Length; i++)
{
    System.Console.WriteLine(grades[i]);
}