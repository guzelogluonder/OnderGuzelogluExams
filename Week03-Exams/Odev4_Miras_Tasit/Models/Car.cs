namespace Odev4_Miras_Tasit.Models;

public class Car : Vehicle
{
    public string Model { get; set; } = string.Empty;
    public int Year { get; set; }

    public override void Display()
    {
        base.Display();
        System.Console.Write($" {Model} ({Year})\n");
    }

}
