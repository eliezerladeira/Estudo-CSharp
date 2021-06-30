using System;

namespace TrabalhandoComObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Trabalha com objetos do tipo pessoa
             * */
            string entrada = "";
            Pessoa pessoa1;
            pessoa1 = new Pessoa();

            Console.WriteLine(("Efetua a leitura dos dados de três pessoas");

            Console.WriteLine("Dados da 1 pessoa");
            Console.Write("Informe o seu nome: ");
            entrada = Console.ReadLine();
            //pessoa1.setNome(entrada);
            pessoa1.nome = entrada;
            Console.Write("Informe a sua altura: ");
            entrada = Console.ReadLine();
            //pessoa1.setAltura(Convert.ToDouble(entrada));
            pessoa1.altura = Convert.ToDouble(entrada);

            pessoa1.faleSobreVoce();
            Console.ReadKey();
        }
    }
}