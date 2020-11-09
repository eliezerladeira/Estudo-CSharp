using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0; int tl = 0;
            Double soma = 0, media = 0, valor = 0;
            Double[] valores = new double[100];

            Console.WriteLine("Programa que calcula a média dos valores informados pelo usuário");
            Console.Write("Quantos números deseja informar? ");
            tl = Convert.ToInt32(Console.ReadLine());

            for(i = 0; i < tl; i++)
            {
                Console.Write("Informar um número: ");
                valor = Convert.ToDouble(Console.ReadLine());
                valores[i] = valor;
            }

            soma = 0;
            media = 0;

            for(i = 0; i < tl; i++)
            {
                soma = soma + valores[i];
            }

            media = soma / tl;

            Console.WriteLine("Média = " + media);
            Console.ReadKey();
        }
    }
}