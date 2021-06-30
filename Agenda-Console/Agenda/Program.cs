using System;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Eliezer Ladeira", "99946-0537", "eliezerladeira@yahoo.com.br");
            Pessoa p2 = new Pessoa();
            PessoaFisica pf = new PessoaFisica("Nome", "telefone", "email", "rg", "cpf");
            //p1.nome = "Eliezer Ladeira";
            //p1.telefone = "99946-0537";
            //p1.email = "eliezerladeira@yahoo.com.br";
            p1.exibeDados();
            
            //pf.nome = "Pessoa";
            //pf.telefone = "telefone";
            //pf.email = "email";
            //pf.rg = "rg";
            //pf.cpf = "cpf";
            pf.exibeDados();

            Console.ReadKey();
        }
    }
}