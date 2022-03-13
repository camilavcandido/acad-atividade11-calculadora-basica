using System;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            calculadora.historicoOperacao = new Historico[100];

            do
            {
                apresentaMensagem("Calculadora Básica - Refatoração", ConsoleColor.Cyan);

                decimal valor1, valor2;
                string opcao = apresentaMenu();

                switch (opcao)
                {
                    case "1":
                        valor1 = obtemPrimeiroNumero();
                        valor2 = obtemSegundoNumero();
                        Console.WriteLine("Resultado: {0}", calculadora.Somar(valor1, valor2));
                        break;
                    case "2":
                        valor1 = obtemPrimeiroNumero();
                        valor2 = obtemSegundoNumero();
                        Console.WriteLine("Resultado: {0}", calculadora.Subtrair(valor1, valor2));
                        break;
                    case "3":
                        valor1 = obtemPrimeiroNumero();
                        valor2 = obtemSegundoNumero();
                        Console.WriteLine("Resultado: {0}", calculadora.Multiplicar(valor1, valor2));
                        break;
                    case "4":
                        valor1 = obtemPrimeiroNumero();
                        valor2 = obtemSegundoNumero();
                        if (valor2 == 0)
                            Console.WriteLine("Não é possível realizar divisão por 0");
                        else
                            Console.WriteLine("Resultado: {0}", calculadora.Dividir(valor1, valor2));
                        break;
                    case "5":
                        calculadora.ExibirHistorico();
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        apresentaMensagem("Por favor, escolha uma opção válida!", ConsoleColor.Yellow);
                        break;

                }

                Console.ReadLine();
                Console.Clear();
            } while (true);

        }

        #region metodos
        static void apresentaMensagem(string msg, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        static string apresentaMenu()
        {

            string opcao;

            Console.WriteLine("Digite 1 - para somar \n" +
                "Digite 2 - para subtrair\n" +
                "Digite 3 - multiplicar \n" +
                "Digite 4 - para dividir\n" +
                "Digite 5 - visualizar histórico\n" +
                "Digite 0 -  sair");

            apresentaMensagem("Escolha Opção: ", ConsoleColor.Blue);
            opcao = Console.ReadLine();
            return opcao;
        }

        static decimal obtemPrimeiroNumero()
        {
            string strPrimeiroNumero;
            decimal primeiroNumero;

            Console.WriteLine("Digite o primeiro número: ");
            strPrimeiroNumero = Console.ReadLine();
            primeiroNumero = Convert.ToDecimal(strPrimeiroNumero);

            return primeiroNumero;
        }

        static decimal obtemSegundoNumero()
        {
            string strSegundoNumero;
            decimal segundoNumero;

            Console.WriteLine("Digite o segundo número: ");
            strSegundoNumero = Console.ReadLine();
            segundoNumero = Convert.ToDecimal(strSegundoNumero);

            return segundoNumero;
        }
        #endregion
    }
}



