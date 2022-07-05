
using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Fluent_Validations.PeliculaValidations
{
    public class ModificarPeliculasValidate : AbstractValidator<Pelicula>
    {
        public ModificarPeliculasValidate()
        {
            RuleFor(Pelicula => Pelicula.PeliculaId).NotEmpty().NotNull().WithMessage("El campo ID no puede ser nulo.   ");
            RuleFor(Pelicula => Pelicula.Titulo).NotEmpty().NotNull().WithMessage("El campo Titulo no puede ser nulo.   ");
            RuleFor(Pelicula => Pelicula.Poster).NotEmpty().NotNull().WithMessage("El campo Poster no puede ser nulo.   ");
            RuleFor(Pelicula => Pelicula.Sinopsis).NotEmpty().NotNull().WithMessage("El campo Sinopsis no puede ser nulo.   ");
            RuleFor(Pelicula => Pelicula.Trailer).NotEmpty().NotNull().WithMessage("El campo Trailer no puede ser nulo.   ");

        }
    
    }
}
