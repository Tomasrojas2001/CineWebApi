using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class TicketResponse
    {
        public string Usuario { get; set; }

        public int FuncionId { get; set; }

        public int Cantidad { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string> ListaErrores { get; set; }
    }

}
