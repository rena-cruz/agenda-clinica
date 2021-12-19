using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaClinica.Repositorio.DTO
{
    internal class PacienteDTO
    {
        public string Codigo { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Celular { get; set; }

        public string SituacaoFinanceira { get; set; }
    }
}
