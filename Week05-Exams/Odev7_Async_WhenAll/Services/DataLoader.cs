namespace Odev7_Async_WhenAll.Services;

public class DataLoader
{
    public async Task<string> LoadUserNameAsync()
    {
        await Task.Delay(800);
        return "bekleme tamamlandi.";
    }

    public async Task<int> LoadOrderCountAsync()
    {
        await Task.Delay(1200);
        return 1200;
    }

    public async Task<decimal> LoadBalanceAsync()
    {
        await Task.Delay(1000);
        return 15.55m;
    }


}
