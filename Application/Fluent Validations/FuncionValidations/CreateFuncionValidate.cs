using Domain.DTOs.FuncionDTO;
using FluentValidation;
using NPOI.SS.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Fluent_Validations.FuncionValidations
{

    public class CreateFuncionValidate : AbstractValidator<FuncionRequest>
    {
        public CreateFuncionValidate()
        {
            RuleFor(Funcion => Funcion.Fecha).NotEmpty().NotNull().WithMessage("El campo Fecha no puede ser nulo.   ");
            RuleFor(Funcion => Funcion.Fecha).Must(FechaValidation).WithMessage("La fecha ingresada esta mal escrita.Formato Correcto:(yyyy-MM-dd).  ");
            RuleFor(Funcion => Funcion.Fecha).Must(FechaValidationTwo).WithMessage($"La Fecha de la funcion no puede ser anterior a hoy({DateTime.Now}).  ");

            RuleFor(Funcion => Funcion.Horario).NotEmpty().NotNull().WithMessage("El campo Horario no puede ser nulo.   ");
            RuleFor(Funcion => Funcion.Horario).Must(TipoDeDatoValidation).WithMessage("El Horario ingresado no esta escrito correctamente(hh:mm). ");

            RuleFor(Funcion => Funcion.PeliculaId).NotEmpty().NotNull().WithMessage("El Id de la pelicula no puede ser nulo.  ");
            RuleFor(Funcion => Funcion.SalaId).NotEmpty().NotNull().WithMessage("El id de la sala no puede ser nulo.  ");

        }
        public bool FechaValidation(string Fecha)
        {
            try
            {
                if (Fecha != null)
                {
                    SimpleDateFormat Formato = new SimpleDateFormat("yyyy-mm-dd");
                    DateTime Date = Formato.Parse(Fecha);
                }
            }
            catch (Exception) { return false; }
            
            return true;
        }
        public bool FechaValidationTwo(string FechaIngresada)
        {
            try
            {
                if (FechaIngresada != null)
                {
                   
                    var Now = DateTime.Now.ToShortDateString();
                    var DateNow = DateTime.Parse(Now);
                    var DateEntered = DateTime.Parse(FechaIngresada);

                    if (DateEntered.CompareTo(DateNow) < 0) return false;
                }
            }
            catch (Exception) { return true; }            

            return true;
        }
        public bool TipoDeDatoValidation(string Horario)
        {
            TimeSpan Hora;
            var _Hora = TimeSpan.TryParse(Horario, out Hora);

            if (_Hora) return true;

            return false;
        }
    }
}
