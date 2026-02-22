using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaFor
    {
        public static void Executar()
        {
            double somatoriaNota= 0;
            string entrada;

            Console.WriteLine("Digite o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 1; i <= tamanhoTurma; i++)
            {
                Console.WriteLine($"Digite a nota do aluno {i}");
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);
                somatoriaNota += notaAtual;
                
            }

            double mediaNota = tamanhoTurma > 0 ? somatoriaNota / tamanhoTurma : 0;

            Console.WriteLine("a media da nota dos alunos deu {0}", mediaNota);

        }
    }
}
