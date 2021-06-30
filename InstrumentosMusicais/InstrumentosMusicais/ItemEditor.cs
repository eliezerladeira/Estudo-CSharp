using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MusicalInstrumentStore2
{
    public partial class ItemEditor : Form
    {
        public ItemEditor()
        {
            InitializeComponent();
        }

        private void btnNovaCategoria_Click(object sender, EventArgs e)
        {
            CategoryEditor editor = new CategoryEditor();

            if (editor.ShowDialog() == DialogResult.OK)
            {
                if (editor.txtCategoria.Text.Length > 0)
                {
                    string strNovaCategoria = editor.txtCategoria.Text;

                    // verifica se a categoria ja esta na lista
                    if (cbxCategorias.Items.Contains(strNovaCategoria))
                        MessageBox.Show(strNovaCategoria + " ja esta na lista ");
                    else
                    {
                        // Inclui a nova categoria no combo
                        cbxCategorias.Items.Add(strNovaCategoria);
                        // Se quiser esta  nova categoria seleciona-a
                        cbxCategorias.Text = strNovaCategoria;
                    }
                }
            }
        }

        private void btnNovoItemTipo_Click(object sender, EventArgs e)
        {
            TypeEditor editor = new TypeEditor();

            if (editor.ShowDialog() == DialogResult.OK)
            {
                if (editor.txtItemTipo.Text.Length > 0)
                {
                    string strNovoTipo = editor.txtItemTipo.Text;

                    // verifica se o tipo ja esta na  lista
                    if (cbxTipos.Items.Contains(strNovoTipo))
                        MessageBox.Show("A lista ja contém " +
                                        strNovoTipo);
                    else
                    {
                        cbxTipos.Items.Add(strNovoTipo);
                        cbxTipos.Text = strNovoTipo;
                    }
                }
            }
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            if (dlgPicture.ShowDialog() == DialogResult.OK)
            {
                txtCaminhoImagem.Text = dlgPicture.FileName;
                pbxItemEstoque.Image = Image.FromFile(txtCaminhoImagem.Text);
            }
        }

        private void ItemEditor_Load(object sender, EventArgs e)
        {
            // Desde que todos os valores estao prontos , prepara o processamento do item
            EstoqueItem item = new EstoqueItem();
            EstoqueItems items = new EstoqueItems();
            BinaryFormatter bfmEstoqueItem = new BinaryFormatter();

            // This is the file that holds the list of items
            string nomeArquivo = @"C:\InstrumentosMusicais\Dados\EstoqueItems.mis";

            if (File.Exists(nomeArquivo))
            {
                FileStream stmArmazenaItem = new FileStream(nomeArquivo,
                                                         FileMode.Open,
                                                         FileAccess.Read,
                                                         FileShare.Read);

                try
                {
                    // retorna a lista de itens do arquivo
                    items = (EstoqueItems)bfmEstoqueItem.Deserialize(stmArmazenaItem);

                    // exibe as categorias no combobox
                    for (int i = 0; i < items.Count; i++)
                    {
                        item = (EstoqueItem)items[i];

                        if (!cbxCategorias.Items.Contains(item.Category))
                            cbxCategorias.Items.Add(item.Category);
                    }

                    // exibe os tipos de itens no the combo box
                    for (int i = 0; i < items.Count; i++)
                    {
                        item = (EstoqueItem)items[i];

                        if (!cbxTipos.Items.Contains(item.Type))
                            cbxTipos.Items.Add(item.Type);
                    }
                }
                finally
                {
                    stmArmazenaItem.Close();
                }
            }
            else
            {
                // Cria um numero aleatorio para identificar um item
                Random rnd = new Random();
                txtItemNumero.Text = rnd.Next(100000, 999999).ToString();

                // verifica se o usuário selecionou a categoria
                cbxCategorias.Text = "";
                cbxTipos.Text = "";
            }
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            FileStream stmArmazenaItem = null;
            EstoqueItem item = new EstoqueItem();
            EstoqueItems items = new EstoqueItems();
            BinaryFormatter bfmEstoqueItem = new BinaryFormatter();

            // se o diretorio nao existe então cria
            Directory.CreateDirectory(@"C:\InstrumentosMusicais\Dados");
            // este arquivo trata a lista de itens
            string nomeArquivo = @"C:\InstrumentosMusicais\Dados\EstoqueItems.mis";

            // Cria um no aleatorio para identificar o item
            Random rnd = new Random();
            txtItemNumero.Text = rnd.Next(100000, 999999).ToString();

            // verifica se o usuário selecionou a categoria
            if (cbxCategorias.Text.Length == 0)
            {
                MessageBox.Show("Você deve definir a categoria do item");
                cbxCategorias.Focus();
                return;
            }

            // verifica se o usuário selecionou um tipo
            if (cbxTipos.Text.Length == 0)
            {
                MessageBox.Show("Você deve definir o tipo do item");
                cbxTipos.Focus();
                return;
            }

            // verifica se o usuário informou o nome/descrição
            if (txtItemNome.Text.Length == 0)
            {
                MessageBox.Show("Você deve informar o nome (ou uma " +
                                "breve descrição) para o item");
                txtItemNome.Focus();
                return;
            }

            // verifica se o preco foi informado
            if (txtPrecoUnitario.Text.Length == 0)
            {
                MessageBox.Show("Você deve informar o preço do item");
                txtPrecoUnitario.Focus();
                return;
            }

            // Ante de salvar um novo item, pesquisa se ja existe
            // um arquivo que trata a lista de itens
            // Se exisitr abre o arquivo e armazena os itens 
            // na lista
            if (File.Exists(nomeArquivo))
            {
                stmArmazenaItem = new FileStream(nomeArquivo,
                                              FileMode.Open,
                                              FileAccess.Read,
                                              FileShare.Read);

                try
                {
                    // retorna a lista de itens do  arquivo
                    items = (EstoqueItems)bfmEstoqueItem.Deserialize(stmArmazenaItem);
                }
                finally
                {
                    stmArmazenaItem.Close();
                }
            }

            // Cria o item 
            item.ItemNumber = txtItemNumero.Text;
            item.Category = cbxCategorias.Text;
            item.Type = cbxTipos.Text;
            item.ItemName = txtItemNome.Text;
            item.UnitPrice = double.Parse(txtPrecoUnitario.Text);

            // Cham o méodo Add da coleção para adicioar o item
            items.Add(item);

            // Save the list
            stmArmazenaItem = new FileStream(nomeArquivo,
                                          FileMode.Create,
                                          FileAccess.Write,
                                          FileShare.Write);

            try
            {
                bfmEstoqueItem.Serialize(stmArmazenaItem, items);

                if (txtCaminhoImagem.Text.Length != 0)
                {
                    FileInfo arqImagem = new FileInfo(txtCaminhoImagem.Text);
                    arqImagem.CopyTo(@"C:\InstrumentosMusicais\Dados\" +
                                      txtItemNumero.Text + arqImagem.Extension);
                }

                // após salvar o item reseta o formulário
                txtItemNumero.Text = rnd.Next(100000, 999999).ToString();
                cbxCategorias.Text = "";
                cbxTipos.Text = "";
                txtItemNome.Text = "";
                txtPrecoUnitario.Text = "0.00";
                txtCaminhoImagem.Text = "";
                pbxItemEstoque.Image = null;
            }
            finally
            {
                stmArmazenaItem.Close();
            }
        }
    
    }
}