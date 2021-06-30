using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contas.Controller;
using Contas.Model;

namespace Contas
{
    public partial class frmEmpresas : Form
    {
        string status;

        public frmEmpresas()
        {
            InitializeComponent();
        }

        private void frmEmpresas_Load(object sender, EventArgs e)
        {
            EmpresasMdl empresaBD = new EmpresasMdl();

            BloqueiaBotoes();
            lblTotalEmpresas.Text="Registros: " + empresaBD.ContaRegistros();
        }

        private void BloqueiaBotoes()
        {
            txtCodigoEmpresa.Enabled = false;
            txtRazaoSocial.Enabled = false;
            mskDataCadastro.Enabled = false;
            txtFantasia.Enabled = false;

            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void DesbloqueiaBotoes(string metodo)
        {
            txtRazaoSocial.Enabled = true;
            mskDataCadastro.Enabled = true;
            txtFantasia.Enabled = true;

            if (metodo == "Add")
            {
                btnNovo.Enabled = false;
                btnExcluir.Enabled = false;
            }

            btnSalvar.Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            DesbloqueiaBotoes("Add");
            mskDataCadastro.Text = DateTime.Today.ToString();
            status = "INCLUI";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtRazaoSocial.Text.Equals(""))
            {
                MessageBox.Show("Informe a razão social da empresa!");
                return;
            }

            try
            {
                EmpresasMdl empresaBD = new EmpresasMdl();
                EmpresasCtl empresaReg = new EmpresasCtl(txtCodigoEmpresa.Text, txtRazaoSocial.Text, mskDataCadastro.Text, txtFantasia.Text);

                if (status == "INCLUI")
                    empresaBD.IncluirEmpresa(empresaReg);
                else
                    empresaBD.AlterarEmpresa(empresaReg);

                MessageBox.Show("Empresa salva com sucesso.");

                txtCodigoEmpresa.Text = "";
                txtRazaoSocial.Text = "";
                mskDataCadastro.Text = "";
                txtFantasia.Text = "";
                status = "INCLUI";
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
            }

        }

        private void txtRazaoSocial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtFantasia.Focus();
        }

        private void mskDataCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSalvar.Focus();
        }
    }
}
