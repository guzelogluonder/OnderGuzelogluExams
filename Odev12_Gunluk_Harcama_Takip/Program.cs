int totalSpend = 0;
string spendingStatus;
for (int i = 1; i <= 5; i++)
{
    System.Console.Write($"{i}. Harcama: ");
    int spendeedMoney = int.Parse(Console.ReadLine()!);
    totalSpend += spendeedMoney;
}
if (totalSpend < 500)
{
    spendingStatus = "Bugün kontrollü harcama yaptınız.";
}
else if (totalSpend >= 500 && totalSpend <= 1000)
{
    spendingStatus = "Bugünkü harcamanız normal seviyede.";
}
else
{
    spendingStatus = "Bugün biraz fazla harcadınız.";
}
System.Console.WriteLine("=== GÜNLÜK HARCAMA === \n" +
                        $"Toplam Harcama: {totalSpend}\n" +
                        $"{spendingStatus}");