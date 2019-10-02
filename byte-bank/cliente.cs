using System;

namespace byte_bank
{
    public class cliente
    {
    
        public string Nome {get;set;}
        public string cpf {get;set;}
        public string Email {get;set;}
        public string Senha {get;set;}
        
        public cliente (string Nome,string cpf,string Email){
            this.Nome = Nome;
            this.cpf = cpf;
            this.Email = Email;
        }

        public bool TrocaSenha(string Senha){
            if ((Senha.Length > 6)&&(Senha.Length < 16)){
                this.Senha = Senha;
                return true;
            }else{
                return false;
            }
        }


    }
}

