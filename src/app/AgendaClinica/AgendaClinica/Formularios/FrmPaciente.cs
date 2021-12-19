using AgendaClinica.Repositorio.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AgendaClinica.Formularios
{
    public partial class FrmPaciente : Form
    {
        public FrmPaciente()
        {
            InitializeComponent();
            CarregarComboBox();
        }

        public void CarregarComboBox() 
        {
            List<string> listaSituacaoFinanceira = new List<string>();
            listaSituacaoFinanceira.Add("Selecione");
            listaSituacaoFinanceira.Add("Bloqueado");
            listaSituacaoFinanceira.Add("Liberado");
            CbxSituacaoFinanceira.DataSource = listaSituacaoFinanceira;
        }

        private void TsbSalvar_Click(object sender, EventArgs e)
        {
            PacienteDTO paciente = new PacienteDTO()
            {
                Codigo = TbxCodigo.Text,
                Nome = TbxNome.Text,
                Email = TbxEmail.Text,
                DataNascimento = DtpDtaNascimento.Value,
                Celular = MkTbxCelular.Text,
                SituacaoFinanceira = CbxSituacaoFinanceira.Text
            };
            
            MessageBox.Show($"O registro {paciente.Nome} {paciente.DataNascimento} {paciente.SituacaoFinanceira} foi salvo");
        }

        private void TsbPesquisar_Click(object sender, EventArgs e)
        {
            PacienteDTO paciente = new PacienteDTO()
            {
                Codigo = "123",
                Nome = "Renata",
                Email = "fff@gmail",
                DataNascimento = new DateTime(2021,12,17),
                Celular = "16988064183",
                SituacaoFinanceira = "Liberado"
            };

            if (string.IsNullOrWhiteSpace(TbxCodigo.Text))
            {
                MessageBox.Show("Informe o código");
                return;
            }

            if (TbxCodigo.Text.Equals(paciente.Codigo))
            {
                TbxCodigo.Text = paciente.Codigo;
                TbxNome.Text = paciente.Nome;
                TbxEmail.Text = paciente.Email;
                DtpDtaNascimento.Value = paciente.DataNascimento;
                MkTbxCelular.Text = paciente.Celular;
                CbxSituacaoFinanceira.SelectedItem = paciente.SituacaoFinanceira;
            }
            else
            {
                MessageBox.Show("O código informado não existe");
            }
        }

        private void TsbLimpar_Click(object sender, EventArgs e)
        {
            TbxNome.Clear();
            TbxEmail.Clear();
            MkTbxCelular.Clear();
            DtpDtaNascimento.Value = DateTime.Now;
            CbxSituacaoFinanceira.SelectedIndex = 0;
            TbxNome.Focus();
        }
    }
}
