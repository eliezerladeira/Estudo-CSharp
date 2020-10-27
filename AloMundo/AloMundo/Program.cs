using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AloMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            //exibe mensagem na tela
            Console.WriteLine("Alô Mundo!");
            Console.WriteLine("Segunda aula de C#");
            // writeline quebra linha, write não quebra linha
            Console.Write("Aula feita no dia 27/10/2020");
            Console.Write(" - Segunda aula ");
            Console.Write(2020);
            // aguarda o pressionamento de alguma tecla
            Console.ReadKey();
        }
    }
}