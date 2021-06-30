namespace Contas.View
{
    partial class frmLancamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLancamentos));
            this.dgvLancamentos = new System.Windows.Forms.DataGridView();
            this.lblData = new System.Windows.Forms.Label();
            this.txtTransacao = new System.Windows.Forms.TextBox();
            this.lblTransacao = new System.Windows.Forms.Label();
            this.mnuLancamentos = new System.Windows.Forms.MenuStrip();
            this.mnuAddLancamento = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveLancamento = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelLancamento = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportLancamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExitLancamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.mskDataCadastro = new System.Windows.Forms.MaskedTextBox();
            this.lblDebito = new System.Windows.Forms.Label();
            this.lblCredito = new System.Windows.Forms.Label();
            this.cmbDebito = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbMovimento = new System.Windows.Forms.GroupBox();
            this.rdbTransferencia = new System.Windows.Forms.RadioButton();
            this.rdbSaida = new System.Windows.Forms.RadioButton();
            this.rdbEntrada = new System.Windows.Forms.RadioButton();
            this.txtHistorico = new System.Windows.Forms.TextBox();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.mskValor = new System.Windows.Forms.MaskedTextBox();
            this.lblValor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLancamentos)).BeginInit();
            this.mnuLancamentos.SuspendLayout();
            this.gbMovimento.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLancamentos
            // 
            this.dgvLancamentos.AllowUserToAddRows = false;
            this.dgvLancamentos.AllowUserToDeleteRows = false;
            this.dgvLancamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLancamentos.Location = new System.Drawing.Point(18, 165);
            this.dgvLancamentos.Name = "dgvLancamentos";
            this.dgvLancamentos.ReadOnly = true;
            this.dgvLancamentos.Size = new System.Drawing.Size(770, 375);
            this.dgvLancamentos.TabIndex = 16;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.SystemColors.Control;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblData.Location = new System.Drawing.Point(321, 69);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(34, 13);
            this.lblData.TabIndex = 14;
            this.lblData.Text = "Data";
            // 
            // txtTransacao
            // 
            this.txtTransacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransacao.Location = new System.Drawing.Point(102, 66);
            this.txtTransacao.Name = "txtTransacao";
            this.txtTransacao.Size = new System.Drawing.Size(63, 20);
            this.txtTransacao.TabIndex = 13;
            // 
            // lblTransacao
            // 
            this.lblTransacao.AutoSize = true;
            this.lblTransacao.BackColor = System.Drawing.SystemColors.Control;
            this.lblTransacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransacao.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTransacao.Location = new System.Drawing.Point(15, 69);
            this.lblTransacao.Name = "lblTransacao";
            this.lblTransacao.Size = new System.Drawing.Size(67, 13);
            this.lblTransacao.TabIndex = 12;
            this.lblTransacao.Text = "Transação";
            // 
            // mnuLancamentos
            // 
            this.mnuLancamentos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddLancamento,
            this.mnuSaveLancamento,
            this.mnuDelLancamento,
            this.mnuReportLancamentos,
            this.mnuExitLancamentos});
            this.mnuLancamentos.Location = new System.Drawing.Point(0, 0);
            this.mnuLancamentos.Name = "mnuLancamentos";
            this.mnuLancamentos.Size = new System.Drawing.Size(800, 56);
            this.mnuLancamentos.TabIndex = 17;
            // 
            // mnuAddLancamento
            // 
            this.mnuAddLancamento.Image = ((System.Drawing.Image)(resources.GetObject("mnuAddLancamento.Image")));
            this.mnuAddLancamento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuAddLancamento.Name = "mnuAddLancamento";
            this.mnuAddLancamento.Size = new System.Drawing.Size(60, 52);
            this.mnuAddLancamento.ToolTipText = "Adicionar nova conta";
            // 
            // mnuSaveLancamento
            // 
            this.mnuSaveLancamento.Image = ((System.Drawing.Image)(resources.GetObject("mnuSaveLancamento.Image")));
            this.mnuSaveLancamento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuSaveLancamento.Name = "mnuSaveLancamento";
            this.mnuSaveLancamento.Size = new System.Drawing.Size(60, 52);
            this.mnuSaveLancamento.ToolTipText = "Salvar a conta";
            // 
            // mnuDelLancamento
            // 
            this.mnuDelLancamento.Image = ((System.Drawing.Image)(resources.GetObject("mnuDelLancamento.Image")));
            this.mnuDelLancamento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuDelLancamento.Name = "mnuDelLancamento";
            this.mnuDelLancamento.Size = new System.Drawing.Size(60, 52);
            this.mnuDelLancamento.ToolTipText = "Deletar a conta";
            // 
            // mnuReportLancamentos
            // 
            this.mnuReportLancamentos.Image = ((System.Drawing.Image)(resources.GetObject("mnuReportLancamentos.Image")));
            this.mnuReportLancamentos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuReportLancamentos.Name = "mnuReportLancamentos";
            this.mnuReportLancamentos.Size = new System.Drawing.Size(60, 52);
            this.mnuReportLancamentos.ToolTipText = "Relatórios de contas";
            // 
            // mnuExitLancamentos
            // 
            this.mnuExitLancamentos.Image = ((System.Drawing.Image)(resources.GetObject("mnuExitLancamentos.Image")));
            this.mnuExitLancamentos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuExitLancamentos.Name = "mnuExitLancamentos";
            this.mnuExitLancamentos.Size = new System.Drawing.Size(60, 52);
            this.mnuExitLancamentos.ToolTipText = "Fechar o cadastro de contas";
            // 
            // mskDataCadastro
            // 
            this.mskDataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDataCadastro.Location = new System.Drawing.Point(411, 66);
            this.mskDataCadastro.Mask = "00/00/0000";
            this.mskDataCadastro.Name = "mskDataCadastro";
            this.mskDataCadastro.Size = new System.Drawing.Size(86, 20);
            this.mskDataCadastro.TabIndex = 18;
            this.mskDataCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // lblDebito
            // 
            this.lblDebito.AutoSize = true;
            this.lblDebito.BackColor = System.Drawing.SystemColors.Control;
            this.lblDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebito.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDebito.Location = new System.Drawing.Point(15, 95);
            this.lblDebito.Name = "lblDebito";
            this.lblDebito.Size = new System.Drawing.Size(81, 13);
            this.lblDebito.TabIndex = 19;
            this.lblDebito.Text = "Conta Débito";
            // 
            // lblCredito
            // 
            this.lblCredito.AutoSize = true;
            this.lblCredito.BackColor = System.Drawing.SystemColors.Control;
            this.lblCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredito.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCredito.Location = new System.Drawing.Point(321, 95);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(84, 13);
            this.lblCredito.TabIndex = 21;
            this.lblCredito.Text = "Conta Crédito";
            // 
            // cmbDebito
            // 
            this.cmbDebito.FormattingEnabled = true;
            this.cmbDebito.Location = new System.Drawing.Point(102, 92);
            this.cmbDebito.Name = "cmbDebito";
            this.cmbDebito.Size = new System.Drawing.Size(213, 21);
            this.cmbDebito.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(411, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // gbMovimento
            // 
            this.gbMovimento.Controls.Add(this.rdbTransferencia);
            this.gbMovimento.Controls.Add(this.rdbSaida);
            this.gbMovimento.Controls.Add(this.rdbEntrada);
            this.gbMovimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMovimento.Location = new System.Drawing.Point(665, 59);
            this.gbMovimento.Name = "gbMovimento";
            this.gbMovimento.Size = new System.Drawing.Size(123, 100);
            this.gbMovimento.TabIndex = 27;
            this.gbMovimento.TabStop = false;
            this.gbMovimento.Text = "Movimento";
            // 
            // rdbTransferencia
            // 
            this.rdbTransferencia.AutoSize = true;
            this.rdbTransferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTransferencia.ForeColor = System.Drawing.Color.Navy;
            this.rdbTransferencia.Location = new System.Drawing.Point(6, 65);
            this.rdbTransferencia.Name = "rdbTransferencia";
            this.rdbTransferencia.Size = new System.Drawing.Size(103, 17);
            this.rdbTransferencia.TabIndex = 29;
            this.rdbTransferencia.Text = "Transferência";
            this.rdbTransferencia.UseVisualStyleBackColor = true;
            // 
            // rdbSaida
            // 
            this.rdbSaida.AutoSize = true;
            this.rdbSaida.Checked = true;
            this.rdbSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSaida.ForeColor = System.Drawing.Color.Navy;
            this.rdbSaida.Location = new System.Drawing.Point(6, 42);
            this.rdbSaida.Name = "rdbSaida";
            this.rdbSaida.Size = new System.Drawing.Size(59, 17);
            this.rdbSaida.TabIndex = 28;
            this.rdbSaida.TabStop = true;
            this.rdbSaida.Text = "Saída";
            this.rdbSaida.UseVisualStyleBackColor = true;
            // 
            // rdbEntrada
            // 
            this.rdbEntrada.AutoSize = true;
            this.rdbEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEntrada.ForeColor = System.Drawing.Color.Navy;
            this.rdbEntrada.Location = new System.Drawing.Point(6, 19);
            this.rdbEntrada.Name = "rdbEntrada";
            this.rdbEntrada.Size = new System.Drawing.Size(69, 17);
            this.rdbEntrada.TabIndex = 27;
            this.rdbEntrada.Text = "Entrada";
            this.rdbEntrada.UseVisualStyleBackColor = true;
            // 
            // txtHistorico
            // 
            this.txtHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistorico.Location = new System.Drawing.Point(102, 119);
            this.txtHistorico.Name = "txtHistorico";
            this.txtHistorico.Size = new System.Drawing.Size(363, 20);
            this.txtHistorico.TabIndex = 29;
            // 
            // lblHistorico
            // 
            this.lblHistorico.AutoSize = true;
            this.lblHistorico.BackColor = System.Drawing.SystemColors.Control;
            this.lblHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorico.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHistorico.Location = new System.Drawing.Point(15, 122);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(57, 13);
            this.lblHistorico.TabIndex = 28;
            this.lblHistorico.Text = "Histórico";
            // 
            // mskValor
            // 
            this.mskValor.Location = new System.Drawing.Point(544, 119);
            this.mskValor.Mask = "#,###.##";
            this.mskValor.Name = "mskValor";
            this.mskValor.Size = new System.Drawing.Size(80, 20);
            this.mskValor.TabIndex = 30;
            this.mskValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.SystemColors.Control;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblValor.Location = new System.Drawing.Point(502, 122);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(36, 13);
            this.lblValor.TabIndex = 31;
            this.lblValor.Text = "Valor";
            // 
            // frmLancamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.mskValor);
            this.Controls.Add(this.txtHistorico);
            this.Controls.Add(this.lblHistorico);
            this.Controls.Add(this.gbMovimento);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmbDebito);
            this.Controls.Add(this.lblCredito);
            this.Controls.Add(this.lblDebito);
            this.Controls.Add(this.mskDataCadastro);
            this.Controls.Add(this.dgvLancamentos);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtTransacao);
            this.Controls.Add(this.lblTransacao);
            this.Controls.Add(this.mnuLancamentos);
            this.Name = "frmLancamentos";
            this.Text = "Controle Financeiro - Lancamentos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLancamentos)).EndInit();
            this.mnuLancamentos.ResumeLayout(false);
            this.mnuLancamentos.PerformLayout();
            this.gbMovimento.ResumeLayout(false);
            this.gbMovimento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLancamentos;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtTransacao;
        private System.Windows.Forms.Label lblTransacao;
        private System.Windows.Forms.MenuStrip mnuLancamentos;
        private System.Windows.Forms.ToolStripMenuItem mnuAddLancamento;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveLancamento;
        private System.Windows.Forms.ToolStripMenuItem mnuDelLancamento;
        private System.Windows.Forms.ToolStripMenuItem mnuReportLancamentos;
        private System.Windows.Forms.ToolStripMenuItem mnuExitLancamentos;
        private System.Windows.Forms.MaskedTextBox mskDataCadastro;
        private System.Windows.Forms.Label lblDebito;
        private System.Windows.Forms.Label lblCredito;
        private System.Windows.Forms.ComboBox cmbDebito;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox gbMovimento;
        private System.Windows.Forms.RadioButton rdbTransferencia;
        private System.Windows.Forms.RadioButton rdbSaida;
        private System.Windows.Forms.RadioButton rdbEntrada;
        private System.Windows.Forms.TextBox txtHistorico;
        private System.Windows.Forms.Label lblHistorico;
        private System.Windows.Forms.MaskedTextBox mskValor;
        private System.Windows.Forms.Label lblValor;
    }
}