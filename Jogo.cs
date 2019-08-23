using System;
using System.Collections.Generic;
using System.Text;

namespace NIM
{
    class Jogo
    {
        int jogada;

        public int JogComp(int n, int m)
        {
            this.jogada = 0;
            bool correct = false;
            int max = m;
            int pecas = n;
            while (correct == false)
            {
                if ((n - max) % (m + 1) == 0)
                {
                    correct = true;
                }
                else
                {
                    max = max - 1;
                }
            }
            this.jogada = max;

            if (this.jogada == 1)
            {
                Console.WriteLine("O Computador removeu uma peça");
            }
            else
            {
                Console.WriteLine("O Computador removeu " + this.jogada + " peças");
            }

            return this.jogada;
        }

        public int Jogador(int n, int m)
        {
            this.jogada = 0;
            bool valid = false;
            while (valid == false)
            {
                Console.Write("Quantas peças deseja retirar: ");
                this.jogada = Convert.ToInt32(Console.ReadLine());

                if (this.jogada > m || this.jogada <= 0)
                {
                    Console.WriteLine("Oops! Digite um numero válido: ");
                }
                else if (this.jogada > n)
                {
                    Console.WriteLine("Oops! Digite um numero válido: ");
                }
                else
                {
                    valid = true;
                }
            }

            if (this.jogada == 1)
            {
                Console.WriteLine("Você removeu uma peça");
            }
            else
            {
                Console.WriteLine("Você removeu " + this.jogada + " peças");
            }


            return this.jogada;

        }



    }
}
