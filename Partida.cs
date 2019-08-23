using System;
using System.Collections.Generic;
using System.Text;

namespace NIM
{
    class Partida
    {
        public string PartCamp()
        {
            Jogo jogo = new Jogo();

            Console.Write("Digite o numero de peças: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            while (n <= 0)
            {
                Console.Write("Digite o numero de peças: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }

            Console.Write("Digite o maximo de peças por jogada: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            while(m > n || m <= 0)
            {
                Console.Write("Digite o maximo de peças por jogada: ");
                m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }

            if (n % (m + 1) == 0)
            {
                Console.WriteLine("Você Começa!\n");
                while (n > 0)
                {
                    int numJog = jogo.Jogador(n, m);
                    n = n - numJog;
                    if (n == 0)
                    {
                        Console.WriteLine("Você ganhou!!!");
                        return "j";
                    }
                    Console.WriteLine("Restam " + n + " Peças\n");

                    int numComp = jogo.JogComp(n, m);
                    n = n - numComp;
                    if (n == 0)
                    {
                        Console.WriteLine("\nO computador ganhou!!!\n");
                        return "c";
                    }
                    Console.WriteLine("Restam " + n + " Peças\n");
                }
            }
            else
            {
                Console.WriteLine("O computador começa!\n");
                while (n > 0)
                {
                    int numComp = jogo.JogComp(n, m);
                    n = n - numComp;
                    if (n == 0)
                    {
                        Console.WriteLine("\nO computador ganhou!!!");
                        return "c";
                    }
                    Console.WriteLine("Restam " + n + " Peças\n");

                    int numJog = jogo.Jogador(n, m);
                    n = n - numJog;
                    if (n == 0)
                    {
                        Console.WriteLine("\nVocê ganhou!!!");
                        return "j";
                    }
                    Console.WriteLine("Restam " + n + " Peças\n");
                }
            }

            return "n";
        }
    }
}
