using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessData.Config
{
    public class PeliculaConfig
    {
        EntityTypeBuilder<Pelicula> PeliculaBuilder;
        public PeliculaConfig(EntityTypeBuilder<Pelicula> _PeliculaBuilder)
        {
            PeliculaBuilder = _PeliculaBuilder;
            PeliculaBuilder.HasKey(x => x.PeliculaId);

            PeliculaBuilder.Property(x => x.Titulo).HasMaxLength(50).IsRequired();
            PeliculaBuilder.Property(x => x.Poster).HasMaxLength(255).IsRequired();
            PeliculaBuilder.Property(x => x.Sinopsis).HasMaxLength(255).IsRequired();
            PeliculaBuilder.Property(x => x.Trailer).HasMaxLength(255).IsRequired();

            CreadorPeliculas.CrearPelicula(PeliculaBuilder, 1, "Tenet", "https://i0.wp.com/thecinemafiles.com/wp-content/uploads/2020/09/tenet-banner.jpg?ssl=1", "En el mundo del espionaje internacional, un hombre (John David Washington) prefiere morir antes que entregar a sus compañeros.", "https://www.youtube.com/embed/CdRL6o8z-2A");
            CreadorPeliculas.CrearPelicula(PeliculaBuilder, 2, "titanic", "https://www.tuposter.com/pub/media/catalog/product/cache/image/91bbed04eb86c2a8aaef7fbfb2041b2a/t/i/titanic_cartel.png", "Jack (DiCaprio), un joven artista, gana en una partida de cartas un pasaje para viajar a América en el Titanic, el transatlántico más grande y seguro jamás construido.", "https://www.youtube.com/embed/1pjJPmzCmgE");
            CreadorPeliculas.CrearPelicula(PeliculaBuilder, 3, "el padrino 1", "https://wc.wallpaperuse.com/wallp/8-85274_s.jpg", "Vito Corleone es el jefe de una de las familias que lideran la Cosa Nostra neoyorkina durante los años 40. Dos de sus hijos participan en las actividades ilícitas, mientras que Michael Corleone está distanciado del negocio familiar.", "https://www.youtube.com/embed/COQvkUmN6H8");
            CreadorPeliculas.CrearPelicula(PeliculaBuilder, 4, "Eternals", "https://cineverso.es/wp-content/uploads/2021/11/marvel-eternals.jpg", "Hace millones de años, los seres cósmicos conocidos como los Celestiales comenzaron a experimentar genéticamente con los humanos. Su intención era crear individuos superpoderosos que hicieran únicamente el bien.", "https://www.youtube.com/embed/MKWXuj3ZYf0");
            CreadorPeliculas.CrearPelicula(PeliculaBuilder, 5, "Encanto", "https://wallpaperaccess.com/full/7485234.jpg", "Encanto nos sitúa en el corazón de Colombia, narrando la increíble aventura de una joven y su familia. Pero, sorprendentemente, todos los miembros del clan tienen poderes mágicos excepto la protagonista.", "https://www.youtube.com/embed/E4dCY_DvT-4");
            CreadorPeliculas.CrearPelicula(PeliculaBuilder, 6, "Spider man: no way home", "https://wallpaperaccess.com/full/6790561.jpg", "Después de que Mysterio desvelara la identidad de Spider-Man a todo el mundo en Lejos de casa, Peter Parker (Tom Holland), desesperado por volver a la normalidad y recuperar su anterior vida, pide ayuda a Doctor Strange para enmendar tal acción.", "https://www.youtube.com/embed/rt-2cxAiPJk");
            CreadorPeliculas.CrearPelicula(PeliculaBuilder, 7, "Sin tiempo para morir", "https://es.web.img3.acsta.net/r_1280_720/pictures/21/09/27/08/50/1188066.jpg", "En esta película, la número 25 de la franquicia, James Bond (Daniel Craig) ha dejado el servicio activo y disfruta de una vida tranquila en Jamaica. ring", "https://www.youtube.com/embed/VYvmuz7ILvg");
            CreadorPeliculas.CrearPelicula(PeliculaBuilder, 8, "la isla siniestra", "https://www.zona-leros.net/storage/movies_tumbl/la-isla-siniestra-cover-knu.jpg", "En 1954 el agente Teddy Daniels y su compañero Check Aule son enviados a la isla de Shutter Island a investigar en un hospital psiquiátrico donde están internados peligrosos criminales.", "https://www.youtube.com/embed/95z6iWCjEgc");
            CreadorPeliculas.CrearPelicula(PeliculaBuilder, 9, "Dune", "https://dunenewsnet.com/wp-content/uploads/2021/08/Dune-Movie-Official-Poster-banner-feature.jpg", "Un futuro lejano, en el que las familias de nobles se disputan el dominio del árido planeta Arrakis, también conocido como Dune por su geografía compuesta por desiertos de dunas", "https://www.youtube.com/embed/GooZSRSWdLQ");
            CreadorPeliculas.CrearPelicula(PeliculaBuilder, 10, "jurassic park", "http://storymind.com/blog/wp-content/uploads/2017/03/1-2.jpg", "Pese a la extinción de los dinosaurios, InGen ha logrado clonar diversas especies mediante la manipulación de segmentos de ADN de la propia sangre de estos, encontrada en mosquitos fosilizados.", "https://www.youtube.com/embed/QWBKEmWWL38");
            CreadorPeliculas.CrearPelicula(PeliculaBuilder, 11, "Halloween kills", "https://es.web.img2.acsta.net/r_1280_720/pictures/21/09/15/17/03/3215619.jpg", "Laurie Strode(Jamie Lee Curtis) vuelve a enfrentarse a su viejo archienemigo Michael Myers, la figura enmascarada que la había perseguido desde que escapó de aquella fatídica noche hace cuatro décadas", "https://www.youtube.com/embed/OUwVHX3242M");
            CreadorPeliculas.CrearPelicula(PeliculaBuilder, 12, "It Capitulo 2", "https://es.web.img3.acsta.net/r_1280_720/pictures/19/07/30/09/09/0763744.jpg", "Han pasado casi 30 desde que el Club de Perdedores formado por Bill, Berverly, Richie, Ben, Eddie, Mike y Stanley se enfrentaran al macabro y despiadado Pennywise (Bill Skarsgård).", "https://www.youtube.com/embed/o1sQbtZpsic");
            CreadorPeliculas.CrearPelicula(PeliculaBuilder, 13, "Coco", "https://lifesciences.ucla.edu/wp-content/uploads/sites/3/2020/10/Cocoimage.jpg", "En un pequeño y alegre pueblo mexicano vive Miguel, un niño de 12 años que pertenece a una familia de zapateros, en la que la música está prohibida.", "https://www.youtube.com/embed/awzWdtCezDo");
            CreadorPeliculas.CrearPelicula(PeliculaBuilder, 14, "Joker", "https://i.pinimg.com/originals/41/eb/8a/41eb8aa615ec4c6abaf8866f070c29c3.png", "El subestimado y mentalmente enfermo Arthur Fleck ha ganado popularidad y su vida y la de ciudad Gótica dan un giro radical", "https://www.youtube.com/embed/t433PEQGErc");
        }



    }
    public class CreadorPeliculas
    {
        public static void CrearPelicula(EntityTypeBuilder<Pelicula> PeliculaBuilder, int xPeliculaId, string xTitulo, string xPoster, string xSinopsis, string xTrailer)
        {
            PeliculaBuilder.HasData(new Pelicula
            {
                PeliculaId = xPeliculaId,
                Titulo = xTitulo,
                Poster = xPoster,
                Sinopsis = xSinopsis,
                Trailer = xTrailer

            });



        }
    }
}
