using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Exercicios
{
    internal class ExercicioCaixaEletronico
    {
        public static void Executar()
        {
            bool sair = false;
            double saldo = 1000;
            const double valorInicial = 1000;
            saldo = valorInicial;



            while (sair == false)
            {
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("1 - Ver saldo\r\n2 - Depositar\r\n3 - Sacar\r\n4 - Sair");
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Digite a opção desejada: ");
                int.TryParse(Console.ReadLine(), out int opcao);

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"Seu saldo é {saldo}");
                        Console.WriteLine("Aperte Enter para continuar");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Quanto você deseja depositar:");
                        double.TryParse(Console.ReadLine(), out double valorDeposito);
                        if (valorDeposito > 0)
                        {
                            Console.WriteLine("Seu valor de {0} foi depositado com sucesso!", valorDeposito);
                            saldo += valorDeposito;
                        }
                        else
                        {
                            Console.WriteLine("Valor de deposito inválido. O valor deve ser maior que zero.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Digite o valor que deseja sacar");
                        double.TryParse(Console.ReadLine(), out double valorSaque);
                        if (valorSaque > 0)
                        {
                            if (valorSaque <= saldo)
                            {
                                Console.WriteLine("saque de {0}, Realizado com sucesso!", valorSaque);
                                Console.WriteLine("Saldo atual: {0}", saldo - valorSaque);
                                saldo -= valorSaque;

                            }
                            else
                            {
                                Console.WriteLine("Saldo insuficiente para realizar o saque.");
                            }
                        }

                        break;
                    case 4:
                        sair = true;
                        break;

                    default:
                        Console.WriteLine("comando invalido, tente novamente");
                        break;
                }

            }

            Console.WriteLine("fim");

        }
    }
}
