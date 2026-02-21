using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variaveis E Contantates - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolacao - Fundamentos", Interpolacao.Executar},
                {"Notacao Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Numeros - Fundamentos", FormatandoNumeros.Executar},
                {"Conversoes - Fundamentos", Conversoes.Executar },
                {"Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar },
                {"Operador Ternario - Fundamentos", OperadorTernario.Executar },
                // Estrutura de Controle
                {"Estrutura If - Estrutura De Controle", EstruturaIf.Executar },
                {"Estrutura If Else - Estrutura De Controle", EstruturaIfElse.Executar },
                {"Estrutura If Else If - Estrutura De Controle", EstruturaIfElseIf.Executar },
                {"Estrutura Switch - Estrutura De Controle", EstruturaSwitch.Executar },
                {"Estrutura While - Estrutura De Controle", EstruturaWhile.Executar },
                {"Estrutura Do While - Estrutura De Controle", EstruturaDoWhile.Executar },

            });

            central.SelecionarEExecutar();
        }
    }
}