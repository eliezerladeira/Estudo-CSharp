namespace Agenda
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
            this.cmdConato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdConato
            // 
            this.cmdConato.Location = new System.Drawing.Point(12, 12);
            this.cmdConato.Name = "cmdConato";
            this.cmdConato.Size = new System.Drawing.Size(100, 100);
            this.cmdConato.TabIndex = 0;
            this.cmdConato.Text = "Contato";
            this.cmdConato.UseVisualStyleBackColor = true;
            this.cmdConato.Click += new System.EventHandler(this.cmdConato_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.cmdConato);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda 2020";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdConato;
    }
}

