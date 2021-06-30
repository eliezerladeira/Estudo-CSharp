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
    public partial class AssuntosFrm : Form
    {
        string status;

        public AssuntosFrm()
        {
            InitializeComponent();
        }

        private void mnuSaveAssunto_Click(object sender, EventArgs e)
        {
            if (txtAssunto.Text.Equals(""))
            {
                MessageBox.Show("Informe o assunto/matéria!");
                return;
            }

            try
            {
                AssuntosBD assuntoBD = new AssuntosBD();
                Assuntos assuntoReg = new Assuntos(txtCodigo.Text, txtAssunto.Text);

                if (status == "INCLUI")
                    assuntoBD.IncluirAssunto(assuntoReg);
                else
                    assuntoBD.AlterarAssunto(assuntoReg);

                MessageBox.Show("Assunto/matéria salva com sucesso.");

                txtCodigo.Text = "";
                txtAssunto.Text = "";

                carregaGrid();
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
            }
        }

        private void AssuntosFrm_Load(object sender, EventArgs e)
        {
            carregaGrid();

            txtCodigo.Enabled = false;
            txtAssunto.Enabled = false;
            mnuDelAssunto.Enabled = false;
            mnuSaveAssunto.Enabled = false;
        }

        private void AssuntosFrm_Activated(object sender, EventArgs e)
        {
            dgvAssuntos.ColumnHeadersDefaultCellStyle.BackColor = Color.Tomato;
            dgvAssuntos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAssuntos.ColumnHeadersDefaultCellStyle.Font = new Font(dgvAssuntos.Font, FontStyle.Bold);
            dgvAssuntos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgvAssuntos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvAssuntos.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvAssuntos.GridColor = Color.Black;
            dgvAssuntos.RowHeadersVisible = false;
        }

        private void dgvAssuntos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvAssuntos.Rows[e.RowIndex].Cells["idAssunto"].Value.ToString();
            txtAssunto.Text = dgvAssuntos.Rows[e.RowIndex].Cells["assunto"].Value.ToString();
            status = "EDITA";
            txtAssunto.Enabled = true;
            mnuAddAssunto.Enabled = false;
            mnuDelAssunto.Enabled = true;
            mnuSaveAssunto.Enabled = true;
        }

        private void mnuAddAssunto_Click(object sender, EventArgs e)
        {
            txtAssunto.Enabled = true;
            mnuAddAssunto.Enabled = false;
            mnuDelAssunto.Enabled = false;
            mnuSaveAssunto.Enabled = true;

            status = "INCLUI";

            txtAssunto.Focus();
        }

        private void carregaGrid()
        {
            AssuntosBD assuntoBD = new AssuntosBD();
            dgvAssuntos.DataSource = assuntoBD.mostraResultados("SELECT * FROM assuntos ORDER BY assunto");
            dgvAssuntos.DataMember = "assuntos";

            dgvAssuntos.Columns["idAssunto"].HeaderText = "Código";
            dgvAssuntos.Columns["idAssunto"].Width = 50;
            dgvAssuntos.Columns["assunto"].HeaderText = "Assunto/Matéria";
            dgvAssuntos.Columns["assunto"].Width = 400;
        }

        private void mnuDelAssunto_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja realmente apagar este assunto/matéria?", "Exclusão de Assuntos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() == "YES")
            {
                try
                {
                    AssuntosBD assuntosBD = new AssuntosBD();
                    Assuntos assuntoreg = new Assuntos(txtCodigo.Text, txtAssunto.Text);

                    assuntosBD.ExcluirAssunto(assuntoreg);

                    MessageBox.Show("Assunto/matéria excluída com sucesso.");

                    txtCodigo.Text = "";
                    txtAssunto.Text = "";

                    carregaGrid();
                }
                catch (Exception c)
                {
                    MessageBox.Show(c.ToString());
                }
            }
        }

        private void mnuExitAssunto_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
