using System;

namespace EscolaDeRock
{
    enum FormaçaoEnum : int
    {
        TRIO = 3,
        QUARTETO
    };

    enum InstrumentoEnum : int {
        BAIXO,
        BATERIA,
        CONTRABAIXO,
        GUITARRA,
        TECLADO,
        TAMBORES,
        VIOLAO
    };

    enum CategoriaEnum : int {
        HARMONIA,
        PERCUSSAO,
        MELODIA
    };
    class Program
    {
        static void Main(string[] args)
        {
            bool querSair = false;
            string[]itensMenuPrincipal = Enum.GetNames(typeof(FormaçaoEnum));
            string[]itensMenuCategoria = Enum.GetNames(typeof(CategoriaEnum));

            var opçoesFormaçao = new List<string>()
            {
                "  - 0  ",
                "  - 1  "
            };

            int opçoesFormaçao = 0;
            string menubar = "====================";

            do
            {
                bool formaçaoEscolhida = false;

                do 
                {
                    Console.Clear();
                    System.Console.WriteLine(menubar);
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    System.Console.WriteLine("seja bem-vind@");
                    System.Console.WriteLine("escolha uma formaçao:");
                    Console.ResetColor();
                    System.Console.WriteLine(menubar);

                    for(int i =0; i <opçoesFormaçao.count; i++)
                    {
                        string titulo = TratarTituloMenu(itensMenuPrincipal[i]);

                        if(opçoesFormaçaoSelecionada == i)
                        {
                            DestacarOpçao(opçoesFormaçao[opçoesFormaçaoSelecionada].Replace("-",">").Replace(i.));
                        }

                        else
                        {
                            System.Console.WriteLine(opçoesFormaçao[i].Replace(i.ToString(),titulo));
                        }

                        var key = Console.ReadLine(true).key;

                    
                        
                    }
                }
            }
        }
    }
}
