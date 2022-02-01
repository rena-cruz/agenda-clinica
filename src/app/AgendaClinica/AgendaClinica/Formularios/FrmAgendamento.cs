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
                    MessageBox.Show("Selecione o paciente antes de salvar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var seqAgendamento = servico.SalvarAgendamento(CarregaAgendamentoDto());
                TbxCodigo.Text = seqAgendamento.ToString();
                CarregarTabela();

                MessageBox.Show($"O registro foi salvo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o registro.\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TsbPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                var agendamento = servico.BuscarAgendamento(long.Parse(TbxCodigo.Text));
                if (TbxCodigo.Text.Equals(agendamento.Codigo.ToString()))
                {
                    TbxCodigo.Text = agendamento.Codigo.ToString();
                    MskDataHorario.Text = agendamento.DataHorario.ToString("dd/MM/yyyy HH:mm:ss");
                    CbxPaciente.Text = agendamento.Paciente;
                    CbxEspecialidadeValor.Text = agendamento.EspecialidadeValor;
                    CbxMedico.Text = agendamento.Medico;
                    CbxFormaPagto.Text = agendamento.FormaPagamento;
                }
                else
                {
                    MessageBox.Show("O código informado não existe", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar os dados do banco\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"Erro ao carregar a tabela\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            int indice;

            if (MessageBox.Show("Confirma a exclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            try
            {
                do
                {
                    indice = -1;
                    for (int i = 0; i < DgvAgendamento.Rows.Count; i++)
                    {
                        if ((bool)DgvAgendamento.Rows[i].Cells[0].Value)
                        {
                            indice = i;
                            break;
                        }
                    }

                    if (indice > -1)
                    {
                        if ((long)DgvAgendamento.Rows[indice].Cells["DgvCodigo"].Value > 0L)
                        {
                            servico.RemoverAgendamento((long)DgvAgendamento.Rows[indice].Cells["DgvCodigo"].Value);
                        }
                        dtAgendamento.Rows.RemoveAt(indice);
                    }
                } while (indice > -1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possivel excluir o agendamento.\n{ex.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void CbxMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(CbxMedico.Text) || CbxMedico.Text.Equals("Selecione")) { return; }

                var dataHora = DateTime.Parse(MskDataHorario.Text); 
                if (!servico.DataHorarioMedicoDisponivel(dataHora, CbxMedico.Text))
                {
                    MessageBox.Show($"Verifique a jornada do médico.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar os dados do banco\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MskDataHorario_Validated(object sender, EventArgs e)
        {
            DateTime dataAgendamento;
            try
            {
                dataAgendamento = DateTime.Parse(MskDataHorario.Text);
            }
            catch (Exception)
            {
                return;
            }

            if (!string.IsNullOrEmpty(MskDataHorario.Text) && servico.HoraAgendamentoValida(dataAgendamento))
            {
                CbxMedico_SelectedIndexChanged(null, null);
            }
            else
            {
                MessageBox.Show($"Horário inválido.\n Agendamento permitido a cada 1 hora", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MskDataHorario.Focus();
            }
        }

        private void CbxPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!CbxPaciente.Text.Equals("Selecione"))
            {
                CbxEspecialidadeValor.DataSource = servico.BuscarEspecialidadeValor(CbxPaciente.Text);
                CbxFormaPagto.DataSource = servico.BuscarFormaPagamento(CbxPaciente.Text);
            }
        }
    }
}
