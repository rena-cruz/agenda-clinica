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

        public static bool ValidaCodigoPaciente(long pCodigo)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append($" SELECT COUNT(1) FROM paciente a WHERE a.seqpaciente = :seqpaciente");

                OracleCommand comando = new OracleCommand();
                comando.Connection = ConexaoBD.AbrirConexao(stringConexao);
                comando.CommandText = sql.ToString();
                comando.Parameters.Add(":seqpaciente", OracleDbType.Int64).Value = pCodigo;
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

        public static bool ValidaCodigoAgendamento(long pCodigo)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append($" SELECT COUNT(1) FROM agendamento a WHERE a.seqagendamento = :seqagendamento");

                OracleCommand comando = new OracleCommand();
                comando.Connection = ConexaoBD.AbrirConexao(stringConexao);
                comando.CommandText = sql.ToString();
                comando.Parameters.Add(":seqagendamento", OracleDbType.Int64).Value = pCodigo;
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

        public static List<string> BuscarSituacaoFinanceira()
        {
            try
            {
                List<string> listaSituacaoFinanceira = new List<string>();

                StringBuilder sql = new StringBuilder();
                sql.Append($" SELECT a.indfinanceiro FROM situacaofinanceira a ORDER BY a.seqfinanceiro ");

                OracleCommand comando = new OracleCommand();
                comando.Connection = ConexaoBD.AbrirConexao(stringConexao);
                comando.CommandText = sql.ToString();
                OracleDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    listaSituacaoFinanceira.Add(reader.GetString(0));
                }

                reader.Dispose();
                ConexaoBD.FecharConexao();

                return listaSituacaoFinanceira;
            }
            catch (Exception ex)
            {
                ConexaoBD.FecharConexao();
                throw ex;
            }
        }

        public static List<string> BuscarPaciente()
        {
            try
            {
                List<string> listaPaciente = new List<string>();

                StringBuilder sql = new StringBuilder();
                sql.Append($" SELECT a.nome FROM paciente a ORDER BY a.seqpaciente ");

                OracleCommand comando = new OracleCommand();
                comando.Connection = ConexaoBD.AbrirConexao(stringConexao);
                comando.CommandText = sql.ToString();
                OracleDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    listaPaciente.Add(reader.GetString(0));
                }

                reader.Dispose();
                ConexaoBD.FecharConexao();

                return listaPaciente;
            }
            catch (Exception ex)
            {
                ConexaoBD.FecharConexao();
                throw ex;
            }
        }

        public static List<string> BuscarMedico(string pEspecialidade)
        {
            try
            {
                List<string> listaMedico = new List<string>();

                StringBuilder sql = new StringBuilder();
                sql.Append($" SELECT a.nome ");
                sql.Append($" FROM medico a, especialidademedico b ");
                sql.Append($" WHERE a.seqespecialidade = b.seqespecialidade ");
                sql.Append($" AND b.especialidade = :especialidade ");
                sql.Append($" ORDER BY a.nome ");

                OracleCommand comando = new OracleCommand();
                comando.Connection = ConexaoBD.AbrirConexao(stringConexao);
                comando.CommandText = sql.ToString();
                comando.Parameters.Add(":especialidade", OracleDbType.Varchar2).Value = pEspecialidade;
                OracleDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    listaMedico.Add(reader.GetString(0));
                }

                reader.Dispose();
                ConexaoBD.FecharConexao();

                return listaMedico;
            }
            catch (Exception ex)
            {
                ConexaoBD.FecharConexao();
                throw ex;
            }
        }

        public static List<string> BuscarEspecialidadeValor()
        {
            try
            {
                List<string> listaEspecialidadeValor = new List<string>();

                StringBuilder sql = new StringBuilder();
                sql.Append($" SELECT a.especialidade || ' - ' || a.vlrpadraoconsulta FROM especialidademedico a ORDER BY a.seqespecialidade ");

                OracleCommand comando = new OracleCommand();
                comando.Connection = ConexaoBD.AbrirConexao(stringConexao);
                comando.CommandText = sql.ToString();
                OracleDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    listaEspecialidadeValor.Add(reader.GetString(0));
                }

                reader.Dispose();
                ConexaoBD.FecharConexao();

                return listaEspecialidadeValor;
            }
            catch (Exception ex)
            {
                ConexaoBD.FecharConexao();
                throw ex;
            }
        }

        public static List<string> BuscarFormaPagamento()
        {
            try
            {
                List<string> listaFormaPagamento = new List<string>();

                StringBuilder sql = new StringBuilder();
                sql.Append($" SELECT a.formapagto FROM formapagto a ORDER BY a.formapagto ");

                OracleCommand comando = new OracleCommand();
                comando.Connection = ConexaoBD.AbrirConexao(stringConexao);
                comando.CommandText = sql.ToString();
                OracleDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    listaFormaPagamento.Add(reader.GetString(0));
                }

                reader.Dispose();
                ConexaoBD.FecharConexao();

                return listaFormaPagamento;
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

        public static List<MedicoJornadaDTO> RetornaJornadaMedicoPorNome(string pNomeMedico)
        {
            try
            {
                List<MedicoJornadaDTO> listaJornada = new List<MedicoJornadaDTO>();

                StringBuilder sql = new StringBuilder();
                sql.Append($" SELECT b.seqjornada, c.periodo, d.diasemana ");
                sql.Append($" FROM jornadamedico a, jornada b, periodo c, diasemana d, medico e ");
                sql.Append($" WHERE e.nome = :nome ");
                sql.Append($" AND b.seqjornada = a.seqjornada ");
                sql.Append($" AND c.seqperiodo = b.seqperiodo ");
                sql.Append($" AND d.seqdiasemana = b.seqdiasemana ");
                sql.Append($" AND a.crm = e.crm ");
                sql.Append($" ORDER BY a.seqjornada ");
  
                OracleCommand comando = new OracleCommand();
                comando.Connection = ConexaoBD.AbrirConexao(stringConexao);
                comando.CommandText = sql.ToString();
                comando.Parameters.Add(":nome", OracleDbType.Varchar2).Value = pNomeMedico;
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

        public static List<AgendamentoDTO> RetornaAgendamento()
        {
            try
            {
                List<AgendamentoDTO> listaAgendamento = new List<AgendamentoDTO>();

                StringBuilder sql = new StringBuilder();
                sql.Append($" SELECT a.seqagendamento, a.dtahoragendamento, b.nome, c.nome, d.formapagto, e.especialidade || ' - ' || a.vlragendamento ");
                sql.Append($" FROM agendamento a, medico b, paciente c, formapagto d, especialidademedico e ");
                sql.Append($" WHERE a.crm = b.crm ");
                sql.Append($" AND a.seqpaciente = c.seqpaciente ");
                sql.Append($" AND a.seqformapagto = d.seqformapagto ");
                sql.Append($" AND b.seqespecialidade = e.seqespecialidade ");
                sql.Append($" ORDER BY a.dtahoragendamento desc ");

                OracleCommand comando = new OracleCommand();
                comando.Connection = ConexaoBD.AbrirConexao(stringConexao);
                comando.CommandText = sql.ToString();
                OracleDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    listaAgendamento.Add(new AgendamentoDTO()
                    {
                        Codigo = reader.GetInt64(0),
                        DataHorario = reader.GetDateTime(1),
                        Paciente = reader.GetString(3),
                        EspecialidadeValor = reader.GetString(5),
                        Medico = reader.GetString(2),
                        FormaPagamento = reader.GetString(4)
                    });
                }

                reader.Dispose();
                ConexaoBD.FecharConexao();

                return listaAgendamento;
            }
            catch (Exception ex)
            {
                ConexaoBD.FecharConexao();
                throw ex;
            }
        }

        public static AgendamentoDTO RetornaAgendamento(long pSeqAgendamento)
        {
            try
            {
                AgendamentoDTO agendamento = new AgendamentoDTO();

                StringBuilder sql = new StringBuilder();
                sql.Append($" SELECT a.seqagendamento, a.dtahoragendamento, b.nome, c.nome, d.formapagto, e.especialidade || ' - ' || a.vlragendamento ");
                sql.Append($" FROM agendamento a, medico b, paciente c, formapagto d, especialidademedico e ");
                sql.Append($" WHERE a.crm = b.crm ");
                sql.Append($" AND a.seqpaciente = c.seqpaciente ");
                sql.Append($" AND a.seqformapagto = d.seqformapagto ");
                sql.Append($" AND b.seqespecialidade = e.seqespecialidade ");
                sql.Append($" AND a.seqagendamento = :seqagendamento ");
                sql.Append($" ORDER BY a.dtahoragendamento desc ");

                OracleCommand comando = new OracleCommand();
                comando.Connection = ConexaoBD.AbrirConexao(stringConexao);
                comando.CommandText = sql.ToString();
                comando.Parameters.Add(":seqagendamento", OracleDbType.Int64).Value = pSeqAgendamento;
                OracleDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    agendamento.Codigo = reader.GetInt64(0);
                    agendamento.DataHorario = reader.GetDateTime(1);
                    agendamento.Paciente = reader.GetString(3);
                    agendamento.EspecialidadeValor = reader.GetString(5);
                    agendamento.Medico = reader.GetString(2);
                    agendamento.FormaPagamento = reader.GetString(4);                    
                }

                reader.Dispose();
                ConexaoBD.FecharConexao();

                return agendamento;
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

        public static MedicoDTO RetornaMedicoPorNome(string pNome)
        {
            try
            {
                MedicoDTO medico = new MedicoDTO();

                StringBuilder sql = new StringBuilder();
                sql.Append($" SELECT a.nome, a.email, a.crm, b.especialidade ");
                sql.Append($" FROM medico a, especialidademedico b ");
                sql.Append($" WHERE a.nome = :nome ");
                sql.Append($" AND b.seqespecialidade = a.seqespecialidade ");

                OracleCommand comando = new OracleCommand();
                comando.Connection = ConexaoBD.AbrirConexao(stringConexao);
                comando.CommandText = sql.ToString();
                comando.Parameters.Add(":nome", OracleDbType.Varchar2).Value = pNome;
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

        public static PacienteDTO RetornaPacientePorNome(string pNome)
        {
            try
            {
                PacienteDTO paciente = new PacienteDTO();

                StringBuilder sql = new StringBuilder();
                sql.Append($" SELECT a.seqpaciente, a.nome, a.email, a.dtanascimento, a.telefone, b.indfinanceiro ");
                sql.Append($" FROM paciente a, situacaofinanceira b ");
                sql.Append($" WHERE a.nome = :nome ");
                sql.Append($" AND b.seqfinanceiro = a.seqfinanceiro ");

                OracleCommand comando = new OracleCommand();
                comando.Connection = ConexaoBD.AbrirConexao(stringConexao);
                comando.CommandText = sql.ToString();
                comando.Parameters.Add(":nome", OracleDbType.Varchar2).Value = pNome;
                OracleDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    paciente.Codigo = reader.GetInt64(0);
                    paciente.Nome = reader.GetString(1);
                    paciente.Email = reader.GetString(2);
                    paciente.DataNascimento = reader.GetDateTime(3);
                    paciente.Celular = reader.GetString(4);
                    paciente.SituacaoFinanceira = reader.GetString(5);
                }

                reader.Dispose();
                ConexaoBD.FecharConexao();

                return paciente;
            }
            catch (Exception ex)
            {
                ConexaoBD.FecharConexao();
                throw ex;
            }
        }

        public static PacienteDTO RetornarPaciente(long pCodigo)
        {
            try
            {
                PacienteDTO paciente = new PacienteDTO();

                StringBuilder sql = new StringBuilder();
                sql.Append($" SELECT a.seqpaciente, a.nome, a.email, a.dtanascimento, a.telefone, b.indfinanceiro ");
                sql.Append($" FROM paciente a, situacaofinanceira b ");
                sql.Append($" WHERE a.seqpaciente = :seqpaciente ");
                sql.Append($" AND b.seqfinanceiro = a.seqfinanceiro ");

                OracleCommand comando = new OracleCommand();
                comando.Connection = ConexaoBD.AbrirConexao(stringConexao);
                comando.CommandText = sql.ToString();
                comando.Parameters.Add(":seqpaciente", OracleDbType.Long).Value = pCodigo;
                OracleDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    paciente.Codigo = reader.GetInt64(0);
                    paciente.Nome = reader.GetString(1);
                    paciente.Email = reader.GetString(2);
                    paciente.DataNascimento = reader.GetDateTime(3);
                    paciente.Celular = reader.GetString(4);
                    paciente.SituacaoFinanceira = reader.GetString(5);
                }

                reader.Dispose();
                ConexaoBD.FecharConexao();

                return paciente;
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

        public static long BuscarSeqFinanceiro(string pFinanceiro)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append($" SELECT a.seqfinanceiro FROM situacaofinanceira a WHERE a.indfinanceiro = :indfinanceiro ");

                OracleCommand comando = new OracleCommand();
                comando.Connection = ConexaoBD.AbrirConexao(stringConexao);
                comando.CommandText = sql.ToString();
                comando.Parameters.Add(":indfinanceiro", OracleDbType.Varchar2).Value = pFinanceiro;
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

        public static long BuscarSeqFormaPagamento(string pFormaPagamento)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append($" SELECT a.seqformapagto FROM formapagto a WHERE a.formapagto = :formapagto ");

                OracleCommand comando = new OracleCommand();
                comando.Connection = ConexaoBD.AbrirConexao(stringConexao);
                comando.CommandText = sql.ToString();
                comando.Parameters.Add(":formapagto", OracleDbType.Varchar2).Value = pFormaPagamento;
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
