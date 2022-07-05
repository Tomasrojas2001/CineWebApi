using Application.Services.Interface_Service;
using Domain.DTOs;
using Domain.DTOs.PeliculaDTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class peliculaController : ControllerBase
    {
        IPeliculaService service;
        public peliculaController(IPeliculaService xservice)
        {
            service = xservice;
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            PeliculaResponse Response = service.GetInfoPeliculaPorId(id);

            if (Response.ListaErrores == null) return new JsonResult(Response) { StatusCode = 200 };

            return new JsonResult(Response.ListaErrores) { StatusCode = 404 };
        }

        [HttpGet]
        [Route("Estrenos")]
        public IActionResult GetEstrenos()
        {
            List<PeliculaResponse> Response = service.GetEstrenos();

            return new JsonResult(Response) { StatusCode = 200 };

        }

        [HttpGet]
        [Route("Cartelera")]
        public IActionResult GetAllPeliculas()
        {
            List<PeliculaResponse> Response = service.GetAllPeliculasService();

            return new JsonResult(Response) { StatusCode = 200 };

        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] PeliculaRequest Pelicula)
        {
            Response Response = service.ModificarPelicula(id,Pelicula); 

            if(Response.Errors == null) return new JsonResult(Response) { StatusCode = 201 };

            return new JsonResult(Response.Errors) { StatusCode = 404 };
        }

        

        
    }
}
