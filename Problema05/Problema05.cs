using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema05
{
    class Problema05
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(280, "Adilson Alves Mattos");
            conta.deposito(175);
            conta.saque(75);

            Console.WriteLine("Titular: {0}", conta.NomeCorrentista);
            Console.WriteLine("Numero: {0}", conta.NumeroConta);
            Console.WriteLine("Saldo: {0}", conta.Saldo);

            Console.ReadLine();
        }
    }
}
