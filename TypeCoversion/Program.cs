using System;
using System.Xml.Schema;
namespace TypeConversion;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name:");
        string name = Console.ReadLine();
        Console.Write("Enter age:");
        int age = int.Parse(Console.ReadLine());
        Console.Write("enter mark of subject1:");
        double subject1 = double.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject2:");
        double subject2 = double.Parse(Console.ReadLine());
        Console.Write("Enter the subject3:");
        double subject3 = double.Parse(Console.ReadLine());
        Console.Write("Enter Grade:");
        char grade = char.Parse(Console.ReadLine());
        Console.Write("Enter mobile number:");
        long num = long.Parse(Console.ReadLine());
        Console.Write("Enter Mail id:");
        string mail = Console.ReadLine();
        double Total = (subject1+subject2+subject3);
        double Average = ((subject1+subject2+subject3)/3);

        Console.WriteLine("       ");
        Console.WriteLine("Trainee Details Are:");
        Console.WriteLine("Name: "+ name);
        Console.WriteLine("Age: "+ age);
        Console.WriteLine("Mobile: "+ num);
        Console.WriteLine("Marks1: "+ subject1);
        Console.WriteLine("Marks2:" + subject2);
        Console.WriteLine("Marks3:" + subject3);
        Console.WriteLine("Total: " + Total);
        Console.WriteLine("Average: "+ Average);
        Console.WriteLine("Grade: "+ grade);
        Console.WriteLine("Mail id: "+ mail);





    }
}
