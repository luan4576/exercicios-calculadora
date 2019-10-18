using System;
namespace ByteBank2.Models
{
    public abstract class ContaBancaria
    {
        public string Titular;
        public int Agencia;
        public int NumeroConta;
        public double Saldo;

        public ContaBancaria(int Agencia,int NumeroConta,string Titular) 
        {
            this.Agencia = Agencia;
            this.NumeroConta = NumeroConta;
            this.Titular = Titular;
            this.Saldo =0.0;
        }

        public abstract bool Saque(double valor)
        {
            if(valor>=0)
            {
                this.Saldo = valor;
                return true;
            }
        }

        public bool Deposito(double valor)
        {
            if(valor>= 0) {
            this.Saldo += valor;
            return true;
                
                }
                return false;
            
        }

        public bool Transferencia (double valor)
        {
            if (this.Saque (valor)) {
                destino.Deposito (valor);
                return true;
            } else {
                return false;
                }
        
        }
    }
}