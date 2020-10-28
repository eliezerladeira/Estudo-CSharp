using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoComRaio
{
    class Program
    {
        static Double calculaDiametro(Double r)
        {
            return 2 * r;
        }

        static Double calculaArea(Double r)
        {
            return 3.14 * (r * r);
        }

        static Double calculaCircunferencia(Double r)
        {
            return 2 * 3.14 * r;
        }

        static void Main(string[] args)
        {
            /*
             * Programa que calcula o diâmetro, a área e a circunferência de um círculo,
             * sabendo que o único dado disponível é o seu raio.
             * Fórmulas: Diâmetro = 2*raio
             *           Área = pi*raio2
             *           Circunferência = 2*pi*raio
             * */
            Double raio = 0;
            Double area = 0;

            Console.WriteLine("Calcula o diâmetro, a área e a circunferência de um círculo");

            Console.Write("Informe o raio: ");
            raio = Convert.ToDouble(Console.ReadLine());
            area = calculaArea(raio);

            Console.WriteLine("Área: " + area);
            Console.WriteLine("Diâmetro: " + calculaDiametro(raio));
            Console.WriteLine("Circunferência: " + calculaCircunferencia(raio));
            Console.ReadKey();
        }
    }
}