using System;
namespace MethodTrail;
class Program{
    public static void Main(string[] args)
    {
         string choice;
         do{
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subraction");
            Console.WriteLine("3.Multiply");
            Console.WriteLine("4.Division");
            int operation = int.Parse(Console.ReadLine());
            switch(operation)
            {
                case 1:{
                    Console.WriteLine($"Result:{Addition(num1,num2)}");
                    break;
                }
                case 2:{
                    Console.WriteLine($"Result:{Subraction(num1,num2)}");
                    break;
                }
                case 3:{
                    Console.WriteLine($"Result:{Multiply(num1,num2)}");
                    break;
                }
                case 4:{
                    Console.WriteLine($"Result:{Division(num1,num2)}");
                    break;
                }
                default:{
                    Console.WriteLine("Invalid choice");
                    break;
                }
            }
            static double Addition(double num1,double num2){
                return num1+num2;
            }
            static double Subraction(double num1,double num2){
                return num1-num2;
            }
            static double Multiply(double num1,double num2){
                return num1*num2;
            }
            static double Division(double num1,double num2){
                return num1/num2;
            }

        }
        
      

    }
     
}
