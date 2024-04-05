using System;
namespace TimeDate;
class Program{
    public static void Main(string[] args)
    {
        DateTime creation = new DateTime(2021,8,10,10,40,32);
        Console.WriteLine(creation.ToString("yyyy"));
        Console.WriteLine(creation.ToString("MM"));
        Console.WriteLine(creation.ToString("dd"));
        Console.WriteLine(creation.ToString("hh"));
        Console.WriteLine(creation.ToString("mm"));
        Console.WriteLine(creation.ToString("ss"));



    }
}
