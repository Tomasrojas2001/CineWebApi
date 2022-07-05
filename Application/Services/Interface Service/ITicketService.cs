using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interface_Service
{
    public interface ITicketService
    {
        List<Response> CreateTicket(TicketRequest xTicket);
    }
}
