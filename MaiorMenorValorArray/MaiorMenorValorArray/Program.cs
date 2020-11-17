using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorMenorValorArray
{
    class Program
    {
        static Double MaiorValor(Double[] v, int tl)
        {
            Double maior = v[0];

            for (int i = 1; i < tl; i++)
            {
                if (maior < v[i])
                {
                    maior = v[i];
                }
            }
            return maior;
        }

        static Double MenorValor(Double[] v, int tl)
        {
            Double menor = v[0];

            for (int i = 1; i < tl; i++)
            {
                if (menor > v[i])
                {
                    menor = v[i];
                }
            }
            return menor;
        }

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
                maior = MaiorValor(valores, tl);
                menor = MenorValor(valores, tl);
            } else {
                Console.WriteLine("Nenhum valor foi informado pelo usuário");
            }
            Console.WriteLine("Maior valor: " + maior);
            Console.WriteLine("Menor valor: " + menor);
            Console.ReadKey();
        }
    }
}