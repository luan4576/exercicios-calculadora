using System;

namespace loogin_senha
{
    class Program
    {
        static void Main(string[] args)
        {

        string login;
        string senha;


            Console.WriteLine("login");
            login=(Console.ReadLine());
           

            Console.WriteLine("senha");
           
            senha=(Console.ReadLine());


       if ((login=="adm")&&(senha=="adm")){
       Console.WriteLine("bem-vindo adm");
       }else{
           Console.WriteLine("bem vindo usuario");
       }

       }

        }
    }

