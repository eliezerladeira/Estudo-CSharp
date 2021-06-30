namespace Questions
{
    partial class AssuntosFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssuntosFrm));
            this.dgvAssuntos = new System.Windows.Forms.DataGridView();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.mnuAssuntos = new System.Windows.Forms.MenuStrip();
            this.mnuAddAssunto = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAssunto = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelAssunto = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportAssunto = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExitAssunto = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssuntos)).BeginInit();
            this.mnuAssuntos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAssuntos
            // 
            this.dgvAssuntos.AllowUserToAddRows = false;
            this.dgvAssuntos.AllowUserToDeleteRows = false;
            this.dgvAssuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssuntos.Location = new System.Drawing.Point(12, 136);
            this.dgvAssuntos.Name = "dgvAssuntos";
            this.dgvAssuntos.ReadOnly = true;
            this.dgvAssuntos.Size = new System.Drawing.Size(462, 420);
            this.dgvAssuntos.TabIndex = 10;
            this.dgvAssuntos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssuntos_CellClick);
            // 
            // txtAssunto
            // 
            this.txtAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssunto.Location = new System.Drawing.Point(90, 101);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(384, 20);
            this.txtAssunto.TabIndex = 9;
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.BackColor = System.Drawing.SystemColors.Control;
            this.lblAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssunto.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAssunto.Location = new System.Drawing.Point(12, 104);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(52, 13);
            this.lblAssunto.TabIndex = 8;
            this.lblAssunto.Text = "Assunto";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(90, 75);
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
            this.lblCodigo.Location = new System.Drawing.Point(12, 78);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 13);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "Código";
            // 
            // mnuAssuntos
            // 
            this.mnuAssuntos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddAssunto,
            this.mnuSaveAssunto,
            this.mnuDelAssunto,
            this.mnuReportAssunto,
            this.mnuExitAssunto});
            this.mnuAssuntos.Location = new System.Drawing.Point(0, 0);
            this.mnuAssuntos.Name = "mnuAssuntos";
            this.mnuAssuntos.Size = new System.Drawing.Size(492, 56);
            this.mnuAssuntos.TabIndex = 11;
            this.mnuAssuntos.Text = "mnuDisciplinas";
            // 
            // mnuAddAssunto
            // 
            this.mnuAddAssunto.Image = ((System.Drawing.Image)(resources.GetObject("mnuAddAssunto.Image")));
            this.mnuAddAssunto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuAddAssunto.Name = "mnuAddAssunto";
            this.mnuAddAssunto.Size = new System.Drawing.Size(60, 52);
            this.mnuAddAssunto.ToolTipText = "Adicionar nova disciplina";
            this.mnuAddAssunto.Click += new System.EventHandler(this.mnuAddAssunto_Click);
            // 
            // mnuSaveAssunto
            // 
            this.mnuSaveAssunto.Image = ((System.Drawing.Image)(resources.GetObject("mnuSaveAssunto.Image")));
            this.mnuSaveAssunto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuSaveAssunto.Name = "mnuSaveAssunto";
            this.mnuSaveAssunto.Size = new System.Drawing.Size(60, 52);
            this.mnuSaveAssunto.ToolTipText = "Salvar a disciplina";
            this.mnuSaveAssunto.Click += new System.EventHandler(this.mnuSaveAssunto_Click);
            // 
            // mnuDelAssunto
            // 
            this.mnuDelAssunto.Image = ((System.Drawing.Image)(resources.GetObject("mnuDelAssunto.Image")));
            this.mnuDelAssunto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuDelAssunto.Name = "mnuDelAssunto";
            this.mnuDelAssunto.Size = new System.Drawing.Size(60, 52);
            this.mnuDelAssunto.ToolTipText = "Deletar a disciplina";
            this.mnuDelAssunto.Click += new System.EventHandler(this.mnuDelAssunto_Click);
            // 
            // mnuReportAssunto
            // 
            this.mnuReportAssunto.Image = ((System.Drawing.Image)(resources.GetObject("mnuReportAssunto.Image")));
            this.mnuReportAssunto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuReportAssunto.Name = "mnuReportAssunto";
            this.mnuReportAssunto.Size = new System.Drawing.Size(60, 52);
            this.mnuReportAssunto.ToolTipText = "Relatórios de disciplinas";
            // 
            // mnuExitAssunto
            // 
            this.mnuExitAssunto.Image = ((System.Drawing.Image)(resources.GetObject("mnuExitAssunto.Image")));
            this.mnuExitAssunto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuExitAssunto.Name = "mnuExitAssunto";
            this.mnuExitAssunto.Size = new System.Drawing.Size(60, 52);
            this.mnuExitAssunto.ToolTipText = "Fechar o cadastro de disciplinas";
            this.mnuExitAssunto.Click += new System.EventHandler(this.mnuExitAssunto_Click);
            // 
            // AssuntosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 561);
            this.Controls.Add(this.dgvAssuntos);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.lblAssunto);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.mnuAssuntos);
            this.Name = "AssuntosFrm";
            this.Text = "Banco de Questões - Assuntos";
            this.Activated += new System.EventHandler(this.AssuntosFrm_Activated);
            this.Load += new System.EventHandler(this.AssuntosFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssuntos)).EndInit();
            this.mnuAssuntos.ResumeLayout(false);
            this.mnuAssuntos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAssuntos;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.MenuStrip mnuAssuntos;
        private System.Windows.Forms.ToolStripMenuItem mnuAddAssunto;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveAssunto;
        private System.Windows.Forms.ToolStripMenuItem mnuDelAssunto;
        private System.Windows.Forms.ToolStripMenuItem mnuReportAssunto;
        private System.Windows.Forms.ToolStripMenuItem mnuExitAssunto;
    }
}