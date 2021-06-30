using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace employeesapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection conn = null;
        OleDbDataAdapter ad = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new OleDbConnection(Conexao.getConexao());
                ad = new OleDbDataAdapter("select * from funcionarios ", conn);
                DataSet ds = new DataSet();
                ad.Fill(ds, "funcionarios");
                BindingSource bs = new BindingSource();
                bs.DataSource = ds.Tables["funcionarios"];
                //vincula os dados nos controles
                txtID.DataBindings.Add("text", bs, "Codigo");
                txtNome.DataBindings.Add("text", bs, "Nome");
                txtCargo.DataBindings.Add("text", bs, "Cargo");
                txtEmpresa.DataBindings.Add("text", bs, "Empresa");

                txtID.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Colaboradores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                txtID.Enabled = false;
                txtNome.Clear();
                txtCargo.Clear();
                txtEmpresa.Clear();
                txtNome.Focus();
                MessageBox.Show("INFORME OS DADOS e clique no botão SALVAR para gravar o NOVO REGISTRO.", "NOVO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                throw;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text.Equals("") || txtCargo.Text.Equals("") || txtEmpresa.Text.Equals(""))
                {
                    MessageBox.Show("Informe os dados necessários.", "NOVO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                funcionarios colab1 = new funcionarios();
                colab1.Nome = txtNome.Text;
                colab1.Cargo = txtCargo.Text;
                colab1.Empresa = txtEmpresa.Text;
                colab1.AddNew();
                MessageBox.Show("Novo colaborador incluído com sucesso.");
                txtNome.Clear();
                txtCargo.Clear();
                txtEmpresa.Clear();
                txtNome.Focus();
                //cria instancia da classe
                funcionarios funci = new funcionarios();
                DataSet ds = funci.get();
                dgvDados.DataSource = ds.Tables[0];
                exibirDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Colaboradores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            //se estiver vazio avisa
            if (txtProcurar.Text == "")
            {
                MessageBox.Show("Informe o ID do colaborador que você quer procurar...");
            }
            else
            {
                int codigo = Convert.ToInt32(txtProcurar.Text);
               
                DataSet ds = funcionarios.Procurar(codigo);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dgvDados.DataSource = ds.Tables["DGV1"];
                    dgvDados.Refresh();
                    dgvDados.Update();
                }
                else
                {
                    MessageBox.Show("Informação não localizada...");
                    exibirDados();
                } 
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja encerrar a aplicação ?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
                Application.Exit();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Deseja excluir este colaborador ?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    funcionarios colab1 = new funcionarios();
                    int codigo = Convert.ToInt32(txtID.Text);
                    colab1.Nome = txtNome.Text;
                    colab1.Cargo = txtCargo.Text;
                    colab1.Empresa = txtEmpresa.Text;

                    colab1.Delete(codigo);
                    MessageBox.Show("O colaborador foi excluído do cadastro.");
                    exibirDados();
                }
            }
            catch
            {
                throw;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("") || txtCargo.Text.Equals("") || txtEmpresa.Text.Equals(""))
            {
                MessageBox.Show("Os dados necessários não foram informados.", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            funcionarios colab1 = new funcionarios();
            int codigo = Convert.ToInt32(txtID.Text);
            colab1.Nome = txtNome.Text;
            colab1.Cargo = txtCargo.Text;
            colab1.Empresa = txtEmpresa.Text;

            colab1.Update(codigo);
            MessageBox.Show("Os dados foram atualizados...");
            exibirDados();
        }

        private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //verifica se o indice da linha da celeula é maior ou igual a zero
            if (e.RowIndex >= 0)
            {
                //pega a coleção que contém todas as linhas
                DataGridViewRow row = this.dgvDados.Rows[e.RowIndex];
                //preenche os textbox com os valores
                txtID.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                txtCargo.Text = row.Cells[2].Value.ToString();
                txtEmpresa.Text = row.Cells[3].Value.ToString();
            } 
        }

        private void btnExibirDados_Click(object sender, EventArgs e)
        {
            exibirDados();
        }

        private void exibirDados()
        {
            try
            {
                funcionarios funci = new funcionarios();
                DataSet ds = funci.get();
                dgvDados.DataSource = ds.Tables[0];
            }
            catch
            {
                throw;
            }
        }

        private void nametext_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNome.Text, @"^[a-zA-Z á]*$"))
            {
                //aceita somente letras
                txtNome.Clear();
            }
        }

        private void jobtext_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCargo.Text,  @"^[a-zA-Z á]*$"))
            {
                //aceita somente letras
                txtCargo.Clear();
            }
        }

        private void comtext_TextChanged(object sender, EventArgs e)
        {    //Regex.IsMatch(input, @"^[a-zA-Z]+$");
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtEmpresa.Text, @"^[a-zA-Z á]*$"))
            {
                //aceita somente letras
                txtEmpresa.Clear();
            }
        }

        // Ao teclar ENTER envia um TAB
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
