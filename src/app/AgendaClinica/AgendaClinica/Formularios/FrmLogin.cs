using System;
using System.Windows.Forms;
using AgendaClinica.Servico;
using AgendaClinica.DTO;

namespace AgendaClinica.Formularios
{
    public partial class FrmLogin : Form
    {
        Service servico;

        public bool Logar { get; set; }

        public FrmLogin()
        {
            InitializeComponent();
            servico = new Service();
            Logar = false;
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            LoginDTO dadosLogin = new LoginDTO(TbxLogin.Text, TbxSenha.Text);
            Logar = servico.Logar(dadosLogin);
            if (Logar) 
            {
                Close();
            }
            else
            {
                MessageBox.Show("Usuario ou Senha invalido");
            }
        }
    }
}
