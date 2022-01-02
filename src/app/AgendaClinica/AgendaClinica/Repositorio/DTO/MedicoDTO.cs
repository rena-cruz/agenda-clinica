using System.Collections.Generic;

namespace AgendaClinica.Repositorio.DTO
{
    internal class MedicoDTO
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Crm { get; set; }

        public string Especialidade { get; set; }

        public List<MedicoJornadaDTO> Jornada { get; set; }
    }

    internal class MedicoJornadaDTO
    {
        public string DiaSemana { get; set; }

        public string Periodo { get; set; }

        public long SeqJornada { get; set; }
    }
}
