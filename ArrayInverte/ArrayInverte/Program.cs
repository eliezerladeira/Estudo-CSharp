using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInverte
{
    class Program
    {
        static void ExibirValores(int[] v, int tl)
        {
            Console.WriteLine("Valores presentes no vetor");

            for (int i = 0; i < tl; i++)
            {
                Console.Write(v[i] + ", ");
            }
            Console.WriteLine("");
        }

        static void InverteValores(int [] vet, int tl)
        {
            int j = tl - 1;
            int i = 0;
            int aux = 0;

            while (i < j)
            {
                aux = vet[i];
                vet[i] = vet[j];
                vet[j] = aux;
                j--;
                i++;
            }
        }

        static void Main(string[] args)
        {
            int[] vet = new int[30];
            int tl = 10, i, j, aux;   // tl = tamanho lógico do vetor

            for (i = 0; i < 10; i++)
            {
                vet[i] = (i + 1) * 10;
            }
            
            ExibirValores(vet, tl);
            InverteValores(vet, tl);
            ExibirValores(vet, tl);
            Console.ReadKey();
        }
    }
}