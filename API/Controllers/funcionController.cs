using Application.Services.Interface_Service;
using Domain.DTOs;
using Domain.DTOs.FuncionDTO;
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
    public class funcionController : ControllerBase
    {
        IFuncionService service;
        public funcionController(IFuncionService xservice)
        {
            service = xservice;
        }


        [HttpPost]
        public IActionResult Post(FuncionRequest funcion)
        {
            
            Response Response = service.CrearFuncion(funcion);

            if (!Response.IsValid) return new JsonResult(Response.Errors) { StatusCode = 400 };
            
            return new JsonResult(Response) { StatusCode = 201 };    
            
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
           
              Response Response = service.DeleteFuncion(id);

              if (Response.IsValid == true) return new JsonResult(Response) { StatusCode = 204 }; 
         
              return new JsonResult(Response.Errors) { StatusCode = 400 };
            
        }


        [HttpGet]
        public IActionResult Get([FromQuery] string Fecha, [FromQuery] string Titulo)
           {
            
            List<FuncionResponse> Response = service.GetFuncionPorFechaTitulo(Fecha,Titulo);

            foreach (var FuncionR in Response) 
                if (FuncionR.ListaErrores != null) return new JsonResult(FuncionR.ListaErrores) { StatusCode = 404 };

            return new JsonResult(Response) { StatusCode = 200 };

        }

        [HttpGet]
        [Route("funciones")]
        public IActionResult Get()
        {

            return new JsonResult(service.GetAllFunciones()) { StatusCode = 200 };

        }


        [HttpGet]
        [Route("pelicula/{peliculaId}")]
        public IActionResult Get(int peliculaId)
        {
           
            List<FuncionResponse> Response = service.GetFuncionPorPeliculaId(peliculaId);

            foreach (var FuncionR in Response) 
                if (FuncionR.ListaErrores != null) return new JsonResult(FuncionR.ListaErrores) { StatusCode = 404 };
                
            return new JsonResult(Response) { StatusCode = 200 };
           
        }


        [HttpGet]
        [Route("{id}/tickets")]
        public IActionResult GetTicketsPorId(int id)
        {

           TicketResponse Response = service.TicketsDisponibles(id);

           if(Response.ListaErrores == null) return new JsonResult(Response.Cantidad) { StatusCode = 200 };    
           
           return new JsonResult(Response.ListaErrores) { StatusCode = 404 };
            
        }

    }
}
