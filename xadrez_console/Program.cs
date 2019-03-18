﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidadeXadrez partida = new PartidadeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);
                    Console.WriteLine();
                    Console.Write("Origem: ");
                    
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");

                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem,destino);
                }

                Tela.imprimirTabuleiro(partida.tab);
               
                //Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            //PosicaoXadrez pos = new PosicaoXadrez('c',7);
            //Console.WriteLine(pos);
            //Console.WriteLine(pos.toPosicao());
            Console.ReadLine();
        }
    }
}
