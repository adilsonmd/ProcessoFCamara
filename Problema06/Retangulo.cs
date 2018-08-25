using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema06
{
    public class Retangulo
    {
        public double Comprimento { get; private set; }
        public double Largura { get; private set; }
        
        public void MudarValorDosLados(double comprimento, double largura)
        {
            this.Comprimento = comprimento;
            this.Largura = largura;
        }

        public double[] RetornarValorDosLados()
        {
            return new double[] { this.Comprimento, this.Largura };
        }

        public double CalcularArea()
        {
            return this.Comprimento * this.Largura;
        }

        public double CalcularPerimetro()
        {
            return 2 * (this.Comprimento + this.Largura);
        }
    }
}
