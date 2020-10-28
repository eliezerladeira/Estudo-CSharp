using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Determina o maior e o menor número informado pelo usuário
             * */
            int maior = 0, menor, i = 0, numero = 0, tl = 0;

            Console.WriteLine("Determina o maior e menor número informado pelo usuário");

            Console.Write("Deseja informar quantos números? ");
            tl = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o 1 número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            maior = numero;
            menor = numero;
            i = 1;

            for (i = 2; i <= tl; i++)
            {
                Console.Write("informe o " + i + " número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero < menor)
                {
                    menor = numero;
                }

                if (numero > maior)
                {
                    maior = numero;
                }
            }

            Console.WriteLine("O maior número é: " + maior);
            Console.WriteLine("O menor número é: " + menor);
            Console.ReadKey();
        }
    }
}