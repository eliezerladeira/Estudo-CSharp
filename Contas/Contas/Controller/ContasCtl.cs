using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas.Controller
{
    public class ContasCtl
    {
        private string _contaID;

        public string ContaID
        {
            get { return _contaID; }
            set { _contaID = value; }
        }

        private string _contaDescricao;

        public string ContaDescricao
        {
            get { return _contaDescricao; }
            set { _contaDescricao = value; }
        }

        private Boolean _contaAtiva;

        public Boolean ContaAtiva
        {
            get { return _contaAtiva; }
            set { _contaAtiva = value; }
        }

        private Decimal _saldoInicial;

        public Decimal SaldoInicial
        {
            get { return _saldoInicial; }
            set { _saldoInicial = value; }
        }

        private string _dataCadastro;

        public string DataCadastro
        {
            get { return _dataCadastro; }
            set { _dataCadastro = value; }
        }

        public ContasCtl()
        {

        }

        public ContasCtl(string id, string descricao, Boolean ativa, decimal saldo, string data)
        {
            this.ContaID = id;
            this.ContaDescricao = descricao;
            this.ContaAtiva = ativa;
            this.SaldoInicial = saldo;
            this.DataCadastro = data;
        }
    }
}