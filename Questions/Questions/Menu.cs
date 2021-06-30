using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questions
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void disciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisciplinasFrm CadastroDisciplina = new DisciplinasFrm();
            CadastroDisciplina.StartPosition = FormStartPosition.CenterParent;
            CadastroDisciplina.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void assuntosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssuntosFrm CadastroAssunto = new AssuntosFrm();
            CadastroAssunto.StartPosition = FormStartPosition.CenterParent;
            CadastroAssunto.Show();
        }

        private void bancasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BancasFrm CadastroBanca = new BancasFrm();
            CadastroBanca.StartPosition = FormStartPosition.CenterParent;
            CadastroBanca.Show();
        }
    }
}
