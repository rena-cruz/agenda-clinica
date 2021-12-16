namespace AgendaClinica.Formularios
{
    partial class FrmLogin
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
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.LblLogin = new System.Windows.Forms.Label();
            this.LblSenha = new System.Windows.Forms.Label();
            this.TbxLogin = new System.Windows.Forms.TextBox();
            this.TbxSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrar.Location = new System.Drawing.Point(140, 162);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(86, 37);
            this.BtnEntrar.TabIndex = 0;
            this.BtnEntrar.Text = "Entrar";
            this.BtnEntrar.UseVisualStyleBackColor = true;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LblLogin.Location = new System.Drawing.Point(66, 47);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(43, 16);
            this.LblLogin.TabIndex = 1;
            this.LblLogin.Text = "Login";
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSenha.Location = new System.Drawing.Point(61, 108);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(48, 16);
            this.LblSenha.TabIndex = 2;
            this.LblSenha.Text = "Senha";
            // 
            // TbxLogin
            // 
            this.TbxLogin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxLogin.Location = new System.Drawing.Point(115, 43);
            this.TbxLogin.Name = "TbxLogin";
            this.TbxLogin.Size = new System.Drawing.Size(149, 25);
            this.TbxLogin.TabIndex = 3;
            // 
            // TbxSenha
            // 
            this.TbxSenha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxSenha.Location = new System.Drawing.Point(115, 104);
            this.TbxSenha.Name = "TbxSenha";
            this.TbxSenha.PasswordChar = '*';
            this.TbxSenha.Size = new System.Drawing.Size(149, 25);
            this.TbxSenha.TabIndex = 4;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 232);
            this.Controls.Add(this.TbxSenha);
            this.Controls.Add(this.TbxLogin);
            this.Controls.Add(this.LblSenha);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.BtnEntrar);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.TextBox TbxLogin;
        private System.Windows.Forms.TextBox TbxSenha;
    }
}

