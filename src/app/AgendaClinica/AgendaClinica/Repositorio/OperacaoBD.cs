using AgendaClinica.DTO;
using AgendaClinica.Repositorio.DTO;
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

        public static MedicoDTO RetornarMedico(string pCrm)
        {
            try
            {
                MedicoDTO medico = new MedicoDTO();

                StringBuilder sql = new StringBuilder();
                sql.Append($" SELECT a.nome, a.email, a.crm, b.especialidade ");
                sql.Append($" FROM medico a, especialidademedico b ");
                sql.Append($" WHERE a.crm = :crm ");
                sql.Append($" AND b.seqespecialidade = a.seqespecialidade ");

                OracleCommand comando = new OracleCommand();
                comando.Connection = ConexaoBD.AbrirConexao(stringConexao);
                comando.CommandText = sql.ToString();
                comando.Parameters.Add(":crm", OracleDbType.Varchar2).Value = pCrm;
                OracleDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    medico.Nome = reader.GetString(0);
                    medico.Email = reader.GetString(1);
                    medico.Crm = reader.GetString(2);
                    medico.Especialidade = reader.GetString(3);
                }

                reader.Dispose();
                ConexaoBD.FecharConexao();

                return medico;
            }
            catch (Exception ex)
            {
                ConexaoBD.FecharConexao();
                throw ex;
            }
        }

        public static List<MedicoJornadaDTO> RetornaJornadaMedico(string pCrm)
        {
            try
            {
                List<MedicoJornadaDTO> listaJornada = new List<MedicoJornadaDTO>();

                StringBuilder sql = new StringBuilder();
                sql.Append($" SELECT b.seqjornada, c.periodo, d.diasemana ");
                sql.Append($" FROM jornadamedico a, jornada b, periodo c, diasemana d ");
                sql.Append($" WHERE a.crm = :crm ");
                sql.Append($" AND b.seqjornada = a.seqjornada ");
                sql.Append($" AND c.seqperiodo = b.seqperiodo ");
                sql.Append($" AND d.seqdiasemana = b.seqdiasemana ");
                sql.Append($" ORDER BY a.seqjornada ");

                OracleCommand comando = new OracleCommand();
                comando.Connection = ConexaoBD.AbrirConexao(stringConexao);
                comando.CommandText = sql.ToString();
                comando.Parameters.Add(":crm", OracleDbType.Varchar2).Value = pCrm;
                OracleDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    listaJornada.Add(new MedicoJornadaDTO()
                    {
                        SeqJornada = reader.GetInt64(0),
                        Periodo = reader.GetString(1),
                        DiaSemana = reader.GetString(2)
                    });
                }

                reader.Dispose();
                ConexaoBD.FecharConexao();

                return listaJornada;
            }
            catch (Exception ex)
            {
                ConexaoBD.FecharConexao();
                throw ex;
            }
        }

        public static long BuscarSeqEspecialidade(string pEspecialidade)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append($" SELECT a.seqespecialidade FROM especialidademedico a WHERE a.especialidade = :especialidade ");

                OracleCommand comando = new OracleCommand();
                comando.Connection = ConexaoBD.AbrirConexao(stringConexao);
                comando.CommandText = sql.ToString();
                comando.Parameters.Add(":especialidade", OracleDbType.Varchar2).Value = pEspecialidade;
                var sequence = comando.ExecuteScalar();

                ConexaoBD.FecharConexao();

                return long.Parse(sequence.ToString());
            }
            catch (Exception ex)
            {
                ConexaoBD.FecharConexao();
                throw ex;
            }
        }

        public static long BuscarSeqDiaSemana(string pDiaSemana)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append($" SELECT a.seqdiasemana FROM diasemana a WHERE a.diasemana = :diaSemana ");

                OracleCommand comando = new OracleCommand();
                comando.Connection = ConexaoBD.AbrirConexao(stringConexao);
                comando.CommandText = sql.ToString();
                comando.Parameters.Add(":diaSemana", OracleDbType.Varchar2).Value = pDiaSemana;
                var sequence = comando.ExecuteScalar();

                ConexaoBD.FecharConexao();

                return long.Parse(sequence.ToString());
            }
            catch (Exception ex)
            {
                ConexaoBD.FecharConexao();
                throw ex;
            }
        }

        public static long BuscarSeqPeriodo(string pPeriodo)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append($" SELECT a.seqperiodo FROM periodo a WHERE a.periodo = :periodo ");

                OracleCommand comando = new OracleCommand();
                comando.Connection = ConexaoBD.AbrirConexao(stringConexao);
                comando.CommandText = sql.ToString();
                comando.Parameters.Add(":periodo", OracleDbType.Varchar2).Value = pPeriodo;
                var sequence = comando.ExecuteScalar();

                ConexaoBD.FecharConexao();

                return long.Parse(sequence.ToString());
            }
            catch (Exception ex)
            {
                ConexaoBD.FecharConexao();
                throw ex;
            }
        }

        public static bool ValidaCrmMedico(string pCrm)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append($" SELECT COUNT(1) FROM medico a WHERE a.crm = :crm ");

                OracleCommand comando = new OracleCommand();
                comando.Connection = ConexaoBD.AbrirConexao(stringConexao);
                comando.CommandText = sql.ToString();
                comando.Parameters.Add(":crm", OracleDbType.Varchar2).Value = pCrm;
                var existe = comando.ExecuteScalar();

                ConexaoBD.FecharConexao();

                return int.Parse(existe.ToString()) == 1;
            }
            catch (Exception ex)
            {
                ConexaoBD.FecharConexao();
                throw ex;
            }
        }

        public static long BuscarProximoValorSequence(string pNomeSequence)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append($" SELECT {pNomeSequence}.Nextval FROM dual ");

                OracleCommand comando = new OracleCommand();
                comando.Connection = ConexaoBD.AbrirConexao(stringConexao);
                comando.CommandText = sql.ToString();
                var sequence = comando.ExecuteScalar();

                ConexaoBD.FecharConexao();

                return long.Parse(sequence.ToString());
            }
            catch (Exception ex)
            {
                ConexaoBD.FecharConexao();
                throw ex;
            }
        }

        public static void ExecutarComando(string pSql)
        {
            try
            {
                OracleCommand comando = new OracleCommand();
                comando.Connection = ConexaoBD.AbrirConexao(stringConexao);
                comando.CommandText = pSql;
                comando.ExecuteNonQuery();

                ConexaoBD.FecharConexao();
            }
            catch (Exception ex)
            {
                ConexaoBD.FecharConexao();
                throw ex;
            }
        }
    }
}
