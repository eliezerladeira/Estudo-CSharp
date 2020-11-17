using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorMenorValorArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0; int tl = 0;
            Double maior = 0; Double menor = 0;
            Double[] valores = new double[100];

            Console.WriteLine("Programa que determina o maior e menor valor informados pelo usuário");
            Console.Write("Quantos números deseja informar? ");
            tl = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < tl; i++)
            {
                Console.Write("Informar um número: ");
                valores[i] = Convert.ToDouble(Console.ReadLine());
            }

            i = 0;

            if (tl > 0)
            {
                maior = valores[0];
                menor = valores[0];

                for (i = 1; i < tl; i++)
                {
                    if (maior < valores[i])
                    {
                        maior = valores[i];
                    }

                    if (menor > valores[i])
                    {
                        menor = valores[i];
                    }
                }
            } else {
                Console.WriteLine("Nenhum valor foi informado pelo usuário");
            }
            Console.WriteLine("Maior valor: " + maior);
            Console.WriteLine("Menor valor: " + menor);
            Console.ReadKey();
        }
    }
}