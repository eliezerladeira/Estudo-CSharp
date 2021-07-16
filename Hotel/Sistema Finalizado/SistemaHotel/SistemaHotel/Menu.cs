using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel
{
    public partial class FrmMenu : Form
    {
        
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            pnlTopo.BackColor = Color.FromArgb(230, 230, 230);
            pnlRight.BackColor = Color.FromArgb(130, 130, 130);

           
            lblUsuario.Text = Program.nomeUsuario;
            lblCargo.Text = Program.cargoUsuario;

        }

        private void FuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.FrmFuncionarios form = new Cadastros.FrmFuncionarios();
            form.Show();
        }

        private void CargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.FrmCargo form = new Cadastros.FrmCargo();
            form.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Produtos.FrmProdutos form = new Produtos.FrmProdutos();
            form.Show();
        }

        private void NovoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos.FrmProdutos form = new Produtos.FrmProdutos();
            form.Show();
        }

        private void UsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.FrmUsuarios form = new Cadastros.FrmUsuarios();
            form.Show();
        }

        private void FornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.FrmFornecedores form = new Cadastros.FrmFornecedores();
            form.Show();
        }

        private void EstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos.FrmEstoque form = new Produtos.FrmEstoque();
            form.Show();
        }

        private void ServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.FrmServicos form = new Cadastros.FrmServicos();
            form.Show();
        }

        private void RelatórioDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.FrmRelProdutos form = new Relatorios.FrmRelProdutos();
            form.Show();
        }

        private void NovaVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movimentacoes.FrmVendas form = new Movimentacoes.FrmVendas();
            form.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Movimentacoes.FrmVendas form = new Movimentacoes.FrmVendas();
            form.Show();
        }

        private void RelatórioDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.FrmRelVendas form = new Relatorios.FrmRelVendas();
            form.Show();
        }

        private void EntradasESaídasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movimentacoes.FrmMovimentacoes form = new Movimentacoes.FrmMovimentacoes();
            form.Show();
        }

        private void GastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movimentacoes.FrmGastos form = new Movimentacoes.FrmGastos();
            form.Show();
        }

        private void HóspedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.FrmHospedes form = new Cadastros.FrmHospedes();
            form.Show();
        }

        private void QuartosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.FrmQuartos form = new Cadastros.FrmQuartos();
            form.Show();
        }

        private void NovoServiçoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Movimentacoes.FrmNovoServics form = new Movimentacoes.FrmNovoServics();
            form.Show();
        }

        private void RelatórioDeServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.FrmRelServicos form = new Relatorios.FrmRelServicos();
            form.Show();
        }

        private void RelatórioDeMovimentaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.FrmRelMovimentacoes form = new Relatorios.FrmRelMovimentacoes();
            form.Show();
        }

        private void RelatórioDeMovimentaçõesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Relatorios.FrmMovimentacoesGerais form = new Relatorios.FrmMovimentacoesGerais();
            form.Show();
        }
    }
}
