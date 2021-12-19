using AgendaClinica.Servico;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AgendaClinica.Formularios
{
    public partial class FrmAgendamento : Form
    {
        Service servico; 

        public FrmAgendamento()
        {
            InitializeComponent();
            servico = new Service();
            CarregarComboBox();
        }

        private void CarregarComboBox()
        {
            List<string> listaEspecialidadeValor = new List<string>();
            listaEspecialidadeValor.Add("Selecione");
            listaEspecialidadeValor.Add("Cardiologia R$190,00");
            listaEspecialidadeValor.Add("Geriatria R$100,00");
            CbxEspecialidadeValor.DataSource = listaEspecialidadeValor;

            List<string> listaFormaPagamento = new List<string>();
            listaFormaPagamento.Add("Selecione");
            listaFormaPagamento.Add("Boleto");
            listaFormaPagamento.Add("Cartão");
            CbxFormaPagto.DataSource = listaFormaPagamento;
        }

        private void TsbSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O agendamento foi salvo");
        }

        private void TsbPesquisar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pesquisa ok");
        }

        private void TsbLimpar_Click(object sender, EventArgs e)
        {
            TbxCodigo.Clear();
            MskDataHorario.Clear();
            TbxPaciente.Clear();
            TbxMedico.Clear();
            CbxEspecialidadeValor.SelectedIndex = 0;
            CbxFormaPagto.SelectedIndex = 0;
        }

        private void TsbExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O agendamento foi excluido");
        }

        private void FrmAgendamento_Shown(object sender, EventArgs e)
        {
            TbxCodigo.Focus();
        }
    }
}
