using System;
using System.Net;
namespace DoWhile;
class Program{
    public static void Main(string[] args)
    {
        bool temp = true;
        string user = "yes";
        do{
  
            if(user=="yes"){
                int num = int.Parse(Console.ReadLine());
                if(num%2==0){
                    Console.WriteLine("Even");
                }
                else{
                    Console.WriteLine("Odd");
                }
                Console.WriteLine("yes or no");
            user = Console.ReadLine();


            }
            else if(user=="no"){
                break;
            }
            else{
                Console.WriteLine("Enter valid input");
            user = Console.ReadLine();

            }
            
           
        }while(temp);

       
    }
}