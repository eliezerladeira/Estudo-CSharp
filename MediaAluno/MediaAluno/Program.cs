using System;

namespace MediaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            // calcular a média de um aluno
            Aluno obj = new Aluno();
            string entrada = "";

            Console.WriteLine("Calcula a média de um aluno");

            Console.Write("Aluno: ");
            entrada = Console.ReadLine();
            obj.nome = entrada;

            Console.Write("Nota 1: ");
            entrada = Console.ReadLine();
            obj.nota1 = Convert.ToDouble(entrada);

            Console.Write("Nota 2: ");
            entrada = Console.ReadLine();
            obj.nota2 = Convert.ToDouble(entrada);

            Console.Write("Nota 3: ");
            entrada = Console.ReadLine();
            obj.nota3 = Convert.ToDouble(entrada);

            Console.Write("Nota 4: ");
            entrada = Console.ReadLine();
            obj.nota4 = Convert.ToDouble(entrada);

            obj.exibeMedia();
            Console.ReadKey();
        }
    }
}
