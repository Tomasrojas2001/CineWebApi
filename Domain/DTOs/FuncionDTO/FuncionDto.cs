using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs.FuncionDTO
{
    public class FuncionDto
    {
        public int FuncionId { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Horario { get; set; }
        public string TituloPelicula { get; set; }
        public int PeliculaId { get; set; }
        public int SalaId { get; set; }
    }
}
