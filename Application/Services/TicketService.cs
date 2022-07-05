using Application.Fluent_Validations.TicketsValidations;
using Application.Services.Interface_Service;
using Domain.Commands;
using Domain.DatabaseValidations;
using Domain.DTOs;
using Domain.Entities;
using Domain.Queries;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class TicketService : ITicketService
    {
        IGenericsRepository Repository;
        ITicketQuery Query;
        ITicketsValidations TicketValidation;
        IFuncionValidations FuncionValidation;
        public TicketService(IGenericsRepository _Repository, ITicketQuery _Query, ITicketsValidations _TicketValidation, IFuncionValidations _FuncionValidation)
        {
            Repository = _Repository;
            Query = _Query;
            TicketValidation = _TicketValidation;
            FuncionValidation = _FuncionValidation;
        }

     

        public List<Response> CreateTicket(TicketRequest Request)
        {
            List<string> ValidacionesBaseDatos = new List<string>();
            List<Object> ListaErrores = new List<Object>();
            var ListaTicketResponse = new List<Response>();

            CreateTicketValidate Validator = new CreateTicketValidate();
            ValidationResult result = Validator.Validate(Request);        

            if (result.IsValid)
            {
                ValidacionesBaseDatos.Add(TicketValidation.TicketAvailableValidation(Request));
                ValidacionesBaseDatos.Add(FuncionValidation.ValidacionFuncionId(Request.FuncionId));

                if (!ValidacionesBaseDatos.Any(Error => Error != null))
                {
                    while (Request.Cantidad != 0)
                    {
                        Ticket TicketGenerado = new Ticket
                        {
                            TicketId = Guid.NewGuid(),
                            FuncionId = Request.FuncionId,
                            Usuario = Request.Usuario
                        };

                        Repository.Add<Ticket>(TicketGenerado);

                        ListaTicketResponse.Add(new Response { IsValid = true, entity = "Ticket", Id = TicketGenerado.TicketId.ToString() });

                        Request.Cantidad--;
                  }
                }

                else ListaErrores.AddRange(ValidacionesBaseDatos.Where(Error => Error != null));
            }

            else result.Errors.ForEach( Error => ListaErrores.Add(Error.ErrorMessage.ToString()));


            if (ListaErrores.Count != 0)
            {
                ListaTicketResponse.Add(new Response { IsValid = false, Errors = ListaErrores });
                return ListaTicketResponse;
            }
            
            return ListaTicketResponse;                
        }
        
    }
}
