using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.Exercicios;
using CursoCSharp.ClassesEMetodos;

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
                {"Estrutura For - Estrutura De Controle", EstruturaFor.Executar },
                {"Estrutura For Each - Estrutura De Controle", EstruturaForEach.Executar },
                {"Usando Break - Estrutura De Controle", UsandoBreak.Executar },
                { "Usando Continue - Estrutura De Controle", UsandoContinue.Executar},
                // Exercicios
                { "Sistema caixa eletronico - Exercicios", ExercicioCaixaEletronico.Executar},
                { "Sistema Cadastrar Alunos - Exercicios", ExercicioCadastrarAluno.Executar},
                //Classes e Metodos
                { "Membros - Classes e Metodos", Membros.Executar},


            });

            central.SelecionarEExecutar();
        }
    }
}