using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco_de_Questões
{
    public partial class InstituicaoFrm : Form
    {
        public InstituicaoFrm()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtInstituicao.Text.Equals(""))
            {
                MessageBox.Show("Informe o nome da Instituição!");
                return;
            }
            try
            {
                instituicaoBD instituicaoData = new instituicaoBD();
                Instituicao instituicaoReg = new Instituicao(txtCodigo.Text, txtInstituicao.Text);
                instituicaoData.IncluirInstituicao(instituicaoReg);
                MessageBox.Show("Registro salvo com sucesso.");
                btnLimpar.PerformClick();
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
            }
        }
    }
}
