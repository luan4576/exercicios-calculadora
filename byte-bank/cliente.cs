using System;

namespace byte_bank
{
    public class cliente
    {
    
        private string _nome;
        private string _cpf ;
        private string _email ;
        private string _senha ;

        public string Nome{
            get{return _nome;}
            set{ _nome = value;}
        }

        public string cpf{
            get{return _cpf;}
            set{_cpf = value ;}
        }

        public string Email{
            get {return _email;}
            set {_email = value ;}
        }

        public string Senha{
            get{return _senha;}
        }




        
        public cliente (string Nome,string cpf,string Email){
            this._nome = Nome;
            this._cpf = cpf;
            this._email = Email;
        }

        public bool TrocaSenha(string Senha){
            if ((Senha.Length > 6)&&(Senha.Length < 16)){
                this._senha = Senha;
                return true;
            }else{
                return false;
            }
        }

    }
    
}

