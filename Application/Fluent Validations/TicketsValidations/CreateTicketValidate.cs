using Domain.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Fluent_Validations.TicketsValidations
{  
    public class CreateTicketValidate : AbstractValidator<TicketRequest>
    {
        public CreateTicketValidate()
        {
            RuleFor(x => x.Cantidad).NotEmpty().NotNull().WithMessage("El campo Cantidad no puede ser nulo.   ");
            RuleFor(x => x.Cantidad).GreaterThan(0).WithMessage("El campo Cantidad no puede ser menor a cero.   ");

            RuleFor(x => x.FuncionId).NotEmpty().NotNull().WithMessage("El campo FuncionId no puede ser nulo.   ");
            RuleFor(x => x.FuncionId).GreaterThan(0).WithMessage("El campo FuncionId no puede ser menor a cero.   ");

            RuleFor(x => x.Usuario).NotEmpty().NotNull().WithMessage("El campo Usuario no puede ser nulo.   ");
        }

        
        
    }
}
