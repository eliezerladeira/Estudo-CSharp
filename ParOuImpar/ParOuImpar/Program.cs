﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, r = 0;

            Console.WriteLine("Verifica se o número informado é par ou ímpar");

            Console.Write("Informe um número: ");
            n = Convert.ToInt32(Console.ReadLine());
            r = n % 2;

            if (r == 0)
            {
                Console.WriteLine("O número infomado é par.");
            }
            else
            {
                Console.WriteLine("O número infomado é ímpar.");
            }
            Console.ReadKey();
        }
    }
}