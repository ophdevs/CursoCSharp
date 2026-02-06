using System;

public class Class1
{
	public Class1()
	{
		public class Interpolacao
		{
			public static void Executar()
			{
				string nome = "Gustavo";
				int idade = 23;
				Console.WriteLine("Olá, {0}! Você tem {1} anos.", nome, idade); // usando o formato tradicional de interpolação
				Console.WriteLine($"Olá, {nome}! Você tem {idade} anos."); // usando a interpolação de string (string interpolation) do C# 6.0 em diante

        }
    }
}
