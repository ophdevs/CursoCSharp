using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;
            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou sorvete? " + comprouSorvete);
            var comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou TV 50? " + comprouTv50);
            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprou TV 32? " + comprouTv32);
            Console.WriteLine("Mais saudável? " + !comprouSorvete);
        }
    }
}
