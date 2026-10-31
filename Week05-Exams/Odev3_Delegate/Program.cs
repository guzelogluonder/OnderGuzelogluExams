using Odev3_Delegate.Services;

namespace Odev3_Delegate;

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        int sum = calculator.Execute(Add, 10, 5);

        int substract = calculator.Execute((a, b) => a - b, 10, 5);

        int multiply = calculator.Execute((a, b) => a * b, 10, 5);

        int max = calculator.Execute((a, b) => a > b ? a : b, 10, 5);

        Func<decimal, decimal, decimal> calculateKDV = (price, kdvRate) => price + (price * kdvRate / 100);

        Action<string> printMessage = message => Console.WriteLine($"Mesaj: {message}");


        Predicate<int> isHigher = age => age >= 18;

        bool isStudent = true;

        Func<decimal, decimal> priceRule;

        if (isStudent)
        {
            priceRule = price => price * 0.80m;
        }
        else
        {
            priceRule = price => price * 0.90m;
        }


        System.Console.WriteLine($"Toplam: {sum}");
        System.Console.WriteLine($"Fark: {substract}");
        System.Console.WriteLine($"Carpim: {multiply}");
        System.Console.WriteLine($"Buyuk Olan: {max}");
        System.Console.WriteLine($"KDV Dahil: {calculateKDV(15000m, 15m)} TL");
        printMessage("İşlem tamamlandı");
        System.Console.WriteLine($"Yaşı uygun mu: {isHigher(21)}");
        System.Console.WriteLine($"Öğrenci fiyatı: {priceRule(1000m)} TL");
    }
    static int Add(int left, int right)
    {
        return left + right;
    }
}
