using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar()
        {
            //bytes 

            byte idade = 45;
            Console.WriteLine("idade = " + idade);

            sbyte menorNumero = sbyte.MinValue;
            Console.WriteLine("menor numero = " + menorNumero );

            // short

            short maiorShort = short.MaxValue;
            Console.WriteLine("maior valor de short: " + maiorShort);

            // inteiro: o "u" é usado para indicar que é unsigned (sem sinal)

            int maiorInt = int.MaxValue; // mais usado dos inteiros
            Console.WriteLine("maior valor de int: " + maiorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("populacao Brasileira: " + populacaoBrasileira);

            // long
            long menorLong = long.MinValue;
            Console.WriteLine("menor valor de long: " + menorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("populacao Mundial: " + populacaoMundial);

            // real
            float precoComputador = 1299.99f; // é necessario o "f" no final do numero
            Console.WriteLine("preco do computador: " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; // mais usado dos reais e tem o dobro de bytes do float
            Console.WriteLine("valor de mercado da apple: " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue; // mais preciso, usado para valores monetarios o "m" no final do numero
            Console.WriteLine("distancia entre estrelas: " + distanciaEntreEstrelas);

            // booleano
            bool estaChovendo = true;
            Console.WriteLine("esta chovendo: " + estaChovendo);

            // caractere
            char letra = 'b'; // usa aspas simples para char e só armazena um unico caractere
            Console.WriteLine("letra: " + letra);

            string texto = "curso de C#";
            Console.WriteLine("texto: " + texto);

        }
    }
}
