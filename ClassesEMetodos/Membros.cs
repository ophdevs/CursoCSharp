using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa deltrano = new Pessoa();
            deltrano.Nome = "Pedro";
            deltrano.Idade = 20;

            deltrano.ApresentarNoConsole();

            var fulano = new Pessoa() { Nome = "ruan", Idade = 23 };

            var apresentacaoFulano = fulano.Apresentar(); // mais flexibilidade para alterar o metodo de apresentação sem precisar alterar o código que o chama -ph
            Console.WriteLine(apresentacaoFulano);
            Console.WriteLine(apresentacaoFulano.Length);
        }
    }
}
