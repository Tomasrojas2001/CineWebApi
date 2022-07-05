using AccessData.DataBaseValidations.FuncionValidations;
using Domain.DTOs;
using Domain.Queries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlKata.Compilers;
using SqlKata.Execution;
using System.Data;
using Domain.Entities;
using Domain.DTOs.FuncionDTO;
using NPOI.SS.Util;

namespace AccessData.Queries
{
    public class FuncionQuery : IFuncionQuery
    {
        private readonly IDbConnection Connection;
        private readonly Compiler SklKataCompiler;
        private readonly CineContext Context;
        public FuncionQuery(IDbConnection _Connection, Compiler xsklKataCompiler,CineContext dbContext)
        {
            Connection = _Connection;
            SklKataCompiler = xsklKataCompiler;
            Context = dbContext;
        }
        public List<CombinadoDto> GetFuncionesDisponiblesQuery(string Titulo)
        {
           
                List<CombinadoDto> ListaFuncion = null;

               

                    ListaFuncion = (from P in Context.Peliculas
                                    join F in Context.Funciones on P.PeliculaId equals F.PeliculaId
                                    into union_P_F
                                    from P_F in union_P_F.DefaultIfEmpty()
                                    join S in Context.Salas on P_F.SalaId equals S.SalaId
                                    into union_F_S
                                    from F_S in union_F_S.DefaultIfEmpty()
                                    where P.Titulo == Titulo
                                    select new CombinadoDto { FuncionId = P_F.FuncionId, FuncionHorario = P_F.Horario, FuncionFecha = P_F.Fecha, PeliculaTitulo = P.Titulo, SalaFuncion = F_S.SalaId, SalaCapacidad = F_S.Capacidad }
                              ).ToList();



               
                return ListaFuncion;
            
        }

        public List<FuncionDto> GetPorFechaTituloQuery(string Fecha, string Titulo)
        { 
            var db = new QueryFactory(Connection, SklKataCompiler);

            SimpleDateFormat ConvertFecha = new SimpleDateFormat("yyyy-mm-dd");
            DateTime FechaDatetime = new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.Day);
           
            if (!string.IsNullOrWhiteSpace(Fecha)) FechaDatetime = ConvertFecha.Parse(Fecha);

            List<FuncionDto> ListaFunciones;

            var result = db.Query("Funciones")
                                .Select("Funciones.FuncionId", "Funciones.Fecha", "Funciones.Horario", "Peliculas.Titulo AS TituloPelicula", "Funciones.PeliculaId", "Funciones.SalaId")
                                .OrderBy("Funciones.Fecha")
                                .Join("Peliculas", "Peliculas.PeliculaId", "Funciones.PeliculaId")
                                .When(!string.IsNullOrWhiteSpace(Titulo), P => P.Where("Peliculas.Titulo", "=", Titulo))
                                .Where("Funciones.Fecha", "=", FechaDatetime);

            ListaFunciones = result.Get<FuncionDto>().ToList();

            if (ListaFunciones != null) return ListaFunciones;

            else return ListaFunciones = null;
        }

        public List<FuncionDto> FuncionPorPeliculaIdQuery(int PeliculaId)
        {
            var db = new QueryFactory(Connection, SklKataCompiler);
            DateTime FechaDatetime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);

            var ListaFuncion = (from P in Context.Peliculas
                                join F in Context.Funciones on P.PeliculaId equals F.PeliculaId
                                into union_P_F
                                from P_F in union_P_F.DefaultIfEmpty()
                                where P_F.PeliculaId == PeliculaId && DateTime.Compare(FechaDatetime, P_F.Fecha) <= 0
                                select new FuncionDto { FuncionId = P_F.FuncionId, Fecha=P_F.Fecha, Horario=P_F.Horario, PeliculaId=P_F.PeliculaId, SalaId=P_F.SalaId, TituloPelicula = P.Titulo }).ToList();
            return ListaFuncion;

        }

        public int TicketsDisponiblesQuery(int FuncionID)
        {
            var db = new QueryFactory(Connection, SklKataCompiler);

            var Capacidad = (from F in Context.Funciones
                             join S in Context.Salas on F.SalaId equals S.SalaId
                             into union_F_S
                             from F_S in union_F_S.DefaultIfEmpty()
                             where F.FuncionId == FuncionID
                             select new { Capacidad = F_S.Capacidad }).Single();

            var Funciones = (from T in Context.Tickets
                             join F in Context.Funciones on T.FuncionId equals F.FuncionId
                             into union_T_F
                             from T_F in union_T_F.DefaultIfEmpty()
                             where T_F.FuncionId == FuncionID
                             group T_F by T_F.FuncionId into Ids
                             select new { TicketsComprados = Ids.Count() }).FirstOrDefault();


            if (Funciones != null) return Capacidad.Capacidad - Funciones.TicketsComprados;

            else return Capacidad.Capacidad;
        }

        public List<FuncionResponse> GetAllFunciones()
        {
            DateTime FechaDatetime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);

            var ListaFunciones = (from F in Context.Funciones
                                  where DateTime.Compare(FechaDatetime, F.Fecha) <= 0
                                  orderby F.Fecha
                                  select new FuncionResponse { FuncionId = F.FuncionId, Fecha = F.Fecha.ToShortDateString(), Horario= F.Horario.ToString(), PeliculaId=F.PeliculaId, SalaId=F.SalaId }).ToList();
            return ListaFunciones;

        }
    }
}
