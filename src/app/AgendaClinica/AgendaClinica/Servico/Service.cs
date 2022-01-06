using AgendaClinica.DTO;
using AgendaClinica.Helper;
using AgendaClinica.Repositorio;
using AgendaClinica.Repositorio.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

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

        #region ComboBox

        public List<string> BuscarEspecialidade()
        {
            try
            {
                var especialidades = OperacaoBD.BuscarEspecialidade();
                especialidades.Insert(0,"Selecione");
                return especialidades;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> BuscarDiaSemana()
        {
            try
            {
                var diasSemana = OperacaoBD.BuscarDiaSemana();
                diasSemana.Insert(0, "Selecione");
                return diasSemana;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> BuscarPeriodo()
        {
            try
            {
                var periodos = OperacaoBD.BuscarPeriodo();
                periodos.Insert(0, "Selecione");
                return periodos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> BuscarSituacaoFinanceira()
        {
            try
            {
                var situacaoFinanceira = OperacaoBD.BuscarSituacaoFinanceira();
                situacaoFinanceira.Insert(0, "Selecione");
                return situacaoFinanceira;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> BuscarPaciente()
        {
            try
            {
                var paciente = OperacaoBD.BuscarPaciente();
                paciente.Insert(0, "Selecione");
                return paciente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> BuscarMedico(string pEspecialidadeValor)
        {
            try
            {
                string especialidade = pEspecialidadeValor.Split('-')[0].Trim();
                var medico = OperacaoBD.BuscarMedico(especialidade);
                medico.Insert(0, "Selecione");
                return medico;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> BuscarEspecialidadeValor()
        {
            try
            {
                var especialidadeValor = OperacaoBD.BuscarEspecialidadeValor();
                especialidadeValor.Insert(0, "Selecione");
                return especialidadeValor;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> BuscarFormaPagamento()
        {
            try
            {
                var formaPagamento = OperacaoBD.BuscarFormaPagamento();
                formaPagamento.Insert(0, "Selecione");
                return formaPagamento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Medico

        public void RemoverJornada(long pSeqJornada)
        {
            try
            {
                string sql = $"DELETE FROM jornadamedico WHERE seqjornada = {pSeqJornada}";
                OperacaoBD.ExecutarComando(sql);
                sql = $"DELETE FROM jornada WHERE seqjornada = {pSeqJornada}";
                OperacaoBD.ExecutarComando(sql);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        
        public MedicoDTO CarregarMedicoJornada(string pCrm)
        {
            try
            {
                var medico = OperacaoBD.RetornarMedico(pCrm);
                medico.Jornada = OperacaoBD.RetornaJornadaMedico(pCrm);
                return medico;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SalvarMedico(MedicoDTO pMedico)
        {
            try
            {
                if (VerificaMedicoExistente(pMedico.Crm))
                {
                    AtualizarMedico(pMedico);
                }
                else
                {
                    IncluirMedico(pMedico);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool VerificaMedicoExistente(string pCrm)
        {
            return OperacaoBD.ValidaCrmMedico(pCrm);
        }

        private void IncluirMedico(MedicoDTO pMedico)
        {
            try
            {
                StringBuilder sql = new StringBuilder();

                var seqEspecialidade = OperacaoBD.BuscarSeqEspecialidade(pMedico.Especialidade);

                sql.AppendLine($"INSERT INTO medico(nome, crm, email, seqespecialidade) ");
                sql.AppendLine($"VALUES('{pMedico.Nome}', '{pMedico.Crm}', '{pMedico.Email}', {seqEspecialidade}) ");
                OperacaoBD.ExecutarComando(sql.ToString());

                IncluirJornada(pMedico.Crm, pMedico.Jornada);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao incluir o médico.\n{ex.Message}");
            }
        }

        private void AtualizarMedico(MedicoDTO pMedico)
        {
            try
            {
                StringBuilder sql = new StringBuilder();

                var seqEspecialidade = OperacaoBD.BuscarSeqEspecialidade(pMedico.Especialidade);

                sql.AppendLine($" UPDATE medico a ");
                sql.AppendLine($" SET a.nome = '{pMedico.Nome}', a.email = '{pMedico.Email}', a.seqespecialidade = {seqEspecialidade} ");
                sql.AppendLine($" WHERE a.crm = '{pMedico.Crm}' ");
                OperacaoBD.ExecutarComando(sql.ToString());

                IncluirJornada(pMedico.Crm, pMedico.Jornada);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar o médico.\n{ex.Message}");
            }
        }

        private void IncluirJornada(string pCrm, List<MedicoJornadaDTO> pJornadas)
        {
            try
            {
                StringBuilder sql = new StringBuilder();

                foreach (var item in pJornadas)
                {
                    sql.Clear();
                    var seqDiaSemana = OperacaoBD.BuscarSeqDiaSemana(item.DiaSemana);
                    var seqPeriodo = OperacaoBD.BuscarSeqPeriodo(item.Periodo);
                    var seqJornada = OperacaoBD.BuscarProximoValorSequence(Constantes.SEQUENCE_TABELA_JORNADA);

                    sql.AppendLine($"INSERT INTO jornada(seqjornada, seqdiasemana, seqperiodo) ");
                    sql.AppendLine($"VALUES({seqJornada}, {seqDiaSemana}, {seqPeriodo}) ");
                    OperacaoBD.ExecutarComando(sql.ToString());


                    sql.Clear();
                    var seqJornadaMedico = OperacaoBD.BuscarProximoValorSequence(Constantes.SEQUENCE_TABELA_JORNADAMEDICO);

                    sql.AppendLine($"INSERT INTO jornadamedico(seqjornadamedico, crm, seqjornada) ");
                    sql.AppendLine($"VALUES({seqJornadaMedico}, '{pCrm}', {seqJornada}) ");
                    OperacaoBD.ExecutarComando(sql.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao incluir a jornada do médico.\n{ex.Message}");
            }
        }

        #endregion

        #region Paciente

        public long SalvarPaciente(PacienteDTO pPaciente)
        {
            try
            {
                if (pPaciente.Codigo > 0L && VerificaPacienteExistente(pPaciente.Codigo))
                {
                    return AtualizarPaciente(pPaciente);
                }
                else
                {
                    return IncluirPaciente(pPaciente);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PacienteDTO CarregarPaciente(long pCodigo)
        {
            try
            {
                var paciente = OperacaoBD.RetornarPaciente(pCodigo);
                return paciente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool VerificaPacienteExistente(long pCodigo)
        {
            return OperacaoBD.ValidaCodigoPaciente(pCodigo);
        }

        private long AtualizarPaciente(PacienteDTO pPaciente)
        {
            try
            {
                StringBuilder sql = new StringBuilder();

                var seqFinanceiro = OperacaoBD.BuscarSeqFinanceiro(pPaciente.SituacaoFinanceira);

                sql.AppendLine($" UPDATE paciente a ");
                sql.AppendLine($" SET a.nome = '{pPaciente.Nome}', a.email = '{pPaciente.Email}', a.dtanascimento = '{pPaciente.DataNascimento.ToString("dd-MMM-yyyy", CultureInfo.InvariantCulture)}', ");
                sql.AppendLine($" a.telefone = {pPaciente.Celular}, a.seqfinanceiro = {seqFinanceiro} ");
                sql.AppendLine($" WHERE a.seqpaciente = {pPaciente.Codigo} ");
                OperacaoBD.ExecutarComando(sql.ToString());

                return pPaciente.Codigo;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar o paciente.\n{ex.Message}");
            }
        }

        private long IncluirPaciente(PacienteDTO pPaciente)
        {
            try
            {
                StringBuilder sql = new StringBuilder();

                var seqPaciente = OperacaoBD.BuscarProximoValorSequence(Constantes.SEQUENCE_TABELA_PACIENTE);
                var seqFinanceiro = OperacaoBD.BuscarSeqFinanceiro(pPaciente.SituacaoFinanceira);

                sql.AppendLine($"INSERT INTO paciente(seqpaciente, nome, email, dtanascimento, telefone, seqfinanceiro) ");
                sql.AppendLine($"VALUES({seqPaciente}, '{pPaciente.Nome}', '{pPaciente.Email}', ");
                sql.AppendLine($" TO_DATE('{pPaciente.DataNascimento.ToString("dd/MM/yyyy")}', 'DD/MM/YYYY'), {pPaciente.Celular}, {seqFinanceiro}) ");
                OperacaoBD.ExecutarComando(sql.ToString());

                return seqPaciente;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao incluir o paciente.\n{ex.Message}");
            }
        }

        #endregion

        #region Agendamento

        public List<AgendamentoDTO> BuscarAgendamento()
        {
            try
            {
                return OperacaoBD.RetornaAgendamento();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public AgendamentoDTO BuscarAgendamento(long pSeqAgendamento)
        {
            try
            {
                return OperacaoBD.RetornaAgendamento(pSeqAgendamento);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long SalvarAgendamento(AgendamentoDTO pAgendamento)
        {
            try
            {
                if (pAgendamento.Codigo > 0L && VerificaAgendamentoExistente(pAgendamento.Codigo))
                {
                    return AtualizarAgendamento(pAgendamento);
                }
                else
                {
                    return IncluirAgendamento(pAgendamento);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool VerificaAgendamentoExistente(long pCodigo)
        {
            return OperacaoBD.ValidaCodigoAgendamento(pCodigo);
        }

        private long AtualizarAgendamento(AgendamentoDTO pAgendamento)
        {
            try
            {
                StringBuilder sql = new StringBuilder();

                var medico = OperacaoBD.RetornaMedicoPorNome(pAgendamento.Medico);
                var paciente = OperacaoBD.RetornaPacientePorNome(pAgendamento.Paciente);
                var seqFormaPagamento = OperacaoBD.BuscarSeqFormaPagamento(pAgendamento.FormaPagamento);

                sql.AppendLine($" UPDATE agendamento a ");
                sql.AppendLine($" SET a.dtahoragendamento = {pAgendamento.DataHorario.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)}, ");
                sql.AppendLine($" a.vlragendamento = '{pAgendamento.EspecialidadeValor}', a.crm = {pAgendamento.Medico}, ");
                sql.AppendLine($" a.seqpaciente = {pAgendamento.Paciente}, a.seqformapagto = {seqFormaPagamento} ");
                sql.AppendLine($" WHERE a.seqagendamento = {pAgendamento.Codigo} ");
                OperacaoBD.ExecutarComando(sql.ToString());

                return pAgendamento.Codigo;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar o agendamento.\n{ex.Message}");
            }
        }

        private long IncluirAgendamento(AgendamentoDTO pAgendamento)
        {
            try
            {
                double valorAgendamento;
                try
                {
                    valorAgendamento = double.Parse(pAgendamento.EspecialidadeValor.Split('-')[1].Trim());
                }
                catch(Exception)
                {
                    valorAgendamento = 0;
                }

                StringBuilder sql = new StringBuilder();

                var seqAgendamento = OperacaoBD.BuscarProximoValorSequence(Constantes.SEQUENCE_TABELA_AGENDAMENTO);
                var medico = OperacaoBD.RetornaMedicoPorNome(pAgendamento.Medico);
                var paciente = OperacaoBD.RetornaPacientePorNome(pAgendamento.Paciente);
                var seqFormaPagamento = OperacaoBD.BuscarSeqFormaPagamento(pAgendamento.FormaPagamento);

                sql.AppendLine($"INSERT INTO agendamento(seqagendamento, dtahoragendamento, vlragendamento, crm, seqpaciente, seqformapagto) ");
                sql.AppendLine($"VALUES({seqAgendamento}, TO_DATE('{pAgendamento.DataHorario.ToString("dd/MM/yyyy HH:mm:ss")}', 'DD/MM/YYYY HH24:MI:SS'), ");
                sql.AppendLine($" {valorAgendamento}, '{medico.Crm}', {paciente.Codigo}, {seqFormaPagamento} )");
                OperacaoBD.ExecutarComando(sql.ToString());

                return seqAgendamento;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao incluir o agendamento.\n{ex.Message}");
            }
        }

        #endregion
    }
}
