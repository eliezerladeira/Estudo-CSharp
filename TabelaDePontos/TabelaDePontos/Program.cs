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
            Console.WriteLine("5 - Listar Times");
            Console.WriteLine("100 - Sair");

            Console.Write("O que deseja fazer? ");
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
                    Console.WriteLine("----Cadastro de time----");
                    Console.Write("Nome do time: ");
                    String nome = Console.ReadLine();
                    Console.Write("Pontos do time: ");
                    int ponto = Convert.ToInt32(Console.ReadLine());

                    nomes[tl] = nome;
                    pontos[tl] = ponto;
                    lastcod++;
                    codigos[tl] = lastcod;
                    tl++;
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

                if (op == 5)
                {
                    Console.WriteLine("Lista de times");
                    for (int i = 0; i < tl; i++)
                    {
                        Console.Write("Código: " + codigos[i] + " - Nome: " + nomes[i] + " - Pontos: " + pontos[i]);
                        Console.WriteLine();
                    }
                }
                Console.ReadKey();
            }
        }
    }
}