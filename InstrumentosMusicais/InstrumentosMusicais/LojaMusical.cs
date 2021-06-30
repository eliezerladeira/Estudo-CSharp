using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MusicalInstrumentStore2
{
    public partial class LojaMusical : Form
    {
        EstoqueItems items;
        int iNomeArquivo;
        bool IsNovoPedidoCliente;
        string caminhoDados = @"C:\InstrumentosMusicais\Dados\";

        public LojaMusical()
        {
            InitializeComponent();
        }

        void LoadLojaMusical()
        {
            string caminhoDados= @"C:\InstrumentosMusicais\Dados\";
            //processa o item
            items = new EstoqueItems();
            BinaryFormatter bfmEstoqueItem = new BinaryFormatter();

            // arquivo que trata os itens
            string nomeArquivo = caminhoDados + "EstoqueItems.mis";

            if (File.Exists(nomeArquivo))
            {
                FileStream stmEstoqueItem = new FileStream(nomeArquivo,
                                                         FileMode.Open,
                                                         FileAccess.Read,
                                                         FileShare.Read);

                try
                {
                    // retorna lista de itens
                    items = (EstoqueItems)bfmEstoqueItem.Deserialize(stmEstoqueItem);

                    // Exibe as categorias no cambobox
                    for (int i = 0; i < items.Count; i++)
                    {
                        EstoqueItem item = (EstoqueItem)items[i];

                        if (!cbxCategorias.Items.Contains(item.Category))
                            cbxCategorias.Items.Add(item.Category);
                    }
                }
                finally
                {
                    stmEstoqueItem.Close();
                }
            }
        }

        private void btnNewEstoqueItem_Click(object sender, EventArgs e)
        {
            ItemEditor editor = new ItemEditor();

            // cria um numero para identificar um novo item 
            Random rnd = new Random();
            editor.txtItemNumero.Text = rnd.Next(100000, 999999).ToString();

            if (editor.ShowDialog() == DialogResult.Cancel)
                LoadLojaMusical();
        }

        private void cbxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxTipos.Items.Clear();
            cbxTipos.Text = "";
            lvwEstoqueItems.Items.Clear();
            pbxEstoqueItem.Image = null;

            if (items.Count == 0)
                return;

            string strCategoria = (string)cbxCategorias.SelectedItem;

            cbxTipos.Items.Clear();

            for (int i = 0; i < items.Count; i++)
            {
                EstoqueItem item = (EstoqueItem)items[i];

                if (item.Category == strCategoria)
                {
                    if (!cbxTipos.Items.Contains(item.Type))
                        cbxTipos.Items.Add(item.Type);
                }
            }
        }

        private void cbxTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvwEstoqueItems.Items.Clear();
            cbxTipos.Text = "";
            pbxEstoqueItem.Image = null;

            if (items.Count == 0)
                return;

            string strCategoria = (string)cbxCategorias.SelectedItem;
            string strType = (string)cbxTipos.SelectedItem;

            lvwEstoqueItems.Items.Clear();

            for (int i = 0; i < items.Count; i++)
            {
                EstoqueItem item = (EstoqueItem)items[i];

                if ((item.Category == strCategoria) &&
                    (item.Type == strType))
                {
                    ListViewItem lviStoreItem =
                     lvwEstoqueItems.Items.Add(item.ItemNumber);
                    lviStoreItem.SubItems.Add(item.ItemName);
                    lviStoreItem.SubItems.Add(item.UnitPrice.ToString("F"));
                }
            }
        }

        private void lvwStoreItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            EstoqueItem item = new EstoqueItem();

            if ((lvwEstoqueItems.SelectedItems.Count == 0) ||
                (lvwEstoqueItems.SelectedItems.Count > 1))
                return;

            string strItemNumero = lvwEstoqueItems.SelectedItems[0].SubItems[0].Text;

            for (int i = 0; i < items.Count; i++)
            {
                EstoqueItem itm = (EstoqueItem)items[i];
                if (itm.ItemNumber == strItemNumero)
                    item = itm;
            }


            // faz uma lista de imagens 
            string strDiretorio = caminhoDados;
            DirectoryInfo dirEstoqueItems = new DirectoryInfo(strDiretorio);
            FileInfo[] ArquivoImagens = dirEstoqueItems.GetFiles("*.jpg");

            // procurar por arquivo que trata o mesmo nome do numero do item
            foreach (FileInfo fle in ArquivoImagens)
            {
                // Pega o nome do arquivo sem extensaõ
                string fwe = Path.GetFileNameWithoutExtension(fle.FullName);

                if (fwe == strItemNumero)
                    pbxEstoqueItem.Image = Image.FromFile(strDiretorio + item.ItemNumber + ".jpg");
            }
        }

        internal void CalculaPedido()
        {
            // calcula o total do pedido atual e atualzia o pedido
            double subTotal1 = 0.00, subTotal2 = 0.00, subTotal3 = 0.00,
                        subTotal4 = 0.00, subTotal5 = 0.00, subTotal6 = 0.00;
            double itemsTotal = 0.00, taxRate = 0.00,
                   valorImposto = 0.00, orderTotal = 0.00;

            // retorna o valor de cada sub total
            try
            {
                subTotal1 = double.Parse(this.txtSubTotal1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Valor Inválido");
            }

            try
            {
                subTotal2 = double.Parse(this.txtSubTotal2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Valor Inválido");
            }

            try
            {
                subTotal3 = double.Parse(this.txtSubTotal3.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Valor Inválido");
            }

            try
            {
                subTotal4 = double.Parse(this.txtSubTotal4.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Valor Inválido");
            }

            try
            {
                subTotal5 = double.Parse(this.txtSubTotal5.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Valor Inválido");
            }

            try
            {
                subTotal6 = double.Parse(this.txtSubTotal6.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Valor Inválido");
            }

            // Calcula o valor total dos sub totals
            itemsTotal = subTotal1 + subTotal2 + subTotal3 +
                         subTotal4 + subTotal5 + subTotal6;

            // Exibe o total do pedido no text box
            txtItemsTotal.Text = itemsTotal.ToString();

            try
            {
                taxRate = double.Parse(txtTaxaImposto.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Taxa inválida");
                txtTaxaImposto.Text = "7,75";
                txtTaxaImposto.Focus();
            }

            valorImposto = itemsTotal * taxRate / 100;
            orderTotal = itemsTotal + valorImposto;

            txtValorImposto.Text = valorImposto.ToString("F");
            txtTotalPedido.Text = orderTotal.ToString("F");
        }

        private void lvwStoreItems_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem lviStoreItem = lvwEstoqueItems.SelectedItems[0];

            if (lvwEstoqueItems.SelectedItems.Count == 0 ||
                        lvwEstoqueItems.SelectedItems.Count > 1)
                return;

            if (txtItemNumero1.Text == "")
            {
                txtItemNumero1.Text = lviStoreItem.Text;
                txtDescricao1.Text = lviStoreItem.SubItems[1].Text;
                txtPrecoUnitario1.Text = lviStoreItem.SubItems[2].Text;

                txtQuantidade1.Text = "1";
                txtSubTotal1.Text = lviStoreItem.SubItems[2].Text;

                btnRemove1.Enabled = true;
                txtQuantidade1.Focus();
            }// se o proximo item não esta vazio usa o proximo
            else if (txtItemNumero2.Text == "")
            {
                txtItemNumero2.Text = lviStoreItem.Text;
                txtDescricao2.Text = lviStoreItem.SubItems[1].Text;
                txtPrecoUnitario2.Text = lviStoreItem.SubItems[2].Text;

                txtQuantidade2.Text = "1";
                txtSubTotal2.Text = txtPrecoUnitario2.Text;

                btnRemove2.Enabled = true;
                txtQuantidade2.Focus();
            }
            else if (txtItemNumero3.Text == "")
            {
                txtItemNumero3.Text = lviStoreItem.Text;
                txtDescricao3.Text = lviStoreItem.SubItems[1].Text;
                txtPrecoUnitario3.Text = lviStoreItem.SubItems[2].Text;

                txtQuantidade3.Text = "1";
                txtSubTotal3.Text = txtPrecoUnitario3.Text;

                btnRemove3.Enabled = true;
                txtQuantidade3.Focus();
            }
            else if (txtItemNumero4.Text == "")
            {
                txtItemNumero4.Text = lviStoreItem.Text;
                txtDescricao4.Text = lviStoreItem.SubItems[1].Text;
                txtPrecoUnitario4.Text = lviStoreItem.SubItems[2].Text;

                txtQuantidade4.Text = "1";
                txtSubTotal4.Text = txtPrecoUnitario4.Text;

                btnRemove4.Enabled = true;
                txtQuantidade4.Focus();
            }
            else if (txtItemNumero5.Text == "")
            {
                txtItemNumero5.Text = lviStoreItem.Text;
                txtDescricao5.Text = lviStoreItem.SubItems[1].Text;
                txtPrecoUnitario5.Text = lviStoreItem.SubItems[2].Text;

                txtQuantidade5.Text = "1";
                txtSubTotal5.Text = txtPrecoUnitario5.Text;

                btnRemove5.Enabled = true;
                txtQuantidade5.Focus();
            }
            else if (txtItemNumero6.Text == "")
            {
                txtItemNumero6.Text = lviStoreItem.Text;
                txtDescricao6.Text = lviStoreItem.SubItems[1].Text;
                txtPrecoUnitario6.Text = lviStoreItem.SubItems[2].Text;

                txtQuantidade6.Text = "1";
                txtSubTotal6.Text = txtPrecoUnitario6.Text;

                btnRemove6.Enabled = true;
                txtQuantidade6.Focus();
            } 
            else
                return;

            CalculaPedido();
        }

        private void txtPrecoUnitario1_Leave(object sender, EventArgs e)
        {
            int quantidade = 0;
            decimal precoUnitario = 0.00M, subTotal = 0.00M;

            // obtem a quantidade do item atual
            try
            {
                quantidade = int.Parse(this.txtQuantidade1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("valor da quantidade inválida para o item 1");
            }

            // pega o preco unitario do item atual
            try
            {
                precoUnitario = decimal.Parse(this.txtPrecoUnitario1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Preço Unitário inválido para o item 1");
            }

            // Calcula o sub total atual
            subTotal = quantidade * precoUnitario;

            // exibe o novo sub total 
            this.txtSubTotal1.Text = subTotal.ToString();
            // atualiza o pedido
            CalculaPedido();
        }

        private void txtPrecoUnitario2_Leave(object sender, EventArgs e)
        {
            int quantidade = 0;
            decimal precoUnitario = 0.00M, subTotal = 0.00M;

            try
            {
                quantidade = int.Parse(this.txtQuantidade2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Preço Unitário inválido para o item 2");
            }

            try
            {
                precoUnitario = decimal.Parse(this.txtPrecoUnitario2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Preço Unitário inválido para o item 2");
            }

            subTotal = quantidade * precoUnitario;
            this.txtSubTotal2.Text = subTotal.ToString();

            CalculaPedido();
        }

        private void txtPrecoUnitario3_Leave(object sender, EventArgs e)
        {
            int quantidade = 0;
            decimal precoUnitario = 0.00M, subTotal = 0.00M;

            try
            {
                quantidade = int.Parse(this.txtQuantidade3.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Preço Unitário inválido para o item 3");
            }

            try
            {
                precoUnitario = decimal.Parse(this.txtPrecoUnitario3.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Preço Unitário inválido para o item 3");
            }

            subTotal = quantidade * precoUnitario;
            this.txtSubTotal3.Text = subTotal.ToString();

            CalculaPedido();
        }

        private void txtPrecoUnitario4_Leave(object sender, EventArgs e)
        {
            int quantidade = 0;
            decimal precoUnitario = 0.00M, subTotal = 0.00M;

            try
            {
                quantidade = int.Parse(this.txtQuantidade4.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Preço Unitário inválido para o item 4");
            }

            try
            {
                precoUnitario = decimal.Parse(this.txtPrecoUnitario4.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Preço Unitário inválido para o item 4");
            }

            subTotal = quantidade * precoUnitario;
            this.txtSubTotal4.Text = subTotal.ToString();

            CalculaPedido();
        }

        private void txtPrecoUnitario5_Leave(object sender, EventArgs e)
        {
            int quantidade = 0;
            decimal precoUnitario = 0.00M, subTotal = 0.00M;

            try
            {
                quantidade = int.Parse(this.txtQuantidade5.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Preço Unitário inválido para o item 5");
            }

            try
            {
                precoUnitario = decimal.Parse(this.txtPrecoUnitario5.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Preço Unitário inválido para o item 5");
            }

            subTotal = quantidade * precoUnitario;
            this.txtSubTotal5.Text = subTotal.ToString();

            CalculaPedido();
        }

        private void txtPrecoUnitario6_Leave(object sender, EventArgs e)
        {
            int quantidade = 0;
            decimal precoUnitario = 0.00M, subTotal = 0.00M;

            try
            {
                quantidade = int.Parse(this.txtQuantidade6.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Preço Unitário inválido para o item 6");
            }

            try
            {
                precoUnitario = decimal.Parse(this.txtPrecoUnitario6.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Preço Unitário inválido para o item 6");
            }

            subTotal = quantidade * precoUnitario;
            this.txtSubTotal6.Text = subTotal.ToString();

            CalculaPedido();
        }

        private void txtTaxRate_Leave(object sender, EventArgs e)
        {
            CalculaPedido();
        }

        private void btnNewCustomerOrder_Click(object sender, EventArgs e)
        {
            //armazena o arquivo na seguinte pasta
            string strDiretorio = caminhoDados + "Recibos";
            DirectoryInfo dirInfo = Directory.CreateDirectory(strDiretorio);

            // pega lista de arquivos 
            FileInfo[] fleList = dirInfo.GetFiles();
            string strNomeArquivo = "";

            // se existir um novo cliente
            //  criar o nome do arquivo
            //            if (IsNovoPedidoCliente == true)
            //          {
            // se não tiver aruqivo na pasta
            // entaõ vamos usar 1000 como primeiro nome do arquivo
            if (fleList.Length == 0)
            {
                iNomeArquivo = 1000;
            }
            else 
            {
                // Pega a referenca para o ultimo arquivo
                FileInfo arqUltimo = fleList[fleList.Length - 1];
                //Pega o nome do ultimo arquivo sem extensão
                string fwe = Path.GetFileNameWithoutExtension(arqUltimo.FullName);
                // Incrementa o nome
                iNomeArquivo = int.Parse(fwe) + 1;
            }

            // atualiza nosso nome global par ao arquivo
            strNomeArquivo = strDiretorio + "\\" + iNomeArquivo.ToString() + ".dat";
            txtNumeroRecibo.Text = iNomeArquivo.ToString();

            cbxCategorias.Text = "";
            cbxTipos.Text = "";
            lvwEstoqueItems.Items.Clear();

            txtItemNumero1.Text = "";
            txtDescricao1.Text = "";
            txtPrecoUnitario1.Text = "0.00";
            txtQuantidade1.Text = "0";
            txtSubTotal1.Text = "0.00";

            txtItemNumero2.Text = "";
            txtDescricao2.Text = "";
            txtPrecoUnitario2.Text = "0.00";
            txtQuantidade2.Text = "0";
            txtSubTotal2.Text = "0.00";

            txtItemNumero3.Text = "";
            txtDescricao3.Text = "";
            txtPrecoUnitario3.Text = "0.00";
            txtQuantidade3.Text = "0";
            txtSubTotal3.Text = "0.00";

            txtItemNumero4.Text = "";
            txtDescricao4.Text = "";
            txtPrecoUnitario4.Text = "0.00";
            txtQuantidade4.Text = "0";
            txtSubTotal4.Text = "0.00";

            txtItemNumero5.Text = "";
            txtDescricao5.Text = "";
            txtPrecoUnitario5.Text = "0.00";
            txtQuantidade5.Text = "0";
            txtSubTotal5.Text = "0.00";

            txtItemNumero6.Text = "";
            txtDescricao6.Text = "";
            txtPrecoUnitario6.Text = "0.00";
            txtQuantidade6.Text = "0";
            txtSubTotal6.Text = "0.00";

            txtItemsTotal.Text = "0.00";
            txtTaxaImposto.Text = "7,75";
            txtValorImposto.Text = "0.00";
            txtTotalOrder.Text = "0.00";
        }

        private void LojaMusical_Load(object sender, EventArgs e)
        {
            btnNewCustomerOrder_Click(sender, e);
            LoadLojaMusical();
            IsNovoPedidoCliente = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // armazena os arquivos nesta pasta    
            string strDiretorio = caminhoDados + "Recibos";
            DirectoryInfo dirInfo = Directory.CreateDirectory(strDiretorio);

            // pega a lista de arquivos 
            FileInfo[] fleList = dirInfo.GetFiles();
            string strNomeArquivo = "";

            // se tem um novo pedido
            // cria um nome para o arquivo
            if (IsNovoPedidoCliente == true)
            {
                // Se não tem arquivos na pasta
                // usa 1000 como primeiro nome do arquivo
                if (fleList.Length == 0)
                {
                    iNomeArquivo = 1000;
                }
                else 
                {
                    // Pega a referencia para o ultimoa arquivo
                    FileInfo arqUltimo = fleList[fleList.Length - 1];
                    // pega o nome sema extensão
                    string fwe = Path.GetFileNameWithoutExtension(arqUltimo.FullName);
                    // incremnte uma unidade
                    iNomeArquivo = int.Parse(fwe) + 1;
                }

                strNomeArquivo = strDiretorio + "\\" + iNomeArquivo.ToString() + ".dat";
                txtNumeroRecibo.Text = iNomeArquivo.ToString();

                IsNovoPedidoCliente = false;
            } 
            else
                strNomeArquivo = caminhoDados + "Recibos\\" + txtNumeroRecibo.Text + ".dat";
                StreamWriter wrtPedidoCliente = new StreamWriter(strNomeArquivo);

            try
            {
                wrtPedidoCliente.WriteLine(txtItemNumero1.Text);
                wrtPedidoCliente.WriteLine(txtDescricao1.Text);
                wrtPedidoCliente.WriteLine(txtPrecoUnitario1.Text);
                wrtPedidoCliente.WriteLine(txtQuantidade1.Text);

                wrtPedidoCliente.WriteLine(txtItemNumero2.Text);
                wrtPedidoCliente.WriteLine(txtDescricao2.Text);
                wrtPedidoCliente.WriteLine(txtPrecoUnitario2.Text);
                wrtPedidoCliente.WriteLine(txtQuantidade2.Text);

                wrtPedidoCliente.WriteLine(txtItemNumero3.Text);
                wrtPedidoCliente.WriteLine(txtDescricao3.Text);
                wrtPedidoCliente.WriteLine(txtPrecoUnitario3.Text);
                wrtPedidoCliente.WriteLine(txtQuantidade3.Text);

                wrtPedidoCliente.WriteLine(txtItemNumero4.Text);
                wrtPedidoCliente.WriteLine(txtDescricao4.Text);
                wrtPedidoCliente.WriteLine(txtPrecoUnitario4.Text);
                wrtPedidoCliente.WriteLine(txtQuantidade4.Text);

                wrtPedidoCliente.WriteLine(txtItemNumero5.Text);
                wrtPedidoCliente.WriteLine(txtDescricao5.Text);
                wrtPedidoCliente.WriteLine(txtPrecoUnitario5.Text);
                wrtPedidoCliente.WriteLine(txtQuantidade5.Text);

                wrtPedidoCliente.WriteLine(txtItemNumero6.Text);
                wrtPedidoCliente.WriteLine(txtDescricao6.Text);
                wrtPedidoCliente.WriteLine(txtPrecoUnitario6.Text);
                wrtPedidoCliente.WriteLine(txtQuantidade6.Text);

                wrtPedidoCliente.WriteLine(txtItemsTotal.Text);
                wrtPedidoCliente.WriteLine(txtTaxaImposto.Text);
                MessageBox.Show("Pedido Gravado com sucesso !");
            }
            finally
            {
                wrtPedidoCliente.Close();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string strDiretorio = caminhoDados + "Recibos";
            string strNomeArquivo = caminhoDados + "Recibos\\1000.dat";

            if (txtNumeroRecibo.Text == "")
                return;
            else
            {
                try
                {
                    //IsNewCleaningOrder = false;
                    strNomeArquivo = strDiretorio + "\\" +
                                  txtNumeroRecibo.Text + ".dat";

                    StreamReader rdrPedidoCliente = new StreamReader(strNomeArquivo);

                    try
                    {
                        txtItemNumero1.Text = rdrPedidoCliente.ReadLine();
                        txtDescricao1.Text = rdrPedidoCliente.ReadLine();
                        txtPrecoUnitario1.Text = rdrPedidoCliente.ReadLine();
                        txtQuantidade1.Text = rdrPedidoCliente.ReadLine();
                        txtPrecoUnitario1_Leave(sender, e);

                        txtItemNumero2.Text = rdrPedidoCliente.ReadLine();
                        txtDescricao2.Text = rdrPedidoCliente.ReadLine();
                        txtPrecoUnitario2.Text = rdrPedidoCliente.ReadLine();
                        txtQuantidade2.Text = rdrPedidoCliente.ReadLine();
                        txtPrecoUnitario2_Leave(sender, e);

                        txtItemNumero3.Text = rdrPedidoCliente.ReadLine();
                        txtDescricao3.Text = rdrPedidoCliente.ReadLine();
                        txtPrecoUnitario3.Text = rdrPedidoCliente.ReadLine();
                        txtQuantidade3.Text = rdrPedidoCliente.ReadLine();
                        txtPrecoUnitario3_Leave(sender, e);

                        txtItemNumero4.Text = rdrPedidoCliente.ReadLine();
                        txtDescricao4.Text = rdrPedidoCliente.ReadLine();
                        txtPrecoUnitario4.Text = rdrPedidoCliente.ReadLine();
                        txtQuantidade4.Text = rdrPedidoCliente.ReadLine();
                        txtPrecoUnitario4_Leave(sender, e);

                        txtItemNumero5.Text = rdrPedidoCliente.ReadLine();
                        txtDescricao5.Text = rdrPedidoCliente.ReadLine();
                        txtPrecoUnitario5.Text = rdrPedidoCliente.ReadLine();
                        txtQuantidade5.Text = rdrPedidoCliente.ReadLine();
                        txtPrecoUnitario5_Leave(sender, e);

                        txtItemNumero6.Text = rdrPedidoCliente.ReadLine();
                        txtDescricao6.Text = rdrPedidoCliente.ReadLine();
                        txtPrecoUnitario6.Text = rdrPedidoCliente.ReadLine();
                        txtQuantidade6.Text = rdrPedidoCliente.ReadLine();
                        txtPrecoUnitario6_Leave(sender, e);

                        txtItemsTotal.Text = rdrPedidoCliente.ReadLine();
                        txtTaxaImposto.Text = rdrPedidoCliente.ReadLine();

                        CalculaPedido();
                        IsNovoPedidoCliente = false;
                    }
                    finally
                    {
                        rdrPedidoCliente.Close();
                    }
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Não existe pedido com este número de recibo");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}