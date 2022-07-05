using Application.Fluent_Validations.TicketsValidations;
using Application.Services.Interface_Service;
using Domain.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ticketsController : ControllerBase
    {
        ITicketService service;
        public ticketsController(ITicketService xservice)
        {
            service = xservice;
        }


        [HttpPost()]
        public IActionResult Post(TicketRequest Ticket)
        {    

                var Response = service.CreateTicket(Ticket);

                if (!Response[0].IsValid)
                {
                    string DevolverErrores = "";

                    foreach (var error in Response[0].Errors) DevolverErrores += error.ToString();

                    return new JsonResult(DevolverErrores) { StatusCode = 404 };
                }

                return new JsonResult(Response) { StatusCode = 201 };
        }

      
    }
}
