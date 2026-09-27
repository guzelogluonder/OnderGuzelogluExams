decimal grade;
decimal avg = 0m;
string gradeStr = "";
decimal[] grades = new decimal[5];
for (int i = 0; i < grades.Length; i++)
{
    try
    {
        System.Console.Write($"{i + 1}. not: ");
        grade = decimal.Parse(Console.ReadLine()!);
        if (grade >= 0 && grade <= 100)
        {
            grades[i] = grade;
            avg += grade;
        }
        else
        {
            throw new ArithmeticException("Hata: Not 0 ile 100 arasında olmalı.");
        }
    }
    catch (FormatException)
    {
        System.Console.WriteLine("Hata: Lütfen geçerli bir sayı girin.");
        i--;
    }
    catch (ArithmeticException ex)
    {
        System.Console.WriteLine(ex.Message);
        i--;
    }
}
for (int i = 0; i < grades.Length; i++)
{
    gradeStr += $"{i + 1}. {grades[i]} \n";
}
Array.Sort(grades);
System.Console.WriteLine("\n === NOT LISTESI ===\n" +
                        gradeStr +
                         $"\nOrtalama: {avg / grades.Length}\n" +
                        $"En Yüksek: {grades[grades.Length - 1]}\n" +
                        $"En Düşük: {grades[0]}");