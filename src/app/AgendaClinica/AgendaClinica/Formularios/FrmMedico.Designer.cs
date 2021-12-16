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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvJornada = new System.Windows.Forms.DataGridView();
            this.DgvCBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DgvDiaSemana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlBotaoCadastroMedico = new System.Windows.Forms.Panel();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
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
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.CbxPeriodo = new System.Windows.Forms.ComboBox();
            this.LblPeriodo = new System.Windows.Forms.Label();
            this.CbxDiaSemana = new System.Windows.Forms.ComboBox();
            this.LblDiaSemana = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvJornada)).BeginInit();
            this.PnlBotaoCadastroMedico.SuspendLayout();
            this.PnlCadastroMedico.SuspendLayout();
            this.PnlJornada.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvJornada
            // 
            this.DgvJornada.AllowUserToAddRows = false;
            this.DgvJornada.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvJornada.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvJornada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DgvJornada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvJornada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgvCBox,
            this.DgvDiaSemana,
            this.DgvPeriodo});
            this.DgvJornada.Location = new System.Drawing.Point(24, 84);
            this.DgvJornada.MultiSelect = false;
            this.DgvJornada.Name = "DgvJornada";
            this.DgvJornada.RowHeadersVisible = false;
            this.DgvJornada.ShowCellErrors = false;
            this.DgvJornada.ShowEditingIcon = false;
            this.DgvJornada.ShowRowErrors = false;
            this.DgvJornada.Size = new System.Drawing.Size(558, 168);
            this.DgvJornada.TabIndex = 17;
            // 
            // DgvCBox
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.NullValue = false;
            this.DgvCBox.DefaultCellStyle = dataGridViewCellStyle13;
            this.DgvCBox.HeaderText = "*";
            this.DgvCBox.Name = "DgvCBox";
            this.DgvCBox.Width = 30;
            // 
            // DgvDiaSemana
            // 
            this.DgvDiaSemana.DataPropertyName = "DiaSemana";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvDiaSemana.DefaultCellStyle = dataGridViewCellStyle14;
            this.DgvDiaSemana.HeaderText = "Dia da Semana";
            this.DgvDiaSemana.Name = "DgvDiaSemana";
            this.DgvDiaSemana.ReadOnly = true;
            this.DgvDiaSemana.Width = 250;
            // 
            // DgvPeriodo
            // 
            this.DgvPeriodo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DgvPeriodo.DataPropertyName = "Periodo";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvPeriodo.DefaultCellStyle = dataGridViewCellStyle15;
            this.DgvPeriodo.HeaderText = "Período";
            this.DgvPeriodo.Name = "DgvPeriodo";
            this.DgvPeriodo.ReadOnly = true;
            // 
            // PnlBotaoCadastroMedico
            // 
            this.PnlBotaoCadastroMedico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlBotaoCadastroMedico.Controls.Add(this.BtnPesquisar);
            this.PnlBotaoCadastroMedico.Controls.Add(this.BtnSalvar);
            this.PnlBotaoCadastroMedico.Controls.Add(this.BtnLimpar);
            this.PnlBotaoCadastroMedico.Location = new System.Drawing.Point(492, 12);
            this.PnlBotaoCadastroMedico.Name = "PnlBotaoCadastroMedico";
            this.PnlBotaoCadastroMedico.Size = new System.Drawing.Size(117, 208);
            this.PnlBotaoCadastroMedico.TabIndex = 15;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesquisar.Location = new System.Drawing.Point(16, 87);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(86, 30);
            this.BtnPesquisar.TabIndex = 11;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Location = new System.Drawing.Point(16, 28);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(86, 30);
            this.BtnSalvar.TabIndex = 9;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.Location = new System.Drawing.Point(16, 146);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(86, 30);
            this.BtnLimpar.TabIndex = 12;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // PnlCadastroMedico
            // 
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
            this.TbxCRM.TabIndex = 6;
            // 
            // TbxEmail
            // 
            this.TbxEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxEmail.Location = new System.Drawing.Point(24, 96);
            this.TbxEmail.Name = "TbxEmail";
            this.TbxEmail.Size = new System.Drawing.Size(415, 21);
            this.TbxEmail.TabIndex = 5;
            // 
            // CbxEspecialidade
            // 
            this.CbxEspecialidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxEspecialidade.FormattingEnabled = true;
            this.CbxEspecialidade.Location = new System.Drawing.Point(233, 154);
            this.CbxEspecialidade.Name = "CbxEspecialidade";
            this.CbxEspecialidade.Size = new System.Drawing.Size(206, 22);
            this.CbxEspecialidade.TabIndex = 13;
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
            this.TbxNome.TabIndex = 7;
            // 
            // PnlJornada
            // 
            this.PnlJornada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlJornada.Controls.Add(this.BtnIncluir);
            this.PnlJornada.Controls.Add(this.BtnExcluir);
            this.PnlJornada.Controls.Add(this.CbxPeriodo);
            this.PnlJornada.Controls.Add(this.LblPeriodo);
            this.PnlJornada.Controls.Add(this.CbxDiaSemana);
            this.PnlJornada.Controls.Add(this.LblDiaSemana);
            this.PnlJornada.Controls.Add(this.DgvJornada);
            this.PnlJornada.Location = new System.Drawing.Point(12, 236);
            this.PnlJornada.Name = "PnlJornada";
            this.PnlJornada.Size = new System.Drawing.Size(597, 267);
            this.PnlJornada.TabIndex = 16;
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIncluir.Location = new System.Drawing.Point(496, 9);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(86, 30);
            this.BtnIncluir.TabIndex = 23;
            this.BtnIncluir.Text = "Incluir";
            this.BtnIncluir.UseVisualStyleBackColor = true;
            this.BtnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Location = new System.Drawing.Point(496, 48);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(86, 30);
            this.BtnExcluir.TabIndex = 22;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // CbxPeriodo
            // 
            this.CbxPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxPeriodo.FormattingEnabled = true;
            this.CbxPeriodo.Location = new System.Drawing.Point(233, 36);
            this.CbxPeriodo.Name = "CbxPeriodo";
            this.CbxPeriodo.Size = new System.Drawing.Size(206, 22);
            this.CbxPeriodo.TabIndex = 21;
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
            this.CbxDiaSemana.TabIndex = 19;
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
            this.ClientSize = new System.Drawing.Size(621, 515);
            this.Controls.Add(this.PnlJornada);
            this.Controls.Add(this.PnlCadastroMedico);
            this.Controls.Add(this.PnlBotaoCadastroMedico);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmMedico";
            this.ShowIcon = false;
            this.Text = "Cadastro de Médico";
            ((System.ComponentModel.ISupportInitialize)(this.DgvJornada)).EndInit();
            this.PnlBotaoCadastroMedico.ResumeLayout(false);
            this.PnlCadastroMedico.ResumeLayout(false);
            this.PnlCadastroMedico.PerformLayout();
            this.PnlJornada.ResumeLayout(false);
            this.PnlJornada.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvJornada;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DgvCBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvDiaSemana;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvPeriodo;
        private System.Windows.Forms.Panel PnlBotaoCadastroMedico;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnLimpar;
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
        private System.Windows.Forms.Button BtnIncluir;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.ComboBox CbxPeriodo;
        private System.Windows.Forms.Label LblPeriodo;
        private System.Windows.Forms.ComboBox CbxDiaSemana;
        private System.Windows.Forms.Label LblDiaSemana;
    }
}