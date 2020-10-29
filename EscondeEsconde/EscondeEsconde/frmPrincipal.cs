using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscondeEsconde
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            txtValor.Text = "Clicou no botão EXIBIR";
            panDados.Visible = true;
            btnExibir.Enabled = false;
            btnOcultar.Enabled = true;
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            txtValor.Text = "Clicou no botão OCULTAR";
            panDados.Visible = false;
            btnOcultar.Enabled = false;
            btnExibir.Enabled = true;
        }
    }
}
