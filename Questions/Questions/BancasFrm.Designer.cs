namespace Questions
{
    partial class BancasFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BancasFrm));
            this.dgvBancas = new System.Windows.Forms.DataGridView();
            this.txtBanca = new System.Windows.Forms.TextBox();
            this.lblBanca = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.mnuBancas = new System.Windows.Forms.MenuStrip();
            this.mnuAddBanca = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveBanca = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelBanca = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportBanca = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExitBanca = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBancas)).BeginInit();
            this.mnuBancas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBancas
            // 
            this.dgvBancas.AllowUserToAddRows = false;
            this.dgvBancas.AllowUserToDeleteRows = false;
            this.dgvBancas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBancas.Location = new System.Drawing.Point(12, 135);
            this.dgvBancas.Name = "dgvBancas";
            this.dgvBancas.ReadOnly = true;
            this.dgvBancas.Size = new System.Drawing.Size(462, 420);
            this.dgvBancas.TabIndex = 16;
            this.dgvBancas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBancas_CellClick);
            // 
            // txtBanca
            // 
            this.txtBanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanca.Location = new System.Drawing.Point(90, 100);
            this.txtBanca.Name = "txtBanca";
            this.txtBanca.Size = new System.Drawing.Size(384, 20);
            this.txtBanca.TabIndex = 15;
            // 
            // lblBanca
            // 
            this.lblBanca.AutoSize = true;
            this.lblBanca.BackColor = System.Drawing.SystemColors.Control;
            this.lblBanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanca.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblBanca.Location = new System.Drawing.Point(12, 103);
            this.lblBanca.Name = "lblBanca";
            this.lblBanca.Size = new System.Drawing.Size(43, 13);
            this.lblBanca.TabIndex = 14;
            this.lblBanca.Text = "Banca";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(90, 74);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(63, 20);
            this.txtCodigo.TabIndex = 13;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.SystemColors.Control;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCodigo.Location = new System.Drawing.Point(12, 77);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 13);
            this.lblCodigo.TabIndex = 12;
            this.lblCodigo.Text = "Código";
            // 
            // mnuBancas
            // 
            this.mnuBancas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddBanca,
            this.mnuSaveBanca,
            this.mnuDelBanca,
            this.mnuReportBanca,
            this.mnuExitBanca});
            this.mnuBancas.Location = new System.Drawing.Point(0, 0);
            this.mnuBancas.Name = "mnuBancas";
            this.mnuBancas.Size = new System.Drawing.Size(492, 56);
            this.mnuBancas.TabIndex = 17;
            this.mnuBancas.Text = "mnuDisciplinas";
            // 
            // mnuAddBanca
            // 
            this.mnuAddBanca.Image = ((System.Drawing.Image)(resources.GetObject("mnuAddBanca.Image")));
            this.mnuAddBanca.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuAddBanca.Name = "mnuAddBanca";
            this.mnuAddBanca.Size = new System.Drawing.Size(60, 52);
            this.mnuAddBanca.ToolTipText = "Adicionar nova disciplina";
            this.mnuAddBanca.Click += new System.EventHandler(this.mnuAddBanca_Click);
            // 
            // mnuSaveBanca
            // 
            this.mnuSaveBanca.Image = ((System.Drawing.Image)(resources.GetObject("mnuSaveBanca.Image")));
            this.mnuSaveBanca.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuSaveBanca.Name = "mnuSaveBanca";
            this.mnuSaveBanca.Size = new System.Drawing.Size(60, 52);
            this.mnuSaveBanca.ToolTipText = "Salvar a disciplina";
            this.mnuSaveBanca.Click += new System.EventHandler(this.mnuSaveBanca_Click);
            // 
            // mnuDelBanca
            // 
            this.mnuDelBanca.Image = ((System.Drawing.Image)(resources.GetObject("mnuDelBanca.Image")));
            this.mnuDelBanca.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuDelBanca.Name = "mnuDelBanca";
            this.mnuDelBanca.Size = new System.Drawing.Size(60, 52);
            this.mnuDelBanca.ToolTipText = "Deletar a disciplina";
            this.mnuDelBanca.Click += new System.EventHandler(this.mnuDelBanca_Click);
            // 
            // mnuReportBanca
            // 
            this.mnuReportBanca.Image = ((System.Drawing.Image)(resources.GetObject("mnuReportBanca.Image")));
            this.mnuReportBanca.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuReportBanca.Name = "mnuReportBanca";
            this.mnuReportBanca.Size = new System.Drawing.Size(60, 52);
            this.mnuReportBanca.ToolTipText = "Relatórios de disciplinas";
            // 
            // mnuExitBanca
            // 
            this.mnuExitBanca.Image = ((System.Drawing.Image)(resources.GetObject("mnuExitBanca.Image")));
            this.mnuExitBanca.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuExitBanca.Name = "mnuExitBanca";
            this.mnuExitBanca.Size = new System.Drawing.Size(60, 52);
            this.mnuExitBanca.ToolTipText = "Fechar o cadastro de disciplinas";
            this.mnuExitBanca.Click += new System.EventHandler(this.mnuExitBanca_Click);
            // 
            // BancasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 561);
            this.Controls.Add(this.dgvBancas);
            this.Controls.Add(this.txtBanca);
            this.Controls.Add(this.lblBanca);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.mnuBancas);
            this.Name = "BancasFrm";
            this.Text = "Banco de Questões - Bancas";
            this.Activated += new System.EventHandler(this.BancasFrm_Activated);
            this.Load += new System.EventHandler(this.BancasFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBancas)).EndInit();
            this.mnuBancas.ResumeLayout(false);
            this.mnuBancas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBancas;
        private System.Windows.Forms.TextBox txtBanca;
        private System.Windows.Forms.Label lblBanca;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.MenuStrip mnuBancas;
        private System.Windows.Forms.ToolStripMenuItem mnuAddBanca;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveBanca;
        private System.Windows.Forms.ToolStripMenuItem mnuDelBanca;
        private System.Windows.Forms.ToolStripMenuItem mnuReportBanca;
        private System.Windows.Forms.ToolStripMenuItem mnuExitBanca;
    }
}