using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var valorPositivo = +valorNegativo;
            Console.WriteLine(valorPositivo);
            valorPositivo = -valorNegativo;
            Console.WriteLine(valorPositivo);
            int numero = 5;
            Console.WriteLine("Incremento: " + ++numero);
            Console.WriteLine("Decremento: " + --numero); // decrementa o numero e depois exibe
        }
    }
}
