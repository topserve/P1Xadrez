using System;
using tabuleiro;
using xadrez;

namespace P1Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('g',8 );
            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();
        }
    }
}
