using Microsoft.EntityFrameworkCore.Migrations;

namespace AccessData.Migrations
{
    public partial class migracionNewMovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 1,
                columns: new[] { "Poster", "Sinopsis", "Titulo", "Trailer" },
                values: new object[] { "https://i0.wp.com/thecinemafiles.com/wp-content/uploads/2020/09/tenet-banner.jpg?ssl=1", "En el mundo del espionaje internacional, un hombre (John David Washington) prefiere morir antes que entregar a sus compañeros.", "Tenet", "https://www.youtube.com/embed/CdRL6o8z-2A" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 4,
                columns: new[] { "Poster", "Sinopsis", "Titulo", "Trailer" },
                values: new object[] { "https://cineverso.es/wp-content/uploads/2021/11/marvel-eternals.jpg", "Hace millones de años, los seres cósmicos conocidos como los Celestiales comenzaron a experimentar genéticamente con los humanos. Su intención era crear individuos superpoderosos que hicieran únicamente el bien.", "Eternals", "https://www.youtube.com/embed/MKWXuj3ZYf0" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 5,
                columns: new[] { "Poster", "Sinopsis", "Titulo", "Trailer" },
                values: new object[] { "https://wallpaperaccess.com/full/7485234.jpg", "Encanto nos sitúa en el corazón de Colombia, narrando la increíble aventura de una joven y su familia. Pero, sorprendentemente, todos los miembros del clan tienen poderes mágicos excepto la protagonista.", "Encanto", "https://www.youtube.com/embed/E4dCY_DvT-4" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 6,
                columns: new[] { "Poster", "Sinopsis", "Titulo", "Trailer" },
                values: new object[] { "https://wallpaperaccess.com/full/6790561.jpg", "Después de que Mysterio desvelara la identidad de Spider-Man a todo el mundo en Lejos de casa, Peter Parker (Tom Holland), desesperado por volver a la normalidad y recuperar su anterior vida, pide ayuda a Doctor Strange para enmendar tal acción.", "Spider man: no way home", "https://www.youtube.com/embed/rt-2cxAiPJk" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 13,
                column: "Poster",
                value: "https://lifesciences.ucla.edu/wp-content/uploads/sites/3/2020/10/Cocoimage.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 1,
                columns: new[] { "Poster", "Sinopsis", "Titulo", "Trailer" },
                values: new object[] { "https://lukewilliamsblog.files.wordpress.com/2012/05/seven-movie-poster-500w.jpg", "El veterano teniente Somerset(Morgan Freeman), del departamento de homicidios, está a punto de jubilarse y ser reemplazado por el ambicioso e impulsivo detective David Mills(Brad Pitt).", "seven", "https://www.youtube.com/embed/xhzBmjdehPA" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 4,
                columns: new[] { "Poster", "Sinopsis", "Titulo", "Trailer" },
                values: new object[] { "https://es.web.img3.acsta.net/r_1920_1080/medias/nmedia/18/89/67/45/20061512.jpg", "En la Tierra Media, el Señor Oscuro Sauron ordenó a los Elfos que forjaran los Grandes Anillos de Poder. Tres para los reyes Elfos, siete para los Señores Enanos, y nueve para los Hombres Mortales.", "el señor de los anillos: La comunidad del anillo", "https://www.youtube.com/embed/3GJp6p_mgPo" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 5,
                columns: new[] { "Poster", "Sinopsis", "Titulo", "Trailer" },
                values: new object[] { "https://es.web.img2.acsta.net/r_1280_720/medias/nmedia/00/02/46/23/affiche.jpg", "Durante la Segunda Guerra Mundial, Wladyslaw Szpilman, un célebre pianista judío de origen polaco, escapa a la deportación, pero se encuentra hacinado en el gueto de Varsovia, donde comparte con los demás sufrimientos, humillaciones y luchas heroicas.", "el pianista", "https://www.youtube.com/embed/yDA1mK6v-ME" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 6,
                columns: new[] { "Poster", "Sinopsis", "Titulo", "Trailer" },
                values: new object[] { "https://es.web.img3.acsta.net/r_1280_720/img/6b/c7/6bc7a13ca6446a603f160b4ab4414141.jpg", "Máximo, interpretado por el ya conocido Russell Crowe, es un General romano muy importante para el Emperador Marco Aurelio. Cómodo, el hijo de Marco Aurelio, está celoso del prestigio de Máximo y del amor que le profesa su padre.", "gladiador", "https://www.youtube.com/embed/uvbavW31adA" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 13,
                column: "Poster",
                value: "https://es.web.img3.acsta.net/r_1280_720/img/86/42/86423dfc4aea8afac1986c1c2c432879.jpg");
        }
    }
}
