namespace EscondeEsconde
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panDados = new System.Windows.Forms.Panel();
            this.lblTexto = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnOcultar = new System.Windows.Forms.Button();
            this.panDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // panDados
            // 
            this.panDados.Controls.Add(this.txtValor);
            this.panDados.Controls.Add(this.lblTexto);
            this.panDados.Location = new System.Drawing.Point(12, 12);
            this.panDados.Name = "panDados";
            this.panDados.Size = new System.Drawing.Size(446, 101);
            this.panDados.TabIndex = 0;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(13, 16);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(95, 13);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.Text = "Botão selecionado";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(16, 44);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(414, 20);
            this.txtValor.TabIndex = 1;
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(12, 136);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 23);
            this.btnExibir.TabIndex = 1;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnOcultar
            // 
            this.btnOcultar.Location = new System.Drawing.Point(102, 136);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(75, 23);
            this.btnOcultar.TabIndex = 2;
            this.btnOcultar.Text = "Ocultar";
            this.btnOcultar.UseVisualStyleBackColor = true;
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 187);
            this.Controls.Add(this.btnOcultar);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.panDados);
            this.Name = "frmPrincipal";
            this.Text = "Esconde Esconde";
            this.panDados.ResumeLayout(false);
            this.panDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panDados;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnOcultar;
    }
}

