using System;

namespace par_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num;
        
            do{


            Console.WriteLine("escolha um numero");
            num=int.Parse(Console.ReadLine());
           
            if(num % 2 == 0){

             Console.WriteLine("o numero é par");
            }
                else{
                 Console.WriteLine("o numero e impar" );
             }
            }while(num !=0);



        }
    }
}
