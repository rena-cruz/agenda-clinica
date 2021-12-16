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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.LblLogin = new System.Windows.Forms.Label();
            this.LblSenha = new System.Windows.Forms.Label();
            this.TbxLogin = new System.Windows.Forms.TextBox();
            this.TbxSenha = new System.Windows.Forms.TextBox();
            this.PnlLogin = new System.Windows.Forms.Panel();
            this.LblImagem = new System.Windows.Forms.Label();
            this.PnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnEntrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrar.Location = new System.Drawing.Point(195, 164);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(180, 34);
            this.BtnEntrar.TabIndex = 0;
            this.BtnEntrar.Text = "Entrar";
            this.BtnEntrar.UseVisualStyleBackColor = false;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LblLogin.Location = new System.Drawing.Point(14, 13);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(45, 18);
            this.LblLogin.TabIndex = 1;
            this.LblLogin.Text = "Login";
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblSenha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSenha.Location = new System.Drawing.Point(14, 77);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(50, 18);
            this.LblSenha.TabIndex = 2;
            this.LblSenha.Text = "Senha";
            // 
            // TbxLogin
            // 
            this.TbxLogin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxLogin.Location = new System.Drawing.Point(14, 36);
            this.TbxLogin.Margin = new System.Windows.Forms.Padding(5);
            this.TbxLogin.Name = "TbxLogin";
            this.TbxLogin.Size = new System.Drawing.Size(149, 25);
            this.TbxLogin.TabIndex = 3;
            // 
            // TbxSenha
            // 
            this.TbxSenha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxSenha.Location = new System.Drawing.Point(14, 100);
            this.TbxSenha.Margin = new System.Windows.Forms.Padding(5);
            this.TbxSenha.Name = "TbxSenha";
            this.TbxSenha.PasswordChar = '*';
            this.TbxSenha.Size = new System.Drawing.Size(149, 25);
            this.TbxSenha.TabIndex = 4;
            // 
            // PnlLogin
            // 
            this.PnlLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlLogin.Controls.Add(this.TbxLogin);
            this.PnlLogin.Controls.Add(this.LblSenha);
            this.PnlLogin.Controls.Add(this.TbxSenha);
            this.PnlLogin.Controls.Add(this.LblLogin);
            this.PnlLogin.Location = new System.Drawing.Point(195, 18);
            this.PnlLogin.Name = "PnlLogin";
            this.PnlLogin.Size = new System.Drawing.Size(180, 140);
            this.PnlLogin.TabIndex = 5;
            // 
            // LblImagem
            // 
            this.LblImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblImagem.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImagem.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LblImagem.Image = ((System.Drawing.Image)(resources.GetObject("LblImagem.Image")));
            this.LblImagem.Location = new System.Drawing.Point(13, 18);
            this.LblImagem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblImagem.Name = "LblImagem";
            this.LblImagem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblImagem.Size = new System.Drawing.Size(175, 180);
            this.LblImagem.TabIndex = 6;
            this.LblImagem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(385, 209);
            this.Controls.Add(this.LblImagem);
            this.Controls.Add(this.PnlLogin);
            this.Controls.Add(this.BtnEntrar);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Login";
            this.PnlLogin.ResumeLayout(false);
            this.PnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.TextBox TbxLogin;
        private System.Windows.Forms.TextBox TbxSenha;
        private System.Windows.Forms.Panel PnlLogin;
        private System.Windows.Forms.Label LblImagem;
    }
}

