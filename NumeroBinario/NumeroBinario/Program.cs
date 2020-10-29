using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            // converte um número decimal para binário
            int num = 0;
            int resto = 0;
            string numBinario = "";

            Console.WriteLine("Converte um número decimal para binário");
            Console.Write("Informe um número: ");
            num = Convert.ToInt32(Console.ReadLine());

            while (num / 2 >= 1)
            {
                numBinario = Convert.ToString(num % 2) + numBinario;
                num = num / 2;
            }

            numBinario = Convert.ToString(num) + numBinario;
            Console.WriteLine("A conversão do número informado é: " + numBinario);
            Console.ReadKey();
        }
    }
}