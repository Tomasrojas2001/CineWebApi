using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Queries
{
    public interface IPeliculaQuery
    {
        PeliculaResponse InfoPeliculaQuery(int Id);

        List<PeliculaResponse> GetEstrenosQuery();

        List<PeliculaResponse> GetAllPeliculasQuery();

    }
}
