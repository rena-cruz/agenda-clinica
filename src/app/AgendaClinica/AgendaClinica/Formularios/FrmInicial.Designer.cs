namespace AgendaClinica.Formularios
{
    partial class FrmInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicial));
            this.BtnCadastroMedico = new System.Windows.Forms.Button();
            this.BtnCadastroPaciente = new System.Windows.Forms.Button();
            this.BtnAgendamento = new System.Windows.Forms.Button();
            this.LblImagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCadastroMedico
            // 
            this.BtnCadastroMedico.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCadastroMedico.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastroMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnCadastroMedico.Location = new System.Drawing.Point(285, 18);
            this.BtnCadastroMedico.Name = "BtnCadastroMedico";
            this.BtnCadastroMedico.Size = new System.Drawing.Size(239, 47);
            this.BtnCadastroMedico.TabIndex = 0;
            this.BtnCadastroMedico.Text = "Cadastro de Médico";
            this.BtnCadastroMedico.UseVisualStyleBackColor = false;
            this.BtnCadastroMedico.Click += new System.EventHandler(this.BtnCadastroMedico_Click);
            // 
            // BtnCadastroPaciente
            // 
            this.BtnCadastroPaciente.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCadastroPaciente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastroPaciente.Location = new System.Drawing.Point(285, 114);
            this.BtnCadastroPaciente.Name = "BtnCadastroPaciente";
            this.BtnCadastroPaciente.Size = new System.Drawing.Size(239, 47);
            this.BtnCadastroPaciente.TabIndex = 1;
            this.BtnCadastroPaciente.Text = "Cadastro de Paciente";
            this.BtnCadastroPaciente.UseVisualStyleBackColor = false;
            this.BtnCadastroPaciente.Click += new System.EventHandler(this.BtnCadastroPaciente_Click);
            // 
            // BtnAgendamento
            // 
            this.BtnAgendamento.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAgendamento.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgendamento.Location = new System.Drawing.Point(285, 210);
            this.BtnAgendamento.Name = "BtnAgendamento";
            this.BtnAgendamento.Size = new System.Drawing.Size(239, 50);
            this.BtnAgendamento.TabIndex = 2;
            this.BtnAgendamento.Text = "Agendamento";
            this.BtnAgendamento.UseVisualStyleBackColor = false;
            this.BtnAgendamento.Click += new System.EventHandler(this.BtnAgendamento_Click);
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
            this.LblImagem.Size = new System.Drawing.Size(265, 242);
            this.LblImagem.TabIndex = 3;
            this.LblImagem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(533, 273);
            this.Controls.Add(this.LblImagem);
            this.Controls.Add(this.BtnAgendamento);
            this.Controls.Add(this.BtnCadastroPaciente);
            this.Controls.Add(this.BtnCadastroMedico);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmInicial";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.Load += new System.EventHandler(this.FrmInicial_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCadastroMedico;
        private System.Windows.Forms.Button BtnCadastroPaciente;
        private System.Windows.Forms.Button BtnAgendamento;
        private System.Windows.Forms.Label LblImagem;
    }
}