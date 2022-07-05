using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class TicketRequest
    {
        public int FuncionId { get; set; }
        public string Usuario { get; set; }       
        public int Cantidad { get; set; }
    }
}
