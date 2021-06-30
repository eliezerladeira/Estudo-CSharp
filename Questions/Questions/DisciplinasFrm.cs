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
    public partial class DisciplinasFrm : Form
    {
        string status;

        public DisciplinasFrm()
        {
            InitializeComponent();
        }

        private void mnuSaveDisciplina_Click(object sender, EventArgs e)
        {
            if (txtDisciplina.Text.Equals(""))
            {
                MessageBox.Show("Informe o nome da disciplina!");
                return;
            }

            try
            {
                DisciplinasBD disciplinaBD = new DisciplinasBD();
                Disciplinas disciplinaReg = new Disciplinas(txtCodigo.Text, txtDisciplina.Text);

                if (status == "INCLUI")
                    disciplinaBD.IncluirDisciplina(disciplinaReg);
                else
                    disciplinaBD.AlterarDisciplina(disciplinaReg);

                MessageBox.Show("Disciplina salva com sucesso.");

                txtCodigo.Text = "";
                txtDisciplina.Text = "";
                status = "INCLUI";

                //dgvDisciplinas.DataSource = disciplinaBD.getDisciplinas();
                carregaGrid();
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
            }
         }

        private void DisciplinaFrm_Load(object sender, EventArgs e)
        {
            carregaGrid();

            txtCodigo.Enabled = false;
            txtDisciplina.Enabled = false;
            mnuDelDisciplina.Enabled = false;
            mnuSaveDisciplina.Enabled = false;
        }

        private void DisciplinaFrm_Activated(object sender, EventArgs e)
        {
            dgvDisciplinas.ColumnHeadersDefaultCellStyle.BackColor = Color.Tomato;
            dgvDisciplinas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDisciplinas.ColumnHeadersDefaultCellStyle.Font = new Font(dgvDisciplinas.Font, FontStyle.Bold);
            dgvDisciplinas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgvDisciplinas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvDisciplinas.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvDisciplinas.GridColor = Color.Black;
            dgvDisciplinas.RowHeadersVisible = false;
        }

        private void dgvDisciplinas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text  = dgvDisciplinas.Rows[e.RowIndex].Cells["idDisciplina"].Value.ToString();
            txtDisciplina.Text = dgvDisciplinas.Rows[e.RowIndex].Cells["disciplina"].Value.ToString();
            status = "EDITA";
            txtDisciplina.Enabled = true;
            mnuAddDisciplina.Enabled = false;
            mnuDelDisciplina.Enabled = true;
            mnuSaveDisciplina.Enabled = true;
        }

        private void mnuAddDisciplina_Click(object sender, EventArgs e)
        {
            txtDisciplina.Enabled = true;
            mnuAddDisciplina.Enabled = false;
            mnuDelDisciplina.Enabled = false;
            mnuSaveDisciplina.Enabled = true;

            status = "INCLUI";

            txtDisciplina.Focus();
        }

        private void carregaGrid()
        {
            DisciplinasBD disciplinaBD = new DisciplinasBD();
            dgvDisciplinas.DataSource = disciplinaBD.mostraResultados("SELECT * FROM disciplinas ORDER BY disciplina");
            dgvDisciplinas.DataMember = "disciplinas";

            dgvDisciplinas.Columns["idDisciplina"].HeaderText = "Código";
            dgvDisciplinas.Columns["idDisciplina"].Width = 50;
            dgvDisciplinas.Columns["disciplina"].HeaderText = "Disciplina";
            dgvDisciplinas.Columns["disciplina"].Width = 400;
        }

        private void mnuDelDisciplina_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja realmente apagar a disciplina?", "Exclusão de Disciplina", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() == "YES")
            {
                try
                {
                    DisciplinasBD disciplinasBD = new DisciplinasBD();
                    Disciplinas disciplinareg = new Disciplinas(txtCodigo.Text, txtDisciplina.Text);

                    disciplinasBD.ExcluirDisciplina(disciplinareg);

                    MessageBox.Show("Disciplina excluída com sucesso.");

                    txtCodigo.Text = "";
                    txtDisciplina.Text = "";

                    carregaGrid();
                }
                catch (Exception c)
                {
                    MessageBox.Show(c.ToString());
                }
            }
        }

        private void mnuExitDisciplina_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picPesquisa_Click(object sender, EventArgs e)
        {
            if (txtDisciplina.Text.Equals(""))
            {
                MessageBox.Show("Digite o texto a ser procurado.");
                return;
            }

            try
            {
                DisciplinasBD disciplinaBD = new DisciplinasBD();
                Disciplinas disciplinaReg = new Disciplinas(txtCodigo.Text, txtDisciplina.Text);

                disciplinaBD.PesquisarDisciplina(disciplinaReg);

                carregaGrid();
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
            }
        }
    }
}