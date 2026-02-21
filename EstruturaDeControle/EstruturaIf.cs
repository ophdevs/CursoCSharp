using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaIf
    {
        public static void Executar()
        {
            string entrada;
            Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui um bom comportamento?");
            entrada = Console.ReadLine();
            bool bomComportamento = false;

            if (entrada == "s" || entrada == "S")
            {
                bomComportamento = true;
            }
            

            if (nota >= 9 && bomComportamento)
            {
                Console.WriteLine("Quadro de Honra!");
            }
            else
            {
                Console.WriteLine("Aluno normal");
            }




        }
    }
}
