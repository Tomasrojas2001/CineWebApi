using Microsoft.EntityFrameworkCore.Migrations;

namespace AccessData.Migrations
{
    public partial class migrationNueva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 2,
                column: "Trailer",
                value: "https://www.youtube.com/embed/1pjJPmzCmgE");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 6,
                column: "Trailer",
                value: "https://www.youtube.com/embed/uePBwv_s6gM");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 7,
                columns: new[] { "Poster", "Sinopsis", "Titulo", "Trailer" },
                values: new object[] { "https://es.web.img3.acsta.net/r_1280_720/pictures/21/09/27/08/50/1188066.jpg", "En esta película, la número 25 de la franquicia, James Bond (Daniel Craig) ha dejado el servicio activo y disfruta de una vida tranquila en Jamaica. ring", "Sin tiempo para morir", "https://www.youtube.com/embed/VYvmuz7ILvg" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 9,
                columns: new[] { "Poster", "Sinopsis", "Titulo", "Trailer" },
                values: new object[] { "https://dunenewsnet.com/wp-content/uploads/2021/08/Dune-Movie-Official-Poster-banner-feature.jpg", "Un futuro lejano, en el que las familias de nobles se disputan el dominio del árido planeta Arrakis, también conocido como Dune por su geografía compuesta por desiertos de dunas", "Dune", "https://www.youtube.com/embed/GooZSRSWdLQ" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 10,
                column: "Trailer",
                value: "https://www.youtube.com/embed/QWBKEmWWL38");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 11,
                column: "Trailer",
                value: "https://www.youtube.com/embed/OUwVHX3242M");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 2,
                column: "Trailer",
                value: "https://www.youtube.com/embed/FiRVcExwBVA");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 6,
                column: "Trailer",
                value: "https://www.youtube.com/embed/lsDdsvKVbMo");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 7,
                columns: new[] { "Poster", "Sinopsis", "Titulo", "Trailer" },
                values: new object[] { "https://es.web.img2.acsta.net/r_1280_720/medias/nmedia/18/35/44/61/18402266.jpg", "Una película ambientada en la década de los 20 que trata sobre Howard Hughes, uno de los hombres más prestigiosos dentro del mundo de la aviación y del cine. Sus películas fueron éxitos de la época.", "el aviador", "https://www.youtube.com/embed/vkl-vTLlB0s" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 9,
                columns: new[] { "Poster", "Sinopsis", "Titulo", "Trailer" },
                values: new object[] { "https://es.web.img3.acsta.net/r_1280_720/medias/nmedia/00/00/00/33/spiderman.jpg", "Huérfano, Peter Parker fue criado por su tía May y su tío Ben en el barrio de Queens de Nueva York.Sin embargo, después de que le picara una araña modificada genéticamente, la agilidad y la fuerza de Peter aumentan gracias a esta picadura.", "el hombre araña", "https://www.youtube.com/embed/TYMMOjBUPMM" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 10,
                column: "Trailer",
                value: "https://www.youtube.com/embed/OsaphlwhhmY");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 11,
                column: "Trailer",
                value: "https://www.youtube.com/embed/I-iJbMA3aoA");
        }
    }
}
