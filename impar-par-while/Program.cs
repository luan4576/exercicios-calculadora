using System;

namespace impar_par_while
{
    class Program
    {
        static void Main(string[] args)
        {
                int num =1;
                while(num !=0){

            


            Console.WriteLine("escolha um numero");
            num=int.Parse(Console.ReadLine());

            if(num % 2 == 0){

             Console.WriteLine("o numero é par");
            }
                else{
                 Console.WriteLine("o numero e impar" );
             }
                }
            
        }
    }
}
        
    
