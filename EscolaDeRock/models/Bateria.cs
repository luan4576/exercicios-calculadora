using System;
using EscolaDeRock.interfaces;

namespace EscolaDeRock.models
{
    public class Bateria : InstrumentoMusical,IPercussao
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Manter ritmo da Bateria");
            return true;
        }
    }
}