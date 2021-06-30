using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas.Controller
{
    public class EmpresasCtl
    {
        private string _empresaID;

        public string EmpresaID
        {
            get { return _empresaID; }
            set { _empresaID = value; }
        }

        private string _empresaRazao;

        public string EmpresaRazao
        {
            get { return _empresaRazao; }
            set { _empresaRazao = value; }
        }

        private string _empresaDataCadastro;

        public string EmpresaDataCadastro
        {
            get { return _empresaDataCadastro; }
            set { _empresaDataCadastro = value; }
        }

        private string _fantasia;

        public string EmpresaFantasia
        {
            get { return _fantasia; }
            set { _fantasia = value; }
        }

        public EmpresasCtl()
        {

        }

        public EmpresasCtl(string id, string razao, string cadastro, string fantasia)
        {
            this.EmpresaID = id;
            this.EmpresaRazao = razao;
            this.EmpresaDataCadastro = cadastro;
            this.EmpresaFantasia = fantasia;
        }
    }
}