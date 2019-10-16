using System;
using EscolaDeRock.interfaces;
namespace EscolaDeRock.models
{
    public class Tambores :InstrumentoMusical,IPercussao
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("mantendo ritmo dos tambores");
            return true;
        }
    }
}