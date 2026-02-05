using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    internal class Inferencia
    {
        public static void Executar()
        {
            var nome = "João"; // o compilador entende que é string
            Console.WriteLine(nome);
            var idade = 25; // o compilador entende que é int
            Console.WriteLine(idade);
            var altura = 1.8; // o compilador entende que é double
            Console.WriteLine(altura);
            // nome = 123; // ERRO: não pode mudar o tipo depois de definido
            dynamic minhaVar = 4; // pode mudar o tipo a qualquer momento
            Console.WriteLine(minhaVar);
            minhaVar = "Agora sou uma string";
            Console.WriteLine(minhaVar);
            minhaVar = true;
            Console.WriteLine(minhaVar);
        }
    }
}
