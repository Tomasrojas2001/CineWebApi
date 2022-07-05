
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.DTOs.FuncionDTO
{
    
    public class FuncionResponse
    {
        public int FuncionId { get; set; }
        public string Fecha { get; set; }
        public string Horario { get; set; }
        public string TituloPelicula { get; set; }
        public int PeliculaId { get; set; }
        public int SalaId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string> ListaErrores { get; set; }


    }
}
