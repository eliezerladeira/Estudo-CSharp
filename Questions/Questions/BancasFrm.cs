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
    public partial class BancasFrm : Form
    {
        string status;

        public BancasFrm()
        {
            InitializeComponent();
        }

        private void mnuSaveBanca_Click(object sender, EventArgs e)
        {
            if (txtBanca.Text.Equals(""))
            {
                MessageBox.Show("Informe a banca!");
                return;
            }

            try
            {
                BancasBD bancaBD = new BancasBD();
                Bancas bancaReg = new Bancas(txtCodigo.Text, txtBanca.Text);

                if (status == "INCLUI")
                    bancaBD.IncluirBanca(bancaReg);
                else
                    bancaBD.AlterarBanca(bancaReg);

                MessageBox.Show("Banca salva com sucesso.");

                txtCodigo.Text = "";
                txtBanca.Text = "";

                carregaGrid();
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
            }
        }

        private void BancasFrm_Load(object sender, EventArgs e)
        {
            carregaGrid();

            txtCodigo.Enabled = false;
            txtBanca.Enabled = false;
            mnuDelBanca.Enabled = false;
            mnuSaveBanca.Enabled = false;
        }

        private void BancasFrm_Activated(object sender, EventArgs e)
        {
            dgvBancas.ColumnHeadersDefaultCellStyle.BackColor = Color.Tomato;
            dgvBancas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvBancas.ColumnHeadersDefaultCellStyle.Font = new Font(dgvBancas.Font, FontStyle.Bold);
            dgvBancas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgvBancas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvBancas.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvBancas.GridColor = Color.Black;
            dgvBancas.RowHeadersVisible = false;
        }

        private void dgvBancas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvBancas.Rows[e.RowIndex].Cells["idBanca"].Value.ToString();
            txtBanca.Text = dgvBancas.Rows[e.RowIndex].Cells["banca"].Value.ToString();
            status = "EDITA";
            txtBanca.Enabled = true;
            mnuAddBanca.Enabled = false;
            mnuDelBanca.Enabled = true;
            mnuSaveBanca.Enabled = true;
        }

        private void mnuAddBanca_Click(object sender, EventArgs e)
        {
            txtBanca.Enabled = true;
            mnuAddBanca.Enabled = false;
            mnuDelBanca.Enabled = false;
            mnuSaveBanca.Enabled = true;

            status = "INCLUI";

            txtBanca.Focus();
        }

        private void carregaGrid()
        {
            BancasBD bancaBD = new BancasBD();
            dgvBancas.DataSource = bancaBD.mostraResultados("SELECT * FROM bancas ORDER BY banca");
            dgvBancas.DataMember = "bancas";

            dgvBancas.Columns["idBanca"].HeaderText = "Código";
            dgvBancas.Columns["idBanca"].Width = 50;
            dgvBancas.Columns["banca"].HeaderText = "Banca";
            dgvBancas.Columns["banca"].Width = 400;
        }

        private void mnuDelBanca_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja realmente apagar esta banca?", "Exclusão de Bancas", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() == "YES")
            {
                try
                {
                    BancasBD bancasBD = new BancasBD();
                    Bancas bancareg = new Bancas(txtCodigo.Text, txtBanca.Text);

                    bancasBD.ExcluirBanca(bancareg);

                    MessageBox.Show("Banca excluída com sucesso.");

                    txtCodigo.Text = "";
                    txtBanca.Text = "";

                    carregaGrid();
                }
                catch (Exception c)
                {
                    MessageBox.Show(c.ToString());
                }
            }
        }

        private void mnuExitBanca_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}