using Microsoft.EntityFrameworkCore.Migrations;

namespace AccessData.Migrations
{
    public partial class migracionJoker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 10,
                column: "Poster",
                value: "http://storymind.com/blog/wp-content/uploads/2017/03/1-2.jpg");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 14,
                column: "Poster",
                value: "https://i.pinimg.com/originals/41/eb/8a/41eb8aa615ec4c6abaf8866f070c29c3.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 10,
                column: "Poster",
                value: "https://es.web.img3.acsta.net/r_1280_720/img/21/01/2101e793fa60041b7295bf426ac37258.jpg");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 14,
                column: "Poster",
                value: "https://es.web.img2.acsta.net/r_1280_720/pictures/19/09/17/17/03/5442885.jpg");
        }
    }
}
