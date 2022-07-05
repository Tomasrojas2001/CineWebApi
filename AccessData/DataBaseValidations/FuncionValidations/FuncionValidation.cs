using Domain.DatabaseValidations;
using Domain.DTOs.FuncionDTO;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.Util;
using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessData.DataBaseValidations.FuncionValidations
{
    public class FuncionValidation : IFuncionValidations
    {

        private readonly IDbConnection Connection;
        private readonly Compiler SklKataCompiler;
        private readonly CineContext Context;
        public FuncionValidation(IDbConnection _Connection, Compiler _SklKataCompiler, CineContext DbContext)
        {
            Connection = _Connection;
            SklKataCompiler = _SklKataCompiler;
            Context = DbContext;
        }
        

        public string ValidacionPeliculaId(int PeliculaId)
        {
            var Db = new QueryFactory(Connection, SklKataCompiler);

            if (Context.Peliculas.Any(P => P.PeliculaId == PeliculaId))
            {
                var TituloPelicula = Context.Peliculas.Where(P => P.PeliculaId == PeliculaId).Select(P => P.Titulo).FirstOrDefault();
                var ListaFunciones = (Db.Query("Funciones")
                                    .Select("Funciones.FuncionId")
                                    .Join("Peliculas", "Peliculas.PeliculaId", "Funciones.PeliculaId")
                                    .Where("Funciones.PeliculaId", "=", PeliculaId)
                                    .Select("Peliculas.Titulo")).FirstOrDefault();

                if (ListaFunciones == null) return $"La pelicula {TituloPelicula} no se ha estrenado aun";

                else return null;

            }
            else return "No existe una pelicula con ese Id";
                
            
            
        }

        public string ValidacionSalaId(int SalaId)
        {
            if (!Context.Funciones.Any(F => F.SalaId == SalaId)) return "El ID de la sala que ingreso no esta asignado a ninguna funcion";
                    
            return null;
        }

        public string ValidacionFuncionId(int FuncionId)
        {
            if (!Context.Funciones.Any(F => F.FuncionId == FuncionId)) return "El ID de la funcion que ingreso no esta asignado a ninguna funcion";

            return null;
        }

        public string ValidacionFecha(string Fecha)
        {
            DateTime FechaDateTime;
            if (Fecha != null)
            {
                try
                {                  
                    SimpleDateFormat Formato = new SimpleDateFormat("yyyy-mm-dd");
                    FechaDateTime = Formato.Parse(Fecha);             
                }
                catch (Exception E) 
                { 
                    return E.Message; 
                }

                if (!Context.Funciones.Any(F => F.Fecha == FechaDateTime)) return "La fecha de la funcion que ingreso no esta asignada a ninguna funcion";
            }

            return null;   
        }

        public string ValidacionTitulo(string Titulo)
        {
            var Db = new QueryFactory(Connection, SklKataCompiler);

            if (Titulo != null)
            {
                if (Context.Peliculas.Any(P => P.Titulo == Titulo))
                {
                    var PeliculaId =(from P in Context.Peliculas
                                     where P.Titulo == Titulo 
                                     select P.PeliculaId).FirstOrDefault();

                    var ExisteFuncion = (from F in Context.Funciones
                                         where F.PeliculaId == PeliculaId
                                         select F.FuncionId).ToList();

                    if (ExisteFuncion.Count == 0) return $"La pelicula {Titulo} no se ha estrenado aun";

                    
                    
                }
                else return "No existe una pelicula con ese titulo";
                
            }
             return null;

        }

        
        public string ValidacionFuncionesSuperpuestas(Funcion FuncionToValidate)
        {
            var ListaHorarioQuery = (from F in Context.Funciones
                                     where F.SalaId == FuncionToValidate.SalaId
                                     where F.Fecha == FuncionToValidate.Fecha
                                     select F.Horario).ToList();


            foreach (var HorarioQuery in ListaHorarioQuery)
            {
                if (FuncionToValidate.Horario > HorarioQuery)
                {
                    var Diferencia = FuncionToValidate.Horario - HorarioQuery;

                    if (Diferencia.TotalMinutes < 150) 
                        return "No se pudo agregar la funcion, ya que en el horario ingresado("+ FuncionToValidate.Horario+") ya existe una funcion en esa sala.";                                    
                }
                else
                {
                    var Diferencia = HorarioQuery - FuncionToValidate.Horario;

                    if (Diferencia.TotalMinutes < 150)                   
                        return "No se pudo agregar la funcion, ya que en el horario ingresado(" + FuncionToValidate.Horario + ") ya existe una funcion en esa sala.";                  
                }
            }

            return null;
        }
        
    }
}

