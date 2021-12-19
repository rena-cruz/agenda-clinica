namespace AgendaClinica.Formularios
{
    partial class FrmMedico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMedico));
            this.DgvJornada = new System.Windows.Forms.DataGridView();
            this.DgvCBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DgvDiaSemana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlBotaoCadastroMedico = new System.Windows.Forms.Panel();
            this.TsBotoesPaciente = new System.Windows.Forms.ToolStrip();
            this.TsbSalvar = new System.Windows.Forms.ToolStripButton();
            this.TssSalvar = new System.Windows.Forms.ToolStripSeparator();
            this.TsbPesquisar = new System.Windows.Forms.ToolStripButton();
            this.TssPesquisar = new System.Windows.Forms.ToolStripSeparator();
            this.TsbLimpar = new System.Windows.Forms.ToolStripButton();
            this.TssLimpar = new System.Windows.Forms.ToolStripSeparator();
            this.PnlCadastroMedico = new System.Windows.Forms.Panel();
            this.LblCRM = new System.Windows.Forms.Label();
            this.TbxCRM = new System.Windows.Forms.TextBox();
            this.TbxEmail = new System.Windows.Forms.TextBox();
            this.CbxEspecialidade = new System.Windows.Forms.ComboBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblEspecialidade = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.TbxNome = new System.Windows.Forms.TextBox();
            this.PnlJornada = new System.Windows.Forms.Panel();
            this.TsBotoes = new System.Windows.Forms.ToolStrip();
            this.TsbIncluirJornada = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsbExcluirJornada = new System.Windows.Forms.ToolStripButton();
            this.CbxPeriodo = new System.Windows.Forms.ComboBox();
            this.LblPeriodo = new System.Windows.Forms.Label();
            this.CbxDiaSemana = new System.Windows.Forms.ComboBox();
            this.LblDiaSemana = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvJornada)).BeginInit();
            this.PnlBotaoCadastroMedico.SuspendLayout();
            this.TsBotoesPaciente.SuspendLayout();
            this.PnlCadastroMedico.SuspendLayout();
            this.PnlJornada.SuspendLayout();
            this.TsBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvJornada
            // 
            this.DgvJornada.AllowUserToAddRows = false;
            this.DgvJornada.AllowUserToDeleteRows = false;
            this.DgvJornada.AllowUserToResizeColumns = false;
            this.DgvJornada.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvJornada.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvJornada.CausesValidation = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvJornada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvJornada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvJornada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgvCBox,
            this.DgvDiaSemana,
            this.DgvPeriodo});
            this.DgvJornada.Location = new System.Drawing.Point(24, 84);
            this.DgvJornada.MultiSelect = false;
            this.DgvJornada.Name = "DgvJornada";
            this.DgvJornada.RowHeadersVisible = false;
            this.DgvJornada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvJornada.ShowCellErrors = false;
            this.DgvJornada.ShowEditingIcon = false;
            this.DgvJornada.ShowRowErrors = false;
            this.DgvJornada.Size = new System.Drawing.Size(558, 168);
            this.DgvJornada.TabIndex = 7;
            this.DgvJornada.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvJornada_CellContentClick);
            // 
            // DgvCBox
            // 
            this.DgvCBox.DataPropertyName = "Check";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.NullValue = false;
            this.DgvCBox.DefaultCellStyle = dataGridViewCellStyle8;
            this.DgvCBox.FalseValue = "false";
            this.DgvCBox.HeaderText = "*";
            this.DgvCBox.Name = "DgvCBox";
            this.DgvCBox.TrueValue = "true";
            this.DgvCBox.Width = 30;
            // 
            // DgvDiaSemana
            // 
            this.DgvDiaSemana.DataPropertyName = "Dia";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvDiaSemana.DefaultCellStyle = dataGridViewCellStyle9;
            this.DgvDiaSemana.HeaderText = "Dia da Semana";
            this.DgvDiaSemana.Name = "DgvDiaSemana";
            this.DgvDiaSemana.ReadOnly = true;
            this.DgvDiaSemana.Width = 250;
            // 
            // DgvPeriodo
            // 
            this.DgvPeriodo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DgvPeriodo.DataPropertyName = "Periodo";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvPeriodo.DefaultCellStyle = dataGridViewCellStyle10;
            this.DgvPeriodo.HeaderText = "Período";
            this.DgvPeriodo.Name = "DgvPeriodo";
            this.DgvPeriodo.ReadOnly = true;
            // 
            // PnlBotaoCadastroMedico
            // 
            this.PnlBotaoCadastroMedico.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PnlBotaoCadastroMedico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlBotaoCadastroMedico.Controls.Add(this.TsBotoesPaciente);
            this.PnlBotaoCadastroMedico.Location = new System.Drawing.Point(478, 12);
            this.PnlBotaoCadastroMedico.Name = "PnlBotaoCadastroMedico";
            this.PnlBotaoCadastroMedico.Size = new System.Drawing.Size(131, 208);
            this.PnlBotaoCadastroMedico.TabIndex = 15;
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
            this.TsBotoesPaciente.Location = new System.Drawing.Point(0, 1);
            this.TsBotoesPaciente.Name = "TsBotoesPaciente";
            this.TsBotoesPaciente.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.TsBotoesPaciente.Size = new System.Drawing.Size(129, 206);
            this.TsBotoesPaciente.TabIndex = 21;
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
            this.TsbSalvar.Size = new System.Drawing.Size(118, 50);
            this.TsbSalvar.Text = "&Salvar";
            this.TsbSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsbSalvar.Click += new System.EventHandler(this.TsbSalvar_Click);
            // 
            // TssSalvar
            // 
            this.TssSalvar.Name = "TssSalvar";
            this.TssSalvar.Size = new System.Drawing.Size(118, 6);
            // 
            // TsbPesquisar
            // 
            this.TsbPesquisar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsbPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("TsbPesquisar.Image")));
            this.TsbPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TsbPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbPesquisar.Name = "TsbPesquisar";
            this.TsbPesquisar.Padding = new System.Windows.Forms.Padding(7);
            this.TsbPesquisar.Size = new System.Drawing.Size(118, 50);
            this.TsbPesquisar.Text = "&Pesquisar";
            this.TsbPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsbPesquisar.Click += new System.EventHandler(this.TsbPesquisar_Click);
            // 
            // TssPesquisar
            // 
            this.TssPesquisar.Name = "TssPesquisar";
            this.TssPesquisar.Size = new System.Drawing.Size(118, 6);
            // 
            // TsbLimpar
            // 
            this.TsbLimpar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsbLimpar.Image = ((System.Drawing.Image)(resources.GetObject("TsbLimpar.Image")));
            this.TsbLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TsbLimpar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbLimpar.Name = "TsbLimpar";
            this.TsbLimpar.Padding = new System.Windows.Forms.Padding(7);
            this.TsbLimpar.Size = new System.Drawing.Size(118, 50);
            this.TsbLimpar.Text = "&Limpar";
            this.TsbLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsbLimpar.Click += new System.EventHandler(this.TsbLimpar_Click);
            // 
            // TssLimpar
            // 
            this.TssLimpar.Name = "TssLimpar";
            this.TssLimpar.Size = new System.Drawing.Size(118, 6);
            // 
            // PnlCadastroMedico
            // 
            this.PnlCadastroMedico.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PnlCadastroMedico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlCadastroMedico.Controls.Add(this.LblCRM);
            this.PnlCadastroMedico.Controls.Add(this.TbxCRM);
            this.PnlCadastroMedico.Controls.Add(this.TbxEmail);
            this.PnlCadastroMedico.Controls.Add(this.CbxEspecialidade);
            this.PnlCadastroMedico.Controls.Add(this.LblEmail);
            this.PnlCadastroMedico.Controls.Add(this.LblEspecialidade);
            this.PnlCadastroMedico.Controls.Add(this.LblNome);
            this.PnlCadastroMedico.Controls.Add(this.TbxNome);
            this.PnlCadastroMedico.Location = new System.Drawing.Point(12, 12);
            this.PnlCadastroMedico.Name = "PnlCadastroMedico";
            this.PnlCadastroMedico.Size = new System.Drawing.Size(460, 208);
            this.PnlCadastroMedico.TabIndex = 14;
            // 
            // LblCRM
            // 
            this.LblCRM.AutoSize = true;
            this.LblCRM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCRM.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCRM.Location = new System.Drawing.Point(24, 134);
            this.LblCRM.Name = "LblCRM";
            this.LblCRM.Size = new System.Drawing.Size(38, 18);
            this.LblCRM.TabIndex = 1;
            this.LblCRM.Text = "CRM";
            // 
            // TbxCRM
            // 
            this.TbxCRM.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxCRM.Location = new System.Drawing.Point(24, 155);
            this.TbxCRM.Name = "TbxCRM";
            this.TbxCRM.Size = new System.Drawing.Size(189, 21);
            this.TbxCRM.TabIndex = 3;
            // 
            // TbxEmail
            // 
            this.TbxEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxEmail.Location = new System.Drawing.Point(24, 96);
            this.TbxEmail.Name = "TbxEmail";
            this.TbxEmail.Size = new System.Drawing.Size(415, 21);
            this.TbxEmail.TabIndex = 2;
            // 
            // CbxEspecialidade
            // 
            this.CbxEspecialidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxEspecialidade.FormattingEnabled = true;
            this.CbxEspecialidade.Location = new System.Drawing.Point(233, 154);
            this.CbxEspecialidade.Name = "CbxEspecialidade";
            this.CbxEspecialidade.Size = new System.Drawing.Size(206, 22);
            this.CbxEspecialidade.TabIndex = 4;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(24, 75);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(46, 18);
            this.LblEmail.TabIndex = 2;
            this.LblEmail.Text = "E-mail";
            // 
            // LblEspecialidade
            // 
            this.LblEspecialidade.AutoSize = true;
            this.LblEspecialidade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblEspecialidade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEspecialidade.Location = new System.Drawing.Point(233, 134);
            this.LblEspecialidade.Name = "LblEspecialidade";
            this.LblEspecialidade.Size = new System.Drawing.Size(90, 18);
            this.LblEspecialidade.TabIndex = 3;
            this.LblEspecialidade.Text = "Especialidade";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(24, 16);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(43, 18);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Nome";
            // 
            // TbxNome
            // 
            this.TbxNome.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxNome.Location = new System.Drawing.Point(24, 37);
            this.TbxNome.Name = "TbxNome";
            this.TbxNome.Size = new System.Drawing.Size(415, 21);
            this.TbxNome.TabIndex = 1;
            // 
            // PnlJornada
            // 
            this.PnlJornada.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PnlJornada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlJornada.Controls.Add(this.TsBotoes);
            this.PnlJornada.Controls.Add(this.CbxPeriodo);
            this.PnlJornada.Controls.Add(this.LblPeriodo);
            this.PnlJornada.Controls.Add(this.CbxDiaSemana);
            this.PnlJornada.Controls.Add(this.LblDiaSemana);
            this.PnlJornada.Controls.Add(this.DgvJornada);
            this.PnlJornada.Location = new System.Drawing.Point(12, 226);
            this.PnlJornada.Name = "PnlJornada";
            this.PnlJornada.Size = new System.Drawing.Size(597, 267);
            this.PnlJornada.TabIndex = 16;
            // 
            // TsBotoes
            // 
            this.TsBotoes.AutoSize = false;
            this.TsBotoes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TsBotoes.Dock = System.Windows.Forms.DockStyle.None;
            this.TsBotoes.GripMargin = new System.Windows.Forms.Padding(5);
            this.TsBotoes.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TsBotoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbIncluirJornada,
            this.toolStripSeparator1,
            this.TsbExcluirJornada});
            this.TsBotoes.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.TsBotoes.Location = new System.Drawing.Point(479, 10);
            this.TsBotoes.Name = "TsBotoes";
            this.TsBotoes.Padding = new System.Windows.Forms.Padding(2);
            this.TsBotoes.Size = new System.Drawing.Size(103, 71);
            this.TsBotoes.TabIndex = 19;
            this.TsBotoes.Text = "toolStrip1";
            // 
            // TsbIncluirJornada
            // 
            this.TsbIncluirJornada.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsbIncluirJornada.Image = ((System.Drawing.Image)(resources.GetObject("TsbIncluirJornada.Image")));
            this.TsbIncluirJornada.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TsbIncluirJornada.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbIncluirJornada.Name = "TsbIncluirJornada";
            this.TsbIncluirJornada.Padding = new System.Windows.Forms.Padding(1);
            this.TsbIncluirJornada.Size = new System.Drawing.Size(98, 22);
            this.TsbIncluirJornada.Text = "&Incluir";
            this.TsbIncluirJornada.ToolTipText = "Incluir";
            this.TsbIncluirJornada.Click += new System.EventHandler(this.TsbIncluirJornada_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(98, 6);
            // 
            // TsbExcluirJornada
            // 
            this.TsbExcluirJornada.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsbExcluirJornada.Image = ((System.Drawing.Image)(resources.GetObject("TsbExcluirJornada.Image")));
            this.TsbExcluirJornada.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TsbExcluirJornada.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbExcluirJornada.Name = "TsbExcluirJornada";
            this.TsbExcluirJornada.Size = new System.Drawing.Size(98, 20);
            this.TsbExcluirJornada.Text = "&Excluir";
            this.TsbExcluirJornada.Click += new System.EventHandler(this.TsbExcluirJornada_Click);
            // 
            // CbxPeriodo
            // 
            this.CbxPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxPeriodo.FormattingEnabled = true;
            this.CbxPeriodo.Location = new System.Drawing.Point(233, 36);
            this.CbxPeriodo.Name = "CbxPeriodo";
            this.CbxPeriodo.Size = new System.Drawing.Size(206, 22);
            this.CbxPeriodo.TabIndex = 6;
            // 
            // LblPeriodo
            // 
            this.LblPeriodo.AutoSize = true;
            this.LblPeriodo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblPeriodo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPeriodo.Location = new System.Drawing.Point(233, 16);
            this.LblPeriodo.Name = "LblPeriodo";
            this.LblPeriodo.Size = new System.Drawing.Size(53, 18);
            this.LblPeriodo.TabIndex = 20;
            this.LblPeriodo.Text = "Período";
            // 
            // CbxDiaSemana
            // 
            this.CbxDiaSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxDiaSemana.FormattingEnabled = true;
            this.CbxDiaSemana.Location = new System.Drawing.Point(24, 36);
            this.CbxDiaSemana.Name = "CbxDiaSemana";
            this.CbxDiaSemana.Size = new System.Drawing.Size(189, 22);
            this.CbxDiaSemana.TabIndex = 5;
            // 
            // LblDiaSemana
            // 
            this.LblDiaSemana.AutoSize = true;
            this.LblDiaSemana.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblDiaSemana.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDiaSemana.Location = new System.Drawing.Point(24, 16);
            this.LblDiaSemana.Name = "LblDiaSemana";
            this.LblDiaSemana.Size = new System.Drawing.Size(98, 18);
            this.LblDiaSemana.TabIndex = 18;
            this.LblDiaSemana.Text = "Dia da Semana";
            // 
            // FrmMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(619, 501);
            this.Controls.Add(this.PnlJornada);
            this.Controls.Add(this.PnlCadastroMedico);
            this.Controls.Add(this.PnlBotaoCadastroMedico);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmMedico";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Médico";
            this.Shown += new System.EventHandler(this.FrmMedico_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DgvJornada)).EndInit();
            this.PnlBotaoCadastroMedico.ResumeLayout(false);
            this.TsBotoesPaciente.ResumeLayout(false);
            this.TsBotoesPaciente.PerformLayout();
            this.PnlCadastroMedico.ResumeLayout(false);
            this.PnlCadastroMedico.PerformLayout();
            this.PnlJornada.ResumeLayout(false);
            this.PnlJornada.PerformLayout();
            this.TsBotoes.ResumeLayout(false);
            this.TsBotoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvJornada;
        private System.Windows.Forms.Panel PnlBotaoCadastroMedico;
        private System.Windows.Forms.Panel PnlCadastroMedico;
        private System.Windows.Forms.Label LblCRM;
        private System.Windows.Forms.TextBox TbxCRM;
        private System.Windows.Forms.TextBox TbxEmail;
        private System.Windows.Forms.ComboBox CbxEspecialidade;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblEspecialidade;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox TbxNome;
        private System.Windows.Forms.Panel PnlJornada;
        private System.Windows.Forms.ComboBox CbxPeriodo;
        private System.Windows.Forms.Label LblPeriodo;
        private System.Windows.Forms.ComboBox CbxDiaSemana;
        private System.Windows.Forms.Label LblDiaSemana;
        private System.Windows.Forms.ToolStrip TsBotoesPaciente;
        private System.Windows.Forms.ToolStripButton TsbSalvar;
        private System.Windows.Forms.ToolStripSeparator TssSalvar;
        private System.Windows.Forms.ToolStripButton TsbPesquisar;
        private System.Windows.Forms.ToolStripSeparator TssPesquisar;
        private System.Windows.Forms.ToolStripButton TsbLimpar;
        private System.Windows.Forms.ToolStripSeparator TssLimpar;
        private System.Windows.Forms.ToolStrip TsBotoes;
        private System.Windows.Forms.ToolStripButton TsbIncluirJornada;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TsbExcluirJornada;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DgvCBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvDiaSemana;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvPeriodo;
    }
}