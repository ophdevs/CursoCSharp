using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    internal class FormatandoNumeros
    {
        public static void Executar()
        {
            double valor = 1234567.89;
            Console.WriteLine(valor.ToString("C")); // Formata como moeda
            Console.WriteLine(valor.ToString("C0")); // Formata como moeda sem casas decimais
            Console.WriteLine(valor.ToString("N")); // Formata como número com separadores de milhar
            Console.WriteLine(valor.ToString("N1")); // Formata como número com 1 casa decimal
            Console.WriteLine(valor.ToString("N3")); // Formata como número com 3 casas decimais
            Console.WriteLine(valor.ToString("F")); // Formata como número fixo
            Console.WriteLine(valor.ToString("F4")); // Formata como número fixo com 4 casas decimais
            Console.WriteLine(valor.ToString("E")); // Formata em notação científica
            Console.WriteLine(valor.ToString("E2")); // Formata em notação científica com 2 casas decimais
        }
    }
}
