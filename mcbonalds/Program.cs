using System;

namespace MCbonalds
{
    class Program
    {
        static void Main(string[] args)
        {
        cliente cliente1 = new cliente("luan","55 11 5555-5555","luan@email.com");

        Console.WriteLine("Nome:"+cliente1.Nome);
        Console.WriteLine("Telefone :"+cliente1.Telefone);
        Console.WriteLine("Email :"+cliente1.Email);
        }
    }
}
