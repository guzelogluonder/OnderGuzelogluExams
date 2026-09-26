System.Console.Write("Çalışan: ");
string employeeName = Console.ReadLine()!;
System.Console.Write("Mevcut Maaş: ");
decimal currentSalary = int.Parse(Console.ReadLine()!);
System.Console.Write("Çalışma Süresi: ");
int workYear = int.Parse(Console.ReadLine()!);
int raiseRatio;
decimal raiseAmount;
decimal newSalary;
if (workYear >= 0 && workYear <= 2)
{
    raiseRatio = 10;
    raiseAmount = currentSalary * 10 / 100;
    newSalary = currentSalary + raiseAmount;
}
else if (workYear >= 3 && workYear <= 5)
{
    raiseRatio = 15;
    raiseAmount = currentSalary * 15 / 100;
    newSalary = currentSalary + raiseAmount;

}
else if (workYear >= 6 && workYear <= 10)
{
    raiseRatio = 20;
    raiseAmount = currentSalary * 20 / 100;
    newSalary = currentSalary + raiseAmount;
}
else
{
    raiseRatio = 25;
    raiseAmount = currentSalary * 25 / 100;
    newSalary = currentSalary + raiseAmount;
}
Console.Clear();
System.Console.Write("=== Maaş Bilgisi === \n\n" +
                        $"Çalışan: {employeeName}\n" +
                        $"Mevcut Maaş: {currentSalary} TL\n" +
                        $"Çalışma Süresi: {workYear} Yıl\n\n" +
                        $"Zam Orani: %{raiseRatio}\n" +
                        $"Zam Tutari: {raiseAmount} TL\n" +
                        $"Yeni Maaş: {newSalary} TL");