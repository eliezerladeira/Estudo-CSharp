using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorValor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Desenvolva um programa que determine o maior valor informado pelo usuário.
             * O usuário deverá informar 4 valores.
             * */
            int n = 0, maior = 0;

            Console.WriteLine("Determina o maior valor");

            Console.Write("Informe o 1 valor: ");
            n = Convert.ToInt32(Console.ReadLine());
            maior = n;

            Console.Write("Informe o 2 valor: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n > maior)
            {
                maior = n;
            }

            Console.Write("Informe o 3 valor: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n > maior)
            {
                maior = n;
            }

            Console.Write("Informe o 4 valor: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n > maior)
            {
                maior = n;
            }

            Console.WriteLine("O maior valor informado é: " + maior);
            Console.ReadKey();
        }
    }
}