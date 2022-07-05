﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Ticket
    {
        public Guid TicketId { get; set; }
        public string Usuario { get; set; }

        public int FuncionId { get; set; }
        public Funcion Funcion { get; set; }
    }
}
