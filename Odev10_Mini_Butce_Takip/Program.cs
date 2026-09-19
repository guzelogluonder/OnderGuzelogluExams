decimal incomeAmount = 10000m;
decimal expenseAmount = 6500m;
decimal balance;
int choice = 1;
while (choice >= 1 && choice < 4)
{
    System.Console.Write("=== BÜTÇE TAKİP ===\n" +
                            "1 - Gelir Ekle\n" +
                            "2 - Gider Ekle\n" +
                            "3 - Bakiye Göster\n" +
                            "4 - Çıkış\n\n" +
                            "Seçiminiz: ");
    choice = int.Parse(Console.ReadLine()!);
    Console.Clear();
    switch (choice)
    {
        case 1:
            System.Console.Write("Eklenecek Gelir: ");
            decimal newIncome = decimal.Parse(Console.ReadLine()!);
            incomeAmount += newIncome;
            break;
        case 2:
            System.Console.Write("Eklenecek Gider: ");
            decimal newExpense = decimal.Parse(Console.ReadLine()!);
            expenseAmount += newExpense;
            break;
        case 3:
            balance = incomeAmount - expenseAmount;
            System.Console.Write("=== BÜTÇE ÖZETİ === \n\n" +
                                    $"Toplam Gelir: {incomeAmount}\n" +
                                    $"Toplam Gider: {expenseAmount}\n" +
                                    $"Bakiye: {balance}\n\n");
            if (balance < 0)
            {
                System.Console.WriteLine("Bütçeniz ekside!");
            }
            else if (balance > 0)
            {
                System.Console.WriteLine("Bütçeniz olumlu durumda.");
            }
            else
            {
                System.Console.WriteLine("Bütçeniz dengede.");
            }
            break;
        case 4:
            System.Console.Write("Çıkış yapıldı.");
            break;
    }
    if (choice != 4 && choice < 4)
    {
        System.Console.Write("Devam Etmek İçin Enter'a basın...");
        Console.ReadLine();
        Console.Clear();
    }
    else if (choice > 4)
    {
        System.Console.Write("Geçersiz seçim.");
    }
}
