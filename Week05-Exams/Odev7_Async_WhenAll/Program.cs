using System.Diagnostics;
using Odev7_Async_WhenAll.Services;

namespace Odev7_Async_WhenAll;

class Program
{
    public static async Task Main()
    {
        DataLoader loader = new();

        Stopwatch stopwatch = Stopwatch.StartNew();

        string userName = await loader.LoadUserNameAsync();
        int orderCount = await loader.LoadOrderCountAsync();
        decimal balance = await loader.LoadBalanceAsync();
        stopwatch.Stop();
        System.Console.WriteLine("=== SIRALI ===");
        System.Console.WriteLine($"Kullanici: {userName} | Siparis: {orderCount} | Bakiye: {balance:N2} TL");
        System.Console.WriteLine($"Sure: {stopwatch.ElapsedMilliseconds} ms");

        Stopwatch stopwatchTask = Stopwatch.StartNew();

        Task<string> userTask = loader.LoadUserNameAsync();
        Task<int> orderTask = loader.LoadOrderCountAsync();
        Task<decimal> balanceTask = loader.LoadBalanceAsync();
        await Task.WhenAll(userTask, orderTask, balanceTask);

        stopwatchTask.Stop();

        string userNameTask = await userTask;
        int taskOrder = await orderTask;
        decimal taskBalance = await balanceTask;

        System.Console.WriteLine("\n === PARALEL ===");
        System.Console.WriteLine($"Kullanici: {userName} | Siparis: {orderCount} | Bakiye: {balance:N2} TL");
        System.Console.WriteLine($"Sure: {stopwatchTask.ElapsedMilliseconds} ms");

        // Task.WhenAll kullanildiginda bagimsiz asenkron islemler birlikte baslatilip tamamlanmalari beklenir.
        /// Hayir async metot CPU yogun isleri otomatik olarak baska bir thread'e tasimaz. async/await, özellikle I/O işlemlerinde thread'i bloke etmeden beklemeyi sağlar.

    }
}
