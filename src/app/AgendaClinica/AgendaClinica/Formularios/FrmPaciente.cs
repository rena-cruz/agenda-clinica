﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaClinica.Formularios
{
    public partial class FrmPaciente : Form
    {
        public FrmPaciente()
        {
            InitializeComponent();
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
            MessageBox.Show("O registro foi limpado");
        }

        private void TsbExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O registro foi excluido");
        }
    }
}