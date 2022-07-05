using Application.Services.Interface_Service;
using Domain.Commands;
using Domain.DTOs.FuncionDTO;
using Domain.Entities;
using Domain.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DTOs;
using NPOI.SS.Util;
using Application.Fluent_Validations.FuncionValidations;
using FluentValidation.Results;
using Domain.DatabaseValidations;

namespace Application.Services
{
    public class FuncionService : IFuncionService
    {
        IGenericsRepository Repository;
        IFuncionQuery Query;
        IFuncionValidations FuncionTovalidate;
        IPeliculaValidations PeliculaToValidate;
        ISalaValidations SalaToValidate;
        List<string> ValidacionesBaseDatos;
        public FuncionService(IGenericsRepository _Repository, IFuncionQuery _Query, IFuncionValidations _FuncionTovalidate, IPeliculaValidations _PeliculaToValidate, ISalaValidations _SalaToValidate)
        {
            Repository = _Repository;
            Query = _Query;
            FuncionTovalidate = _FuncionTovalidate;
            PeliculaToValidate = _PeliculaToValidate;
            SalaToValidate = _SalaToValidate;
        }

        public List<CombinadoDto> GetFuncionesDisponibles(string Titulo)
        {
            return Query.GetFuncionesDisponiblesQuery(Titulo);
        }

        public List<FuncionResponse> GetFuncionPorFechaTitulo(string Fecha, string Titulo)
        {
            ValidacionesBaseDatos = new List<string>();
            var ListaValidacionesBaseDatos = new List<string>(); 

            List<FuncionResponse> ListaFuncionResponse = new List<FuncionResponse>();

            ValidacionesBaseDatos.Add(FuncionTovalidate.ValidacionFecha(Fecha));
            ValidacionesBaseDatos.Add(FuncionTovalidate.ValidacionTitulo(Titulo));
            

            ListaValidacionesBaseDatos.AddRange(ValidacionesBaseDatos.Where(Error => Error != null) );

            if (!ValidacionesBaseDatos.Any(Validacion => Validacion != null))
            {
                foreach (var Funcion in Query.GetPorFechaTituloQuery(Fecha, Titulo))
                {
                    ListaFuncionResponse.Add(new FuncionResponse
                    {
                        FuncionId = Funcion.FuncionId,
                        Fecha = Funcion.Fecha.ToShortDateString(),
                        Horario = Funcion.Horario.ToString(),
                        TituloPelicula = Funcion.TituloPelicula,
                        PeliculaId = Funcion.PeliculaId,
                        SalaId = Funcion.SalaId
                    });
                }
            }

            else ListaFuncionResponse.Add(new FuncionResponse { ListaErrores = ListaValidacionesBaseDatos });

            return ListaFuncionResponse;
        }

        public Response CrearFuncion(FuncionRequest Request)
        {
            var ListaErrores = new List<Object>();
            ValidacionesBaseDatos = new List<string>();
            Funcion entity = null;
            var validator = new CreateFuncionValidate();

            ValidationResult result = validator.Validate(Request);

            if (result.IsValid)
            {

                var hora = TimeSpan.Parse(Request.Horario);
                var FechaDatetime = DateTime.Parse(Request.Fecha);

                entity = new Funcion
                {
                    Fecha = FechaDatetime, 
                    Horario = hora, 
                    PeliculaId = Request.PeliculaId, 
                    SalaId = Request.SalaId 
                };

                ValidacionesBaseDatos.Add(FuncionTovalidate.ValidacionFuncionesSuperpuestas(entity));
                ValidacionesBaseDatos.Add(PeliculaToValidate.ValidacionPeliculaId(entity.PeliculaId));
                ValidacionesBaseDatos.Add(SalaToValidate.ValidacionSalaId(entity.SalaId));

                if (!ValidacionesBaseDatos.Any(Error => Error != null)) Repository.Add<Funcion>(entity);

                else ListaErrores.AddRange(( ValidacionesBaseDatos.Where(Validacion => Validacion != null )));
            }

            else result.Errors.ToList().ForEach(error => ListaErrores.Add(error.ErrorMessage));

            
            if (ListaErrores.Count != 0) return new Response {IsValid=false, Errors = ListaErrores };

            return new Response { IsValid = true, entity ="Funcion", Id= entity.FuncionId.ToString() };
        }

        public Response DeleteFuncion(int Id)
        {
            var ListaErrores = new List<Object>();
            ValidacionesBaseDatos = new List<string>();

            ValidacionesBaseDatos.Add(FuncionTovalidate.ValidacionFuncionId(Id));

            if (!ValidacionesBaseDatos.Any(Error => Error != null))
            {
                Repository.Delete<Funcion>(Id);
                return new Response { IsValid = true };
            }

            else 
            { 
                ListaErrores.Add(ValidacionesBaseDatos);
                return new Response { IsValid = false, Errors=ListaErrores };
            }
        }

        public List<FuncionResponse> GetFuncionPorPeliculaId(int PeliculaId)
        {
            ValidacionesBaseDatos = new List<string>();
            var ListaFuncionResponse = new List<FuncionResponse>();


            ValidacionesBaseDatos.Add(FuncionTovalidate.ValidacionPeliculaId(PeliculaId));

            if (!ValidacionesBaseDatos.Any(Error => Error != null))
            {
                foreach (var Funcion in Query.FuncionPorPeliculaIdQuery(PeliculaId)) 
                {
                    ListaFuncionResponse.Add(new FuncionResponse
                    {
                        FuncionId = Funcion.FuncionId,
                        Fecha = Funcion.Fecha.ToShortDateString(),
                        Horario = Funcion.Horario.ToString(),
                        TituloPelicula = Funcion.TituloPelicula,
                        PeliculaId=Funcion.PeliculaId,
                        SalaId = Funcion.SalaId
                    });
                }
            }
            else  ListaFuncionResponse.Add( new FuncionResponse { ListaErrores = ValidacionesBaseDatos });     
               
            return ListaFuncionResponse;
        }

        public TicketResponse TicketsDisponibles(int FuncionId)
        {          
            ValidacionesBaseDatos = new List<string>();
            TicketResponse Response = new TicketResponse();

            ValidacionesBaseDatos.Add(FuncionTovalidate.ValidacionFuncionId(FuncionId));

            if (!ValidacionesBaseDatos.Any(Error => Error != null)) Response.Cantidad = Query.TicketsDisponiblesQuery(FuncionId);

            else return new TicketResponse {ListaErrores = ValidacionesBaseDatos };

            return Response;
        }

        public List<FuncionResponse> GetAllFunciones()
        {
            return Query.GetAllFunciones();
        }
    }
}
