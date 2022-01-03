using AgendaClinica.Repositorio.DTO;
using AgendaClinica.Servico;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AgendaClinica.Formularios
{
    public partial class FrmPaciente : Form
    {
        Service servico;

        public FrmPaciente()
        {
            InitializeComponent();
            servico = new Service();
            CarregarComboBox();
        }

        public void CarregarComboBox()
        {
            try
            {
                CbxSituacaoFinanceira.DataSource = servico.BuscarSituacaoFinanceira();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar a tela.\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TsbSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CbxSituacaoFinanceira.Text.Equals("Selecione"))
                {
                    MessageBox.Show("Selecione a situação financeira antes de salvar");
                    return;
                }
                servico.SalvarPaciente(CarregaPacienteDto());
                MessageBox.Show($"O registro foi salvo");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o registro.\n{ex.Message}");
            }
        }

        private void TsbPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TbxCodigo.Text))
                {
                    MessageBox.Show("Informe o código");
                    return;
                }

                var celular = RetornaValorCelularSemMascara();

                if (!string.IsNullOrWhiteSpace(TbxNome.Text) || !string.IsNullOrWhiteSpace(TbxEmail.Text) ||
                        !string.IsNullOrWhiteSpace(celular) || !CbxSituacaoFinanceira.Text.Equals("Selecione"))
                {
                    MessageBox.Show("Limpe a tela e informe o código");
                    return;
                }

                var paciente = servico.CarregarPaciente(long.Parse(TbxCodigo.Text));

                if (TbxCodigo.Text.Equals(paciente.Codigo.ToString()))
                {
                    TbxCodigo.Text = paciente.Codigo.ToString();
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
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar os dados do banco.\n{ex.Message}");
            }

        }

        private void TsbLimpar_Click(object sender, EventArgs e)
        {
            TbxCodigo.Clear();
            TbxNome.Clear();
            TbxEmail.Clear();
            MkTbxCelular.Clear();
            DtpDtaNascimento.Value = DateTime.Now;
            CbxSituacaoFinanceira.SelectedIndex = 0;
            TbxNome.Focus();
        }

        private PacienteDTO CarregaPacienteDto()
        {
            var celular = RetornaValorCelularSemMascara();

            PacienteDTO paciente = new PacienteDTO()
            {
                Codigo = string.IsNullOrWhiteSpace(TbxCodigo.Text) ? 0L : long.Parse(TbxCodigo.Text),
                Nome = TbxNome.Text,
                Email = TbxEmail.Text,
                DataNascimento = DtpDtaNascimento.Value,
                Celular = celular,
                SituacaoFinanceira = CbxSituacaoFinanceira.Text
            };

            return paciente;
        }

        private string RetornaValorCelularSemMascara()
        {
            MkTbxCelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            var celular = MkTbxCelular.Text;
            MkTbxCelular.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            return celular;
        }
    }
}
