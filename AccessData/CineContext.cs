using AccessData.Config;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace AccessData
{
    public class CineContext : DbContext
    {
        public CineContext(DbContextOptions<CineContext> options):base(options)
        {

        }
        public DbSet<Funcion> Funciones { get; set; }
        public DbSet<Sala> Salas { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Ticket> Tickets { get; set; }


        protected override void OnModelCreating(ModelBuilder Builder)
        {

            new FuncionConfig(Builder.Entity<Funcion>());
            new PeliculaConfig(Builder.Entity<Pelicula>());
            new SalaConfig(Builder.Entity<Sala>());
            new TicketConfig(Builder.Entity<Ticket>());


            base.OnModelCreating(Builder);
        }
    }
}
