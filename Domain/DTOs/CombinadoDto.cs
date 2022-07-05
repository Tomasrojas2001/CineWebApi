using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class CombinadoDto
    {
        public int FuncionId { get; set; }

        public TimeSpan FuncionHorario { get; set; }

        public DateTime FuncionFecha { get; set; }

        public string PeliculaTitulo { get; set; }

        public int SalaFuncion { get; set; }

        public int SalaCapacidad { get; set; }
    }
}
