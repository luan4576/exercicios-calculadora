using System;

namespace byte_bank {
    class Program {
        static void Main (string[] args) {
        

            System.Console.WriteLine ($"cadastro de clientes");
            System.Console.WriteLine ();
            System.Console.Write ("nome:");
            string nome = Console.ReadLine ();
            System.Console.Write ("cpf: ");
            string cpf = Console.ReadLine ();
            System.Console.Write ("email: ");
            string Email = Console.ReadLine ();

            cliente cliente1 = new cliente (nome, cpf, Email);

            bool trocousenha = false;
            do {
                System.Console.Write ("digite a senha ");
                string senha = Console.ReadLine ();
                trocousenha =cliente1.TrocaSenha(senha);
                if (!trocousenha) {
                    System.Console.WriteLine ("senha nao atende aos requisitos");
                } else {
                    System.Console.WriteLine ("senha trocada com sucesso");
                }
            } while (!trocousenha);

            System.Console.WriteLine ("conta corrente");
            System.Console.WriteLine ();

            System.Console.WriteLine ("Agencia:");
            int Agencia = int.Parse (Console.ReadLine ());

            System.Console.WriteLine (" Conta:");
            int Numeros = int.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Titular:");
            string Titular = Console.ReadLine ();

            bool SaldoValido = false;
            double saldo;
            do {
                System.Console.Write ("Digite o saldo ");
                saldo = double.Parse (Console.ReadLine ());
                if (saldo > 0) {
                    SaldoValido = true;
                } else {
                    System.Console.WriteLine ("o saldo nao pode ser negativo");
                }
            } while (!SaldoValido);

            ContaCorrente contaCorrente = new ContaCorrente (Agencia, Titular, Numeros);
            contaCorrente.Saldo = saldo;
        }

    }
}