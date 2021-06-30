namespace Questions
{
    partial class DisciplinasFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisciplinasFrm));
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblDisciplina = new System.Windows.Forms.Label();
            this.txtDisciplina = new System.Windows.Forms.TextBox();
            this.dgvDisciplinas = new System.Windows.Forms.DataGridView();
            this.mnuDisciplinas = new System.Windows.Forms.MenuStrip();
            this.mnuAddDisciplina = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveDisciplina = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelDisciplina = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportDisciplina = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExitDisciplina = new System.Windows.Forms.ToolStripMenuItem();
            this.picPesquisa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplinas)).BeginInit();
            this.mnuDisciplinas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPesquisa)).BeginInit();
            this.SuspendLayout();
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
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(90, 74);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(63, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblDisciplina
            // 
            this.lblDisciplina.AutoSize = true;
            this.lblDisciplina.BackColor = System.Drawing.SystemColors.Control;
            this.lblDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisciplina.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDisciplina.Location = new System.Drawing.Point(12, 103);
            this.lblDisciplina.Name = "lblDisciplina";
            this.lblDisciplina.Size = new System.Drawing.Size(62, 13);
            this.lblDisciplina.TabIndex = 2;
            this.lblDisciplina.Text = "Disciplina";
            // 
            // txtDisciplina
            // 
            this.txtDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisciplina.Location = new System.Drawing.Point(90, 100);
            this.txtDisciplina.Name = "txtDisciplina";
            this.txtDisciplina.Size = new System.Drawing.Size(360, 20);
            this.txtDisciplina.TabIndex = 3;
            // 
            // dgvDisciplinas
            // 
            this.dgvDisciplinas.AllowUserToAddRows = false;
            this.dgvDisciplinas.AllowUserToDeleteRows = false;
            this.dgvDisciplinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisciplinas.Location = new System.Drawing.Point(12, 135);
            this.dgvDisciplinas.Name = "dgvDisciplinas";
            this.dgvDisciplinas.ReadOnly = true;
            this.dgvDisciplinas.Size = new System.Drawing.Size(462, 420);
            this.dgvDisciplinas.TabIndex = 4;
            this.dgvDisciplinas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisciplinas_CellClick);
            // 
            // mnuDisciplinas
            // 
            this.mnuDisciplinas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddDisciplina,
            this.mnuSaveDisciplina,
            this.mnuDelDisciplina,
            this.mnuReportDisciplina,
            this.mnuExitDisciplina});
            this.mnuDisciplinas.Location = new System.Drawing.Point(0, 0);
            this.mnuDisciplinas.Name = "mnuDisciplinas";
            this.mnuDisciplinas.Size = new System.Drawing.Size(492, 56);
            this.mnuDisciplinas.TabIndex = 5;
            this.mnuDisciplinas.Text = "mnuDisciplinas";
            // 
            // mnuAddDisciplina
            // 
            this.mnuAddDisciplina.Image = ((System.Drawing.Image)(resources.GetObject("mnuAddDisciplina.Image")));
            this.mnuAddDisciplina.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuAddDisciplina.Name = "mnuAddDisciplina";
            this.mnuAddDisciplina.Size = new System.Drawing.Size(60, 52);
            this.mnuAddDisciplina.ToolTipText = "Adicionar nova disciplina";
            this.mnuAddDisciplina.Click += new System.EventHandler(this.mnuAddDisciplina_Click);
            // 
            // mnuSaveDisciplina
            // 
            this.mnuSaveDisciplina.Image = ((System.Drawing.Image)(resources.GetObject("mnuSaveDisciplina.Image")));
            this.mnuSaveDisciplina.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuSaveDisciplina.Name = "mnuSaveDisciplina";
            this.mnuSaveDisciplina.Size = new System.Drawing.Size(60, 52);
            this.mnuSaveDisciplina.ToolTipText = "Salvar a disciplina";
            this.mnuSaveDisciplina.Click += new System.EventHandler(this.mnuSaveDisciplina_Click);
            // 
            // mnuDelDisciplina
            // 
            this.mnuDelDisciplina.Image = ((System.Drawing.Image)(resources.GetObject("mnuDelDisciplina.Image")));
            this.mnuDelDisciplina.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuDelDisciplina.Name = "mnuDelDisciplina";
            this.mnuDelDisciplina.Size = new System.Drawing.Size(60, 52);
            this.mnuDelDisciplina.ToolTipText = "Deletar a disciplina";
            this.mnuDelDisciplina.Click += new System.EventHandler(this.mnuDelDisciplina_Click);
            // 
            // mnuReportDisciplina
            // 
            this.mnuReportDisciplina.Image = ((System.Drawing.Image)(resources.GetObject("mnuReportDisciplina.Image")));
            this.mnuReportDisciplina.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuReportDisciplina.Name = "mnuReportDisciplina";
            this.mnuReportDisciplina.Size = new System.Drawing.Size(60, 52);
            this.mnuReportDisciplina.ToolTipText = "Relatórios de disciplinas";
            // 
            // mnuExitDisciplina
            // 
            this.mnuExitDisciplina.Image = ((System.Drawing.Image)(resources.GetObject("mnuExitDisciplina.Image")));
            this.mnuExitDisciplina.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuExitDisciplina.Name = "mnuExitDisciplina";
            this.mnuExitDisciplina.Size = new System.Drawing.Size(60, 52);
            this.mnuExitDisciplina.ToolTipText = "Fechar o cadastro de disciplinas";
            this.mnuExitDisciplina.Click += new System.EventHandler(this.mnuExitDisciplina_Click);
            // 
            // picPesquisa
            // 
            this.picPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("picPesquisa.Image")));
            this.picPesquisa.Location = new System.Drawing.Point(456, 100);
            this.picPesquisa.Name = "picPesquisa";
            this.picPesquisa.Size = new System.Drawing.Size(18, 18);
            this.picPesquisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPesquisa.TabIndex = 6;
            this.picPesquisa.TabStop = false;
            this.picPesquisa.Click += new System.EventHandler(this.picPesquisa_Click);
            // 
            // DisciplinasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 561);
            this.Controls.Add(this.picPesquisa);
            this.Controls.Add(this.dgvDisciplinas);
            this.Controls.Add(this.txtDisciplina);
            this.Controls.Add(this.lblDisciplina);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.mnuDisciplinas);
            this.Name = "DisciplinasFrm";
            this.Text = "Banco de Questões - Disciplinas";
            this.Activated += new System.EventHandler(this.DisciplinaFrm_Activated);
            this.Load += new System.EventHandler(this.DisciplinaFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplinas)).EndInit();
            this.mnuDisciplinas.ResumeLayout(false);
            this.mnuDisciplinas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblDisciplina;
        private System.Windows.Forms.TextBox txtDisciplina;
        private System.Windows.Forms.DataGridView dgvDisciplinas;
        private System.Windows.Forms.MenuStrip mnuDisciplinas;
        private System.Windows.Forms.ToolStripMenuItem mnuAddDisciplina;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveDisciplina;
        private System.Windows.Forms.ToolStripMenuItem mnuDelDisciplina;
        private System.Windows.Forms.ToolStripMenuItem mnuReportDisciplina;
        private System.Windows.Forms.ToolStripMenuItem mnuExitDisciplina;
        private System.Windows.Forms.PictureBox picPesquisa;
    }
}