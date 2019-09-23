using System;

namespace faixa_etaria
{
    class Program
    {
        static void Main(string[] args)
      {
          int anoatual = 2019;
          int anonasc = 0;
          int idade;
          Console.WriteLine("qual o ano de nascimento?");
          anonasc = int.Parse(Console.ReadLine());
          idade = anoatual - anonasc;

          Console.WriteLine("sua idade atual é de"+ idade + "anos");

          if (idade <=2){
              Console.WriteLine("voce é um rescem nascido");
          }else if ((idade>=3) && (idade <=11)){
               Console.WriteLine("voce é uma criança");
          }else if ((idade>=12) && (idade <=19)){
               Console.WriteLine("voce é um adolescente");
          }else if ((idade>=20) && (idade <=65)){
               Console.WriteLine("voce é um adulto");
          }else if (idade>=60){
               Console.WriteLine("voce é um idoso");
               }
      }
    }
}


