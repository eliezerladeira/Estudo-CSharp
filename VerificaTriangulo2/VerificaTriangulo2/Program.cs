using System;

namespace VerificaTriangulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            Triangulo objeto;

            Console.WriteLine("Verifica se três valores informados formam um triângulo");

            Console.Write("Lado A: ");
            entrada = Console.ReadLine();

            objeto = new Triangulo();

            objeto.ladoA = Convert.ToInt32(entrada);

            Console.Write("Lado B: ");
            entrada = Console.ReadLine();
            objeto.ladoB = Convert.ToInt32(entrada);

            Console.Write("Lado C: ");
            entrada = Console.ReadLine();
            objeto.ladoC = Convert.ToInt32(entrada);

            objeto.VerificaTriangulo();
            Console.ReadKey();
        }
    }
}
