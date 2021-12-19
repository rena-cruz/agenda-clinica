using AgendaClinica.DTO;
using AgendaClinica.Repositorio;
using System;
using System.Collections.Generic;
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

        private string RetornaStringConexao()
        {
            return File.ReadAllText(@"bdconfig.txt");
        }
    }
}
