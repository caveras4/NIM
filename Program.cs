using System;

namespace NIM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao jogo NIM!\n");

            Console.WriteLine("Escolha uma das opções:\n1 - Jogar uma partida\n2 - Jogar um Campeonato\n");

            Partida partida = new Partida();
            int escolha = 0;
            bool prox = false;
            int cont = 1;
            int jog = 0;
            int comp = 0;
            string camp;

            while(prox == false)
            {
                Console.Write("Qual sera sua escolha, 1 ou 2: ");
                escolha = Convert.ToInt32(Console.ReadLine());
                if (escolha == 1 || escolha == 2)
                {
                    prox = true;
                }
            }

            Console.WriteLine();

            if (escolha == 1)
            {
                partida.PartCamp();
            }
            else
            {
                while (cont < 4)
                {
                    Console.WriteLine("\n*** " + cont + "º Rodada ***\n");

                    camp = partida.PartCamp();
                    if (camp == "c")
                    {
                        comp++;
                    }
                    else if (camp == "j")
                    {
                        jog++;
                    }                    
                    cont++;
                }

                if (comp > jog)
                {
                    Console.WriteLine("\nO Computador é o campeão!");
                }
                else if (jog > comp)
                {
                    Console.WriteLine("\nVocê é o campeão!");
                }
            }
        }
    }
}
