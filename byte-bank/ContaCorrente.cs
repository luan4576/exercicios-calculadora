using System;
namespace byte_bank {
    public class ContaCorrente {
        public int Agencia { get; set; }
        public cliente Titular { get; set; }
        public int Numeros { get; set; }
        private double _saldo;

        public double Saldo{
            get { return _saldo; }
        }

        public ContaCorrente (int Agencia, cliente Titular, int Numeros) {
            this.Titular = Titular;
            this.Agencia = Agencia;
            this.Numeros = Numeros;
            this._saldo = 0.0;
        }
        public double Deposito (double valor) {

            if(valor> 0) {
            this._saldo += valor;
            return this._saldo;
                
                }else {
                    System.Console.WriteLine("o deposito nao pode ser negativo");
                    return this._saldo;
                } 
            }
        


        public bool Saque (double valor) {
            if (valor >0 ) {
                this._saldo -= valor;
                return true;
                
            } else {System.Console.WriteLine("o saque nao pode ser negativo");
                return false;
            }
        }
        public bool Trasferencia (ContaCorrente destino, double valor) {
            if (this.Saque (valor)) {
                destino.Deposito (valor);
                return true;
            } else {
                return false;
            }
        }
    }
}
