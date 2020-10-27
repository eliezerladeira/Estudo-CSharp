using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dialogo
{
    class Program
    {
        static void Main(string[] args)
        {
            String usuarioNome = "";
            Console.WriteLine("Diálogo entre o PC e o usuário");
            Console.Write("Qual o seu nome? ");
            usuarioNome = Console.ReadLine();
            Console.WriteLine("Olá " + usuarioNome);
            Console.ReadKey();
        }
    }
}