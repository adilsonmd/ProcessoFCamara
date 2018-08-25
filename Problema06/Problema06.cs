using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema06
{
    class Problema06
    {
        static void Main(string[] args)
        {
            double comprimentoLocal = 0;
            double larguraLocal = 0;

            // Perimetro
            double quantidadeRodape = 0;
            // Area
            double quantidadePiso = 0;

            try
            {
                Console.Write("Digite o comprimento do retângulo: ");
                comprimentoLocal = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a largura do retângulo: ");
                larguraLocal = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Erro ao converter: " + ex.Message.ToString());
            }

            Retangulo ret = new Retangulo();
            ret.MudarValorDosLados(comprimentoLocal, larguraLocal);

            quantidadeRodape = ret.CalcularPerimetro();
            quantidadePiso = ret.CalcularArea();

            Console.WriteLine("Quantidade necessária de rodapés é de {0}m", quantidadeRodape);
            Console.WriteLine("Quantidade necessária de pisos é de {0}m²", quantidadePiso);

            Console.ReadLine();
        }
    }
}
