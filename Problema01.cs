using System;

namespace ProcessoFCamara
{
    class Problema01
    {
        static void Main(string[] args)
        {
            #region Variáveis do problema
            double salarioInicial = 1000.0;
            int anoDeEntrada = 2005;
            int anoCorrente = 2018;
            double taxaDeAumento = 1.5; // 1.5%

            double salarioFinal = salarioInicial;
            #endregion

            // Aumentos de salario a partir de 2006
            for (int ano = anoDeEntrada + 1; ano <= anoCorrente; ano++)
            {
                if(ano >= 2007)
                {
                    taxaDeAumento = AjustarTaxa(taxaDeAumento);
                }
                salarioFinal = AumentarSalario(salarioFinal, taxaDeAumento);
            }

            Console.WriteLine("No ano de " + anoCorrente + " o salario do funcionário é de R$" + 
                salarioFinal.ToString("0,000.00"));

            Console.ReadLine();
        }
        
        public static double AumentarSalario(double salario, double valorTaxa)
        {
            return salario + (salario * (valorTaxa / 100));

        }

        public static double AjustarTaxa(double valorTaxa)
        {
            return valorTaxa * 2;
        }
    }
}
