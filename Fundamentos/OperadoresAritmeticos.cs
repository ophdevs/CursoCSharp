using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresAritmeticos
    {
        public static void Executar()
        {
            var preco = 1000.0;
            var imposto = 355.0;
            var total = preco + imposto;
            Console.WriteLine("O preço é " + total);
            var diferenca = preco - imposto;
            Console.WriteLine("A diferença é " + diferenca);
            var produto = preco * 2;
            Console.WriteLine("O dobro do preço é " + produto);
            var divisao = preco / 2;
            Console.WriteLine("A metade do preço é " + divisao);
            var resto = 7 % 3;
            Console.WriteLine("O resto da divisão de 7 por 3 é " + resto);
            Console.WriteLine("ola");
        }
    }
}
