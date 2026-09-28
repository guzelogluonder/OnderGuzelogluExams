using System.Runtime.InteropServices;

string[] bookNames = new string[12];
string[] memberNames = new string[12];
bool[] isReturnedFlags = new bool[12];
string bookName = "";
string memberName = "";
int recordCount = 0;
int menuChoice = 0;
while (menuChoice != 4)
{
    Console.Clear();
    System.Console.Write("=== KÜTÜPHANE ===\n" +
     "1 - Kitap ödünç ver\n" +
     "2 - Kitap iade al\n" +
     "3 - Kayıtları listele\n" +
     "4 - Çıkış\n" +
     "Seciminiz: ");
    try
    {
        menuChoice = int.Parse(Console.ReadLine() ?? "0");
    }
    catch (FormatException)
    {
        Console.Clear();
        Console.WriteLine("HATA-> Lütfen 1-4 arasında bir değer giriniz.");
        Console.ReadLine();
        continue;
    }
    catch (OverflowException)
    {
        Console.Clear();
        Console.WriteLine("HATA-> Lütfen 1-4 arasında bir değer giriniz.");
        Console.ReadLine();
        continue;
    }
    try
    {
        switch (menuChoice)
        {
            case 1:
                if (recordCount < bookNames.Length)
                {
                    Console.Clear();
                    System.Console.Write("Kitap adi: ");
                    bookName = Console.ReadLine() ?? "";
                    if (bookName != "")
                    {
                        bookNames[recordCount] = bookName;
                    }
                    else
                    {
                        throw new FormatException("Kitap adi bos birakilamaz.");
                    }
                    System.Console.Write("Uye adi: ");
                    memberName = Console.ReadLine() ?? "";
                    if (memberName != "")
                    {
                        memberNames[recordCount] = memberName;
                    }
                    else
                    {
                        throw new FormatException("Uye adi bos birakilamaz.");
                    }
                    isReturnedFlags[recordCount] = false;
                    recordCount++;
                }
                else
                {
                    throw new OutOfMemoryException("Maksimum kayit seviyesine ulasilmitir.");
                }
                break;
            case 2:
                Console.Clear();
                System.Console.Write("Kayıt numarası: ");
                string recordStr = Console.ReadLine()!;
                bool record = int.TryParse(recordStr, out int num);
                if (record && recordCount != 0)
                {
                    if (isReturnedFlags[num - 1])
                    {
                        throw new ArgumentException("Bu kitap zaten iade edilmiş.");
                    }
                    else
                    {
                        isReturnedFlags[num - 1] = true;
                    }
                }
                else
                {
                    throw new ArgumentException("Hata: Böyle bir kayıt yok.");
                }
                break;
            case 3:
                Console.Clear();
                if (recordCount != 0)
                {
                    for (int i = 0; i < recordCount; i++)
                    {
                        string isReturned = isReturnedFlags[i] == true ? "[iade]" : "[ödünçte]";
                        System.Console.Write($"{i + 1}. {isReturned} {bookNames[i]} - {memberNames[i]}\n");
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    throw new ArgumentException("Hata: Kayıtlı kitap bulunmamaktadır.");
                }
                break;
            case 4:
                Console.Clear();
                System.Console.Write("Cikis yapildi.");
                break;
            default:
                Console.Clear();
                System.Console.Write("HATA-> Lütfen 1-4 arasında bir değer giriniz.");
                Console.ReadLine();
                break;
        }
    }
    catch (FormatException ex)
    {
        Console.Clear();
        System.Console.Write(ex.Message);
        Console.ReadLine();
        Console.Clear();
    }
    catch (ArgumentException ex)
    {
        Console.Clear();
        System.Console.Write(ex.Message);
        Console.ReadLine();
        Console.Clear();
    }
    catch (OutOfMemoryException ex)
    {
        Console.Clear();
        System.Console.Write(ex.Message);
        Console.ReadLine();
        Console.Clear();
    }
    catch (IndexOutOfRangeException)
    {
        Console.Clear();
        System.Console.Write("12 adet kayit vardir.");
        Console.ReadLine();
        Console.Clear();
    }
}