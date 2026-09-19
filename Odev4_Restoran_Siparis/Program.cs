int menuChoice = 1;
int piece = 0;
while (menuChoice >= 1 && menuChoice <= 5)
{

    System.Console.Write(" === RESTORAN MENUSU === \n " +
                            "1 - Hamburger      250 TL\n " +
                            "2 - Pizza          300 TL\n " +
                            "3 - Makarna        200 TL\n " +
                            "4 - Salata         120 TL\n " +
                            "5 - Çıkış \n" +
                            "Seciminiz: ");
    menuChoice = int.Parse(Console.ReadLine()!);

    if (menuChoice < 5)
    {
        System.Console.Write("Adet: ");
        piece = int.Parse(Console.ReadLine()!);

        int totalPrice = 0;
        Console.Clear();
        switch (menuChoice)
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
        }
        System.Console.Write("Ana menüye dönmek için Enter'a basınız");
        Console.ReadLine();
        Console.Clear();
        System.Console.Write("Yeni Secim --> 1 \n Cikis --> 5 \n Seciminiz: ");
        menuChoice = int.Parse(Console.ReadLine()!);
        Console.Clear();
    }
    if (menuChoice == 5)
    {
        Console.Clear();
        System.Console.Write("Cikis Yaptiniz.");
        break;
    }
    else if (menuChoice != 1 && menuChoice != 5)
    {
        Console.Clear();
        System.Console.Write("Yanlis Secim Yaptiniz Lütfen Tekrar Deneyiniz. \n Yeni Secim --> 1 \n Cikis --> 5 \n Seciminiz:  ");
        Console.ReadLine();
        Console.Clear();
    }
}
if (menuChoice != 5)
{
    Console.Clear();
    System.Console.WriteLine("Yanlış seçim yaptınız. Çıkış yapıldı.");
}
