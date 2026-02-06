using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    internal class Conversoes
    {
        public static void Executar()
        {
            // Conversão implícita
            int inteiro = 10;
            double quebrado = inteiro; // int para double
            Console.WriteLine(quebrado);
            // Conversão explícita (cast)
            double nota = 9.7;
            int notaTruncada = (int)nota; // double para int
            Console.WriteLine(notaTruncada);
            // Conversão usando Convert
            string numeroString = "1234";
            int numeroConvertido = Convert.ToInt32(numeroString);
            Console.WriteLine(numeroConvertido);
            // Conversão usando Parse
            string valorDecimalString = "99.88";
            double valorDecimalConvertido = double.Parse(valorDecimalString);
            Console.WriteLine(valorDecimalConvertido);
        }
    }
}
