using System;
namespace Calculadora.ConsoleApp
{
    public class Calculadora
    {
        public decimal valor1;
        public decimal valor2;
        public Historico[] historicoOperacao;

        public decimal Somar(decimal valor1, decimal valor2)
        {
            Historico historico = new Historico();
            historico.operador = "+";
            historico.valor1 = valor1;
            historico.valor2 = valor2;
            historico.resultado = valor1 + valor2;
            addHistorico(historico);
            return valor1 + valor2;
        }

        public decimal Subtrair(decimal valor1, decimal valor2)
        {
            Historico historico = new Historico();
            historico.operador = "-";
            historico.valor1 = valor1;
            historico.valor2 = valor2;
            historico.resultado = valor1 - valor2;
            addHistorico(historico);
            return valor1 - valor2;
        }

        public decimal Multiplicar(decimal valor1, decimal valor2)
        {
            Historico historico = new Historico();
            historico.operador = "*";
            historico.valor1 = valor1;
            historico.valor2 = valor2;
            historico.resultado = valor1 * valor2;
            addHistorico(historico);
            return valor1 * valor2;
        }

        public decimal Dividir(decimal valor1, decimal valor2)
        {
            if(valor2 != 0)
            {
            Historico historico = new Historico();
            historico.operador = "/";
            historico.valor1 = valor1;
            historico.valor2 = valor2;
            historico.resultado = valor1 / valor2;
            addHistorico(historico);
            }
            return valor1 / valor2;

        }

        public void addHistorico(Historico historico)
        {
            for (int i = 0; i < historicoOperacao.Length; i++)
            {
                if (historicoOperacao[i] == null)
                {
                    historicoOperacao[i] = historico;
                    break;
                }
            }
        }

        public void ExibirHistorico()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Histórico da Calculadora");
            Console.ResetColor();

            if (historicoOperacao[0] == null)
                Console.WriteLine("Histórico vázio");
            else

            {
                for (int i = 0; i < historicoOperacao.Length; i++)
                {
                    if (historicoOperacao[i] == null)
                        break;
                    else
                    {
                        Console.WriteLine(historicoOperacao[i].valor1 + " " + 
                               historicoOperacao[i].operador + " " +
                               historicoOperacao[i].valor2 + " = " +
                               historicoOperacao[i].resultado);
                    }
                }


            }
        }
    }
}


          