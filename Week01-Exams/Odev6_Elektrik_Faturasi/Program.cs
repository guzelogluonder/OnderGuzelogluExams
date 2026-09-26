System.Console.Write("Elektrik tüketiminiz: ");
int usedElektricity = int.Parse(Console.ReadLine()!);
int remaining;
decimal totalBill;
if (usedElektricity <= 150)
{
    totalBill = usedElektricity * 2;
}
else if (usedElektricity >= 151 && usedElektricity <= 300)
{
    totalBill = 150 * 2;
    remaining = usedElektricity - 150;
    totalBill += remaining * 3;
}
else
{
    totalBill = 150 * 2;
    remaining = usedElektricity - 150;
    totalBill += remaining * 4;
}
System.Console.WriteLine(" === ELEKTRIK FATURASI === \n" +
                         $"Tüketim: {usedElektricity}\n" +
                         $"Toplam Tutar: {totalBill} TL");