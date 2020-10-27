using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaDoisNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 0;
            int valor2 = 0;
            int total = 0;
            String entrada = "";

            Console.WriteLine("Programa que realiza a soma de dois números");

            Console.Write("Informe o 1º valor: ");
            entrada = Console.ReadLine();
            valor1 = Convert.ToInt32(entrada);

            Console.Write("Informe o 2º valor: ");
            entrada = Console.ReadLine();
            valor2 = Convert.ToInt32(entrada);

            total = valor1 + valor2;
            Console.WriteLine(valor1 + " + " + valor2 + " = " + total);
            Console.ReadKey();
        }
    }
}