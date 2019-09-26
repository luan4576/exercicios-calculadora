using System;

namespace temperatura
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] temperaturas = new double [12];
            double maior=0;
            double menor=0;

        for(int i =0;i <12; i++){
            Console.Write($"digite a temperatura do mes {i+1}:");
            temperaturas[i]= double.Parse(Console.ReadLine());
            }


            maior = temperaturas[0];
            menor = temperaturas[0];

            foreach (double temp in temperaturas)
            {
                if(temp>maior){
                    maior =temp;
                }else if(temp < menor){
                    menor= temp;
                }
            }

            Console.WriteLine($"a maior temperatura é{maior}");
            Console.WriteLine($"a menor temperatura é {menor}");
        }
    }
}
