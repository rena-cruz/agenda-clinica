using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaClinica.Repositorio.DTO
{
    internal class AgendamentoDTO
    {
        public long Codigo { get; set; }

        public DateTime DataHorario { get; set;}

        public string Paciente { get; set; }

        public string Medico { get; set; }

        public string EspecialidadeValor { get; set; }

        public string FormaPagamento { get; set; }
    }
}
