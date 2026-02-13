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
            var valorPositivo = +valorNegativo; // o operador + não altera o valor
            Console.WriteLine(valorPositivo); // saída: -5
            valorPositivo = -valorNegativo;
            Console.WriteLine(valorPositivo); // saída: 5
            int numero = 5;
            Console.WriteLine("Incremento: " + ++numero); // incrementa o numero e depois exibe
            Console.WriteLine("Decremento: " + --numero); // decrementa o numero e depois exibe
        }
    }
}
