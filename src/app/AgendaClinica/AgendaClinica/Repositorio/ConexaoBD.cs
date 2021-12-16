using Oracle.ManagedDataAccess.Client;

namespace AgendaClinica.Repositorio
{
    internal static class ConexaoBD
    {
        private static OracleConnection conexao;

        public static OracleConnection AbrirConexao(string pStringConexao)
        {
            conexao = new OracleConnection(pStringConexao);
            conexao.Open();
            return conexao;
        }

        public static void FecharConexao()
        {
            conexao.Close();
            conexao.Dispose();
        }
    }
}
