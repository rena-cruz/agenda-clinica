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

        public FrmMedico()
        {
            InitializeComponent();
            servico = new Service();
            CarregarComboBox();
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jornada excluida");
        }

        private void CarregarComboBox()
        {
            List<string> listaEspecialidade = new List<string>();
            listaEspecialidade.Add("Selecione");
            listaEspecialidade.Add("Teste");
            CbxEspecialidade.DataSource = listaEspecialidade;

            List<string> listaDiaSemana = new List<string>();
            listaDiaSemana.Add("Selecione");
            listaDiaSemana.Add("Teste");
            CbxDiaSemana.DataSource = listaDiaSemana;

            List<string> listaPeriodo = new List<string>();
            listaPeriodo.Add("Selecione");
            listaPeriodo.Add("Teste");
            CbxPeriodo.DataSource = listaPeriodo;
        }

        private void TsbSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O registro foi salvo");
        }

        private void TsbPesquisar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pesquisa ok");
        }

        private void TsbLimpar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O registro foi limpo");
        }

        private void TsbIncluirJornada_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro incluido com sucesso");
        }

        private void TsbExcluirJornada_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O registro foi excluido");
        }
    }
}
