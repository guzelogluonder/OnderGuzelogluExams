using System.Net;

namespace Odev3_Metotlar.Models;

public class BankAccount
{
    public string OwnerName { get; set; } = string.Empty;
    public decimal Balance { get; set; }

    public void Display()
    {
        System.Console.Write($"Hesap Sahibi: {OwnerName}\n" +
                            $"Bakiye: {Balance} TL");
    }
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
        else
        {
            System.Console.WriteLine("Hata: Tutar pozitif olmalı.");
        }


    }
    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
        }
        else
        {
            System.Console.WriteLine("Yetersiz bakiye.");
        }

    }
    public string GetSummary()
    {
        string summary = $"\nÖzet: {OwnerName} — {Balance} TL\n";
        return summary;
    }
}
