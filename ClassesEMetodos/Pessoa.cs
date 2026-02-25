using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        public string? Nome;
        public int Idade;


        public string Apresentar()
        {
            return string.Format($"Olá, meu nome é {Nome} e tenho {Idade} anos");
        }

        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }
        
        public void ZerarDados()
        {
            Nome = string.Empty;
            Idade = 0;
        }
    }
}
