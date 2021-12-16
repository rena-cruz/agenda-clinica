using AgendaClinica.DTO;
using AgendaClinica.Repositorio;
using System.IO;

namespace AgendaClinica.Servico
{
    internal class Service
    {
        public Service() 
        {
            OperacaoBD.stringConexao = RetornaStringConexao();
        }

        public bool Logar(LoginDTO pDadosLogin)
        {
            return OperacaoBD.ExisteUsuario(pDadosLogin);
        }

        private string RetornaStringConexao()
        {
            return File.ReadAllText(@"bdconfig.txt");
        }
    }
}
