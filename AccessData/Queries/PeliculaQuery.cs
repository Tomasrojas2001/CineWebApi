using Domain.DTOs;
using Domain.Queries;
using Microsoft.EntityFrameworkCore;
using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessData.Queries
{
    public class PeliculaQuery : IPeliculaQuery
    {
        private readonly CineContext Context;
        private readonly IDbConnection Connection;
        private readonly Compiler SklKataCompiler;
        public PeliculaQuery(IDbConnection _Connection, Compiler xsklKataCompiler, CineContext dbContext)
        {
            Connection = _Connection;
            SklKataCompiler = xsklKataCompiler;
            Context = dbContext;
        }

        public List<PeliculaResponse> GetEstrenosQuery()
        {
            

            DateTime FechaDatetime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);

            var ListaPeliculasFuturas = (from P in Context.Peliculas
                                         join F in Context.Funciones on P.PeliculaId equals F.PeliculaId
                                         into union_P_F
                                         from P_F in union_P_F.DefaultIfEmpty()
                                         where DateTime.Compare(FechaDatetime,P_F.Fecha) <= 0 &&
                                         P_F.PeliculaId != Context.Funciones.Where(D => DateTime.Compare(FechaDatetime, D.Fecha) > 0 && D.PeliculaId == P_F.PeliculaId).Select(c => c.PeliculaId).FirstOrDefault()
                                         select new PeliculaResponse { PeliculaId = P.PeliculaId, Titulo = P.Titulo, Poster = P.Poster, Sinopsis = P.Sinopsis, Trailer = P.Trailer }).ToList();

            
            if (ListaPeliculasFuturas != null) return ListaPeliculasFuturas;
            else return null;
            


        }
        public bool EsEstreno(DateTime Date1, DateTime Date2)
        {
            var Resultado = DateTime.Compare(Date1, Date2);
            if (Resultado <= 0) return true;
            else return false;
        }
        public PeliculaResponse InfoPeliculaQuery(int Id)
        {

            PeliculaResponse Pelicula = Context.Peliculas.Where(w => w.PeliculaId == Id).Select(c => new PeliculaResponse { PeliculaId = c.PeliculaId, Titulo = c.Titulo, Poster = c.Poster, Sinopsis = c.Sinopsis, Trailer = c.Trailer }).Single();
            return Pelicula;
            
        }

        public List<PeliculaResponse> GetAllPeliculasQuery()
        {
            var db = new QueryFactory(Connection, SklKataCompiler);

            var ListaPeliculas = db.Query("Peliculas")
                                .Select("Peliculas.PeliculaId", "Peliculas.Titulo", "Peliculas.Poster", "Peliculas.Sinopsis", "Peliculas.Trailer").Get<PeliculaResponse>().ToList();

            return ListaPeliculas;
                             
        }
    }
}
