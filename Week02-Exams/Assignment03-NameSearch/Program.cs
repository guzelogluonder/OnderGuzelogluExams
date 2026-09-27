string[] names = { "Ayşe", "Mehmet", "Zeynep", "Ali", "Elif" };
string name = "";
while (name != "çıkış")
{
    bool isExists = false;
    try
    {
        System.Console.Write("Aranacak Isim: ");
        name = Console.ReadLine()!;
        for (int i = 0; i < names.Length; i++)
        {

            if (names[i] == name)
            {
                System.Console.WriteLine($"{name} listede bulundu. Sıra: {i + 1}");
                isExists = true;
            }
        }
        if (name != "çıkış" && isExists == false)
        {
            throw new Exception("Bu isim listede yok.");

        }
    }
    catch (Exception ex)
    {
        System.Console.WriteLine(ex.Message);
    }

}
System.Console.WriteLine("Çıkış yapıldı.");