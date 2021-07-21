using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._9
{
    class Program
    {
        /* Pega como entrada do usuário o raio de um círculo e calcula o diâmetro, a circunferência e a área.
         * r é o raio, diâmetro = 2r, circunferência = 2pir, área = pir2*/
        static void Main(string[] args)
        {
            int r = 0;

            Console.Write("Digite o raio: ");
            r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Diâmetro: " + (2 * r));
            Console.WriteLine("Circunferência: " + (2 * 3.14 * r));
            Console.WriteLine("Área: " + (3.14 * (r * r)));
            Console.ReadKey();
        }
    }
}
