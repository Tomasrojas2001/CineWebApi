using Domain.DatabaseValidations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessData.DataBaseValidations.PeliculaValidations
{
    public class PeliculaValidation : IPeliculaValidations
    {
        private readonly CineContext Context;
        public PeliculaValidation( CineContext DbContext)
        {
            Context = DbContext;
        }
        public string ValidacionPeliculaId(int PeliculaId)
        {
            if (!Context.Peliculas.Any(P => P.PeliculaId == PeliculaId)) return "El ID de la pelicula que ingreso no existe";

            return null;
        }
    }
}
