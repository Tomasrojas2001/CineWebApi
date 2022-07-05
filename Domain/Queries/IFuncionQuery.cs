
using Domain.DTOs.FuncionDTO;
using Domain.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Queries
{
    public interface IFuncionQuery
    {
        List<CombinadoDto> GetFuncionesDisponiblesQuery(string Titulo);
        List<FuncionDto> GetPorFechaTituloQuery(string Fecha , string Titulo);
        List<FuncionDto> FuncionPorPeliculaIdQuery(int PeliculaId);

        int TicketsDisponiblesQuery(int FuncionId);

        List<FuncionResponse> GetAllFunciones();
    }
}
