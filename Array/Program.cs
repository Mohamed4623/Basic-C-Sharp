using System;
namespace Array;
class Program{
    public static void Main(string[] args)
    {
        bool temp = true;
        string[] names = new string[]{"Mani","Ganesh","Venkat","Suresh","Venkat"};
        for(int i = 0;i<names.Length;i++){
            Console.WriteLine(names[i]);

        }
        string user = "Venkat";
        for(int i =0;i<names.Length;i++){
            
            if(names[i] ==user){
                
                temp=false;
                Console.WriteLine("The name is present");

            }
            
            }if(temp==true){
                
            
                Console.WriteLine("The name is not present in the array");
            }
            /*foreach(string i in names){
            if(i==user){

                 temp=true;
                Console.WriteLine("The name is present");

               
            }
            
            }if(temp==false){
                
            
                Console.WriteLine("The name is not present in the array");
            }*/
    }
            
        }


