using System;
namespace ByteBank2.Models
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(int Agencia, int NumeroConta,string Titular):base(Agencia,NumeroConta,Titular)
        {

        }

        public override bool Saque(double valor)
        {
            if (valor >=0)
            {
                if (valor<= this.Saldo)
                {
                    this.Saldo -= valor;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}

