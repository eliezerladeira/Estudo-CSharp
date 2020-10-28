using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InverteNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            // inverte 3 dígitos informados
            // Ex.: 978 -> 879
            int ni = 0, c = 0, d = 0, u = 0;

            Console.WriteLine("Programa que mostra o número informado invertido");

            Console.Write("Informe um número de 3 dígitos: ");
            ni = Convert.ToInt32(Console.ReadLine());

            c = ni / 100;
            d = (ni % 100) / 10;
            u = ni % 10;

            Console.Write("O número informado invertido fica: " + u + d + c);
            Console.ReadKey();
        }
    }
}