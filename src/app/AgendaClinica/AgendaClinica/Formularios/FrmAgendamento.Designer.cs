namespace AgendaClinica.Formularios
{
    partial class FrmAgendamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgendamento));
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblDataHorario = new System.Windows.Forms.Label();
            this.LblMedico = new System.Windows.Forms.Label();
            this.LblPaciente = new System.Windows.Forms.Label();
            this.LblEspecialidadeValor = new System.Windows.Forms.Label();
            this.LblFormaPagto = new System.Windows.Forms.Label();
            this.TbxPaciente = new System.Windows.Forms.TextBox();
            this.TbxCodigo = new System.Windows.Forms.TextBox();
            this.CbxEspecialidadeValor = new System.Windows.Forms.ComboBox();
            this.TbxMedico = new System.Windows.Forms.TextBox();
            this.CbxFormaPagto = new System.Windows.Forms.ComboBox();
            this.MskDataHorario = new System.Windows.Forms.MaskedTextBox();
            this.GbxAgendamento = new System.Windows.Forms.GroupBox();
            this.LblImagem = new System.Windows.Forms.Label();
            this.TsBotoes = new System.Windows.Forms.ToolStrip();
            this.TsbSalvar = new System.Windows.Forms.ToolStripButton();
            this.TsbPesquisar = new System.Windows.Forms.ToolStripButton();
            this.TsbLimpar = new System.Windows.Forms.ToolStripButton();
            this.TsbExcluir = new System.Windows.Forms.ToolStripButton();
            this.TssLimpar = new System.Windows.Forms.ToolStripSeparator();
            this.TssSalvar = new System.Windows.Forms.ToolStripSeparator();
            this.TssPesquisar = new System.Windows.Forms.ToolStripSeparator();
            this.LvAgendamento = new System.Windows.Forms.ListView();
            this.ChCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChDataHorario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChPaciente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChMedico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChEspecialidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChFormaPagamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TssExcluir = new System.Windows.Forms.ToolStripSeparator();
            this.GbxAgendamento.SuspendLayout();
            this.TsBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCodigo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(126, 20);
            this.LblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(54, 18);
            this.LblCodigo.TabIndex = 0;
            this.LblCodigo.Text = "Código";
            // 
            // LblDataHorario
            // 
            this.LblDataHorario.AutoSize = true;
            this.LblDataHorario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblDataHorario.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDataHorario.Location = new System.Drawing.Point(71, 68);
            this.LblDataHorario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDataHorario.Name = "LblDataHorario";
            this.LblDataHorario.Size = new System.Drawing.Size(101, 18);
            this.LblDataHorario.TabIndex = 2;
            this.LblDataHorario.Text = "Data e Horário";
            // 
            // LblMedico
            // 
            this.LblMedico.AutoSize = true;
            this.LblMedico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMedico.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMedico.Location = new System.Drawing.Point(126, 164);
            this.LblMedico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMedico.Name = "LblMedico";
            this.LblMedico.Size = new System.Drawing.Size(54, 18);
            this.LblMedico.TabIndex = 3;
            this.LblMedico.Text = "Médico";
            // 
            // LblPaciente
            // 
            this.LblPaciente.AutoSize = true;
            this.LblPaciente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblPaciente.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPaciente.Location = new System.Drawing.Point(114, 116);
            this.LblPaciente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPaciente.Name = "LblPaciente";
            this.LblPaciente.Size = new System.Drawing.Size(64, 18);
            this.LblPaciente.TabIndex = 4;
            this.LblPaciente.Text = "Paciente";
            // 
            // LblEspecialidadeValor
            // 
            this.LblEspecialidadeValor.AutoSize = true;
            this.LblEspecialidadeValor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblEspecialidadeValor.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEspecialidadeValor.Location = new System.Drawing.Point(22, 212);
            this.LblEspecialidadeValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEspecialidadeValor.Name = "LblEspecialidadeValor";
            this.LblEspecialidadeValor.Size = new System.Drawing.Size(145, 18);
            this.LblEspecialidadeValor.TabIndex = 5;
            this.LblEspecialidadeValor.Text = "Especialidade e Valor";
            // 
            // LblFormaPagto
            // 
            this.LblFormaPagto.AutoSize = true;
            this.LblFormaPagto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblFormaPagto.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFormaPagto.Location = new System.Drawing.Point(21, 260);
            this.LblFormaPagto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFormaPagto.Name = "LblFormaPagto";
            this.LblFormaPagto.Size = new System.Drawing.Size(146, 18);
            this.LblFormaPagto.TabIndex = 7;
            this.LblFormaPagto.Text = "Forma de Pagamento";
            // 
            // TbxPaciente
            // 
            this.TbxPaciente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxPaciente.Location = new System.Drawing.Point(196, 112);
            this.TbxPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.TbxPaciente.Name = "TbxPaciente";
            this.TbxPaciente.Size = new System.Drawing.Size(328, 21);
            this.TbxPaciente.TabIndex = 8;
            // 
            // TbxCodigo
            // 
            this.TbxCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxCodigo.Location = new System.Drawing.Point(197, 17);
            this.TbxCodigo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TbxCodigo.Name = "TbxCodigo";
            this.TbxCodigo.Size = new System.Drawing.Size(89, 21);
            this.TbxCodigo.TabIndex = 18;
            // 
            // CbxEspecialidadeValor
            // 
            this.CbxEspecialidadeValor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxEspecialidadeValor.FormattingEnabled = true;
            this.CbxEspecialidadeValor.Items.AddRange(new object[] {
            "Selecione",
            "Cardiologia - R$190,00",
            "Geriatria - R$100,00",
            "Ginecologia - R$90,00",
            "Oncologia - R$380,00",
            "Pediatria - R$80,00",
            "Urologia - R$160,00"});
            this.CbxEspecialidadeValor.Location = new System.Drawing.Point(196, 206);
            this.CbxEspecialidadeValor.Margin = new System.Windows.Forms.Padding(4);
            this.CbxEspecialidadeValor.Name = "CbxEspecialidadeValor";
            this.CbxEspecialidadeValor.Size = new System.Drawing.Size(328, 23);
            this.CbxEspecialidadeValor.TabIndex = 19;
            // 
            // TbxMedico
            // 
            this.TbxMedico.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxMedico.Location = new System.Drawing.Point(196, 160);
            this.TbxMedico.Margin = new System.Windows.Forms.Padding(4);
            this.TbxMedico.Name = "TbxMedico";
            this.TbxMedico.Size = new System.Drawing.Size(328, 21);
            this.TbxMedico.TabIndex = 21;
            // 
            // CbxFormaPagto
            // 
            this.CbxFormaPagto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxFormaPagto.FormattingEnabled = true;
            this.CbxFormaPagto.Items.AddRange(new object[] {
            "Selecione",
            "Boleto",
            "Cartão",
            "Dinheiro"});
            this.CbxFormaPagto.Location = new System.Drawing.Point(196, 257);
            this.CbxFormaPagto.Margin = new System.Windows.Forms.Padding(4);
            this.CbxFormaPagto.Name = "CbxFormaPagto";
            this.CbxFormaPagto.Size = new System.Drawing.Size(328, 23);
            this.CbxFormaPagto.TabIndex = 22;
            // 
            // MskDataHorario
            // 
            this.MskDataHorario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskDataHorario.Location = new System.Drawing.Point(196, 63);
            this.MskDataHorario.Margin = new System.Windows.Forms.Padding(4);
            this.MskDataHorario.Mask = "00/00/000   00:00";
            this.MskDataHorario.Name = "MskDataHorario";
            this.MskDataHorario.Size = new System.Drawing.Size(130, 22);
            this.MskDataHorario.TabIndex = 23;
            // 
            // GbxAgendamento
            // 
            this.GbxAgendamento.Controls.Add(this.MskDataHorario);
            this.GbxAgendamento.Controls.Add(this.CbxFormaPagto);
            this.GbxAgendamento.Controls.Add(this.TbxMedico);
            this.GbxAgendamento.Controls.Add(this.CbxEspecialidadeValor);
            this.GbxAgendamento.Controls.Add(this.TbxCodigo);
            this.GbxAgendamento.Controls.Add(this.TbxPaciente);
            this.GbxAgendamento.Controls.Add(this.LblFormaPagto);
            this.GbxAgendamento.Controls.Add(this.LblEspecialidadeValor);
            this.GbxAgendamento.Controls.Add(this.LblPaciente);
            this.GbxAgendamento.Controls.Add(this.LblMedico);
            this.GbxAgendamento.Controls.Add(this.LblDataHorario);
            this.GbxAgendamento.Controls.Add(this.LblCodigo);
            this.GbxAgendamento.Location = new System.Drawing.Point(205, 28);
            this.GbxAgendamento.Margin = new System.Windows.Forms.Padding(4);
            this.GbxAgendamento.Name = "GbxAgendamento";
            this.GbxAgendamento.Padding = new System.Windows.Forms.Padding(4);
            this.GbxAgendamento.Size = new System.Drawing.Size(544, 298);
            this.GbxAgendamento.TabIndex = 0;
            this.GbxAgendamento.TabStop = false;
            // 
            // LblImagem
            // 
            this.LblImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblImagem.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImagem.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LblImagem.Image = ((System.Drawing.Image)(resources.GetObject("LblImagem.Image")));
            this.LblImagem.Location = new System.Drawing.Point(27, 28);
            this.LblImagem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblImagem.Name = "LblImagem";
            this.LblImagem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblImagem.Size = new System.Drawing.Size(170, 147);
            this.LblImagem.TabIndex = 1;
            this.LblImagem.Text = "Agenda";
            this.LblImagem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TsBotoes
            // 
            this.TsBotoes.AutoSize = false;
            this.TsBotoes.Dock = System.Windows.Forms.DockStyle.None;
            this.TsBotoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbSalvar,
            this.TssSalvar,
            this.TsbPesquisar,
            this.TssPesquisar,
            this.TsbLimpar,
            this.TssLimpar,
            this.TsbExcluir,
            this.TssExcluir});
            this.TsBotoes.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.TsBotoes.Location = new System.Drawing.Point(43, 188);
            this.TsBotoes.Name = "TsBotoes";
            this.TsBotoes.Size = new System.Drawing.Size(140, 138);
            this.TsBotoes.TabIndex = 18;
            this.TsBotoes.Text = "toolStrip1";
            // 
            // TsbSalvar
            // 
            this.TsbSalvar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsbSalvar.Image = ((System.Drawing.Image)(resources.GetObject("TsbSalvar.Image")));
            this.TsbSalvar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TsbSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbSalvar.Name = "TsbSalvar";
            this.TsbSalvar.Size = new System.Drawing.Size(138, 20);
            this.TsbSalvar.Text = "    &Salvar";
            this.TsbSalvar.Click += new System.EventHandler(this.TsbSalvar_Click);
            // 
            // TsbPesquisar
            // 
            this.TsbPesquisar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsbPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("TsbPesquisar.Image")));
            this.TsbPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TsbPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbPesquisar.Name = "TsbPesquisar";
            this.TsbPesquisar.Size = new System.Drawing.Size(138, 20);
            this.TsbPesquisar.Text = "    &Pesquisar";
            this.TsbPesquisar.Click += new System.EventHandler(this.TsbPesquisar_Click);
            // 
            // TsbLimpar
            // 
            this.TsbLimpar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsbLimpar.Image = ((System.Drawing.Image)(resources.GetObject("TsbLimpar.Image")));
            this.TsbLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TsbLimpar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbLimpar.Name = "TsbLimpar";
            this.TsbLimpar.Size = new System.Drawing.Size(138, 20);
            this.TsbLimpar.Text = "    &Limpar";
            this.TsbLimpar.Click += new System.EventHandler(this.TsbLimpar_Click);
            // 
            // TsbExcluir
            // 
            this.TsbExcluir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("TsbExcluir.Image")));
            this.TsbExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TsbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbExcluir.Name = "TsbExcluir";
            this.TsbExcluir.Size = new System.Drawing.Size(138, 20);
            this.TsbExcluir.Text = "    &Excluir";
            this.TsbExcluir.Click += new System.EventHandler(this.TsbExcluir_Click);
            // 
            // TssLimpar
            // 
            this.TssLimpar.Name = "TssLimpar";
            this.TssLimpar.Size = new System.Drawing.Size(138, 6);
            // 
            // TssSalvar
            // 
            this.TssSalvar.Name = "TssSalvar";
            this.TssSalvar.Size = new System.Drawing.Size(138, 6);
            // 
            // TssPesquisar
            // 
            this.TssPesquisar.Name = "TssPesquisar";
            this.TssPesquisar.Size = new System.Drawing.Size(138, 6);
            // 
            // LvAgendamento
            // 
            this.LvAgendamento.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChCodigo,
            this.ChDataHorario,
            this.ChPaciente,
            this.ChMedico,
            this.ChEspecialidade,
            this.ChFormaPagamento});
            this.LvAgendamento.HideSelection = false;
            this.LvAgendamento.Location = new System.Drawing.Point(27, 333);
            this.LvAgendamento.Name = "LvAgendamento";
            this.LvAgendamento.Size = new System.Drawing.Size(722, 209);
            this.LvAgendamento.TabIndex = 19;
            this.LvAgendamento.UseCompatibleStateImageBehavior = false;
            this.LvAgendamento.View = System.Windows.Forms.View.Details;
            // 
            // ChCodigo
            // 
            this.ChCodigo.Text = "Código";
            // 
            // ChDataHorario
            // 
            this.ChDataHorario.Text = "Data e Horário";
            this.ChDataHorario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChDataHorario.Width = 110;
            // 
            // ChPaciente
            // 
            this.ChPaciente.Text = "Paciente";
            this.ChPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChPaciente.Width = 200;
            // 
            // ChMedico
            // 
            this.ChMedico.Text = "Médico";
            this.ChMedico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChMedico.Width = 130;
            // 
            // ChEspecialidade
            // 
            this.ChEspecialidade.Text = "Especialidade";
            this.ChEspecialidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChEspecialidade.Width = 120;
            // 
            // ChFormaPagamento
            // 
            this.ChFormaPagamento.Text = "Pagamento";
            this.ChFormaPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChFormaPagamento.Width = 100;
            // 
            // TssExcluir
            // 
            this.TssExcluir.Name = "TssExcluir";
            this.TssExcluir.Size = new System.Drawing.Size(138, 6);
            // 
            // FrmAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 554);
            this.Controls.Add(this.LvAgendamento);
            this.Controls.Add(this.TsBotoes);
            this.Controls.Add(this.LblImagem);
            this.Controls.Add(this.GbxAgendamento);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAgendamento";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamento de Consultas";
            this.GbxAgendamento.ResumeLayout(false);
            this.GbxAgendamento.PerformLayout();
            this.TsBotoes.ResumeLayout(false);
            this.TsBotoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label LblDataHorario;
        private System.Windows.Forms.Label LblMedico;
        private System.Windows.Forms.Label LblPaciente;
        private System.Windows.Forms.Label LblEspecialidadeValor;
        private System.Windows.Forms.Label LblFormaPagto;
        private System.Windows.Forms.TextBox TbxPaciente;
        private System.Windows.Forms.TextBox TbxCodigo;
        private System.Windows.Forms.ComboBox CbxEspecialidadeValor;
        private System.Windows.Forms.TextBox TbxMedico;
        private System.Windows.Forms.ComboBox CbxFormaPagto;
        private System.Windows.Forms.MaskedTextBox MskDataHorario;
        private System.Windows.Forms.GroupBox GbxAgendamento;
        private System.Windows.Forms.Label LblImagem;
        private System.Windows.Forms.ToolStrip TsBotoes;
        private System.Windows.Forms.ToolStripButton TsbSalvar;
        private System.Windows.Forms.ToolStripSeparator TssSalvar;
        private System.Windows.Forms.ToolStripButton TsbPesquisar;
        private System.Windows.Forms.ToolStripSeparator TssPesquisar;
        private System.Windows.Forms.ToolStripButton TsbLimpar;
        private System.Windows.Forms.ToolStripSeparator TssLimpar;
        private System.Windows.Forms.ToolStripButton TsbExcluir;
        private System.Windows.Forms.ListView LvAgendamento;
        private System.Windows.Forms.ColumnHeader ChDataHorario;
        private System.Windows.Forms.ColumnHeader ChPaciente;
        private System.Windows.Forms.ColumnHeader ChMedico;
        private System.Windows.Forms.ColumnHeader ChEspecialidade;
        private System.Windows.Forms.ColumnHeader ChFormaPagamento;
        private System.Windows.Forms.ColumnHeader ChCodigo;
        private System.Windows.Forms.ToolStripSeparator TssExcluir;
    }
}