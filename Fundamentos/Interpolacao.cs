using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    internal class Interpolacao 
    {
        public static void Executar()
        {
            string nome = "Notebook";
            double preco = 2300.99;
            // Usando concatenação
            Console.WriteLine("O " + nome + " custa " + preco);
            // Usando interpolação
            Console.WriteLine($"O {nome} custa {preco}");
            // Interpolação com expressões
            Console.WriteLine($"1 + 1 = {1 + 1}");
            Console.WriteLine($"10% de {preco} é {preco * 0.1}");
            // Formatação dentro da interpolação
            Console.WriteLine($"{nome} custa {preco:C2}"); // Formata como moeda com 2 casas decimais
            Console.WriteLine($"{nome} custa {preco:N2}"); // Formata como número com 2 casas decimais

            Console.WriteLine("nome {0} custa {1}", nome, preco);
        }

    }
}





