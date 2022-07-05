using Domain.DTOs;
using Domain.DTOs.FuncionDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interface_Service
{
    public interface IFuncionService
    {
        List<CombinadoDto> GetFuncionesDisponibles(string Titulo);

        List<FuncionResponse> GetFuncionPorFechaTitulo(string Fecha , string Titulo);

        Response CrearFuncion(FuncionRequest Funcion);
        Response DeleteFuncion(int Id);  
        List<FuncionResponse> GetFuncionPorPeliculaId(int PeliculaId);
        TicketResponse TicketsDisponibles(int FuncionId);

        List<FuncionResponse> GetAllFunciones();

    }
}
