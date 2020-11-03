using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10, n2 = 4, n3 = 6, n4 = 3, n5 = 9, soma = 0, media = 0;

            // implementar a leitura dos valores

            soma = n1 + n2 + n3 + n4 + n5;
            media = soma / 5;

            Console.WriteLine("(" + n1 + "+" + n2 + "+" + n3 + "+" + n4 + "+" + n5 + ") / 5 = " + media);
            Console.ReadKey();

            soma = 0;

            int[] vetor = new int[5];
            vetor[0] = 10;
            vetor[1] = 4;
            vetor[2] = 6;
            vetor[3] = 3;
            vetor[4] = 9;

            for (int i = 0; i < 5; i++)
            {
                soma = soma + vetor[i];
            }
            media = soma / 5;

            Console.Write("(");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(vetor[i]);

                if (i != 4)
                { Console.Write(" +"); }
                else
                { Console.Write(" )/5 = "); }
            }
            Console.WriteLine(media);
            Console.ReadKey();
        }
    }
}