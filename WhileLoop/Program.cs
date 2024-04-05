using System;
namespace WhileLoop;
class Project{
    public static void Main(string[] args)
    {
        int i=0;
        while(i<=25){
            if(i%2==0)
            {
                Console.WriteLine(i);
              
            }
              i++;
        }
        Console.Write("Enter a number:");
        bool isValid = int.TryParse(Console.Readline(),out int output);
        while(!isValid){
            Console.Write("Invalid Number.Enter Again:");
            isValid = int.TryParse(Console.ReadLine(),out output);
        }
        

    }
}
