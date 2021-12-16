using System;
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
    public partial class FrmInicial : Form
    {
        public FrmInicial()
        {
            InitializeComponent();
        }

        private void FrmInicial_Load(object sender, EventArgs e)
        {
            FrmLogin telaLogin = new FrmLogin();
            telaLogin.ShowDialog();
            if (telaLogin.Logar)
            {
                telaLogin.Dispose();
            }
            else
            {
                Close();
                Dispose();
            }
        }

        private void BtnCadastroMedico_Click(object sender, EventArgs e)
        {
            FrmMedico telaMedico = new FrmMedico();
            telaMedico.Show();
        }

        private void BtnCadastroPaciente_Click(object sender, EventArgs e)
        {
            FrmPaciente telaPaciente = new FrmPaciente();
            telaPaciente.Show();
        }

        private void BtnAgendamento_Click(object sender, EventArgs e)
        {
            FrmAgendamento telaAgendamento = new FrmAgendamento();
            telaAgendamento.Show();
        }
    }
}
