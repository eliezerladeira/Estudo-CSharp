using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhandoComObjetos
{
    class Pessoa
    {
        //private string nome;
        //private double altura;
        private string _nome;
        private double _altura;

        /*
        public void setNome(string valor)
        {
            //nome = valor;
            this.nome = valor;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setAltura(double valor)
        {
            //nome = valor;
            this.altura = valor;
        }

        public double getAltura()
        {
            return this.altura;
        }
        */

        public string nome
        {
            get
            {
                return this._nome;
            }
            set
            {
                this._nome = value;
            }
        }

        public double altura
        {
            get
            {
                return this._altura;
            }
            set
            {
                this._altura = value;
            }
        }

        public void faleSobreVoce()
        {
            Console.WriteLine("Meu nome é: " + nome);
            Console.WriteLine("Eu tenho " + altura + " metros de altura");
        }
    }
}