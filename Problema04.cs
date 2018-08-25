using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema04
{
    class Problema04
    {
        static void Main(string[] args)
        {
            const double VALOR_LATA_DE_TINTA = 80.0;
            const int LITROS_POR_LATA_DE_TINTA = 18;
            int qtdLatasDeTinta;

            double areaMetrosQuadrados = 0; //metros quadrados

            Console.Write("Digite a area em m² que deseja pintar: ");
            try
            {
                areaMetrosQuadrados = Convert.ToDouble(Console.ReadLine());
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Erro ao converter valor: " + ex.Message.ToString());
            }

            qtdLatasDeTinta = CalcularLatasNecessarias(CalcularTintaNecessaria(areaMetrosQuadrados));

            double preçoTotal = CalcularPreço(VALOR_LATA_DE_TINTA, qtdLatasDeTinta);

            Console.WriteLine("Para realizar a pintura de {0}m², será necessário {1} lata(s) de tinta.", areaMetrosQuadrados, qtdLatasDeTinta);
            Console.WriteLine("O valor total é de R${0}", preçoTotal.ToString("0.00"));
            Console.ReadLine();
        }

        public static int CalcularTintaNecessaria(double areaMetrosQuadrados)
        {
            int litros = 0;
            if(areaMetrosQuadrados <= 0)
            {
                return litros;
            }
            litros = (int) Math.Ceiling(areaMetrosQuadrados / 3);
            return litros;
        }

        public static int CalcularLatasNecessarias(int qtdTinta)
        {
            int latas = 0;
            if(qtdTinta <= 0)
            {
                return latas;
            }
            latas = (int) Math.Ceiling(qtdTinta / 18.0); 
            return latas;
        }

        public static double CalcularPreço(double preçoLata, int qtdLatas)
        {
            return preçoLata * qtdLatas;
        }
    }
}
