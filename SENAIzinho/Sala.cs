namespace SENAIzinho
{
    public class Sala
    {
        public int capacidadeAtual {get;set;}
        public int capacidadeTotal {get;set;}
        public int numeroSala {get;set;}
        public string[] alunos {get;set;}

        public Sala(int numerSala,int capacidadeTotalSala);
        public string AlolcarAluno();
        public string RemoverAluno();
        public string MostrarAlunos();
    }
}