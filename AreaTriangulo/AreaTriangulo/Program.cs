using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            // calcular a área de um triângulo
            double baseTri = 0, alturaTri = 0;

            Console.WriteLine("Calcula a área de um triângulo");

            Console.WriteLine("Informe a base do triângulo: ");
            baseTri = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a altura do triângulo: ");
            alturaTri = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Área = " + ((baseTri * alturaTri) / 2));
            Console.ReadKey();
        }
    }
}