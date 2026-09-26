System.Console.WriteLine("=== Sınav Sonucu Hesaplama Robotu === \n");
System.Console.Write("Öğrenci Adı: ");
string studentName = Console.ReadLine()!;
System.Console.Write("Vize Notu: ");
int midtermGrade = int.Parse(Console.ReadLine()!);
System.Console.Write("Final Notu: ");
int finalGrade = int.Parse(Console.ReadLine()!);
decimal averageGrade = (midtermGrade * 40 / 100) + (finalGrade * 60 / 100);
string letterGrade = "";
string passOrFail = "";

if (averageGrade >= 0 && averageGrade <= 49)
{
    letterGrade = "FF";
} 
else if (averageGrade >= 50 && averageGrade <= 59)
{
    letterGrade = "CC";
}
else if (averageGrade >= 60 && averageGrade <= 69)
{
    letterGrade = "CB";
}
else if (averageGrade >= 70 && averageGrade <= 79)
{
    letterGrade = "BB";
}
else if (averageGrade >= 80 && averageGrade <= 89)
{
    letterGrade = "BA";
}
else
{
    letterGrade = "AA";
}

if(averageGrade >= 50)
{
    passOrFail = "Geçtiniz.";
}
else
{
    passOrFail = "Kaldiniz.";
}
System.Console.WriteLine($"=== ÖĞRENCİ SONUCU === \n Öğrenci: {studentName} \n"+ 
$" Vize: {midtermGrade} \n Final: {finalGrade} \n Ortalama: {averageGrade} \n Harf Notu: {letterGrade} \n Sonuç: {passOrFail}");