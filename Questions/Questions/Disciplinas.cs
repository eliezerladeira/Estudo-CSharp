using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class Disciplinas
    {
        private string _disciplinaID;

        public string DisciplinaID
        {
            get { return _disciplinaID; }
            set { _disciplinaID = value; }
        }

        private string _disciplina;

        public string Disciplina
        {
            get { return _disciplina; }
            set { _disciplina = value; }
        }

        public Disciplinas()
        {

        }

        public Disciplinas(string disciplinaid, string disciplina)
        {
            this.DisciplinaID = disciplinaid;
            this.Disciplina = disciplina;
        }
    }
}