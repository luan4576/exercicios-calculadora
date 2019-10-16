using System;
using EscolaDeRock.Interfaces;
namespace EscolaDeRock.models
{
    public class violao : InstrumentoMusical, IHarmonia,IMelodia,IPercussao
    {
        public bool TocarAcordes()
        {
        System.Console.WriteLine("tocando acordes de violao");
        return true;
        }

        public bool ManterRitmo()
        {
            System.Console.WriteLine("mantendo ritmo do violao");
            return true;
        }
        public bool TocarAcordes()
        {
            System.Console.WriteLine("tocando acordes do violao.");
            return true;
        }

        public bool TocarSolo()
        {
            System.Console.WriteLine("tocando solo do violao.");
            return true;
        }
    }
}