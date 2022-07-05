using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DatabaseValidations
{
    public interface IFuncionValidations
    {
        string ValidacionFuncionesSuperpuestas(Funcion FuncionToValidate);
        string ValidacionPeliculaId(int PeliculaId);
        string ValidacionSalaId(int SalaId);
        string ValidacionFuncionId(int FuncionId);
        string ValidacionTitulo(string Titulo);
        string ValidacionFecha(string Fecha);
      
    }
}
