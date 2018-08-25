using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema05
{
    public class ContaCorrente
    {
        public int NumeroConta { get; set; }
        public string NomeCorrentista { get; private set; }
        public double Saldo { get; private set; }

        public ContaCorrente(int numeroConta, string nomeCorrentista, double saldo = 0)
        {
            this.NumeroConta = numeroConta;
            this.NomeCorrentista = nomeCorrentista;
            this.Saldo = saldo;
        }

        public void alterarNome(string nome)
        {
            if (nome.Equals(string.Empty))
            {
                return;
            }
            this.NomeCorrentista = nome;
        }

        public void deposito(double valor)
        {
            if(valor < 0)
            {
                return;
            }
            this.Saldo += valor;
        }

        public bool saque(double valor)
        {
            if(valor < 0 || valor > this.Saldo)
            {
                return false;
            }

            this.Saldo -= valor;
            return true;
        }

    }
}
