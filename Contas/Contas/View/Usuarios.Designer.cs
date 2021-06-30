namespace Contas
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.tabUsuarios = new System.Windows.Forms.TabControl();
            this.tabManutencaoUsuario = new System.Windows.Forms.TabPage();
            this.tabConsultaUsuario = new System.Windows.Forms.TabPage();
            this.imgUsuarios = new System.Windows.Forms.ImageList(this.components);
            this.tabRelatorioUsuario = new System.Windows.Forms.TabPage();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.lblSenhaUsuario = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabUsuarios.SuspendLayout();
            this.tabManutencaoUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.Controls.Add(this.tabManutencaoUsuario);
            this.tabUsuarios.Controls.Add(this.tabConsultaUsuario);
            this.tabUsuarios.Controls.Add(this.tabRelatorioUsuario);
            this.tabUsuarios.ImageList = this.imgUsuarios;
            this.tabUsuarios.ItemSize = new System.Drawing.Size(96, 50);
            this.tabUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.SelectedIndex = 0;
            this.tabUsuarios.Size = new System.Drawing.Size(788, 438);
            this.tabUsuarios.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabUsuarios.TabIndex = 0;
            // 
            // tabManutencaoUsuario
            // 
            this.tabManutencaoUsuario.Controls.Add(this.textBox2);
            this.tabManutencaoUsuario.Controls.Add(this.lblSenhaUsuario);
            this.tabManutencaoUsuario.Controls.Add(this.txtNomeUsuario);
            this.tabManutencaoUsuario.Controls.Add(this.lblNomeUsuario);
            this.tabManutencaoUsuario.ImageIndex = 0;
            this.tabManutencaoUsuario.Location = new System.Drawing.Point(4, 54);
            this.tabManutencaoUsuario.Name = "tabManutencaoUsuario";
            this.tabManutencaoUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tabManutencaoUsuario.Size = new System.Drawing.Size(780, 380);
            this.tabManutencaoUsuario.TabIndex = 0;
            this.tabManutencaoUsuario.ToolTipText = "Manutenção de usuários";
            this.tabManutencaoUsuario.UseVisualStyleBackColor = true;
            // 
            // tabConsultaUsuario
            // 
            this.tabConsultaUsuario.ImageIndex = 1;
            this.tabConsultaUsuario.Location = new System.Drawing.Point(4, 54);
            this.tabConsultaUsuario.Name = "tabConsultaUsuario";
            this.tabConsultaUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultaUsuario.Size = new System.Drawing.Size(780, 380);
            this.tabConsultaUsuario.TabIndex = 1;
            this.tabConsultaUsuario.ToolTipText = "Consulta cadastro de usuários";
            this.tabConsultaUsuario.UseVisualStyleBackColor = true;
            // 
            // imgUsuarios
            // 
            this.imgUsuarios.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgUsuarios.ImageStream")));
            this.imgUsuarios.TransparentColor = System.Drawing.Color.Transparent;
            this.imgUsuarios.Images.SetKeyName(0, "icons8-maintenance-48.png");
            this.imgUsuarios.Images.SetKeyName(1, "icons8-detective-48.png");
            this.imgUsuarios.Images.SetKeyName(2, "icons8-impressão-48.png");
            // 
            // tabRelatorioUsuario
            // 
            this.tabRelatorioUsuario.ImageIndex = 2;
            this.tabRelatorioUsuario.Location = new System.Drawing.Point(4, 54);
            this.tabRelatorioUsuario.Name = "tabRelatorioUsuario";
            this.tabRelatorioUsuario.Size = new System.Drawing.Size(780, 380);
            this.tabRelatorioUsuario.TabIndex = 2;
            this.tabRelatorioUsuario.ToolTipText = "Imprime relação de usuários";
            this.tabRelatorioUsuario.UseVisualStyleBackColor = true;
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblNomeUsuario.Location = new System.Drawing.Point(32, 33);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(50, 13);
            this.lblNomeUsuario.TabIndex = 0;
            this.lblNomeUsuario.Text = "Usuário";
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(103, 30);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(145, 20);
            this.txtNomeUsuario.TabIndex = 1;
            // 
            // lblSenhaUsuario
            // 
            this.lblSenhaUsuario.AutoSize = true;
            this.lblSenhaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSenhaUsuario.Location = new System.Drawing.Point(32, 67);
            this.lblSenhaUsuario.Name = "lblSenhaUsuario";
            this.lblSenhaUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblSenhaUsuario.TabIndex = 2;
            this.lblSenhaUsuario.Text = "Senha";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 20);
            this.textBox2.TabIndex = 3;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabUsuarios);
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Controle Financeiro - Usuários";
            this.tabUsuarios.ResumeLayout(false);
            this.tabManutencaoUsuario.ResumeLayout(false);
            this.tabManutencaoUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabUsuarios;
        private System.Windows.Forms.TabPage tabManutencaoUsuario;
        private System.Windows.Forms.TabPage tabConsultaUsuario;
        private System.Windows.Forms.TabPage tabRelatorioUsuario;
        private System.Windows.Forms.ImageList imgUsuarios;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblSenhaUsuario;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Label lblNomeUsuario;
    }
}