using System;

namespace MCbonalds
{
    public class cliente
    {  //atributos
    public string Nome {get;set;}
    public string Endereço {get;set;}
    public string Telefone {get;set;}
    public string Senha {get;set;}
    public string Email {get;set;}
    DateTime DataNascimento {get;set;}

    //construtor

    public cliente(string nome, string telefone,string email){
        this.Nome = nome;
        this.Telefone = telefone;
        this.Email = email;

        }
    }
}