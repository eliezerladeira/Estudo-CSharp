using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelaDePontos
{
    class Program
    {
        static void ListaTimes(int[] codigos, String[] nomes, int[] pontos, int tl)
        {
            Console.WriteLine("Lista de times");
            for (int i = 0; i < tl; i++)
            {
                Console.Write("Código: " + codigos[i] + " - Nome: " + nomes[i] + " - Pontos: " + pontos[i]);
                Console.WriteLine();
            }
        }

        static void RemoveTimes(int[] codigos, String[] nomes, int[] pontos, ref int tl, int cod)
        {
            int p = LocalizaTimeCodigo(codigos, nomes, pontos, tl, cod);

            //p é a posição do time no vetot
            if (p >= 0)
            {
                for (int i = p; i < tl-1; i++)
                {
                    //reposiciona os elementos um indice abaixo, pois um valor de indice foi apagado
                    codigos[i] = codigos[i + 1];
                    nomes[i] = nomes[i + 1];
                    pontos[i] = pontos[i + 1];
                }
                tl--;
            }
        }

        static void InsereTimes(int[] codigos, String[] nomes, int[] pontos, ref int tl, ref int lastcod, String nome, int ponto)
        {
            nomes[tl] = nome;
            pontos[tl] = ponto;
            lastcod++;
            codigos[tl] = lastcod;
            tl++;
        }

        static int LocalizaTimeCodigo(int[] codigos, String[] nomes, int[] pontos, int tl, int cod)
        {
            int i = 0;
            int r = -1;

            for (i = 0; i < tl; i++)
            {
                if (codigos[i] == cod)
                {
                    break;
                }
            }

            if (i < tl) r = i;

            return r;
        }

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
            String nome = "";
            int ponto = 0;

            while (op != 100)
            {
                op = ExibeMenu();
                Console.Clear();

                if (op == 1) // inserir
                {
                    Console.WriteLine("----Cadastro de time----");
                    Console.Write("Nome do time: ");
                    nome = Console.ReadLine();
                    Console.Write("Pontos do time: ");
                    ponto = Convert.ToInt32(Console.ReadLine());

                    InsereTimes(codigos, nomes, pontos, ref tl, ref lastcod, nome, ponto);
                }

                if (op == 2) // excluir
                {
                    Console.WriteLine("----Remove time----");
                    Console.Write("Código do time: ");

                    int cod = Convert.ToInt32(Console.ReadLine());
                    RemoveTimes(codigos, nomes, pontos, ref tl, cod);

                }

                if (op == 3) // alterar
                {

                }

                if (op == 4) // localizar
                {
                    Console.Write("----Localiza Time----");
                    Console.Write("Informe o código do time: ");

                    int cod = Convert.ToInt32(Console.ReadLine());
                    int p = LocalizaTimeCodigo(codigos, nomes, pontos, tl, cod);

                    if (p > 0) Console.WriteLine("O time está armazenado na posição " + p);
                    else Console.WriteLine("Time não encontrado!");
                }

                if (op == 5) // listar
                {
                    ListaTimes(codigos, nomes, pontos, tl);
                }
                Console.ReadKey();
            }
        }
    }
}