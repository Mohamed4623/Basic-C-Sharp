using System;
namespace ForLoop;
class Project{
    public static void Main(string[] args)
    {
        int result,sum=0;
        Console.WriteLine("Enter the Two numbers:");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        for(int i= num1; i<=num2;i++){
            
            result=i*i;
            sum=sum+result;
        }
          Console.WriteLine(sum);
    }
}