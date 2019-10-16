using System;
using EscolaDeRock.interfaces;
namespace EscolaDeRock.models
{
    public class Guitarra : InstrumentoMusical,IMelodia,IHarmonia
    {
        public bool TocarAcordes()
        {
            System.Console.WriteLine("tocando acordes de guitarra.");
            return true;
        }
        public bool TocarSolo()
        {
            System.Console.WriteLine("tocando solo de guitarra");
            return true;
        }
    }
}