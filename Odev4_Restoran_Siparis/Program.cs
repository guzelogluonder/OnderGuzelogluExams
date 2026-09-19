System.Console.Write(" === RESTORAN MENUSU === \n " +
                        "1 - Hamburger      250 TL\n " +
                        "2 - Pizza          300 TL\n " +
                        "3 - Makarna        200 TL\n " +
                        "4 - Salata         120 TL\n " +
                        "5 - Çıkış \n" +
                        "Seciminiz: ");
int menuChoise = int.Parse(Console.ReadLine()!);
if (menuChoise >= 1 && menuChoise <= 5)
{   
    System.Console.Write("Adet: ");
    int piece = int.Parse(Console.ReadLine()!);
    int totalPrice = 0;
    Console.Clear();
    switch (menuChoise)
    {
        case 1:
            totalPrice = 250 * piece;
            System.Console.WriteLine($"Ürün: Hamburger \n" +
                    $"Birim Fiyat: 250 TL \nAdet: {piece} \nToplam: {totalPrice} TL");
            break;
        case 2:
            totalPrice = 300 * piece;
            System.Console.WriteLine($"Ürün: Pizza\n" +
                        $"Birim Fiyat: 300 TL \nAdet: {piece} \nToplam: {totalPrice} TL");
            break;
        case 3:
            totalPrice = 200 * piece;
            System.Console.WriteLine($"Ürün: Makarna\n" +
                    $"Birim Fiyat: 200 TL \nAdet: {piece} \nToplam: {totalPrice} TL");
            break;
        case 4:
            totalPrice = 120 * piece;
            System.Console.WriteLine($"Ürün: Salata\n" +
                    $"Birim Fiyat: 120 TL \nAdet: {piece} \nToplam: {totalPrice} TL");
            break;
        case 5:
            System.Console.WriteLine("Çıkış Yaptınız.");
            break;
    }
}
else
{
    System.Console.WriteLine("Gecersiz menu secimi.");
}
