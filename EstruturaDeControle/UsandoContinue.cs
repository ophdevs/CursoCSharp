using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    internal class UsandoContinue
    {
        public static void Executar()
        {
            int intervalo = 50;
            Console.WriteLine($"Numeros pares entre 0 e {intervalo}:");


            for (int i = 0; i <= intervalo; i++)
            {
                if (i % 2 == 1) // se o numero for impar, ele pula para a proxima iteracao do loop
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
