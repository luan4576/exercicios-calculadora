using System;
namespace SENAIzinho
{
    public class Aluno
    {
        public string nome {get;set;}
        public DateTime dataNascimento {get;set;}
        public string curso {get;set;}
        public string numeroSala {get;set;}


        
        public Aluno (string nome, DateTime dataNascimento,string curso,string numeroSala)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.curso = curso;
            this.numeroSala = numeroSala;
        }
    }
}