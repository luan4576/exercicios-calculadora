using System;
using EscolaDeRock.interfaces;
namespace EscolaDeRock.models
{
    public class Teclado : InstrumentoMusical,IMelodia,IHarmonia
    {
        public bool TocarAcordes()
        {
            System.Console.WriteLine("tocando acordes de teclado.");
            return true;
        }
        public bool TocarSolo()
        {
            System.Console.WriteLine("tocando solo de teclado");
            return true;
        }
    }
}