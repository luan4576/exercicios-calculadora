namespace ByteBank2.Models {
    public class ContaEspecial : ContaBancaria {
        double Limite;
        public ContaEspecial (int Agencia, int NumroConta, string Titular) : base (Agencia, NumeroConta, Titular) {
            Limite = 0.0;
        }

        public override bool Saque (double valor) {
            if (valor >= 0) {

                if (valor <= base.Saldo + Limite) {
                    Saldo -= valor;
                    return true;
                } else {
                    return false;
                }
            }
            return false;
        }

        public void setLimite(double valor)
        {
            if (valor >= 0) 
            {
                Limite = valor;
                return true;
            }
            return false;
        }
    }
}