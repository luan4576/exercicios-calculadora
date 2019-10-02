using System;
using MateODragao.Models;
namespace MateODragao {
    class Program {
        static void Main (string[] args) {
            bool JogadorNaoDesistiu = true;
            do {

                System.Console.WriteLine ("==============================");
                System.Console.WriteLine ("        mate o dragao!");
                System.Console.WriteLine ("==============================");

                System.Console.WriteLine ("1 - iniciar jogo");
                System.Console.WriteLine ("0 - sair do jogo");

                string OpçaoJogador = Console.ReadLine ();

                switch (OpçaoJogador) {
                    case "1":
                        Console.Clear ();
                        
                        Guerreiro guerreiro = CriarGuerreiro ();

                        Dragao dragao = new Dragao ();
                        dragao.Nome = "dragonildo";
                        dragao.Força = 5;
                        dragao.Destreza = 1;
                        dragao.Inteligencia = 3;
                        dragao.Vida = 300;

                        /* INICIO - primeiro dialogo */
                        CriarDialogo (guerreiro.Nome, $"{dragao.Nome},seu louco! vim-lhe derrotar-lhe");

                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: kkkk! se é um jao , seu jao ,vem tranquilo");

                        FinalizarDialogo();
                        /* FIM - primeiro dialogo */

                        /* INICIO - segundo dialogo */

                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper ()}:eu sou {guerreiro.Nome}!da casa {guerreiro.SobreNome}, ó criatura morfetica");
                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper ()}: vim de {guerreiro.CidadeNatal} para derrotar-te e mostrar meu valor!");
                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}:quem? de onde?bom,que seja...fritar-te-ei e devorar-te-ei,primata insolante!");

                        FinalizarDialogo();
                        /* FIM - segundo dialogo */
                        
                        bool JogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;

                        bool JogadorNaoCorreu = true;

                        int PoderAtaqueGuerreiro = guerreiro.Força > guerreiro.Inteligencia ? guerreiro.Força + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;

                        /*INICIO da treta */
                        if (JogadorAtacaPrimeiro) {
                            Console.Clear ();

                            System.Console.WriteLine ("***Turno do jogador***");
                            System.Console.WriteLine ("Escolha sua açao:");
                            System.Console.WriteLine (" 1 - Atacar");
                            System.Console.WriteLine (" 2 - Fugir");

                            string OpçaoBatalhaJogador = Console.ReadLine ();

                            switch (OpçaoBatalhaJogador) {
                                case "1":
                                    Random GeradorNumeroAleatorio = new Random ();
                                    int NumeroAleatorioJogador = GeradorNumeroAleatorio.Next (0, 5);
                                    int NumeroAleatorioDragao = GeradorNumeroAleatorio.Next (0, 5);

                                    int GuerreiroDestrezaTotal = guerreiro.Destreza + NumeroAleatorioJogador;
                                    int DragaoDestrezaTotal = dragao.Destreza + NumeroAleatorioDragao;

                                    if (GuerreiroDestrezaTotal > DragaoDestrezaTotal) {
                                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}:toma essa lagarto MALDJEETO");
                                        dragao.Vida -= PoderAtaqueGuerreiro + 5;
                                        System.Console.WriteLine ("----------");
                                        System.Console.WriteLine ($"HP Dragao: {dragao.Vida}");
                                        System.Console.WriteLine ($"HP Guerreiro: {guerreiro.Vida}");
                                    } else {
                                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}:Errrrrrou,humanoide tosco!");
                                    }

                                    break;
                                case "2":
                                    JogadorNaoCorreu = false;
                                    System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}:simbora fii!FLW VLW!");
                                    System.Console.WriteLine ($"{dragao.Nome.ToUpper()}:GG EZ!");
                                    break;
                            }

                            System.Console.WriteLine ("aperte ENTER para proseguir");
                            Console.ReadLine ();

                            while (dragao.Vida > 0 && guerreiro.Vida > 0 && JogadorNaoCorreu) {
                                Console.Clear ();
                                System.Console.WriteLine ("***Turno do Dragao***");
                                Random GeradorNumeroAleatorio = new Random ();
                                int NumeroAleatorioJogador = GeradorNumeroAleatorio.Next (0, 5);
                                int NumeroAleatorioDragao = GeradorNumeroAleatorio.Next (0, 5);

                                int GuerreiroDestrezaTotal = guerreiro.Destreza + NumeroAleatorioJogador;
                                int DragaoDestrezaTotal = dragao.Destreza + NumeroAleatorioDragao;

                                if (GuerreiroDestrezaTotal > DragaoDestrezaTotal) {
                                    System.Console.WriteLine ($"{dragao.Nome.ToUpper()}:chamuscou o fiofó? foi?");
                                    guerreiro.Vida -= dragao.Força;
                                    System.Console.WriteLine ("----------");
                                    System.Console.WriteLine ($"HP Dragao: {dragao.Vida}");
                                    System.Console.WriteLine ($"HP guerreiro: {guerreiro.Vida}");
                                } else {
                                    System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}:vem tranquilo, noa se afoba nao!");
                                }
                                System.Console.WriteLine ();
                                System.Console.WriteLine ("aperte o ENTER para prosseguir");
                                Console.ReadLine ();

                                /*INICIO - turno jogador */
                                Console.Clear ();
                                System.Console.WriteLine ("***Turno do jogador***");
                                System.Console.WriteLine ("Escolha sua açao:");
                                System.Console.WriteLine (" 1 - Atacar");
                                System.Console.WriteLine (" 2 - Fugir");

                                string opçaoBatalhaJogador = Console.ReadLine ();

                                switch (opçaoBatalhaJogador) {
                                    case "1":
                                        GeradorNumeroAleatorio = new Random ();
                                        NumeroAleatorioJogador = GeradorNumeroAleatorio.Next (0, 5);
                                        NumeroAleatorioDragao = GeradorNumeroAleatorio.Next (0, 5);

                                        GuerreiroDestrezaTotal = guerreiro.Destreza + NumeroAleatorioJogador;
                                        DragaoDestrezaTotal = dragao.Destreza + NumeroAleatorioDragao;

                                        if (GuerreiroDestrezaTotal > DragaoDestrezaTotal) {
                                            System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}:toma essa lagarto MALDJEETO");
                                            dragao.Vida -= PoderAtaqueGuerreiro + 5;
                                            System.Console.WriteLine ("----------");
                                            System.Console.WriteLine ($"HP Dragao: {dragao.Vida}");
                                            System.Console.WriteLine ($"HP Guerreiro: {guerreiro.Vida}");
                                        } else {
                                            System.Console.WriteLine ($"{dragao.Nome.ToUpper()}:Errrrrrou,humanoide tosco!");
                                        }

                                        if (guerreiro.Vida <= 0) {
                                            System.Console.WriteLine ("jogador morrrrrrreu!");
                                        }
                                        if (dragao.Vida <= 0) {
                                            System.Console.WriteLine ("el dragon murio!");
                                        }
                                        System.Console.WriteLine ();
                                        System.Console.WriteLine ("aperte ENTER para prosseguir");
                                        Console.ReadLine ();

                                        break;
                                    case "2":
                                        JogadorNaoCorreu = false;
                                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}:simbora fii!FLW VLW!");
                                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}:GG EZ!");
                                        break;
                                }

                                System.Console.WriteLine ("aperte ENTER para proseguir");
                                Console.ReadLine ();
                                /*FIM - turno jogador */

                            }

                        }
                        /*FIM da treta */

                        break;
                    case "0":
                        JogadorNaoDesistiu = false;
                        break;
                    default:
                        System.Console.WriteLine ("comando desconhecido");
                        break;
                }
            } while (JogadorNaoDesistiu);

        }

        private static void CriarDialogo (string nome, string frase) {

            System.Console.WriteLine ($"{nome.ToUpper()}:{frase}!");
        }

        private static void FinalizarDialogo () {
            System.Console.WriteLine ();
            System.Console.WriteLine ("aperte ENTER para prosseguir");
            Console.ReadLine ();
            Console.Clear ();
        }

        private static Guerreiro CriarGuerreiro()
        {
                        Guerreiro guerreiro = new Guerreiro ();
                        guerreiro.Nome = "filipi";
                        guerreiro.SobreNome = "stenson";
                        guerreiro.CidadeNatal = "wisterman";
                        guerreiro.DataNascimento = DateTime.Parse ("01/01/1450");
                        guerreiro.FerramentaAtaque = "espada";
                        guerreiro.FerramentaProteçao = "armadura de ferro";
                        guerreiro.Força = 3;
                        guerreiro.Destreza = 2;
                        guerreiro.Inteligencia = 3;
                        guerreiro.Vida = 20;

                        return guerreiro;
        }
    }
}