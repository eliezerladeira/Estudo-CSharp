namespace Contas.View
{
    partial class Contas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contas));
            this.dgvContas = new System.Windows.Forms.DataGridView();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.lblConta = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.mnuAddContas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveConta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelConta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportContas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExitConta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContas = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).BeginInit();
            this.mnuContas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvContas
            // 
            this.dgvContas.AllowUserToAddRows = false;
            this.dgvContas.AllowUserToDeleteRows = false;
            this.dgvContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContas.Location = new System.Drawing.Point(15, 127);
            this.dgvContas.Name = "dgvContas";
            this.dgvContas.ReadOnly = true;
            this.dgvContas.Size = new System.Drawing.Size(462, 420);
            this.dgvContas.TabIndex = 10;
            // 
            // txtConta
            // 
            this.txtConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConta.Location = new System.Drawing.Point(93, 92);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(360, 20);
            this.txtConta.TabIndex = 9;
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.BackColor = System.Drawing.SystemColors.Control;
            this.lblConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConta.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblConta.Location = new System.Drawing.Point(15, 95);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(40, 13);
            this.lblConta.TabIndex = 8;
            this.lblConta.Text = "Conta";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(93, 66);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(63, 20);
            this.txtCodigo.TabIndex = 7;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.SystemColors.Control;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCodigo.Location = new System.Drawing.Point(15, 69);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 13);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "Código";
            // 
            // mnuAddContas
            // 
            this.mnuAddContas.Image = ((System.Drawing.Image)(resources.GetObject("mnuAddContas.Image")));
            this.mnuAddContas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuAddContas.Name = "mnuAddContas";
            this.mnuAddContas.Size = new System.Drawing.Size(60, 52);
            this.mnuAddContas.ToolTipText = "Adicionar nova conta";
            // 
            // mnuSaveConta
            // 
            this.mnuSaveConta.Image = ((System.Drawing.Image)(resources.GetObject("mnuSaveConta.Image")));
            this.mnuSaveConta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuSaveConta.Name = "mnuSaveConta";
            this.mnuSaveConta.Size = new System.Drawing.Size(60, 52);
            this.mnuSaveConta.ToolTipText = "Salvar a conta";
            this.mnuSaveConta.Click += new System.EventHandler(this.mnuSaveConta_Click);
            // 
            // mnuDelConta
            // 
            this.mnuDelConta.Image = ((System.Drawing.Image)(resources.GetObject("mnuDelConta.Image")));
            this.mnuDelConta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuDelConta.Name = "mnuDelConta";
            this.mnuDelConta.Size = new System.Drawing.Size(60, 52);
            this.mnuDelConta.ToolTipText = "Deletar a conta";
            // 
            // mnuReportContas
            // 
            this.mnuReportContas.Image = ((System.Drawing.Image)(resources.GetObject("mnuReportContas.Image")));
            this.mnuReportContas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuReportContas.Name = "mnuReportContas";
            this.mnuReportContas.Size = new System.Drawing.Size(60, 52);
            this.mnuReportContas.ToolTipText = "Relatórios de contas";
            // 
            // mnuExitConta
            // 
            this.mnuExitConta.Image = ((System.Drawing.Image)(resources.GetObject("mnuExitConta.Image")));
            this.mnuExitConta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuExitConta.Name = "mnuExitConta";
            this.mnuExitConta.Size = new System.Drawing.Size(60, 52);
            this.mnuExitConta.ToolTipText = "Fechar o cadastro de contas";
            // 
            // mnuContas
            // 
            this.mnuContas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddContas,
            this.mnuSaveConta,
            this.mnuDelConta,
            this.mnuReportContas,
            this.mnuExitConta});
            this.mnuContas.Location = new System.Drawing.Point(0, 0);
            this.mnuContas.Name = "mnuContas";
            this.mnuContas.Size = new System.Drawing.Size(491, 56);
            this.mnuContas.TabIndex = 11;
            // 
            // Contas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 561);
            this.Controls.Add(this.dgvContas);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.lblConta);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.mnuContas);
            this.Name = "Contas";
            this.Text = "Controle Financeiro - Contas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).EndInit();
            this.mnuContas.ResumeLayout(false);
            this.mnuContas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContas;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ToolStripMenuItem mnuAddContas;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveConta;
        private System.Windows.Forms.ToolStripMenuItem mnuDelConta;
        private System.Windows.Forms.ToolStripMenuItem mnuReportContas;
        private System.Windows.Forms.ToolStripMenuItem mnuExitConta;
        private System.Windows.Forms.MenuStrip mnuContas;
    }
}