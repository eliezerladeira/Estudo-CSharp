using System;

namespace _3_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio;
            double area;

            Console.Write("Digite o valor do raio do círculo: ");
            raio = double.Parse(Console.ReadLine());

            area = 3.14159 * Math.Pow(raio, 2.0);

            Console.WriteLine("A = " + area.ToString("F4"));
        }
    }
}
