using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
        internal class LendoDados
        {
            public static void Executar()
            {
                Console.Write("Digite o seu nome: ");
                string nome = Console.ReadLine();
                Console.Write("Digite a sua idade: ");
                int idade = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite a sua altura (em metros): ");
                double altura = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Olá {nome}, você tem {idade} anos e {altura}m de altura.");
            }
        }
}
