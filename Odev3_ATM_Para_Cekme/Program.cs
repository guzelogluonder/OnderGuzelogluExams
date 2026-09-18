int currentAmount = 12500;
System.Console.WriteLine($" === ATM Bank === \n mevcut Bakiyeniz: {currentAmount}");
System.Console.Write("Çekmek istediğiniz Tutar: ");
int withdrawnAmount = int.Parse(Console.ReadLine()!);
int accountBalance = currentAmount - withdrawnAmount;
System.Console.WriteLine("İşleminiz Gerçekleşiyor Lütfen Bekleyiniz..");
Thread.Sleep(3000);
System.Console.WriteLine($"İşleminiz tamamlandı. \n {withdrawnAmount} TL çekildi. \n Yeni Bakiyeniz: {accountBalance} TL");
