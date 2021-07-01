using System;

namespace _3_Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, diferenca;

            Console.Write("Digite o primeiro valor: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro valor: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Digite o quarto valor: ");
            d = int.Parse(Console.ReadLine());

            diferenca = (a * b - c * d);

            Console.WriteLine(diferenca);
        }
    }
}
