using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class frmCadastroContato : Form
    {
        public string operacao = "";

        public frmCadastroContato()
        {
            InitializeComponent();
        }

        public void AlteraBotoes(int op)
        {
            panDados.Enabled = false;
            cmdInserir.Enabled = false;
            cmdLocalizar.Enabled = false;
            cmdAlterar.Enabled = false;
            cmdExcluir.Enabled = false;
            cmdSalvar.Enabled = false;
            cmdSalvar.Enabled = false;
            cmdCancelar.Enabled = false;

            if (op == 1)
            {
                cmdInserir.Enabled = true;
                cmdLocalizar.Enabled = true;
            }

            if (op == 2)
            {
                panDados.Enabled = true;
                cmdSalvar.Enabled = true;
                cmdCancelar.Enabled = true;
            }

            if (op ==3)
            {
                cmdExcluir.Enabled = true;
                cmdAlterar.Enabled = true;
                cmdCancelar.Enabled = true;
            }
        }

        public void LimpaCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCep.Clear();
            txtCidade.Clear();
            txtEmail.Clear();
            txtEstado.Clear();
            txtTelefone.Clear();
        }

        private void frmCadastroContato_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
        }

        private void cmdInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "Inserir";
            this.AlteraBotoes(2);
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
            this.LimpaCampos();
        }

        private void cmdSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Contato contato = new Contato();
                if (txtNome.Text.Length <= 0)
                {
                    MessageBox.Show("Nome é obrigatório!");
                    return;
                }
                contato.Nome = txtNome.Text;
                contato.Rua = txtEndereco.Text;
                contato.Bairro = txtBairro.Text;
                contato.Cidade = txtCidade.Text;
                contato.Estado = txtEstado.Text;
                contato.Fone = txtTelefone.Text;
                contato.Email = txtEmail.Text;
                contato.Cep = txtCep.Text;

                String strConexao = @"Data Source=DESKTOP-7D46FRE\SQLEXPRESS; Initial Catalog=Agenda;User ID=sa;Password=123456";
                Conexao conexao = new Conexao(strConexao);
                DALContato dal = new DALContato(conexao);

                if (this.operacao == "Inserir")
                {
                    dal.Incluir(contato);
                    MessageBox.Show("O código gerado foi " + contato.Codigo.ToString());
                }
                else
                {
                    contato.Codigo = Convert.ToInt32(txtCodigo.Text);
                    dal.Alterar(contato);
                    MessageBox.Show("Registro alterado!");
                }
                this.AlteraBotoes(1);
                this.LimpaCampos();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void cmdLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaContato f = new frmConsultaContato();
            f.ShowDialog();

            if (f.codigo != 0)
            {
                String strConexao = @"Data Source=DESKTOP-7D46FRE\SQLEXPRESS; Initial Catalog=Agenda;User ID=sa;Password=123456";
                Conexao conexao = new Conexao(strConexao);
                DALContato dal = new DALContato(conexao);
                Contato contato = dal.carregaContato(f.codigo);

                txtCodigo.Text = contato.Codigo.ToString();
                txtNome.Text = contato.Nome;
                txtEmail.Text = contato.Email;
                txtBairro.Text = contato.Bairro;
                txtCep.Text = contato.Cep;
                txtCidade.Text = contato.Cidade;
                txtEndereco.Text = contato.Rua;
                txtEstado.Text = contato.Estado;
                txtTelefone.Text = contato.Fone;

                this.AlteraBotoes(3);
            }
            f.Dispose();
        }

        private void cmdAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "Alterar";
            this.AlteraBotoes(2);
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Deseja excluir o registro?", "AVISO", MessageBoxButtons.YesNo);
            if (d.ToString() == "Yes")
            {
                String strConexao = @"Data Source=DESKTOP-7D46FRE\SQLEXPRESS; Initial Catalog=Agenda;User ID=sa;Password=123456";
                Conexao conexao = new Conexao(strConexao);
                DALContato dal = new DALContato(conexao);

                dal.Excluir(Convert.ToInt32(txtCodigo.Text));

                this.AlteraBotoes(1);
                this.LimpaCampos();
            }
        }
    }
}