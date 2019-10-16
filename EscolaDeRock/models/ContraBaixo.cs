using System;
using EscolaDeRock.interfaces;
namespace EscolaDeRock.models
{
    public class ContraBaixo : InstrumentoMusical,IPercussao,IHarmonia
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("mantendo ritmo do baixo");
            return true;

        }
        public bool TocarAcordes()
        {
            System.Console.WriteLine("tocando acordes de baixo");
            return true;
        }
    }
}