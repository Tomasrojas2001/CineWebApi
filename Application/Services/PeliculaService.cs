
using Application.Fluent_Validations.PeliculaValidations;
using Application.Services.Interface_Service;
using Domain.Commands;
using Domain.DatabaseValidations;
using Domain.DTOs;
using Domain.DTOs.PeliculaDTO;
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
    public class PeliculaService : IPeliculaService
    {

        IGenericsRepository Repository;
        IPeliculaQuery Query;
        IPeliculaValidations PeliculaToValidate;
        List<string> ValidacionesBaseDatos;
        public PeliculaService(IGenericsRepository _Repository, IPeliculaQuery _Query, IPeliculaValidations _PeliculaToValidate)
        {
            Repository = _Repository;
            Query = _Query;
            PeliculaToValidate = _PeliculaToValidate;
        }

        public List<PeliculaResponse> GetAllPeliculasService()
        {
            return Query.GetAllPeliculasQuery();
        }

        public List<PeliculaResponse> GetEstrenos()
        {
            var ListaNoRepetirEstrenos = new List<PeliculaResponse>();
            List<PeliculaResponse> ListaEstrenosFuturos =  Query.GetEstrenosQuery();
           
            foreach (var Estreno in ListaEstrenosFuturos)
            {
                if (!ListaNoRepetirEstrenos.Any(EstrenoSinRepetir => EstrenoSinRepetir.PeliculaId == Estreno.PeliculaId))
                    ListaNoRepetirEstrenos.Add(Estreno);
            }

            return ListaNoRepetirEstrenos;
        }

        public PeliculaResponse GetInfoPeliculaPorId(int Id)
        {
            ValidacionesBaseDatos = new List<string>();
            ValidacionesBaseDatos.Add(PeliculaToValidate.ValidacionPeliculaId(Id));

            if (!ValidacionesBaseDatos.Any(Validacion => Validacion != null)) return Query.InfoPeliculaQuery(Id);

            else return new PeliculaResponse { ListaErrores = ValidacionesBaseDatos };
            
        }

        public Response ModificarPelicula(int Id, PeliculaRequest Request)
        {
            var Validator = new ModificarPeliculasValidate();
            var ListaErrores = new List<Object>();
            ValidacionesBaseDatos = new List<string>();   

            ValidacionesBaseDatos.Add(PeliculaToValidate.ValidacionPeliculaId(Id));

            var PeliculaModificada = new Pelicula
            {
                PeliculaId = Id,
                Titulo = Request.Titulo,
                Poster = Request.Poster,             
                Sinopsis = Request.Sinopsis,
                Trailer = Request.Trailer
            };

            ValidationResult result = Validator.Validate(PeliculaModificada);

            if (result.IsValid) 
            {
                if (!ValidacionesBaseDatos.Any(Validacion => Validacion != null)) Repository.Update(Id, PeliculaModificada);

                else  ListaErrores.Add(ValidacionesBaseDatos);
            }

            else result.Errors.ToList().ForEach(error => ListaErrores.Add(error.ErrorMessage));

            if (ListaErrores.Count != 0) return new Response { Errors = ListaErrores };

            return new Response { Errors = null };


        }

      
    }
}
