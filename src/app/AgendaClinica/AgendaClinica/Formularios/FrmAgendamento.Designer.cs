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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblDataHorario = new System.Windows.Forms.Label();
            this.LblMedico = new System.Windows.Forms.Label();
            this.LblPaciente = new System.Windows.Forms.Label();
            this.LblEspecialidadeValor = new System.Windows.Forms.Label();
            this.LblFormaPagto = new System.Windows.Forms.Label();
            this.TbxCodigo = new System.Windows.Forms.TextBox();
            this.CbxEspecialidadeValor = new System.Windows.Forms.ComboBox();
            this.CbxFormaPagto = new System.Windows.Forms.ComboBox();
            this.MskDataHorario = new System.Windows.Forms.MaskedTextBox();
            this.GbxAgendamento = new System.Windows.Forms.GroupBox();
            this.CbxMedico = new System.Windows.Forms.ComboBox();
            this.CbxPaciente = new System.Windows.Forms.ComboBox();
            this.LblImagem = new System.Windows.Forms.Label();
            this.TsBotoes = new System.Windows.Forms.ToolStrip();
            this.TsbSalvarAgenda = new System.Windows.Forms.ToolStripButton();
            this.TssSalvar = new System.Windows.Forms.ToolStripSeparator();
            this.TsbPesquisarAgenda = new System.Windows.Forms.ToolStripButton();
            this.TssPesquisar = new System.Windows.Forms.ToolStripSeparator();
            this.TsbLimparAgenda = new System.Windows.Forms.ToolStripButton();
            this.TssLimpar = new System.Windows.Forms.ToolStripSeparator();
            this.TsbExcluirAgenda = new System.Windows.Forms.ToolStripButton();
            this.TssExcluir = new System.Windows.Forms.ToolStripSeparator();
            this.DgvAgendamento = new System.Windows.Forms.DataGridView();
            this.DgvCBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DgvCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DvgPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvEspecialidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DvgMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbxAgendamento.SuspendLayout();
            this.TsBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAgendamento)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCodigo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(126, 17);
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
            this.LblDataHorario.Location = new System.Drawing.Point(79, 63);
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
            this.LblMedico.Location = new System.Drawing.Point(126, 208);
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
            this.LblPaciente.Location = new System.Drawing.Point(116, 110);
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
            this.LblEspecialidadeValor.Location = new System.Drawing.Point(35, 158);
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
            this.LblFormaPagto.Location = new System.Drawing.Point(34, 254);
            this.LblFormaPagto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFormaPagto.Name = "LblFormaPagto";
            this.LblFormaPagto.Size = new System.Drawing.Size(146, 18);
            this.LblFormaPagto.TabIndex = 7;
            this.LblFormaPagto.Text = "Forma de Pagamento";
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
            this.CbxEspecialidadeValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.CbxEspecialidadeValor.Location = new System.Drawing.Point(196, 158);
            this.CbxEspecialidadeValor.Margin = new System.Windows.Forms.Padding(4);
            this.CbxEspecialidadeValor.Name = "CbxEspecialidadeValor";
            this.CbxEspecialidadeValor.Size = new System.Drawing.Size(328, 23);
            this.CbxEspecialidadeValor.TabIndex = 19;
            this.CbxEspecialidadeValor.SelectedIndexChanged += new System.EventHandler(this.CbxEspecialidadeValor_SelectedIndexChanged);
            // 
            // CbxFormaPagto
            // 
            this.CbxFormaPagto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxFormaPagto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxFormaPagto.FormattingEnabled = true;
            this.CbxFormaPagto.Items.AddRange(new object[] {
            "Selecione",
            "Boleto",
            "Cartão",
            "Dinheiro"});
            this.CbxFormaPagto.Location = new System.Drawing.Point(196, 254);
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
            this.MskDataHorario.Mask = "00/00/0000   00:00";
            this.MskDataHorario.Name = "MskDataHorario";
            this.MskDataHorario.Size = new System.Drawing.Size(130, 22);
            this.MskDataHorario.TabIndex = 23;
            this.MskDataHorario.Validated += new System.EventHandler(this.MskDataHorario_Validated);
            // 
            // GbxAgendamento
            // 
            this.GbxAgendamento.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GbxAgendamento.Controls.Add(this.CbxMedico);
            this.GbxAgendamento.Controls.Add(this.CbxPaciente);
            this.GbxAgendamento.Controls.Add(this.MskDataHorario);
            this.GbxAgendamento.Controls.Add(this.CbxFormaPagto);
            this.GbxAgendamento.Controls.Add(this.CbxEspecialidadeValor);
            this.GbxAgendamento.Controls.Add(this.TbxCodigo);
            this.GbxAgendamento.Controls.Add(this.LblFormaPagto);
            this.GbxAgendamento.Controls.Add(this.LblEspecialidadeValor);
            this.GbxAgendamento.Controls.Add(this.LblPaciente);
            this.GbxAgendamento.Controls.Add(this.LblMedico);
            this.GbxAgendamento.Controls.Add(this.LblDataHorario);
            this.GbxAgendamento.Controls.Add(this.LblCodigo);
            this.GbxAgendamento.Location = new System.Drawing.Point(201, 14);
            this.GbxAgendamento.Margin = new System.Windows.Forms.Padding(4);
            this.GbxAgendamento.Name = "GbxAgendamento";
            this.GbxAgendamento.Padding = new System.Windows.Forms.Padding(4);
            this.GbxAgendamento.Size = new System.Drawing.Size(544, 298);
            this.GbxAgendamento.TabIndex = 0;
            this.GbxAgendamento.TabStop = false;
            // 
            // CbxMedico
            // 
            this.CbxMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxMedico.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxMedico.FormattingEnabled = true;
            this.CbxMedico.Location = new System.Drawing.Point(196, 206);
            this.CbxMedico.Margin = new System.Windows.Forms.Padding(4);
            this.CbxMedico.Name = "CbxMedico";
            this.CbxMedico.Size = new System.Drawing.Size(328, 23);
            this.CbxMedico.TabIndex = 25;
            this.CbxMedico.SelectedIndexChanged += new System.EventHandler(this.CbxMedico_SelectedIndexChanged);
            // 
            // CbxPaciente
            // 
            this.CbxPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxPaciente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxPaciente.FormattingEnabled = true;
            this.CbxPaciente.Items.AddRange(new object[] {
            "Selecione",
            "Cardiologia - R$190,00",
            "Geriatria - R$100,00",
            "Ginecologia - R$90,00",
            "Oncologia - R$380,00",
            "Pediatria - R$80,00",
            "Urologia - R$160,00"});
            this.CbxPaciente.Location = new System.Drawing.Point(196, 110);
            this.CbxPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.CbxPaciente.Name = "CbxPaciente";
            this.CbxPaciente.Size = new System.Drawing.Size(328, 23);
            this.CbxPaciente.TabIndex = 24;
            this.CbxPaciente.SelectedIndexChanged += new System.EventHandler(this.CbxPaciente_SelectedIndexChanged);
            // 
            // LblImagem
            // 
            this.LblImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblImagem.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImagem.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LblImagem.Image = ((System.Drawing.Image)(resources.GetObject("LblImagem.Image")));
            this.LblImagem.Location = new System.Drawing.Point(13, 14);
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
            this.TsBotoes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TsBotoes.Dock = System.Windows.Forms.DockStyle.None;
            this.TsBotoes.GripMargin = new System.Windows.Forms.Padding(5);
            this.TsBotoes.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TsBotoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbSalvarAgenda,
            this.TssSalvar,
            this.TsbPesquisarAgenda,
            this.TssPesquisar,
            this.TsbLimparAgenda,
            this.TssLimpar,
            this.TsbExcluirAgenda,
            this.TssExcluir});
            this.TsBotoes.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.TsBotoes.Location = new System.Drawing.Point(13, 172);
            this.TsBotoes.Name = "TsBotoes";
            this.TsBotoes.Padding = new System.Windows.Forms.Padding(2);
            this.TsBotoes.Size = new System.Drawing.Size(170, 136);
            this.TsBotoes.TabIndex = 18;
            this.TsBotoes.Text = "toolStrip1";
            // 
            // TsbSalvarAgenda
            // 
            this.TsbSalvarAgenda.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsbSalvarAgenda.Image = ((System.Drawing.Image)(resources.GetObject("TsbSalvarAgenda.Image")));
            this.TsbSalvarAgenda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TsbSalvarAgenda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbSalvarAgenda.Name = "TsbSalvarAgenda";
            this.TsbSalvarAgenda.Size = new System.Drawing.Size(165, 20);
            this.TsbSalvarAgenda.Text = "&Salvar";
            this.TsbSalvarAgenda.ToolTipText = "Salvar";
            this.TsbSalvarAgenda.Click += new System.EventHandler(this.TsbSalvar_Click);
            // 
            // TssSalvar
            // 
            this.TssSalvar.Name = "TssSalvar";
            this.TssSalvar.Size = new System.Drawing.Size(165, 6);
            // 
            // TsbPesquisarAgenda
            // 
            this.TsbPesquisarAgenda.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsbPesquisarAgenda.Image = ((System.Drawing.Image)(resources.GetObject("TsbPesquisarAgenda.Image")));
            this.TsbPesquisarAgenda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TsbPesquisarAgenda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbPesquisarAgenda.Name = "TsbPesquisarAgenda";
            this.TsbPesquisarAgenda.Size = new System.Drawing.Size(165, 20);
            this.TsbPesquisarAgenda.Text = "&Pesquisar";
            this.TsbPesquisarAgenda.Click += new System.EventHandler(this.TsbPesquisar_Click);
            // 
            // TssPesquisar
            // 
            this.TssPesquisar.Name = "TssPesquisar";
            this.TssPesquisar.Size = new System.Drawing.Size(165, 6);
            // 
            // TsbLimparAgenda
            // 
            this.TsbLimparAgenda.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsbLimparAgenda.Image = ((System.Drawing.Image)(resources.GetObject("TsbLimparAgenda.Image")));
            this.TsbLimparAgenda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TsbLimparAgenda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbLimparAgenda.Name = "TsbLimparAgenda";
            this.TsbLimparAgenda.Size = new System.Drawing.Size(165, 20);
            this.TsbLimparAgenda.Text = "&Limpar";
            this.TsbLimparAgenda.Click += new System.EventHandler(this.TsbLimpar_Click);
            // 
            // TssLimpar
            // 
            this.TssLimpar.Name = "TssLimpar";
            this.TssLimpar.Size = new System.Drawing.Size(165, 6);
            // 
            // TsbExcluirAgenda
            // 
            this.TsbExcluirAgenda.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsbExcluirAgenda.Image = ((System.Drawing.Image)(resources.GetObject("TsbExcluirAgenda.Image")));
            this.TsbExcluirAgenda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TsbExcluirAgenda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbExcluirAgenda.Name = "TsbExcluirAgenda";
            this.TsbExcluirAgenda.Size = new System.Drawing.Size(165, 20);
            this.TsbExcluirAgenda.Text = "&Excluir";
            this.TsbExcluirAgenda.Click += new System.EventHandler(this.TsbExcluir_Click);
            // 
            // TssExcluir
            // 
            this.TssExcluir.Name = "TssExcluir";
            this.TssExcluir.Size = new System.Drawing.Size(165, 6);
            // 
            // DgvAgendamento
            // 
            this.DgvAgendamento.AllowUserToAddRows = false;
            this.DgvAgendamento.AllowUserToDeleteRows = false;
            this.DgvAgendamento.AllowUserToResizeColumns = false;
            this.DgvAgendamento.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvAgendamento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvAgendamento.CausesValidation = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAgendamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvAgendamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAgendamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgvCBox,
            this.DgvCodigo,
            this.DgvData,
            this.DvgPaciente,
            this.DgvEspecialidade,
            this.DvgMedico,
            this.DgvPagamento});
            this.DgvAgendamento.Location = new System.Drawing.Point(13, 319);
            this.DgvAgendamento.MultiSelect = false;
            this.DgvAgendamento.Name = "DgvAgendamento";
            this.DgvAgendamento.RowHeadersVisible = false;
            this.DgvAgendamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAgendamento.ShowCellErrors = false;
            this.DgvAgendamento.ShowEditingIcon = false;
            this.DgvAgendamento.ShowRowErrors = false;
            this.DgvAgendamento.Size = new System.Drawing.Size(732, 218);
            this.DgvAgendamento.TabIndex = 19;
            this.DgvAgendamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAgendamento_CellContentClick);
            // 
            // DgvCBox
            // 
            this.DgvCBox.DataPropertyName = "Check";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.NullValue = false;
            this.DgvCBox.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvCBox.FalseValue = "false";
            this.DgvCBox.HeaderText = "*";
            this.DgvCBox.Name = "DgvCBox";
            this.DgvCBox.TrueValue = "true";
            this.DgvCBox.Width = 30;
            // 
            // DgvCodigo
            // 
            this.DgvCodigo.DataPropertyName = "Codigo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvCodigo.DefaultCellStyle = dataGridViewCellStyle4;
            this.DgvCodigo.HeaderText = "Código";
            this.DgvCodigo.Name = "DgvCodigo";
            this.DgvCodigo.ReadOnly = true;
            this.DgvCodigo.Width = 50;
            // 
            // DgvData
            // 
            this.DgvData.DataPropertyName = "Data";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvData.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvData.HeaderText = "Data";
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.Width = 120;
            // 
            // DvgPaciente
            // 
            this.DvgPaciente.DataPropertyName = "Paciente";
            this.DvgPaciente.HeaderText = "Paciente";
            this.DvgPaciente.Name = "DvgPaciente";
            this.DvgPaciente.ReadOnly = true;
            this.DvgPaciente.Width = 170;
            // 
            // DgvEspecialidade
            // 
            this.DgvEspecialidade.DataPropertyName = "Especialidade";
            this.DgvEspecialidade.HeaderText = "Especialidade";
            this.DgvEspecialidade.Name = "DgvEspecialidade";
            this.DgvEspecialidade.ReadOnly = true;
            this.DgvEspecialidade.Width = 130;
            // 
            // DvgMedico
            // 
            this.DvgMedico.DataPropertyName = "Medico";
            this.DvgMedico.HeaderText = "Médico";
            this.DvgMedico.Name = "DvgMedico";
            this.DvgMedico.ReadOnly = true;
            this.DvgMedico.Width = 130;
            // 
            // DgvPagamento
            // 
            this.DgvPagamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DgvPagamento.DataPropertyName = "Pagamento";
            this.DgvPagamento.HeaderText = "Pagamento";
            this.DgvPagamento.Name = "DgvPagamento";
            this.DgvPagamento.ReadOnly = true;
            // 
            // FrmAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(752, 540);
            this.Controls.Add(this.DgvAgendamento);
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
            this.Shown += new System.EventHandler(this.FrmAgendamento_Shown_1);
            this.GbxAgendamento.ResumeLayout(false);
            this.GbxAgendamento.PerformLayout();
            this.TsBotoes.ResumeLayout(false);
            this.TsBotoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAgendamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label LblDataHorario;
        private System.Windows.Forms.Label LblMedico;
        private System.Windows.Forms.Label LblPaciente;
        private System.Windows.Forms.Label LblEspecialidadeValor;
        private System.Windows.Forms.Label LblFormaPagto;
        private System.Windows.Forms.TextBox TbxCodigo;
        private System.Windows.Forms.ComboBox CbxEspecialidadeValor;
        private System.Windows.Forms.ComboBox CbxFormaPagto;
        private System.Windows.Forms.MaskedTextBox MskDataHorario;
        private System.Windows.Forms.GroupBox GbxAgendamento;
        private System.Windows.Forms.Label LblImagem;
        private System.Windows.Forms.ToolStrip TsBotoes;
        private System.Windows.Forms.ToolStripButton TsbSalvarAgenda;
        private System.Windows.Forms.ToolStripSeparator TssSalvar;
        private System.Windows.Forms.ToolStripButton TsbPesquisarAgenda;
        private System.Windows.Forms.ToolStripSeparator TssPesquisar;
        private System.Windows.Forms.ToolStripButton TsbLimparAgenda;
        private System.Windows.Forms.ToolStripSeparator TssLimpar;
        private System.Windows.Forms.ToolStripButton TsbExcluirAgenda;
        private System.Windows.Forms.ToolStripSeparator TssExcluir;
        private System.Windows.Forms.ComboBox CbxMedico;
        private System.Windows.Forms.ComboBox CbxPaciente;
        private System.Windows.Forms.DataGridView DgvAgendamento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DgvCBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn DvgPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvEspecialidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn DvgMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvPagamento;
    }
}