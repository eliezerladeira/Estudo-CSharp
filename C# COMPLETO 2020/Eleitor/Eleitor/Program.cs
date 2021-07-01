using System;

namespace Eleitor
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Programa que lê a idade de uma pessoa e informa a sua classe
             * eleitoral: não eleitor (abaixo de 16 anos); eleitor obrigatório 
             * (entre 18 e 65 anos); eleitor facultativo (entre 16 e 18 anos e
             * maior de 65 anos)
             * */
            int idade = 0;
            string msg = "";

            Console.WriteLine("Determina a classe eleitoral de uma pessoa");

            Console.Write("Informe sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade < 16)
                msg = "Não é um eleitor!";
            else
            {
                if ((idade >= 18) && (idade <= 65))
                    msg = "Eleitor obrigatório!";
                else
                    msg = "Eleitor facultativo!";
            }

            Console.WriteLine(msg);

            Console.ReadKey();
        }
    }
}