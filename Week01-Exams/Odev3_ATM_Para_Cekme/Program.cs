decimal currentAmount = 12500m;
System.Console.WriteLine($" === ATM Bank === \n mevcut Bakiyeniz: {currentAmount}");
System.Console.Write("Çekmek istediğiniz Tutar: ");
decimal withdrawnAmount = int.Parse(Console.ReadLine()!);
decimal accountBalance = currentAmount - withdrawnAmount;
System.Console.WriteLine("İşleminiz Gerçekleşiyor Lütfen Bekleyiniz..");
Thread.Sleep(3000);
System.Console.WriteLine($"İşleminiz tamamlandı. \n {withdrawnAmount} TL çekildi. \n Yeni Bakiyeniz: {accountBalance} TL");
