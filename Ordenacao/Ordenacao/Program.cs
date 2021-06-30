using System;

namespace Ordenacao
{
    class Program
    {
        static void Main(string[] args)
        {
            // programa que exibe em ordem crescente três vslores informados pelo usuario
            int v1 = 0;
            int v2 = 0;
            int v3 = 0;
            int aux = 0;

            Console.WriteLine("Exibe em ordem crescente três valores informados");

            Console.Write("Informe o 1 valor: ");
            v1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o 2 valor: ");
            v2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o 3 valor: ");
            v3 = Convert.ToInt32(Console.ReadLine());

            if (v1 > v2)
            {
                aux = v1;
                v1 = v2;
                v2 = aux;
            }

            if (v1 > v3)
            {
                aux = v1;
                v1 = v3;
                v3 = aux;
            }

            if (v2 > v3)
            {
                aux = v2;
                v2 = v3;
                v3 = aux;
            }

            Console.WriteLine("Valores ordenados: " + v1 + ", " + v2 + ", " + v3);
            Console.ReadKey();
        }
    }
}