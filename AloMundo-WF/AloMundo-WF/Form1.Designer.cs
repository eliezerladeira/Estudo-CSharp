namespace AloMundo_WF
{
    partial class Form1
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
            this.lbTexto = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btExecutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTexto
            // 
            this.lbTexto.AutoSize = true;
            this.lbTexto.Location = new System.Drawing.Point(12, 9);
            this.lbTexto.Name = "lbTexto";
            this.lbTexto.Size = new System.Drawing.Size(162, 13);
            this.lbTexto.TabIndex = 0;
            this.lbTexto.Text = "Trabalhado com Windows Forms";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(15, 25);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(407, 20);
            this.txtValor.TabIndex = 1;
            // 
            // btExecutar
            // 
            this.btExecutar.Location = new System.Drawing.Point(347, 56);
            this.btExecutar.Name = "btExecutar";
            this.btExecutar.Size = new System.Drawing.Size(75, 23);
            this.btExecutar.TabIndex = 2;
            this.btExecutar.Text = "Executar";
            this.btExecutar.UseVisualStyleBackColor = true;
            this.btExecutar.Click += new System.EventHandler(this.btExecutar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 91);
            this.Controls.Add(this.btExecutar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lbTexto);
            this.Name = "Form1";
            this.Text = "Alô Mundo!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTexto;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btExecutar;
    }
}

