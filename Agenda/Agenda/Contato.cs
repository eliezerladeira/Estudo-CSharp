using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Contato
    {
        public Contato()
        {
            this.Codigo = 0;
            this.Nome = "";
            this.Email = "";
            this.Fone = "";
            this.Rua = "";
            this.Bairro = "";
            this.Cidade = "";
            this.Estado = "";
            this.Cep = "";
        }

        public Contato(int codigo, string nome, string email, string fone, string rua, string bairro, string cidade, string estado, string cep)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Email = email;
            this.Fone = fone;
            this.Rua = rua;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Cep = cep;
        }

        private int _con_cod;
        private string _con_nome;
        private string _con_email;
        private string _con_fone;
        private string _con_rua;
        private string _con_bairro;
        private string _con_cidade;
        private string _con_estado;
        private string _con_cep;

        public int Codigo
        {
            get { return this._con_cod; }
            set { this._con_cod = value; }
        }

        public string Nome
        {
            get { return this._con_nome; }
            set { this._con_nome = value; }
        }

        public string Email
        {
            get { return this._con_email; }
            set { this._con_email = value; }
        }

        public string Fone
        {
            get { return this._con_fone; }
            set { this._con_fone = value; }
        }

        public string Rua
        {
            get { return this._con_rua; }
            set { this._con_rua = value; }
        }

        public string Bairro
        {
            get { return this._con_bairro; }
            set { this._con_bairro = value; }
        }

        public string Cidade
        {
            get { return this._con_cidade; }
            set { this._con_cidade = value; }
        }

        public string Estado
        {
            get { return this._con_estado; }
            set { this._con_estado = value; }
        }

        public string Cep
        {
            get { return this._con_cep; }
            set { this._con_cep = value; }
        }
    }
}