using AgendaClinica.DTO;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Text;

namespace AgendaClinica.Repositorio
{
    internal static class OperacaoBD
    {
        public static string stringConexao = "";

        public static bool ExisteUsuario(LoginDTO pDadosLogin)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append($" SELECT SeqUsuario FROM Usuario WHERE UPPER(login) = :login AND senha = :senha ");

                OracleCommand comando = new OracleCommand();
                comando.Connection = ConexaoBD.AbrirConexao(stringConexao);
                comando.CommandText = sql.ToString();
                comando.Parameters.Add(":login", OracleDbType.Varchar2).Value = pDadosLogin.Login.ToUpper();
                comando.Parameters.Add(":senha", OracleDbType.Varchar2).Value = pDadosLogin.Senha;
                var seqUsuario = comando.ExecuteScalar();

                ConexaoBD.FecharConexao();

                return seqUsuario != null;         
            }
            catch(Exception ex)
            {
                ConexaoBD.FecharConexao();
                throw ex;
            }
        }
    }
}
