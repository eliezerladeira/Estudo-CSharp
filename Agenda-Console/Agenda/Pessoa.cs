using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda
{
    public class Pessoa
    {
        // private eu não tenho acesso fora dessa classe
        // se mudar para protect, serão visíveis para as classes que herdarem essa classe, como a PessoaFisica
        private string _nome;
        private string _email;
        private string _telefone;

        // construtor (coloca apenas a visibilidade e o nome, que é o nome da classe)
        public Pessoa(string nome, string telefone, string email)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
        }

        // construtor com mesmo nome, parâmetros diferentes (sobrecarga)
        public Pessoa()
        {
            this.nome = "";
            this.telefone = "";
            this.email = "";
        }

        public string nome
        {
            get { return this._nome; }
            set { this._nome = value; }
        }

        public string email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        public string telefone
        {
            get { return this._telefone; }
            set { this._telefone = value; }
        }

        public void exibeDados()
        {
            Console.Clear();
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("E-mail: " + this.email);
            Console.WriteLine("Telefone: " + this.telefone);
        }
    }
}