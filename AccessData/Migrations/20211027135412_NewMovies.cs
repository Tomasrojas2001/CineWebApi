using Microsoft.EntityFrameworkCore.Migrations;

namespace AccessData.Migrations
{
    public partial class NewMovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 1,
                column: "Trailer",
                value: "https://youtu.be/xhzBmjdehPA");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 2,
                column: "Trailer",
                value: "https://youtu.be/FiRVcExwBVA");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 3,
                column: "Trailer",
                value: "https://youtu.be/COQvkUmN6H8");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 4,
                column: "Trailer",
                value: "https://youtu.be/3GJp6p_mgPo");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 5,
                column: "Trailer",
                value: "https://youtu.be/yDA1mK6v-ME");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 6,
                column: "Trailer",
                value: "https://youtu.be/lsDdsvKVbMo");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 7,
                column: "Trailer",
                value: "https://youtu.be/vkl-vTLlB0s");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 8,
                column: "Trailer",
                value: "https://youtu.be/95z6iWCjEgc");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 9,
                column: "Trailer",
                value: "https://youtu.be/TYMMOjBUPMM");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 10,
                column: "Trailer",
                value: "https://youtu.be/OsaphlwhhmY");

            migrationBuilder.InsertData(
                table: "Peliculas",
                columns: new[] { "PeliculaId", "Poster", "Sinopsis", "Titulo", "Trailer" },
                values: new object[,]
                {
                    { 11, "https://es.web.img2.acsta.net/r_1280_720/pictures/21/09/15/17/03/3215619.jpg", "Laurie Strode(Jamie Lee Curtis) vuelve a enfrentarse a su viejo archienemigo Michael Myers, la figura enmascarada que la había perseguido desde que escapó de aquella fatídica noche hace cuatro décadas", "Halloween kills", "https://youtu.be/I-iJbMA3aoA" },
                    { 12, "https://es.web.img3.acsta.net/r_1280_720/pictures/19/07/30/09/09/0763744.jpg", "Han pasado casi 30 desde que el Club de Perdedores formado por Bill, Berverly, Richie, Ben, Eddie, Mike y Stanley se enfrentaran al macabro y despiadado Pennywise (Bill Skarsgård).", "It Capitulo 2", "https://youtu.be/o1sQbtZpsic" },
                    { 13, "https://es.web.img3.acsta.net/r_1280_720/img/86/42/86423dfc4aea8afac1986c1c2c432879.jpg", "En un pequeño y alegre pueblo mexicano vive Miguel, un niño de 12 años que pertenece a una familia de zapateros, en la que la música está prohibida.", "Coco", "https://youtu.be/awzWdtCezDo" },
                    { 14, "https://es.web.img2.acsta.net/r_1280_720/pictures/19/09/17/17/03/5442885.jpg", "El subestimado y mentalmente enfermo Arthur Fleck ha ganado popularidad y su vida y la de ciudad Gótica dan un giro radical", "Joker", "https://youtu.be/t433PEQGErc" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 14);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 1,
                column: "Trailer",
                value: "https://www.youtube.com/watch?v=xhzBmjdehPA");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 2,
                column: "Trailer",
                value: "https://www.youtube.com/watch?v=FiRVcExwBVA");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 3,
                column: "Trailer",
                value: "https://www.youtube.com/watch?v=COQvkUmN6H8");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 4,
                column: "Trailer",
                value: "https://www.youtube.com/watch?v=3GJp6p_mgPo");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 5,
                column: "Trailer",
                value: "https://www.youtube.com/watch?v=yDA1mK6v-ME");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 6,
                column: "Trailer",
                value: "https://www.youtube.com/watch?v=lsDdsvKVbMo");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 7,
                column: "Trailer",
                value: "https://www.youtube.com/watch?v=vkl-vTLlB0s");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 8,
                column: "Trailer",
                value: "https://www.youtube.com/watch?v=95z6iWCjEgc");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 9,
                column: "Trailer",
                value: "https://www.youtube.com/watch?v=TYMMOjBUPMM");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 10,
                column: "Trailer",
                value: "https://www.youtube.com/watch?v=OsaphlwhhmY");
        }
    }
}
