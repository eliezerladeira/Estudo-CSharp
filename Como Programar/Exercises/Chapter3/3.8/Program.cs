using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 0;

            Console.Write("Digite o primeiro número: " );
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(n1 + " + " + n2 + " = " + (n1 + n2));
            Console.WriteLine(n1 + " - " + n2 + " = " + (n1 - n2));
            Console.WriteLine(n1 + " * " + n2 + " = " + (n1 * n2));
            Console.WriteLine(n1 + " / " + n2 + " = " + (n1 / n2));

            Console.ReadKey();
        }
    }
}
