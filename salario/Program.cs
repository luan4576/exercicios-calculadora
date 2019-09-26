using System;

namespace salario
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            double aumento;

            Console.WriteLine("qual o seu salario");
            salario= double.Parse(Console.ReadLine());

            if (salario <500) {
                aumento = salario * 0.3;
                salario += aumento;
                Console.WriteLine("parabens voce ganhou o aumento");
                Console.WriteLine("seu novo salario é" + salario);

            }else {
                Console.WriteLine("descupe sem almento para voce");
            }
        }
    }
}
