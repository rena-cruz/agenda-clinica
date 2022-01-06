using AgendaClinica.Repositorio.DTO;
using AgendaClinica.Servico;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AgendaClinica.Formularios
{
    public partial class FrmAgendamento : Form
    {
        Service servico;

        DataTable dtAgendamento;

        public FrmAgendamento()
        {
            InitializeComponent();
            servico = new Service();
            CarregarComboBox();

            dtAgendamento = new DataTable();
            dtAgendamento.Columns.Add("Check", typeof(bool));
            dtAgendamento.Columns.Add("Codigo", typeof(long));
            dtAgendamento.Columns.Add("Data", typeof(DateTime));
            dtAgendamento.Columns.Add("Paciente", typeof(string));
            dtAgendamento.Columns.Add("Especialidade", typeof(string));
            dtAgendamento.Columns.Add("Medico", typeof(string));
            dtAgendamento.Columns.Add("Pagamento", typeof(string));
            DgvAgendamento.DataSource = dtAgendamento;
        }

        private void CarregarComboBox()
        {
            try
            {
                CbxPaciente.DataSource = servico.BuscarPaciente();
                CbxEspecialidadeValor.DataSource = servico.BuscarEspecialidadeValor();
                CbxFormaPagto.DataSource = servico.BuscarFormaPagamento();
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
                if (CbxPaciente.Text.Equals("Selecione"))
                {
                    MessageBox.Show("Selecione o paciente antes de salvar");
                    return;
                }
                var seqAgendamento = servico.SalvarAgendamento(CarregaAgendamentoDto());
                TbxCodigo.Text = seqAgendamento.ToString();
                CarregarTabela();

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
                var agendamento = servico.BuscarAgendamento(long.Parse(TbxCodigo.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro na pesquisa\n{ex.Message}");
            }
        }

        private void CarregarTabela()
        {
            try
            {
                var listaAgendamento = servico.BuscarAgendamento();
                dtAgendamento.Clear();
                foreach (var item in listaAgendamento)
                {
                    DataRow dr = dtAgendamento.NewRow();
                    dr["Check"] = false;
                    dr["Codigo"] = item.Codigo;
                    dr["Data"] = item.DataHorario;
                    dr["Paciente"] = item.Paciente;
                    dr["Especialidade"] = item.EspecialidadeValor;
                    dr["Medico"] = item.Medico;
                    dr["Pagamento"] = item.FormaPagamento;
                    dtAgendamento.Rows.Add(dr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar a tabela\n{ex.Message}");
            }
        }

        private void TsbLimpar_Click(object sender, EventArgs e)
        {
            TbxCodigo.Clear();
            MskDataHorario.Clear();
            CbxPaciente.SelectedIndex = 0;
            CbxMedico.SelectedIndex = 0;
            CbxEspecialidadeValor.SelectedIndex = 0;
            CbxFormaPagto.SelectedIndex = 0;
        }

        private void TsbExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O agendamento foi excluido");
        }

        private void CbxEspecialidadeValor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!CbxEspecialidadeValor.Text.Equals("Selecione"))
            {
                CbxMedico.DataSource = servico.BuscarMedico(CbxEspecialidadeValor.Text);
            }           
        }

        private void DgvAgendamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DgvAgendamento.EndEdit();
            }
        }

        private AgendamentoDTO CarregaAgendamentoDto()
        {
            AgendamentoDTO agendamento = new AgendamentoDTO()
            {
                Codigo = string.IsNullOrWhiteSpace(TbxCodigo.Text) ? 0L : long.Parse(TbxCodigo.Text),
                DataHorario = DateTime.Parse(MskDataHorario.Text),
                Paciente = CbxPaciente.Text,
                Medico = CbxMedico.Text,
                EspecialidadeValor = CbxEspecialidadeValor.Text,
                FormaPagamento = CbxFormaPagto.Text
            };

            return agendamento;
        }

        private void FrmAgendamento_Shown_1(object sender, EventArgs e)
        {
            TbxCodigo.Focus();
            CarregarTabela();
        }
    }
}
