namespace MusicalInstrumentStore2
{
    partial class ItemEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dlgPicture = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCaminhoImagem = new System.Windows.Forms.TextBox();
            this.btnImagem = new System.Windows.Forms.Button();
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnNovoItemTipo = new System.Windows.Forms.Button();
            this.btnNovaCategoria = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtPrecoUnitario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItemNumero = new System.Windows.Forms.TextBox();
            this.pbxItemEstoque = new System.Windows.Forms.PictureBox();
            this.txtItemNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTipos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxCategorias = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxItemEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // dlgPicture
            // 
            this.dlgPicture.DefaultExt = "bmp";
            this.dlgPicture.Filter = "JPEG Files (*.jpg,*.jpeg)|*.jpg|GIF Files (*.gif)|*.gif|Bitmap Files (*.bmp)|*.bm" +
    "p|PNG Files (*.png)|*.png";
            this.dlgPicture.Title = "Select Item Picture";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 138;
            this.label1.Text = "Item #:";
            // 
            // txtCaminhoImagem
            // 
            this.txtCaminhoImagem.Location = new System.Drawing.Point(82, 175);
            this.txtCaminhoImagem.Name = "txtCaminhoImagem";
            this.txtCaminhoImagem.Size = new System.Drawing.Size(333, 20);
            this.txtCaminhoImagem.TabIndex = 144;
            // 
            // btnImagem
            // 
            this.btnImagem.Location = new System.Drawing.Point(12, 174);
            this.btnImagem.Name = "btnImagem";
            this.btnImagem.Size = new System.Drawing.Size(64, 23);
            this.btnImagem.TabIndex = 136;
            this.btnImagem.Text = "Imagem...";
            this.btnImagem.UseVisualStyleBackColor = true;
            this.btnImagem.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(259, 402);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(75, 23);
            this.btnCriar.TabIndex = 137;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnNovoItemTipo
            // 
            this.btnNovoItemTipo.Location = new System.Drawing.Point(209, 76);
            this.btnNovoItemTipo.Name = "btnNovoItemTipo";
            this.btnNovoItemTipo.Size = new System.Drawing.Size(137, 23);
            this.btnNovoItemTipo.TabIndex = 140;
            this.btnNovoItemTipo.Text = "Novo Tipo de  I&tem ...";
            this.btnNovoItemTipo.UseVisualStyleBackColor = true;
            this.btnNovoItemTipo.Click += new System.EventHandler(this.btnNovoItemTipo_Click);
            // 
            // btnNovaCategoria
            // 
            this.btnNovaCategoria.Location = new System.Drawing.Point(209, 41);
            this.btnNovaCategoria.Name = "btnNovaCategoria";
            this.btnNovaCategoria.Size = new System.Drawing.Size(137, 23);
            this.btnNovaCategoria.TabIndex = 139;
            this.btnNovaCategoria.Text = "Nova C&ategoria...";
            this.btnNovaCategoria.UseVisualStyleBackColor = true;
            this.btnNovaCategoria.Click += new System.EventHandler(this.btnNovaCategoria_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.Location = new System.Drawing.Point(340, 402);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 142;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.Location = new System.Drawing.Point(82, 142);
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.Size = new System.Drawing.Size(77, 20);
            this.txtPrecoUnitario.TabIndex = 135;
            this.txtPrecoUnitario.Text = "0,00";
            this.txtPrecoUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 134;
            this.label5.Text = "Preço :";
            // 
            // txtItemNumero
            // 
            this.txtItemNumero.Location = new System.Drawing.Point(82, 11);
            this.txtItemNumero.Name = "txtItemNumero";
            this.txtItemNumero.Size = new System.Drawing.Size(77, 20);
            this.txtItemNumero.TabIndex = 143;
            // 
            // pbxItemEstoque
            // 
            this.pbxItemEstoque.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pbxItemEstoque.Location = new System.Drawing.Point(18, 210);
            this.pbxItemEstoque.Name = "pbxItemEstoque";
            this.pbxItemEstoque.Size = new System.Drawing.Size(397, 177);
            this.pbxItemEstoque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxItemEstoque.TabIndex = 145;
            this.pbxItemEstoque.TabStop = false;
            // 
            // txtItemNome
            // 
            this.txtItemNome.Location = new System.Drawing.Point(82, 109);
            this.txtItemNome.Name = "txtItemNome";
            this.txtItemNome.Size = new System.Drawing.Size(333, 20);
            this.txtItemNome.TabIndex = 133;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 132;
            this.label4.Text = "Nome &Item:";
            // 
            // cbxTipos
            // 
            this.cbxTipos.FormattingEnabled = true;
            this.cbxTipos.Location = new System.Drawing.Point(82, 76);
            this.cbxTipos.Name = "cbxTipos";
            this.cbxTipos.Size = new System.Drawing.Size(121, 21);
            this.cbxTipos.TabIndex = 131;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 130;
            this.label3.Text = "&Tipo de Item:";
            // 
            // cbxCategorias
            // 
            this.cbxCategorias.FormattingEnabled = true;
            this.cbxCategorias.Location = new System.Drawing.Point(82, 43);
            this.cbxCategorias.Name = "cbxCategorias";
            this.cbxCategorias.Size = new System.Drawing.Size(121, 21);
            this.cbxCategorias.TabIndex = 129;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 128;
            this.label2.Text = "&Categoria:";
            // 
            // ItemEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(430, 437);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCaminhoImagem);
            this.Controls.Add(this.btnImagem);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.btnNovoItemTipo);
            this.Controls.Add(this.btnNovaCategoria);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtPrecoUnitario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtItemNumero);
            this.Controls.Add(this.pbxItemEstoque);
            this.Controls.Add(this.txtItemNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxTipos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxCategorias);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editor de Item";
            this.Load += new System.EventHandler(this.ItemEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxItemEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCaminhoImagem;
        private System.Windows.Forms.Button btnImagem;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button btnNovoItemTipo;
        private System.Windows.Forms.Button btnNovaCategoria;
        private System.Windows.Forms.Button btnFechar;
        public System.Windows.Forms.TextBox txtPrecoUnitario;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtItemNumero;
        private System.Windows.Forms.PictureBox pbxItemEstoque;
        public System.Windows.Forms.TextBox txtItemNome;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cbxTipos;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbxCategorias;
        private System.Windows.Forms.Label label2;
    }
}