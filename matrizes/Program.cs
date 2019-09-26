using System;

namespace matrizes
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int[] vetor = new int [6];
            int pares =0;
            int impares = 0;


            for (int cont =0; cont <6; cont++){
            Console.WriteLine("digite 6 numeros");
            vetor[cont]= int.Parse(Console.ReadLine());

            }
            
            foreach(int num in vetor)
        {
                if(num%2 == 0){
                    pares += 1;
                    //pares=pares +1;
                    // pares +=1;
                }else {
                    impares++;
                }
        }
                Console.WriteLine($"voce tem {pares}numeros pares e {impares}numeros impares");
                

        }
    }
}
