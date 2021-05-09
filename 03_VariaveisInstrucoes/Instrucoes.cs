using System;

namespace DIO_Aulas_Dotnet
{
    class Instrucoes
    {
        public void Declaracoes()
        {
            int a;
            int b = 2, c = 3;
            const int d = 4;
            a = 1;
            
            const string varStr = "Declaração de variáveis: ";

            Console.WriteLine(varStr + a + b + c + d);
            Console.WriteLine(a + b + c + d);
        }

        public void InstrucaoIf(string[] args)
        {
            Console.WriteLine($"{args.Length} foram passados.");
            if(args.Length == 0)
            {
                Console.WriteLine("Nenhum argumento foi informado");                
            }
            else if(args.Length == 1)
            {
                Console.WriteLine("Um argumento foi informado");                
            }
            else
            {
                Console.WriteLine($"{args.Length} argumentos foram informados");
            }
        }
        public void InstrucaoSwitch(string[] args)
        {
            int numArgs = args.Length;
            switch(numArgs)
            {
                case 0:
                    Console.WriteLine("Nenhum argumento foi informado");                
                    break;
                case 1:
                    Console.WriteLine("Um argumento foi informado");                
                    break;
                default:
                    Console.WriteLine($"{args.Length} argumentos foram informados");
                    break;                
            }
        }
        public void InstrucaoWhile(string[] args)
        {
                int i = 0;
                while (i < args.Length)
                {
                    Console.WriteLine(args[i]);
                    i++; 
                }
        }

        public void InstrucaoDo(string[] args)
        {
            string texto;
            do
            {
                texto = Console.ReadLine();
                Console.WriteLine(texto);
            }while(!string.IsNullOrEmpty(texto));
        }

        public void InstrucaoFor(string[] args)
        {
            for(int i = 0; i< args.Length;i++)
            {
                Console.WriteLine(args[i]);
            }
        }
        public void InstrucaoForeach(string[] args)
        {
            foreach(string s in args)
            {
                Console.WriteLine(s);
            }

        }

        public void InstrucaoBreak(string[] args)
        {
            while (true)
            {
                string s = Console.ReadLine();
                if (string.IsNullOrEmpty(s))
                {
                    break;
                }
                Console.WriteLine(s);
            }   
        }
        public void InstrucaoContinue(string[] args)
        {
            Console.WriteLine("Entrou no Continue, digite / para continuar");
            Console.WriteLine(args.Length);
            for(int i = 0; i< args.Length;i++)
            {
                if (args[i].StartsWith("/"))
                {
                    continue;
                }
                Console.WriteLine(args[i]);
            }
        }

        public void InstrucaoReturn(string[] args)
        {
            int Somar(int a, int b)
            {
                return a + b;
            }

            if(args.Length != 2)
            {
                return;
            }

            Console.WriteLine(Somar(int.Parse(args[0]), int.Parse(args[1])));
            return;
        }
        public void InstrucoesTryCatchFinallyThrow(string[] args)
        {
            double Dividir(double x, double y)
            {
                if (y == 0)
                    throw new DivideByZeroException("Não é possível realizar divisão por zero!");
            
                return x / y;
            }
            
            try
            {
                if(args.Length != 2)
                {
                    throw new InvalidOperationException("Informe 2 números");
                }
                double x = double.Parse(args[0]);
                double y = double.Parse(args[1]);
                Console.WriteLine(Dividir(x, y));
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine(e.Message);             
            }
            catch(Exception e)
            {
                Console.WriteLine($"Erro generico: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Até breve!");
            }
        }

        public void InstrucaoUsing(string[] args)
        {
            using (System.IO.TextWriter w = System.IO.File.CreateText("Teste.txt"))
            {
                w.WriteLine("Line 1");
                w.WriteLine("Line 2");
                w.WriteLine("Line 3");
            }
        }
    }
}