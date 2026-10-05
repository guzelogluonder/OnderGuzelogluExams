using System.Runtime.InteropServices;
using Odev3_Metotlar.Models;

namespace Odev3_Metotlar;

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new()
        {
            OwnerName = "Ali",
            Balance = 5000
        };

        account.Deposit(2000);
        account.Withdraw(1500);
        account.Withdraw(10000);
        account.Deposit(-50);
        account.Display();
        System.Console.WriteLine(account.GetSummary());
    }
}
