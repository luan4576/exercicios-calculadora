using System;

namespace programa_menu
{
    class Program
    {
        static void Main(string[] args)
        {

            double  n1;
            double  n2;
            double  n3;
            double area;
            string menu="";

            Console.WriteLine("calcule as formas geometricas");
            Console.WriteLine("1-circulo");
            Console.WriteLine("2-quadrado");
            Console.WriteLine("3-retangulo");
            Console.WriteLine("4-triangulo");
            Console.WriteLine("5-losangulo");
            Console.WriteLine("6-trapezio");
            Console.WriteLine("fim para terminar");
            menu=Console.ReadLine();


            switch (menu) {
                case "1":
                 Console.WriteLine("qual o raio da circuferencia?");
                 double n1 = Parse(Console.ReadLine());
                 double area =3.14*n1*n1;
                  Console.WriteLine("a area da circuferencia é" + area);
                break;
                case "2":
                 Console.WriteLine("qual o lado do quadrado?");
                 double n1=double.Parse(Console.ReadLine());
                 double area =*n1*n1;
                  Console.WriteLine("a area do quadrado é" + area);

            }
        }
    }
}
