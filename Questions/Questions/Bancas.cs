using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class Bancas
    {
        private string _bancaID;

        public string BancaID
        {
            get { return _bancaID; }
            set { _bancaID = value; }
        }

        private string _banca;

        public string Banca
        {
            get { return _banca; }
            set { _banca = value; }
        }

        public Bancas()
        {

        }

        public Bancas(string bancaid, string banca)
        {
            this.BancaID = bancaid;
            this.Banca = banca;
        }
    }
}