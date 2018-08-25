using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema
{
    class Problema02
    {
        static void Main(string[] args)
        {
            int inicial = 0;
            int final = 0;
            bool sucesso = true;

            Console.WriteLine("Digite dois valores a seguir:");
            string entradaNum1 = Console.ReadLine();
            string entradaNum2 = Console.ReadLine();

            inicial = FormatarValor(entradaNum1);
            final = FormatarValor(entradaNum2);

            Console.WriteLine("-----------");
            Console.WriteLine("Lista de números primos");

            Console.WriteLine(GerarListaDeNumerosPrimos(inicial, final));
            Console.ReadLine();
        }

        public static int FormatarValor(string str)
        {
            try
            {
                return int.Parse(str);
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FormatarValor]: " + ex.Message);
            }
            // Caso caia na exception
            return 0;
        }

        public static string GerarListaDeNumerosPrimos(int inicial, int final)
        {
            string text = string.Empty;

            if (inicial > 0 && inicial < final)
            {

                for (int i = inicial; i <= final; i++)
                {
                    if (IsNumeroPrimo(i))
                        text += i + " ";
                }
            }

            if (text.Equals(string.Empty))
                return "Valor invalido";
            
            return text;
        }

        // int 13
        public static bool IsNumeroPrimo(int n)
        {
            try
            {
                int divisivel = 0;

                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        divisivel++;
                    }
                }

                if (divisivel == 2)
                {
                    return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                Console.WriteLine("[IsNumeroPrimo]: " + ex.Message);
                return false;
            }
            
        }
    }
}