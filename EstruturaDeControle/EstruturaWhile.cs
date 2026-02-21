using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativa = 0;

            while (!numeroEncontrado && tentativasRestantes > 0)
            {
                Console.WriteLine("insira o seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);
                tentativa++;
                tentativasRestantes--;

                if (palpite == numeroSecreto)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Parabéns! Você acertou o número secreto em {0} tentativas!", tentativa);
                    Console.BackgroundColor = corAnterior;
                }

                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("O número secreto é menor");
                    Console.WriteLine("tem {0} tentativas restantes", tentativasRestantes);
                }

                else
                {
                    Console.WriteLine("O número secreto é maior");
                    Console.WriteLine("tem {0} tentativas restantes", tentativasRestantes);
                }



            }
        }
    }
}
