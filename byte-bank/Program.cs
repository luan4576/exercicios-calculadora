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

            // System.Console.WriteLine ("Titular:");
            //string Titular = Console.ReadLine ();

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

            ContaCorrente contaCorrente = new ContaCorrente (Agencia, cliente1, Numeros);
            contaCorrente.Saldo = saldo;

            System.Console.WriteLine("byte-bank - Deposito");
            cliente usuario = contaCorrente.Titular;
            System.Console.WriteLine($"Bem vindo - {usuario.Nome}");
            System.Console.WriteLine($"agencia:{contaCorrente.Agencia} conta:{contaCorrente.Numeros}");
            System.Console.WriteLine($"saldo {contaCorrente.Saldo}");
            System.Console.WriteLine("digite o valor do deposito");
            double valor =double.Parse( Console.ReadLine());
            contaCorrente.Deposito(valor);

            Console.WriteLine("ByteBank - saque");
            System.Console.Write("qual o valor do saque?");
            valor = double.Parse(Console.ReadLine());
            if(contaCorrente.Saque(valor)){
                System.Console.WriteLine("saque realizado com sucesso, retire as notas");
            }else{
                System.Console.WriteLine("Nao foi possivel realizar a operaçao ");
            }
            System.Console.WriteLine();

            System.Console.WriteLine("bytebank - Tranferencia");
            System.Console.Write("digite o valor da transferencia:");
            valor = double.Parse(Console.ReadLine());
            cliente cliente2 =new cliente("Luan","123.456.789","vfgv@ttt.com");
            
            ContaCorrente contaCorrente2 = new ContaCorrente (123,cliente2,132);

            if (contaCorrente.Trasferencia(contaCorrente2,valor)){
                System.Console.WriteLine("transferencia efetuada com sucesso");
            }else{
                System.Console.WriteLine("operaçao nao pode ser realizada");
            }
            System.Console.WriteLine($"saldo origem:{contaCorrente.Saldo}");
            System.Console.WriteLine($"saldo destino: {contaCorrente2.Saldo}");
            

        }

    }
}