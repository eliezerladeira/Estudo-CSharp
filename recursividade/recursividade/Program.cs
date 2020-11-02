using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursividade
{
    class Program
    {
        static void ExibeMensagem(string msg, int n)
        {
            int i = 0;
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine(msg); ;
            }
        }

        static void ExibeMensagemRecursiva(string msg, int n)
        {
            if (n > 0)
            {
                Console.WriteLine(msg);
                ExibeMensagemRecursiva(msg, n - 1);
            }
        }

        static int Multiplica(int a, int b)
        {
            int resp = 0;
            if (b > 0)
            {
                resp = a + Multiplica(a, b - 1);
            }
            return resp;
        }

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("6 x 3 = " + Multiplica(6, 3));
            Console.ReadKey();
        }
    }
}