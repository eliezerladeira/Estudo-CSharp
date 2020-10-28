using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParOuImpar
{
    class Program
    {
        static public Boolean numeroPar(int num)
        {
            Boolean retorno = false;
            if (num % 2 == 0) retorno = true;
            return retorno;
        }

        static void Main(string[] args)
        {
            int n = 0; // r = 0;
            Boolean par = false;
            String op = "s";

            while (op == "s")
            {
                Console.Clear();
                Console.WriteLine("Verifica se o número informado é par ou ímpar");

                Console.Write("Informe um número: ");
                n = Convert.ToInt32(Console.ReadLine());
                //r = n % 2;
                par = numeroPar(n);

                //if (r == 0)
                if (par == true)
                {
                    Console.WriteLine("O número infomado é par.");
                }
                else
                {
                    Console.WriteLine("O número infomado é ímpar.");
                }
                Console.ReadKey();

                op = "X";

                while (op != "s" && op != "n") {
                    Console.Write("Deseja verificar outro número? (s/n): ");
                    op = Console.ReadLine();
                    // converte o s para minúsculo
                    op = op.ToLower();
                }
            }
        }
    }
}