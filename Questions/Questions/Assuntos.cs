using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class Assuntos
    {
        private string _assuntoID;

        public string AssuntoID
        {
            get { return _assuntoID; }
            set { _assuntoID = value; }
        }

        private string _assunto;

        public string Assunto
        {
            get { return _assunto; }
            set { _assunto = value; }
        }

        public Assuntos()
        {

        }

        public Assuntos(string assuntoid, string assunto)
        {
            this.AssuntoID = assuntoid;
            this.Assunto = assunto;
        }
    }
}
