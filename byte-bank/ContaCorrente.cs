using System;
namespace byte_bank {
    public class ContaCorrente {
        public int Agencia { get; set; }
        public cliente Titular { get; set; }
        public int Numeros { get; set; }
        public double Saldo { get; set; }

        public ContaCorrente (int Agencia, cliente Titular, int Numeros) {
            this.Titular = Titular;
            this.Agencia = Agencia;
            this.Numeros = Numeros;
            this.Saldo = 0.0;
        }
        public double Deposito (double valor) {
            this.Saldo += valor;
            return this.Saldo;
        }
        public bool Saque (double valor) {
            if (valor <= this.Saldo) {
                this.Saldo -= valor;
                return true;
                
            } else {
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