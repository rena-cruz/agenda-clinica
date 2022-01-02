using AgendaClinica.Repositorio.DTO;
using AgendaClinica.Servico;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AgendaClinica.Formularios
{
    public partial class FrmMedico : Form
    {
        Service servico;

        DataTable dtJornada;

        public FrmMedico()
        {
            InitializeComponent();
            servico = new Service();
            CarregarComboBox();

            dtJornada = new DataTable();
            dtJornada.Columns.Add("Check", typeof(bool));
            dtJornada.Columns.Add("Dia", typeof(string));
            dtJornada.Columns.Add("Periodo", typeof(string));
            dtJornada.Columns.Add("SeqJornada", typeof(long));
            DgvJornada.DataSource = dtJornada;
        }

        private void CarregarComboBox()
        {
            try
            {
                CbxEspecialidade.DataSource = servico.BuscarEspecialidade();
                CbxDiaSemana.DataSource = servico.BuscarDiaSemana();
                CbxPeriodo.DataSource = servico.BuscarPeriodo();
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
                servico.SalvarMedico(CarregaMedicoDto());
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
                if (string.IsNullOrWhiteSpace(TbxCRM.Text))
                {
                    MessageBox.Show("Informe o numero do CRM");
                    return;
                }

                if (!string.IsNullOrWhiteSpace(TbxNome.Text) || !string.IsNullOrWhiteSpace(TbxEmail.Text) ||
                    !CbxEspecialidade.Text.Equals("Selecione") || dtJornada.Rows.Count > 0)
                {
                    MessageBox.Show("Limpe a tela e informe o CRM");
                    return;
                }

                var medico = servico.CarregarMedicoJornada(TbxCRM.Text);

                if (TbxCRM.Text.Equals(medico.Crm))
                {
                    TbxNome.Text = medico.Nome;
                    TbxEmail.Text = medico.Email;
                    TbxCRM.Text = medico.Crm;
                    CbxEspecialidade.SelectedItem = medico.Especialidade;

                    foreach (MedicoJornadaDTO item in medico.Jornada)
                    {
                        DataRow dr = dtJornada.NewRow();
                        dr["Check"] = false;
                        dr["Dia"] = item.DiaSemana;
                        dr["Periodo"] = item.Periodo;
                        dr["SeqJornada"] = item.SeqJornada;
                        dtJornada.Rows.Add(dr);
                    }
                }
                else
                {
                    MessageBox.Show("O CRM informado não existe");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar os dados do banco.\n{ex.Message}");
            }
        }

        private void TsbLimpar_Click(object sender, EventArgs e)
        {
            TbxNome.Clear();
            TbxEmail.Clear();
            TbxCRM.Clear();
            CbxEspecialidade.SelectedIndex = 0;
            CbxDiaSemana.SelectedIndex = 0;
            CbxPeriodo.SelectedIndex = 0;
            dtJornada.Rows.Clear();
            TbxNome.Focus();
        }

        private void TsbIncluirJornada_Click(object sender, EventArgs e)
        {
            if (CbxDiaSemana.Text == "Selecione")
            {
                MessageBox.Show("Informe um dia da semana válido");
                return;
            }

            if (CbxPeriodo.Text == "Selecione")
            {
                MessageBox.Show("Informe um periodo válido");
                return;
            }

            DataRow dr = dtJornada.NewRow();
            dr["Check"] = false;
            dr["Dia"] = CbxDiaSemana.Text;
            dr["Periodo"] = CbxPeriodo.Text;
            dr["SeqJornada"] = 0L;
            dtJornada.Rows.Add(dr);
        }

        private void TsbExcluirJornada_Click(object sender, EventArgs e)
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
                    for (int i = 0; i < DgvJornada.Rows.Count; i++)
                    {
                        if ((bool)DgvJornada.Rows[i].Cells[0].Value)
                        {
                            indice = i;
                            break;
                        }
                    }

                    if (indice > -1)
                    {
                        if ((long)DgvJornada.Rows[indice].Cells["DgvSeqJornada"].Value > 0L)
                        {
                            servico.RemoverJornada((long)DgvJornada.Rows[indice].Cells["DgvSeqJornada"].Value);
                        }
                        dtJornada.Rows.RemoveAt(indice);
                    }
                } while (indice > -1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possivel excluir a jornada.\n{ex.Message}");
            }
        }

        private void FrmMedico_Shown(object sender, EventArgs e)
        {
            TbxNome.Focus();
        }

        private void DgvJornada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DgvJornada.EndEdit();
            }
        }

        private MedicoDTO CarregaMedicoDto()
        {
            List<MedicoJornadaDTO> jornada = new List<MedicoJornadaDTO>();
            foreach (DataGridViewRow linha in DgvJornada.Rows)
            {
                if ((long)linha.Cells["DgvSeqJornada"].Value == 0L)
                {
                    jornada.Add(new MedicoJornadaDTO()
                    {
                        DiaSemana = linha.Cells[1].Value.ToString(),
                        Periodo = linha.Cells[2].Value.ToString()
                    });
                }
            }

            MedicoDTO medico = new MedicoDTO()
            {
                Nome = TbxNome.Text,
                Email = TbxEmail.Text,
                Crm = TbxCRM.Text,
                Especialidade = CbxEspecialidade.Text,
                Jornada = jornada
            };

            return medico;
        }
    }
}
