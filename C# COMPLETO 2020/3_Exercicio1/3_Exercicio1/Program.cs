using System;

namespace _3_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int soma;

            Console.Write("Digite o primeiro número inteiro: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número inteiro: ");
            num2 = int.Parse(Console.ReadLine());

            soma = num1 + num2;

            Console.WriteLine("SOMA = " + soma);
        }
    }
}
