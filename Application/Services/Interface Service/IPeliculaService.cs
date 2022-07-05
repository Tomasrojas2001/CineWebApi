using Domain.DTOs;
using Domain.DTOs.PeliculaDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interface_Service
{
    public interface IPeliculaService
    {
        PeliculaResponse GetInfoPeliculaPorId(int Id);
        Response ModificarPelicula(int Id, PeliculaRequest Request);
        List<PeliculaResponse> GetEstrenos();

        List<PeliculaResponse> GetAllPeliculasService();

    }
}
