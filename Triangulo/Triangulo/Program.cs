using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Desenvolva um programa para verificar se três valores informados representam os
             * lados de um triângulo. (O comprimento de cada lado do triângulo é menor do que a
             * soma dos comprimentos dos outros dois lados)
             * */
            int a = 0, b = 0, c = 0;

            String msg = "Os valores informados não representam os lados de um triângulo.";
            Console.WriteLine("Verifica se três valores informados representam os lados de um triângulo");

            Console.Write("Informe o valor do lado 1 do triângulo: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o valor do lado 2 do triângulo: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o valor do lado 3 do triângulo: ");
            c = Convert.ToInt32(Console.ReadLine());

            /*
            if (a < b + c)
            {
                if (b < a + c)
                {
                    if (c < b + a)
                    {
                        msg="Os valores informados representam os lados de um triângulo";
                    }
                }
            }
            */

            if ((a < b + c) && (b < a + c) && (c < a + b))
            {
                msg = "Os valores informados representam os lados de um triângulo";
            }

            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}