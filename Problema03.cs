using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema03
{
    class Problema03
    {
        static void Main(string[] args)
        {
            int horasTrabalhadas = 0;
            double valSalarioMinimo = 0.0;
            double salarioBruto = 0.0;
            double salarioLiquido = 0.0;
            double imposto = 3; //3%

            try
            {
                Console.WriteLine("Digite as horas trabalhadas:");
                horasTrabalhadas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o valor do salario minimo");
                valSalarioMinimo = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Erro de conversão: " + ex.Message.ToString());
            }

            double horaTrabalho = CalcularHoraTrabalho(valSalarioMinimo);

            salarioLiquido = CalcularSalarioLiquido(CalcularSalarioBruto(horasTrabalhadas, horaTrabalho), imposto);

            Console.WriteLine("O salário a receber é de R${0}", salarioLiquido);
            Console.ReadLine();
        }

        public static double CalcularHoraTrabalho(double valorSalarioMinimo)
        {
            return valorSalarioMinimo * 0.10;
        }

        public static double CalcularSalarioBruto(int horasTrabalhadas, double valorHoraTrabalho)
        {
            return horasTrabalhadas * valorHoraTrabalho;
        }

        public static double CalcularSalarioLiquido(double salarioBruto, double imposto)
        {
            return salarioBruto - (salarioBruto * (imposto/100));
        }
    }
}
