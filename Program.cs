using System;

namespace DIO_Aulas_Dotnet
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Olá! Qual o seu nome?");

            string nomeAluno = Console.ReadLine();
            string opcaoAula = ObterOpcaoAula();

            while (opcaoAula.ToUpper() != "X")
            {
                switch(opcaoAula)
                {
                    case "1":
                        //AULA 01 - Téorica - O que é .NET
                        //AULA 02 - Criando uma aplicação console
                        var bv = new Introducao();
                        bv.BoasVindas(nomeAluno);
                        break;
                    case "2":
                        //AULA 03 - Aplicando conceito de pilha e classe aninhada
                        Console.WriteLine("AULA 03 - Aplicando conceito de pilha e classe aninhada");
                        var p = new Pilha();
                        p.Empilha(10);
                        p.Empilha(100);
                        p.Empilha(1000);

                        Console.WriteLine(p.Desempilha());
                        Console.WriteLine(p.Desempilha());
                        Console.WriteLine(p.Desempilha());        
                        break;
                    case "3":
                        //AULA 04 - Aula sobre tipos de variáveis e instruções lógicas
                        Console.WriteLine("AULA 04 - Aula sobre tipos de variáveis e instruções lógicas");
                        Console.WriteLine();
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Sugiro entrar no debug para ver como tudo acontece.");
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine();
                        
                        VerInstrucoes();

                        break;
                    case "4":
                        //AULA 05 - Aula sobre objetos essenciais em C#
                        Console.WriteLine("AULA 05 - Aula sobre objetos essenciais em C#");
                        break;
                    case "5":
                        //AULA 06 - Aula de Scructs, Interfaces e Enuns
                        Console.WriteLine("AULA 06 - Aula de Scructs, Interfaces e Enuns");
                        break;
                    case "6":
                        //Aula 07 - Revisao     
                        Console.WriteLine("AULA 07 - Revisao");
                        break;
                    default:
                        Console.WriteLine("Escolha uma das opções válidas");
                        break;
                }
                opcaoAula = ObterOpcaoAula();
            }    
        }
        private static string ObterOpcaoAula()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a aula que deseja revisar:");
            Console.WriteLine();
            Console.WriteLine("1 - Aula de  introdução ao C# - Hello World!");
            Console.WriteLine("2 - Aula sobre pilha e classes aninhadas");
            Console.WriteLine("3 - Aula sobre tipos de variáveis e instruções lógicas");
            Console.WriteLine("4 - Aula sobre objetos essenciais em C#");
            Console.WriteLine("5 - Aula de Scructs, Interfaces e Enuns");
            Console.WriteLine("6 - Revisão");
            Console.WriteLine("X - Para sair da revisão");
            Console.WriteLine();

            string opcaoAula = Console.ReadLine();
            return opcaoAula;
        }   

          private static string ObterOpcaoInstrucao()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a instrução que deseja executar:");
            Console.WriteLine();
            Console.WriteLine("A - DECLARAÇÕES");
            Console.WriteLine("B - IF");
            Console.WriteLine("C - SWITCH");
            Console.WriteLine("D - WHILE");
            Console.WriteLine("E - DO");
            Console.WriteLine("F - FOR");
            Console.WriteLine("G - FOREACH");
            Console.WriteLine("H - BREAK");
            Console.WriteLine("I - CONTINUE");
            Console.WriteLine("J - RETURN");
            Console.WriteLine("K - TRY CATH");
            Console.WriteLine("L - USING");
            Console.WriteLine("X - Para voltar ao menu principal");
            Console.WriteLine();

            string opcaoInstrucao = Console.ReadLine().ToString();
            return opcaoInstrucao;
        }   

        private static void VerInstrucoes()
        {
            string opcaoInstrucao = ObterOpcaoInstrucao();

            var instr = new Instrucoes();
            var arrS1 = new string[1];
            var arrS2 = new string[2];
            var arrS3 = new string[3];
            var arrS4 = new int[2];
            var arrS5 = new int[3];

            do
            {

                switch(opcaoInstrucao.ToString().ToUpper())
                {
                    case "A":
                        Console.WriteLine("DECLARAÇÕES: ");
                        instr.Declaracoes();
                        break;
                    case "B":
                        arrS2[0] = "10";
                        arrS2[1] = "20";
                        Console.WriteLine("IF: ");
                        instr.InstrucaoIf(arrS2);
                        break;
                    case "C":
                        arrS2[0] = "1";
                        arrS2[0] = "2";
                        Console.WriteLine("SWITCH: ");
                        instr.InstrucaoSwitch(arrS2);
                        break;
                    case "D":
                        arrS2[0] = "3";
                        arrS2[1] = "5";
                        Console.WriteLine("WHILE: ");
                        instr.InstrucaoWhile(arrS2);
                        break;
                    case "E":
                        arrS2[0] = "2";
                        arrS2[1] = "4";
                        Console.WriteLine("DO: ");
                        instr.InstrucaoDo(arrS2);
                        break;
                    case "F":
                        arrS3[0] = "Instrucao For";
                        Console.WriteLine("FOR: ");
                        instr.InstrucaoFor(arrS3);
                        break;
                    case "G":
                        arrS3[0] = "Instrucao Foreach";
                        Console.WriteLine("FOREACH: ");
                        instr.InstrucaoForeach(arrS3);
                        break;
                    case "H":
                        arrS3[0] = "Instrucao Break";
                        Console.WriteLine("BREAK: ");
                        instr.InstrucaoBreak(arrS3);
                        break;
                    case "I":
                        arrS3[0] = "Comando Continue...";
                        arrS3[1] = "Comando Continue...";
                        arrS3[2] = "/";
                        Console.WriteLine("CONTINUE: ");
                        instr.InstrucaoContinue(arrS3);
                        break;
                    case "J":
                        arrS3[0] = "Instrucao  Return";
                        Console.WriteLine("RETURN: ");
                        instr.InstrucaoReturn(arrS3);
                        break;
                    case "K":
                        arrS3[0] = "98569586958";
                        arrS3[1] = "0";
                        Console.WriteLine("TRY CATH: ");
                        instr.InstrucoesTryCatchFinallyThrow(arrS1);
                        break;
                    case "L":
                        arrS3[0] = "Texto";
                        arrS3[1] = "Documento";
                        Console.WriteLine("USING");
                        instr.InstrucaoUsing(arrS3);
                        break;
                    case "X":
                        break;
                    default:
                        Console.WriteLine("Escolha uma das opções válidas");
                        break;
                }
                opcaoInstrucao = ObterOpcaoInstrucao();
            } while (opcaoInstrucao.ToUpper() != "X");            
        }
    }
}