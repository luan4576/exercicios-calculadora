using System;
using ByteBank2.Models;

namespace ByteBank2
{
    class Program
    {
        static void Main(string[] args)
        {
            string cliente1 = "Alexandre";
            string cliente2 = "cesar";

            #region Testa Conta Corrente
            ContaCorrente contaCorrente1 = new ContaCorrente(1, 1, cliente1);
            ContaCorrente contaCorrente2= new ContaCorrente(1, 2, cliente2);
            DepositarConta(contaCorrente1);
            DepositarConta(contaCorrente2);
            SacarConta(contaCorrente1);
            SacarConta(contaCorrente2);
            TrasferirEntreContas(contaCorrente1,contaCorrente2);
            #endregion


            ContaEspecial contaEspecial1 = new ContaEspecial(1, 1, cliente1);
            contaEspecial1.setLimite(100);
            ContaEspecial contaEspecial2 = new ContaEspecial(2, 2, cliente2);
            contaEspecial2.setLimite(500);
            DepositarConta(contaEspecial1);
            DepositarConta(contaEspecial2);
            SacarConta(contaEspecial1);
            SacarConta(contaEspecial2);
            TransferirEntreContas(contaEspecial2,contaCorrente1);
        }


        #region Deposito em conta
        public static void DepositarConta(ContaBancaria contaBancaria)
        {
            System.Console.WriteLine("byteBank -deposito");
            System.Console.WriteLine("------------------");
            System.Console.WriteLine();
            string usuario = contaBancaria.Titular;
        
        }
    }
}
