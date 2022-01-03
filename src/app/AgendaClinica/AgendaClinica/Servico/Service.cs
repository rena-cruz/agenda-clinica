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

        public void SalvarPaciente(PacienteDTO pPaciente)
        {
            try
            {
                if (pPaciente.Codigo > 0L && VerificaPacienteExistente(pPaciente.Codigo))
                {
                    AtualizarPaciente(pPaciente);
                }
                else
                {
                    IncluirPaciente(pPaciente);
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

        private void AtualizarPaciente(PacienteDTO pPaciente)
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
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar o paciente.\n{ex.Message}");
            }
        }

        private void IncluirPaciente(PacienteDTO pPaciente)
        {
            try
            {
                StringBuilder sql = new StringBuilder();

                var seqPaciente = OperacaoBD.BuscarProximoValorSequence(Constantes.SEQUENCE_TABELA_PACIENTE);
                var seqFinanceiro = OperacaoBD.BuscarSeqFinanceiro(pPaciente.SituacaoFinanceira);

                sql.AppendLine($"INSERT INTO paciente(seqpaciente, nome, email, dtanascimento, telefone, seqfinanceiro) ");
                sql.AppendLine($"VALUES({seqPaciente}, '{pPaciente.Nome}', '{pPaciente.Email}', ");
                sql.AppendLine($" '{pPaciente.DataNascimento.ToString("dd-MMM-yyyy", CultureInfo.InvariantCulture)}', {pPaciente.Celular}, {seqFinanceiro}) ");
                OperacaoBD.ExecutarComando(sql.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao incluir o paciente.\n{ex.Message}");
            }
        }

        #endregion
    }
}
