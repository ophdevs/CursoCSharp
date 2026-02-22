using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaForEach
    {
        public static void Executar()
        {
            var palavra = "palavra";

            foreach (var letra in palavra) //percorre cada letra da palavra e atribui a letra a variavel letra
            {
                Console.WriteLine(letra);
            }

            var alunos = new string[] { "Ana", "Bia", "Carlos" }; //percorre cada elemento do array de string e atribui a variavel aluno

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

        }
    }
}
