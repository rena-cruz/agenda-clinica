namespace AgendaClinica.Formularios
{
    partial class FrmPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaciente));
            this.PnlCadastroPaciente = new System.Windows.Forms.Panel();
            this.TbxCodigo = new System.Windows.Forms.TextBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TbxEmail = new System.Windows.Forms.TextBox();
            this.DtpDtaNascimento = new System.Windows.Forms.DateTimePicker();
            this.MkTbxCelular = new System.Windows.Forms.MaskedTextBox();
            this.LblDtaNascimento = new System.Windows.Forms.Label();
            this.LblCelular = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.TbxNome = new System.Windows.Forms.TextBox();
            this.PnlSituacaoFinanceira = new System.Windows.Forms.Panel();
            this.CbxSituacaoFinanceira = new System.Windows.Forms.ComboBox();
            this.LblSituacaoFinanceira = new System.Windows.Forms.Label();
            this.TsBotoesPaciente = new System.Windows.Forms.ToolStrip();
            this.TsbSalvar = new System.Windows.Forms.ToolStripButton();
            this.TssSalvar = new System.Windows.Forms.ToolStripSeparator();
            this.TsbPesquisar = new System.Windows.Forms.ToolStripButton();
            this.TssPesquisar = new System.Windows.Forms.ToolStripSeparator();
            this.TsbLimpar = new System.Windows.Forms.ToolStripButton();
            this.PnlBotoes = new System.Windows.Forms.Panel();
            this.TssLimpar = new System.Windows.Forms.ToolStripSeparator();
            this.PnlCadastroPaciente.SuspendLayout();
            this.PnlSituacaoFinanceira.SuspendLayout();
            this.TsBotoesPaciente.SuspendLayout();
            this.PnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlCadastroPaciente
            // 
            this.PnlCadastroPaciente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PnlCadastroPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlCadastroPaciente.Controls.Add(this.TbxCodigo);
            this.PnlCadastroPaciente.Controls.Add(this.LblCodigo);
            this.PnlCadastroPaciente.Controls.Add(this.LblEmail);
            this.PnlCadastroPaciente.Controls.Add(this.TbxEmail);
            this.PnlCadastroPaciente.Controls.Add(this.DtpDtaNascimento);
            this.PnlCadastroPaciente.Controls.Add(this.MkTbxCelular);
            this.PnlCadastroPaciente.Controls.Add(this.LblDtaNascimento);
            this.PnlCadastroPaciente.Controls.Add(this.LblCelular);
            this.PnlCadastroPaciente.Controls.Add(this.LblNome);
            this.PnlCadastroPaciente.Controls.Add(this.TbxNome);
            this.PnlCadastroPaciente.Location = new System.Drawing.Point(14, 14);
            this.PnlCadastroPaciente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PnlCadastroPaciente.Name = "PnlCadastroPaciente";
            this.PnlCadastroPaciente.Size = new System.Drawing.Size(459, 208);
            this.PnlCadastroPaciente.TabIndex = 15;
            // 
            // TbxCodigo
            // 
            this.TbxCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxCodigo.Location = new System.Drawing.Point(28, 34);
            this.TbxCodigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TbxCodigo.Name = "TbxCodigo";
            this.TbxCodigo.Size = new System.Drawing.Size(77, 21);
            this.TbxCodigo.TabIndex = 1;
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCodigo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(28, 13);
            this.LblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(49, 18);
            this.LblCodigo.TabIndex = 16;
            this.LblCodigo.Text = "Código";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(28, 69);
            this.LblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(46, 18);
            this.LblEmail.TabIndex = 2;
            this.LblEmail.Text = "E-mail";
            // 
            // TbxEmail
            // 
            this.TbxEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxEmail.Location = new System.Drawing.Point(28, 90);
            this.TbxEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TbxEmail.Name = "TbxEmail";
            this.TbxEmail.Size = new System.Drawing.Size(330, 21);
            this.TbxEmail.TabIndex = 3;
            // 
            // DtpDtaNascimento
            // 
            this.DtpDtaNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDtaNascimento.Location = new System.Drawing.Point(28, 150);
            this.DtpDtaNascimento.Name = "DtpDtaNascimento";
            this.DtpDtaNascimento.Size = new System.Drawing.Size(200, 21);
            this.DtpDtaNascimento.TabIndex = 4;
            // 
            // MkTbxCelular
            // 
            this.MkTbxCelular.Location = new System.Drawing.Point(247, 150);
            this.MkTbxCelular.Mask = "(99) 00000-0000";
            this.MkTbxCelular.Name = "MkTbxCelular";
            this.MkTbxCelular.Size = new System.Drawing.Size(111, 21);
            this.MkTbxCelular.TabIndex = 5;
            // 
            // LblDtaNascimento
            // 
            this.LblDtaNascimento.AutoSize = true;
            this.LblDtaNascimento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblDtaNascimento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDtaNascimento.Location = new System.Drawing.Point(28, 129);
            this.LblDtaNascimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDtaNascimento.Name = "LblDtaNascimento";
            this.LblDtaNascimento.Size = new System.Drawing.Size(127, 18);
            this.LblDtaNascimento.TabIndex = 1;
            this.LblDtaNascimento.Text = "Data de Nascimento";
            // 
            // LblCelular
            // 
            this.LblCelular.AutoSize = true;
            this.LblCelular.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCelular.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCelular.Location = new System.Drawing.Point(247, 129);
            this.LblCelular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCelular.Name = "LblCelular";
            this.LblCelular.Size = new System.Drawing.Size(49, 18);
            this.LblCelular.TabIndex = 3;
            this.LblCelular.Text = "Celular";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(113, 13);
            this.LblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(43, 18);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Nome";
            // 
            // TbxNome
            // 
            this.TbxNome.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxNome.Location = new System.Drawing.Point(113, 34);
            this.TbxNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TbxNome.Name = "TbxNome";
            this.TbxNome.Size = new System.Drawing.Size(330, 21);
            this.TbxNome.TabIndex = 2;
            // 
            // PnlSituacaoFinanceira
            // 
            this.PnlSituacaoFinanceira.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PnlSituacaoFinanceira.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlSituacaoFinanceira.Controls.Add(this.CbxSituacaoFinanceira);
            this.PnlSituacaoFinanceira.Controls.Add(this.LblSituacaoFinanceira);
            this.PnlSituacaoFinanceira.Location = new System.Drawing.Point(14, 228);
            this.PnlSituacaoFinanceira.Name = "PnlSituacaoFinanceira";
            this.PnlSituacaoFinanceira.Size = new System.Drawing.Size(595, 82);
            this.PnlSituacaoFinanceira.TabIndex = 17;
            // 
            // CbxSituacaoFinanceira
            // 
            this.CbxSituacaoFinanceira.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxSituacaoFinanceira.FormattingEnabled = true;
            this.CbxSituacaoFinanceira.Location = new System.Drawing.Point(24, 36);
            this.CbxSituacaoFinanceira.Name = "CbxSituacaoFinanceira";
            this.CbxSituacaoFinanceira.Size = new System.Drawing.Size(204, 23);
            this.CbxSituacaoFinanceira.TabIndex = 6;
            // 
            // LblSituacaoFinanceira
            // 
            this.LblSituacaoFinanceira.AutoSize = true;
            this.LblSituacaoFinanceira.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblSituacaoFinanceira.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSituacaoFinanceira.Location = new System.Drawing.Point(24, 16);
            this.LblSituacaoFinanceira.Name = "LblSituacaoFinanceira";
            this.LblSituacaoFinanceira.Size = new System.Drawing.Size(124, 18);
            this.LblSituacaoFinanceira.TabIndex = 18;
            this.LblSituacaoFinanceira.Text = "Situação Financeira";
            // 
            // TsBotoesPaciente
            // 
            this.TsBotoesPaciente.AutoSize = false;
            this.TsBotoesPaciente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TsBotoesPaciente.Dock = System.Windows.Forms.DockStyle.None;
            this.TsBotoesPaciente.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TsBotoesPaciente.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbSalvar,
            this.TssSalvar,
            this.TsbPesquisar,
            this.TssPesquisar,
            this.TsbLimpar,
            this.TssLimpar});
            this.TsBotoesPaciente.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.TsBotoesPaciente.Location = new System.Drawing.Point(0, 0);
            this.TsBotoesPaciente.Name = "TsBotoesPaciente";
            this.TsBotoesPaciente.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.TsBotoesPaciente.Size = new System.Drawing.Size(127, 206);
            this.TsBotoesPaciente.TabIndex = 20;
            this.TsBotoesPaciente.Text = "toolStrip1";
            // 
            // TsbSalvar
            // 
            this.TsbSalvar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsbSalvar.Image = ((System.Drawing.Image)(resources.GetObject("TsbSalvar.Image")));
            this.TsbSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TsbSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbSalvar.Name = "TsbSalvar";
            this.TsbSalvar.Padding = new System.Windows.Forms.Padding(7);
            this.TsbSalvar.Size = new System.Drawing.Size(116, 50);
            this.TsbSalvar.Text = "&Salvar";
            this.TsbSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsbSalvar.Click += new System.EventHandler(this.TsbSalvar_Click);
            // 
            // TssSalvar
            // 
            this.TssSalvar.Name = "TssSalvar";
            this.TssSalvar.Size = new System.Drawing.Size(116, 6);
            // 
            // TsbPesquisar
            // 
            this.TsbPesquisar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsbPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("TsbPesquisar.Image")));
            this.TsbPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TsbPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbPesquisar.Name = "TsbPesquisar";
            this.TsbPesquisar.Padding = new System.Windows.Forms.Padding(7);
            this.TsbPesquisar.Size = new System.Drawing.Size(116, 50);
            this.TsbPesquisar.Text = "&Pesquisar";
            this.TsbPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsbPesquisar.Click += new System.EventHandler(this.TsbPesquisar_Click);
            // 
            // TssPesquisar
            // 
            this.TssPesquisar.Name = "TssPesquisar";
            this.TssPesquisar.Size = new System.Drawing.Size(116, 6);
            // 
            // TsbLimpar
            // 
            this.TsbLimpar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsbLimpar.Image = ((System.Drawing.Image)(resources.GetObject("TsbLimpar.Image")));
            this.TsbLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TsbLimpar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbLimpar.Name = "TsbLimpar";
            this.TsbLimpar.Padding = new System.Windows.Forms.Padding(7);
            this.TsbLimpar.Size = new System.Drawing.Size(116, 50);
            this.TsbLimpar.Text = "&Limpar";
            this.TsbLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsbLimpar.Click += new System.EventHandler(this.TsbLimpar_Click);
            // 
            // PnlBotoes
            // 
            this.PnlBotoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlBotoes.Controls.Add(this.TsBotoesPaciente);
            this.PnlBotoes.Location = new System.Drawing.Point(480, 14);
            this.PnlBotoes.Name = "PnlBotoes";
            this.PnlBotoes.Size = new System.Drawing.Size(129, 208);
            this.PnlBotoes.TabIndex = 21;
            // 
            // TssLimpar
            // 
            this.TssLimpar.Name = "TssLimpar";
            this.TssLimpar.Size = new System.Drawing.Size(116, 6);
            // 
            // FrmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(617, 317);
            this.Controls.Add(this.PnlBotoes);
            this.Controls.Add(this.PnlSituacaoFinanceira);
            this.Controls.Add(this.PnlCadastroPaciente);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmPaciente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Paciente";
            this.PnlCadastroPaciente.ResumeLayout(false);
            this.PnlCadastroPaciente.PerformLayout();
            this.PnlSituacaoFinanceira.ResumeLayout(false);
            this.PnlSituacaoFinanceira.PerformLayout();
            this.TsBotoesPaciente.ResumeLayout(false);
            this.TsBotoesPaciente.PerformLayout();
            this.PnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlCadastroPaciente;
        private System.Windows.Forms.Label LblDtaNascimento;
        private System.Windows.Forms.TextBox TbxEmail;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblCelular;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox TbxNome;
        private System.Windows.Forms.TextBox TbxCodigo;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.DateTimePicker DtpDtaNascimento;
        private System.Windows.Forms.MaskedTextBox MkTbxCelular;
        private System.Windows.Forms.Panel PnlSituacaoFinanceira;
        private System.Windows.Forms.ComboBox CbxSituacaoFinanceira;
        private System.Windows.Forms.Label LblSituacaoFinanceira;
        private System.Windows.Forms.ToolStrip TsBotoesPaciente;
        private System.Windows.Forms.ToolStripButton TsbSalvar;
        private System.Windows.Forms.ToolStripSeparator TssSalvar;
        private System.Windows.Forms.ToolStripButton TsbPesquisar;
        private System.Windows.Forms.ToolStripSeparator TssPesquisar;
        private System.Windows.Forms.ToolStripButton TsbLimpar;
        private System.Windows.Forms.Panel PnlBotoes;
        private System.Windows.Forms.ToolStripSeparator TssLimpar;
    }
}