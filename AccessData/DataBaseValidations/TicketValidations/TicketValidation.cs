using Domain.DatabaseValidations;
using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessData.DataBaseValidations.TicketValidations
{
    public class TicketValidation : ITicketsValidations
    {
        private readonly CineContext Context;
        public TicketValidation(CineContext DbContext)
        {

            Context = DbContext;
        }
        public string TicketAvailableValidation(TicketRequest xTicket)
        {

            var Capacidad = (from F in Context.Funciones
                            join S in Context.Salas on F.SalaId equals S.SalaId
                            into union_F_S
                            from F_S in union_F_S.DefaultIfEmpty()
                            where F.FuncionId == xTicket.FuncionId
                            select new { Capacidad = F_S.Capacidad }).FirstOrDefault();

            if (Capacidad == null) return null;

            var Funciones = (from T in Context.Tickets
                                    join F in Context.Funciones on T.FuncionId equals F.FuncionId
                                    into union_T_F
                                    from T_F in union_T_F.DefaultIfEmpty()
                                    where T_F.FuncionId == xTicket.FuncionId
                                    group T_F by T_F.FuncionId into Ids
                                    select new { TicketsComprados = Ids.Count() }).FirstOrDefault();

            var TicketsDisponibles = 0;

            if (Funciones != null)
            {
                TicketsDisponibles = Capacidad.Capacidad - Funciones.TicketsComprados;

                if (TicketsDisponibles == 0) return "No hay tickets para la funcion.";

                else if ((TicketsDisponibles - xTicket.Cantidad) < 0) return "La cantidad de tickets que quiere comprar es mayor a la cantidad de tickets disponibles. Tickets disponibles:" + TicketsDisponibles ;
            }

            else if((Capacidad.Capacidad - xTicket.Cantidad) < 0) return "La cantidad de tickets que quiere comprar es mayor a la cantidad de tickets disponibles. Tickets disponibles:" + Capacidad.Capacidad ; 
            

            return null;
        }
    }
}
