using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassagemPorValorReferencia
{
    class Program
    {
        static void passagemPorValor(int a)
        {
            a = 10;
        }

        static void passagemPorReferencia(ref int a)
        {
            a = 10;
        }

        static void Main(string[] args)
        {
            int n = 5;
            passagemPorValor(n);
            Console.WriteLine("Passagem de parâmetros por valor: " + n);

            passagemPorReferencia(ref n);
            Console.WriteLine("Passagem de parâmetros por referência: " + n);
            Console.ReadKey();
        }
    }
}
