using System;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            string oper;




            Console.WriteLine("digite o 1 numero:");
            num1 = int.Parse (Console.ReadLine());
            Console.WriteLine("digite o 2 numero");
            num2 = int.Parse (Console.ReadLine());
            Console.WriteLine("qual o operador desejado?");
            oper =  Console.ReadLine();

            
          



            switch (oper) {
                case "+":
                Console.WriteLine($"{num1}+{num2} = {num1 + num2}");
                break;

                  case "-":
                Console.WriteLine($"{num1}-{num2} = {num1 - num2}");
                break;

                  case "*":
                Console.WriteLine($"{num1}*{num2} = {num1 * num2}");
                break;
                  case "/":
                Console.WriteLine($"{num1}/{num2} = {num1 / num2}");
                break;
                
                  case "%":
                Console.WriteLine($"{num1}%{num2} = {num1 % num2}");
                break;
                
                default:
                    Console.WriteLine("operaçao nao reconhecida");
                    break;


            }
        }
    }
}
