using AgendaClinica.DTO;
using AgendaClinica.Helper;
using AgendaClinica.Repositorio;
using AgendaClinica.Repositorio.DTO;
using System;
using System.Collections.Generic;
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

        private string RetornaStringConexao()
        {
            return File.ReadAllText(@"bdconfig.txt");
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
    }
}
