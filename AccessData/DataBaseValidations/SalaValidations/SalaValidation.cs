using Domain.DatabaseValidations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessData.DataBaseValidations.SalaValidations
{
    public class SalaValidation : ISalaValidations
    {
        private readonly CineContext Context;
        public SalaValidation(CineContext DbContext)
        {
            Context = DbContext;
        }
        public string ValidacionSalaId(int SalaId)
        {
            if (!Context.Salas.Any(S => S.SalaId == SalaId)) return "El ID de la sala que ingreso no existe";

            return null;
        }
    }
}
