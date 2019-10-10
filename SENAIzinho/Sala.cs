using System;
namespace SENAIzinho
{
    public class Sala
    {
        public int capacidadeAtual {get;set;}
        public int capacidadeTotal {get;set;}
        public int numeroSala {get;set;}
        public string[] alunos {get;set;}

        public Sala(int numeroSala,int capacidadeTotal);



    }
}