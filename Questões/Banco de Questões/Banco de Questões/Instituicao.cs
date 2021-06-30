using System;

namespace Banco_de_Questões
{
    public class Instituicao
    {
        private int _instituicaoID;
        private string _instituicao;
        private DateTime _dataCriacao;
        private DateTime _dataAlteracao;

        public int InstituicaoID
        {
            get { return _instituicaoID; }
            set { _instituicaoID = value; }
        }

        public string Instituicao
        {
            get { return _instituicao; }
            set { _instituicao = value; }
        }

        public DateTime DataCriacao
        {
            get { return _dataCriacao; }
            set { _dataCriacao = value; }
        }

        public DateTime DataAlteracao
        {
            get { return _dataAlteracao; }
            set { _dataAlteracao = value; }
        }

        public Instituicao()
        {

        }

        public Instituicao(string instituicao, DateTime dataCadastro, DateTime dataAlteracao)
        {
            this.Instituicao = instituicao;
            this.DataCriacao = dataCadastro;
            this.DataAlteracao = dataAlteracao;
        }
    }
}