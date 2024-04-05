using System;
namespace Switch;
class Program{
    public static void Main(string[] args)
    {
       int physics,chemistry,maths;
                physics=int.Parse(Console.ReadLine());
                
                chemistry=int.Parse(Console.ReadLine());
                
                maths=int.Parse(Console.ReadLine());
                int sum = physics+chemistry+maths;
                
                int percentage =(sum/300)*100;
                Console.WriteLine("Sum:"+sum);
                Console.WriteLine("Percentage:"+percentage);
           
    }

} 