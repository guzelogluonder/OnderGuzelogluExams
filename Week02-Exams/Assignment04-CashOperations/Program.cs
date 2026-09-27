string[] descriptions = new string[10];
decimal[] amounts = new decimal[10];
bool[] isIncomeFlags = new bool[10];
string isIncome = "";
int transactionCount = 3;
decimal totalIncome = 0m;
decimal totalExpense = 0m;
decimal balance = 0m;
string balanceStatus = "";
String response = "";

for (int i = 0; i < transactionCount; i++)
{
    try
    {
        System.Console.Write("Açıklama: ");
        string desc = Console.ReadLine() ?? "";
        if (string.IsNullOrEmpty(desc))
        {
            throw new Exception("Açıklama boş bırakılamaz.");
        }
        else
        {
            descriptions[i] = desc;
        }
        System.Console.Write("Tutar: ");
        decimal amount = decimal.Parse(Console.ReadLine()!);
        if (amount < 0)
        {
            throw new IndexOutOfRangeException("Hata: Tutar pozitif olmalı.");
        }
        else
        {
            System.Console.Write("Gelir mi gider mi?  (G / I — Gelir / Gider): ");
            string isIncomeFlag = Console.ReadLine()!;
            descriptions[i] = desc;
            amounts[i] = amount;
            if (isIncomeFlag == "G" || isIncomeFlag == "Gelir")
            {
                isIncomeFlags[i] = true;
                totalIncome += amount;
            }
            else if (isIncomeFlag == "I" || isIncomeFlag == "Gider")
            {
                isIncomeFlags[i] = false;
                totalExpense += amount;
            }
            else
            {
                throw new FormatException();
            }
        }
    }
    catch (FormatException)
    {
        System.Console.WriteLine("Hatali karakter girdiniz.");
        i--;
    }
    catch (IndexOutOfRangeException ex)
    {
        System.Console.WriteLine(ex.Message);
        i--;
    }
    catch (Exception ex)
    {
        System.Console.WriteLine(ex.Message);
        i--;
    }

}
for (int i = 0; i < transactionCount; i++)
{
    if (isIncomeFlags[i])
    {
        isIncome = "[Gelir]";
    }
    else
    {
        isIncome = "[Gider]";
    }
    response += $"{i + 1}. {isIncome} {descriptions[i]} {amounts[i]} TL\n";
}

balance = totalIncome - totalExpense;
balanceStatus = balance < 0 ? "UYARI: Kasa ekside!" : $"Kalan: {balance} TL";

System.Console.WriteLine("\n=== KAYITLI ISLEMLER ===\n" +
                        response +
                        $"\nToplam Gelir : {totalIncome} TL\n" +
                        $"Toplam Gider: {totalExpense} TL\n" +
                        balanceStatus);