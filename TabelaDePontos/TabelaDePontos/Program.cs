using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelaDePontos
{
    class Program
    {
        static int ExibeMenu()
        {
            int op = 0;
            
            Console.Clear();
            Console.WriteLine("Tabela de pontos dos times brasileiros");
            Console.WriteLine("1 - Inserir Time");
            Console.WriteLine("2 - Excluir Time");
            Console.WriteLine("3 - Alterar Time");
            Console.WriteLine("4 - Localizar Time");
            Console.WriteLine("100 - Sair");

            Console.WriteLine("O que deseja fazer? ");
            op = Convert.ToInt32(Console.ReadLine());
            return op;
        }

        static void Main(string[] args)
        {
            String[] nomes = new string[100];
            int[] codigos = new int[100];
            int[] pontos = new int[100];
            int tl = 0, lastcod = 0, op = 0;

            while (op != 100)
            {
                op = ExibeMenu();

                if (op == 1)
                {

                }

                if (op == 2)
                {

                }

                if (op == 3)
                {

                }

                if (op == 4)
                {

                }
                Console.ReadKey();
            }
        }
    }
}