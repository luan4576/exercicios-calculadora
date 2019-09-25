using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("alt do trian");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("qt de tr");
            int c = int.Parse(Console.ReadLine());

            for (int i=0;i<c;i++){
                string estrelas ="";

                for (int j=0;j<=a;j++) {
                   estrelas +="*";
                        Console.WriteLine(estrelas);
                    }
                  
                }                
            }

        }
    }

