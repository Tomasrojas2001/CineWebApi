﻿// <auto-generated />
using System;
using AccessData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AccessData.Migrations
{
    [DbContext(typeof(CineContext))]
    partial class CineContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.Funcion", b =>
                {
                    b.Property<int>("FuncionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("Horario")
                        .HasColumnType("time");

                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.Property<int>("SalaId")
                        .HasColumnType("int");

                    b.HasKey("FuncionId");

                    b.HasIndex("PeliculaId");

                    b.HasIndex("SalaId");

                    b.ToTable("Funciones");
                });

            modelBuilder.Entity("Domain.Entities.Pelicula", b =>
                {
                    b.Property<int>("PeliculaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Poster")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Sinopsis")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Trailer")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("PeliculaId");

                    b.ToTable("Peliculas");

                    b.HasData(
                        new
                        {
                            PeliculaId = 1,
                            Poster = "https://i0.wp.com/thecinemafiles.com/wp-content/uploads/2020/09/tenet-banner.jpg?ssl=1",
                            Sinopsis = "En el mundo del espionaje internacional, un hombre (John David Washington) prefiere morir antes que entregar a sus compañeros.",
                            Titulo = "Tenet",
                            Trailer = "https://www.youtube.com/embed/CdRL6o8z-2A"
                        },
                        new
                        {
                            PeliculaId = 2,
                            Poster = "https://www.tuposter.com/pub/media/catalog/product/cache/image/91bbed04eb86c2a8aaef7fbfb2041b2a/t/i/titanic_cartel.png",
                            Sinopsis = "Jack (DiCaprio), un joven artista, gana en una partida de cartas un pasaje para viajar a América en el Titanic, el transatlántico más grande y seguro jamás construido.",
                            Titulo = "titanic",
                            Trailer = "https://www.youtube.com/embed/1pjJPmzCmgE"
                        },
                        new
                        {
                            PeliculaId = 3,
                            Poster = "https://wc.wallpaperuse.com/wallp/8-85274_s.jpg",
                            Sinopsis = "Vito Corleone es el jefe de una de las familias que lideran la Cosa Nostra neoyorkina durante los años 40. Dos de sus hijos participan en las actividades ilícitas, mientras que Michael Corleone está distanciado del negocio familiar.",
                            Titulo = "el padrino 1",
                            Trailer = "https://www.youtube.com/embed/COQvkUmN6H8"
                        },
                        new
                        {
                            PeliculaId = 4,
                            Poster = "https://cineverso.es/wp-content/uploads/2021/11/marvel-eternals.jpg",
                            Sinopsis = "Hace millones de años, los seres cósmicos conocidos como los Celestiales comenzaron a experimentar genéticamente con los humanos. Su intención era crear individuos superpoderosos que hicieran únicamente el bien.",
                            Titulo = "Eternals",
                            Trailer = "https://www.youtube.com/embed/MKWXuj3ZYf0"
                        },
                        new
                        {
                            PeliculaId = 5,
                            Poster = "https://wallpaperaccess.com/full/7485234.jpg",
                            Sinopsis = "Encanto nos sitúa en el corazón de Colombia, narrando la increíble aventura de una joven y su familia. Pero, sorprendentemente, todos los miembros del clan tienen poderes mágicos excepto la protagonista.",
                            Titulo = "Encanto",
                            Trailer = "https://www.youtube.com/embed/E4dCY_DvT-4"
                        },
                        new
                        {
                            PeliculaId = 6,
                            Poster = "https://wallpaperaccess.com/full/6790561.jpg",
                            Sinopsis = "Después de que Mysterio desvelara la identidad de Spider-Man a todo el mundo en Lejos de casa, Peter Parker (Tom Holland), desesperado por volver a la normalidad y recuperar su anterior vida, pide ayuda a Doctor Strange para enmendar tal acción.",
                            Titulo = "Spider man: no way home",
                            Trailer = "https://www.youtube.com/embed/rt-2cxAiPJk"
                        },
                        new
                        {
                            PeliculaId = 7,
                            Poster = "https://es.web.img3.acsta.net/r_1280_720/pictures/21/09/27/08/50/1188066.jpg",
                            Sinopsis = "En esta película, la número 25 de la franquicia, James Bond (Daniel Craig) ha dejado el servicio activo y disfruta de una vida tranquila en Jamaica. ring",
                            Titulo = "Sin tiempo para morir",
                            Trailer = "https://www.youtube.com/embed/VYvmuz7ILvg"
                        },
                        new
                        {
                            PeliculaId = 8,
                            Poster = "https://www.zona-leros.net/storage/movies_tumbl/la-isla-siniestra-cover-knu.jpg",
                            Sinopsis = "En 1954 el agente Teddy Daniels y su compañero Check Aule son enviados a la isla de Shutter Island a investigar en un hospital psiquiátrico donde están internados peligrosos criminales.",
                            Titulo = "la isla siniestra",
                            Trailer = "https://www.youtube.com/embed/95z6iWCjEgc"
                        },
                        new
                        {
                            PeliculaId = 9,
                            Poster = "https://dunenewsnet.com/wp-content/uploads/2021/08/Dune-Movie-Official-Poster-banner-feature.jpg",
                            Sinopsis = "Un futuro lejano, en el que las familias de nobles se disputan el dominio del árido planeta Arrakis, también conocido como Dune por su geografía compuesta por desiertos de dunas",
                            Titulo = "Dune",
                            Trailer = "https://www.youtube.com/embed/GooZSRSWdLQ"
                        },
                        new
                        {
                            PeliculaId = 10,
                            Poster = "http://storymind.com/blog/wp-content/uploads/2017/03/1-2.jpg",
                            Sinopsis = "Pese a la extinción de los dinosaurios, InGen ha logrado clonar diversas especies mediante la manipulación de segmentos de ADN de la propia sangre de estos, encontrada en mosquitos fosilizados.",
                            Titulo = "jurassic park",
                            Trailer = "https://www.youtube.com/embed/QWBKEmWWL38"
                        },
                        new
                        {
                            PeliculaId = 11,
                            Poster = "https://es.web.img2.acsta.net/r_1280_720/pictures/21/09/15/17/03/3215619.jpg",
                            Sinopsis = "Laurie Strode(Jamie Lee Curtis) vuelve a enfrentarse a su viejo archienemigo Michael Myers, la figura enmascarada que la había perseguido desde que escapó de aquella fatídica noche hace cuatro décadas",
                            Titulo = "Halloween kills",
                            Trailer = "https://www.youtube.com/embed/OUwVHX3242M"
                        },
                        new
                        {
                            PeliculaId = 12,
                            Poster = "https://es.web.img3.acsta.net/r_1280_720/pictures/19/07/30/09/09/0763744.jpg",
                            Sinopsis = "Han pasado casi 30 desde que el Club de Perdedores formado por Bill, Berverly, Richie, Ben, Eddie, Mike y Stanley se enfrentaran al macabro y despiadado Pennywise (Bill Skarsgård).",
                            Titulo = "It Capitulo 2",
                            Trailer = "https://www.youtube.com/embed/o1sQbtZpsic"
                        },
                        new
                        {
                            PeliculaId = 13,
                            Poster = "https://lifesciences.ucla.edu/wp-content/uploads/sites/3/2020/10/Cocoimage.jpg",
                            Sinopsis = "En un pequeño y alegre pueblo mexicano vive Miguel, un niño de 12 años que pertenece a una familia de zapateros, en la que la música está prohibida.",
                            Titulo = "Coco",
                            Trailer = "https://www.youtube.com/embed/awzWdtCezDo"
                        },
                        new
                        {
                            PeliculaId = 14,
                            Poster = "https://i.pinimg.com/originals/41/eb/8a/41eb8aa615ec4c6abaf8866f070c29c3.png",
                            Sinopsis = "El subestimado y mentalmente enfermo Arthur Fleck ha ganado popularidad y su vida y la de ciudad Gótica dan un giro radical",
                            Titulo = "Joker",
                            Trailer = "https://www.youtube.com/embed/t433PEQGErc"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Sala", b =>
                {
                    b.Property<int>("SalaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacidad")
                        .HasColumnType("int");

                    b.HasKey("SalaId");

                    b.ToTable("Salas");

                    b.HasData(
                        new
                        {
                            SalaId = 1,
                            Capacidad = 5
                        },
                        new
                        {
                            SalaId = 2,
                            Capacidad = 15
                        },
                        new
                        {
                            SalaId = 3,
                            Capacidad = 35
                        });
                });

            modelBuilder.Entity("Domain.Entities.Ticket", b =>
                {
                    b.Property<Guid>("TicketId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("FuncionId")
                        .HasColumnType("int");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TicketId", "FuncionId");

                    b.HasIndex("FuncionId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Domain.Entities.Funcion", b =>
                {
                    b.HasOne("Domain.Entities.Pelicula", "Pelicula")
                        .WithMany("Funciones")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Sala", "Sala")
                        .WithMany("Funciones2")
                        .HasForeignKey("SalaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pelicula");

                    b.Navigation("Sala");
                });

            modelBuilder.Entity("Domain.Entities.Ticket", b =>
                {
                    b.HasOne("Domain.Entities.Funcion", "Funcion")
                        .WithMany("Tickets")
                        .HasForeignKey("FuncionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcion");
                });

            modelBuilder.Entity("Domain.Entities.Funcion", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("Domain.Entities.Pelicula", b =>
                {
                    b.Navigation("Funciones");
                });

            modelBuilder.Entity("Domain.Entities.Sala", b =>
                {
                    b.Navigation("Funciones2");
                });
#pragma warning restore 612, 618
        }
    }
}
