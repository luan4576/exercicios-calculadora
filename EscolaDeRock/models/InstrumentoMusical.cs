using System;
using EscolaDeRock.interfaces;
namespace EscolaDeRock.models
{
    public class InstrumentoMusical
    {
        string[] notas = {"dó","ré","mí","fá","sol","lá","si"};

        protected string TocarMusica()
        {
            int nota = new Random().Next(notas.Length - 1);
            return notas[nota];
        }
    }
}