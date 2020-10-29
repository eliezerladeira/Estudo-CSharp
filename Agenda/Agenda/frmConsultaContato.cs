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
    public partial class frmConsultaContato : Form
    {
        public int codigo;

        public frmConsultaContato()
        {
            InitializeComponent();
        }

        private void cmdExecutar_Click(object sender, EventArgs e)
        {
            Conexao conn = new Conexao("Data Source=DESKTOP-7D46FRE\\SQLEXPRESS;Initial Catalog=Agenda;User ID=sa;Password=123456");
            DALContato dal = new DALContato(conn);
            dgvDados.DataSource = dal.Localizar(txtValor.Text);
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
                // usuario clicou em uma coluna existente
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}