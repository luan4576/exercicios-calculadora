using System;

namespace byte_bank
{
    class Program
    {
        static void Main(string[] args)
        {
            string  digite;

            System.Console.WriteLine($"cadastro de clientes");
            System.Console.WriteLine();
            System.Console.Write("nome:");
            string nome = Console.ReadLine();
            System.Console.Write("cpf: ");
            string cpf = Console.ReadLine();
            System.Console.Write("email: ");
            string Email = Console.ReadLine();
            
            cliente cliente1 = new cliente(nome,cpf,Email);

                bool trocousenha = false;
            do{
                System.Console.Write("digite a senha ");
                string senha = Console.ReadLine();
                if (!trocousenha){
                    System.Console.WriteLine("senha nao atende aos requisitos");
                }else{
                    System.Console.WriteLine("senha trocada com sucesso");
                }
            }while(!trocousenha);
            
            }
        }
    }

