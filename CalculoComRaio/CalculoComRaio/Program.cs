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
            Double retorno = 2 * r;
            return retorno;
        }

        static Double calculaArea(Double r)
        {
            return 3.14 * (r * r);
        }

        static Double calculaCircunferencia(Double r)
        {
            return 2 * 3.14 * r;
        }

        static void exibeResultado(Double a, Double b, Double c)
        {
            Console.WriteLine("Área: " + a);
            Console.WriteLine("Diâmetro: " + calculaDiametro(b));
            Console.WriteLine("Circunferência: " + calculaCircunferencia(c));
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

            exibeResultado(area, calculaDiametro(raio), calculaCircunferencia(raio));
            Console.ReadKey();
        }
    }
}