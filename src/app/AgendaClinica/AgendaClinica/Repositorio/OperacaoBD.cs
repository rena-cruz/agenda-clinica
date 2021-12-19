using AgendaClinica.DTO;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
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

        public static List<string> BuscarEspecialidade()
        {
            try
            {
                List<string> listaEspecialidade = new List<string>();

                StringBuilder sql = new StringBuilder();
                sql.Append($" SELECT a.ESPECIALIDADE FROM EspecialidadeMedico a ORDER BY a.ESPECIALIDADE ");

                OracleCommand comando = new OracleCommand();
                comando.Connection = ConexaoBD.AbrirConexao(stringConexao);
                comando.CommandText = sql.ToString();
                OracleDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    listaEspecialidade.Add(reader.GetString(0));
                }

                reader.Dispose();
                ConexaoBD.FecharConexao();

                return listaEspecialidade;
            }
            catch (Exception ex)
            {
                ConexaoBD.FecharConexao();
                throw ex;
            }
        }

        public static List<string> BuscarDiaSemana()
        {
            try
            {
                List<string> listaDiaSemana = new List<string>();

                StringBuilder sql = new StringBuilder();
                sql.Append($" SELECT a.diasemana FROM DiaSemana a ORDER BY a.seqdiasemana ");

                OracleCommand comando = new OracleCommand();
                comando.Connection = ConexaoBD.AbrirConexao(stringConexao);
                comando.CommandText = sql.ToString();
                OracleDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    listaDiaSemana.Add(reader.GetString(0));
                }

                reader.Dispose();
                ConexaoBD.FecharConexao();

                return listaDiaSemana;
            }
            catch (Exception ex)
            {
                ConexaoBD.FecharConexao();
                throw ex;
            }
        }

        public static List<string> BuscarPeriodo()
        {
            try
            {
                List<string> listaPeriodo = new List<string>();

                StringBuilder sql = new StringBuilder();
                sql.Append($" SELECT a.periodo FROM periodo a ORDER BY a.seqperiodo ");

                OracleCommand comando = new OracleCommand();
                comando.Connection = ConexaoBD.AbrirConexao(stringConexao);
                comando.CommandText = sql.ToString();
                OracleDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    listaPeriodo.Add(reader.GetString(0));
                }

                reader.Dispose();
                ConexaoBD.FecharConexao();

                return listaPeriodo;
            }
            catch (Exception ex)
            {
                ConexaoBD.FecharConexao();
                throw ex;
            }
        }
    }
}
