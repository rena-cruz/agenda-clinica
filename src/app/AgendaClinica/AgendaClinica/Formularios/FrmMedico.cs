﻿using AgendaClinica.Servico;
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

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O registro foi salvo");
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pesquisa ok");
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O registro foi limpo");
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            var diaSemana = CbxDiaSemana.SelectedItem.ToString();
            var periodo = CbxPeriodo.SelectedItem.ToString();
            if (diaSemana == "Selecione" || periodo == "Selecione")
            {
                MessageBox.Show("Selecione o valor correto");
            }
            else
            {
                string[] linha = { null, diaSemana, periodo };
                DgvJornada.Rows.Add(linha);
            }
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
    }
}
