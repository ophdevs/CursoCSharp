using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    internal class UsandoBreak
    {
        public static void Executar()
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 51);

            Console.WriteLine("O numero que queremos É {0}", numeroSecreto);

            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine($"{i} É o numero que queremos? ");
                if (i == numeroSecreto)
                {
                    Console.WriteLine("Sim!");
                    break;
                } else
                    {
                        Console.WriteLine("Não!");
                }
                Thread.Sleep(500);
            }

            Console.WriteLine("fim!");
        }
    }
}
