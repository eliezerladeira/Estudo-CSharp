using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda
{
    // herança (dois pontos)
    class PessoaFisica : Pessoa
    {
        private string _rg;
        private string _cpf;

        // construtor - dois pontos chamo o construtor da classe pai (base)
        public PessoaFisica(string nome, string telefone, string email, string rg, string cpf) : base(nome, telefone, email)
        {
            this.rg = rg;
            this.cpf = cpf;
        }

        public PessoaFisica() : base()
        {
            this.rg = "";
            this.cpf = "";
        }

        public string rg
        {
            get { return this._rg; }
            set { this._rg = value; }
        }

        public string cpf
        {
            get { return this._cpf; }
            set { this._cpf = value; }
        }

        // polimorfismo
        // posso reescrever um método de uma classe pai (superclasse)
        public void exibeDados()
        {
            // usando 'base', eu tenho acesso a tudo da classe pai
            base.exibeDados();
            Console.WriteLine("RG: " + this.nome);
            Console.WriteLine("CPF: " + this.nome);
        }
    }
}