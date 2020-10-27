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
            // variáveis do tipo String
            int valor1 = 0;
            int valor2 = 0;
            int total = 0;
            String entrada = "";

            Console.WriteLine("Programa que realiza a soma de dois números - int");

            Console.Write("Informe o 1º valor: ");
            entrada = Console.ReadLine();
            valor1 = Convert.ToInt32(entrada);

            Console.Write("Informe o 2º valor: ");
            entrada = Console.ReadLine();
            valor2 = Convert.ToInt32(entrada);

            total = valor1 + valor2;
            Console.WriteLine(valor1 + " + " + valor2 + " = " + total);
            Console.ReadKey();

            // variáveis do tipo double
            double valor3 = 0;
            double valor4 = 0;
            double total1 = 0;

            Console.WriteLine("Programa que realiza a soma de dois números - double");

            Console.Write("Informe o 1º valor: ");
            valor3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o 2º valor: ");
            valor4 = Convert.ToDouble(Console.ReadLine());

            total1 = valor3 + valor4;
            Console.WriteLine(valor3 + " + " + valor4 + " = " + total1);
            Console.ReadKey();
        }
    }
}