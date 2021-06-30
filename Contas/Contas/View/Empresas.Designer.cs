namespace Contas
{
    partial class frmEmpresas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpresas));
            this.tabEmpresas = new System.Windows.Forms.TabControl();
            this.tabManutencaoEmpresa = new System.Windows.Forms.TabPage();
            this.tabManutencao = new System.Windows.Forms.TabControl();
            this.tabGeral = new System.Windows.Forms.TabPage();
            this.txtFantasia = new System.Windows.Forms.TextBox();
            this.lblFantasia = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.mskDataCadastro = new System.Windows.Forms.MaskedTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.txtCodigoEmpresa = new System.Windows.Forms.TextBox();
            this.lblCodigoEmpresa = new System.Windows.Forms.Label();
            this.tabConsultaEmpresa = new System.Windows.Forms.TabPage();
            this.tabRelatorioEmpresa = new System.Windows.Forms.TabPage();
            this.imgEmpresas = new System.Windows.Forms.ImageList(this.components);
            this.lblTotalEmpresas = new System.Windows.Forms.Label();
            this.tabEmpresas.SuspendLayout();
            this.tabManutencaoEmpresa.SuspendLayout();
            this.tabManutencao.SuspendLayout();
            this.tabGeral.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabEmpresas
            // 
            this.tabEmpresas.Controls.Add(this.tabManutencaoEmpresa);
            this.tabEmpresas.Controls.Add(this.tabConsultaEmpresa);
            this.tabEmpresas.Controls.Add(this.tabRelatorioEmpresa);
            this.tabEmpresas.ImageList = this.imgEmpresas;
            this.tabEmpresas.ItemSize = new System.Drawing.Size(96, 50);
            this.tabEmpresas.Location = new System.Drawing.Point(6, 6);
            this.tabEmpresas.Name = "tabEmpresas";
            this.tabEmpresas.SelectedIndex = 0;
            this.tabEmpresas.Size = new System.Drawing.Size(788, 438);
            this.tabEmpresas.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabEmpresas.TabIndex = 1;
            // 
            // tabManutencaoEmpresa
            // 
            this.tabManutencaoEmpresa.Controls.Add(this.tabManutencao);
            this.tabManutencaoEmpresa.ImageIndex = 0;
            this.tabManutencaoEmpresa.Location = new System.Drawing.Point(4, 54);
            this.tabManutencaoEmpresa.Name = "tabManutencaoEmpresa";
            this.tabManutencaoEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tabManutencaoEmpresa.Size = new System.Drawing.Size(780, 380);
            this.tabManutencaoEmpresa.TabIndex = 0;
            this.tabManutencaoEmpresa.ToolTipText = "Manutenção de empresas";
            this.tabManutencaoEmpresa.UseVisualStyleBackColor = true;
            // 
            // tabManutencao
            // 
            this.tabManutencao.Controls.Add(this.tabGeral);
            this.tabManutencao.Location = new System.Drawing.Point(6, 6);
            this.tabManutencao.Name = "tabManutencao";
            this.tabManutencao.SelectedIndex = 0;
            this.tabManutencao.Size = new System.Drawing.Size(768, 368);
            this.tabManutencao.TabIndex = 1;
            // 
            // tabGeral
            // 
            this.tabGeral.Controls.Add(this.lblTotalEmpresas);
            this.tabGeral.Controls.Add(this.txtFantasia);
            this.tabGeral.Controls.Add(this.lblFantasia);
            this.tabGeral.Controls.Add(this.btnNovo);
            this.tabGeral.Controls.Add(this.mskDataCadastro);
            this.tabGeral.Controls.Add(this.lblData);
            this.tabGeral.Controls.Add(this.btnSair);
            this.tabGeral.Controls.Add(this.btnExcluir);
            this.tabGeral.Controls.Add(this.btnSalvar);
            this.tabGeral.Controls.Add(this.txtRazaoSocial);
            this.tabGeral.Controls.Add(this.lblRazaoSocial);
            this.tabGeral.Controls.Add(this.txtCodigoEmpresa);
            this.tabGeral.Controls.Add(this.lblCodigoEmpresa);
            this.tabGeral.Location = new System.Drawing.Point(4, 22);
            this.tabGeral.Name = "tabGeral";
            this.tabGeral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeral.Size = new System.Drawing.Size(760, 342);
            this.tabGeral.TabIndex = 1;
            this.tabGeral.Text = "Geral";
            this.tabGeral.UseVisualStyleBackColor = true;
            // 
            // txtFantasia
            // 
            this.txtFantasia.Location = new System.Drawing.Point(114, 77);
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.Size = new System.Drawing.Size(210, 20);
            this.txtFantasia.TabIndex = 3;
            // 
            // lblFantasia
            // 
            this.lblFantasia.AutoSize = true;
            this.lblFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFantasia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblFantasia.Location = new System.Drawing.Point(17, 80);
            this.lblFantasia.Name = "lblFantasia";
            this.lblFantasia.Size = new System.Drawing.Size(91, 13);
            this.lblFantasia.TabIndex = 12;
            this.lblFantasia.Text = "Nome Fantasia";
            // 
            // btnNovo
            // 
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(496, 276);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(60, 60);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // mskDataCadastro
            // 
            this.mskDataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDataCadastro.Location = new System.Drawing.Point(668, 6);
            this.mskDataCadastro.Mask = "00/00/0000";
            this.mskDataCadastro.Name = "mskDataCadastro";
            this.mskDataCadastro.Size = new System.Drawing.Size(86, 20);
            this.mskDataCadastro.TabIndex = 4;
            this.mskDataCadastro.ValidatingType = typeof(System.DateTime);
            this.mskDataCadastro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskDataCadastro_KeyDown);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblData.Location = new System.Drawing.Point(574, 9);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(88, 13);
            this.lblData.TabIndex = 11;
            this.lblData.Text = "Data Cadastro";
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(694, 276);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(60, 60);
            this.btnSair.TabIndex = 10;
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(628, 276);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(60, 60);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(562, 276);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(60, 60);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazaoSocial.Location = new System.Drawing.Point(114, 51);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(405, 20);
            this.txtRazaoSocial.TabIndex = 2;
            this.txtRazaoSocial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRazaoSocial_KeyDown);
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazaoSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblRazaoSocial.Location = new System.Drawing.Point(17, 54);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(82, 13);
            this.lblRazaoSocial.TabIndex = 6;
            this.lblRazaoSocial.Text = "Razão Social";
            // 
            // txtCodigoEmpresa
            // 
            this.txtCodigoEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoEmpresa.Location = new System.Drawing.Point(114, 25);
            this.txtCodigoEmpresa.Name = "txtCodigoEmpresa";
            this.txtCodigoEmpresa.Size = new System.Drawing.Size(63, 20);
            this.txtCodigoEmpresa.TabIndex = 1;
            // 
            // lblCodigoEmpresa
            // 
            this.lblCodigoEmpresa.AutoSize = true;
            this.lblCodigoEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCodigoEmpresa.Location = new System.Drawing.Point(17, 28);
            this.lblCodigoEmpresa.Name = "lblCodigoEmpresa";
            this.lblCodigoEmpresa.Size = new System.Drawing.Size(46, 13);
            this.lblCodigoEmpresa.TabIndex = 4;
            this.lblCodigoEmpresa.Text = "Código";
            // 
            // tabConsultaEmpresa
            // 
            this.tabConsultaEmpresa.ImageIndex = 1;
            this.tabConsultaEmpresa.Location = new System.Drawing.Point(4, 54);
            this.tabConsultaEmpresa.Name = "tabConsultaEmpresa";
            this.tabConsultaEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultaEmpresa.Size = new System.Drawing.Size(780, 380);
            this.tabConsultaEmpresa.TabIndex = 1;
            this.tabConsultaEmpresa.ToolTipText = "Consulta cadastro de empresas";
            this.tabConsultaEmpresa.UseVisualStyleBackColor = true;
            // 
            // tabRelatorioEmpresa
            // 
            this.tabRelatorioEmpresa.ImageIndex = 2;
            this.tabRelatorioEmpresa.Location = new System.Drawing.Point(4, 54);
            this.tabRelatorioEmpresa.Name = "tabRelatorioEmpresa";
            this.tabRelatorioEmpresa.Size = new System.Drawing.Size(780, 380);
            this.tabRelatorioEmpresa.TabIndex = 2;
            this.tabRelatorioEmpresa.ToolTipText = "Imprime relação de empresas";
            this.tabRelatorioEmpresa.UseVisualStyleBackColor = true;
            // 
            // imgEmpresas
            // 
            this.imgEmpresas.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgEmpresas.ImageStream")));
            this.imgEmpresas.TransparentColor = System.Drawing.Color.Transparent;
            this.imgEmpresas.Images.SetKeyName(0, "icons8-maintenance-48.png");
            this.imgEmpresas.Images.SetKeyName(1, "icons8-detective-48.png");
            this.imgEmpresas.Images.SetKeyName(2, "icons8-impressão-48.png");
            // 
            // lblTotalEmpresas
            // 
            this.lblTotalEmpresas.AutoSize = true;
            this.lblTotalEmpresas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEmpresas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTotalEmpresas.Location = new System.Drawing.Point(183, 28);
            this.lblTotalEmpresas.Name = "lblTotalEmpresas";
            this.lblTotalEmpresas.Size = new System.Drawing.Size(0, 13);
            this.lblTotalEmpresas.TabIndex = 13;
            // 
            // frmEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabEmpresas);
            this.Name = "frmEmpresas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Controle Financeiro - Empresas";
            this.Load += new System.EventHandler(this.frmEmpresas_Load);
            this.tabEmpresas.ResumeLayout(false);
            this.tabManutencaoEmpresa.ResumeLayout(false);
            this.tabManutencao.ResumeLayout(false);
            this.tabGeral.ResumeLayout(false);
            this.tabGeral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEmpresas;
        private System.Windows.Forms.TabPage tabManutencaoEmpresa;
        private System.Windows.Forms.TabPage tabConsultaEmpresa;
        private System.Windows.Forms.TabPage tabRelatorioEmpresa;
        private System.Windows.Forms.ImageList imgEmpresas;
        private System.Windows.Forms.TabControl tabManutencao;
        private System.Windows.Forms.TabPage tabGeral;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.TextBox txtCodigoEmpresa;
        private System.Windows.Forms.Label lblCodigoEmpresa;
        private System.Windows.Forms.MaskedTextBox mskDataCadastro;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtFantasia;
        private System.Windows.Forms.Label lblFantasia;
        private System.Windows.Forms.Label lblTotalEmpresas;
    }
}