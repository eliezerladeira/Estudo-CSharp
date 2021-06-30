using Contas.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contas
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formUsuarios = Application.OpenForms["frmUsuarios"];
            if (formUsuarios == null)
            {
                frmUsuarios FormUsuarios = new frmUsuarios();
                FormUsuarios.MdiParent = this;
                FormUsuarios.Show();
            }
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formEmpresas = Application.OpenForms["frmEmpresas"];
            if (formEmpresas == null)
            {
                frmEmpresas FormEmpresas = new frmEmpresas();
                FormEmpresas.MdiParent = this;
                FormEmpresas.Show();
            }
        }

        private void lançamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formLancamentos = Application.OpenForms["frmLancamentos"];
            if (formLancamentos == null)
            {
                frmLancamentos FormLancamento = new frmLancamentos();
                FormLancamento.MdiParent = this;
                FormLancamento.Show();
            }
        }
    }
}
