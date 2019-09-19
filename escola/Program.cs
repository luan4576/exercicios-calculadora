using System;

namespace escola
{
    class Program
    {
        static void Main(string[] args)
        {
            double  nota1,nota2,nota3,nota4,media;
            
            Console.WriteLine("entre a primeira nota:");
            nota1=double.parse(Console.ReadLine());

              Console.WriteLine("entre a segunda nota:");
            nota2=double.parse(Console.ReadLine());

              Console.WriteLine("entre a terceira nota:");
            nota3=double.parse(Console.ReadLine());

              Console.WriteLine("entre a quarta nota:");
            nota4=double.parse(Console.ReadLine());

            Media = (nota1,nota2,nota3,nota4 ) /4;

            if (media>=7.0) {
                Console.WriteLine("parabens vc foi aprovado");

            }else{
                Console.WriteLine("tente novamente");
            }
            Console.WriteLine("a media é:" + media);
            
        }
    }
}
