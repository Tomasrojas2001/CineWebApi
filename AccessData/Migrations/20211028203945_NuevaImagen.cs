using Microsoft.EntityFrameworkCore.Migrations;

namespace AccessData.Migrations
{
    public partial class NuevaImagen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 8,
                column: "Poster",
                value: "https://www.zona-leros.net/storage/movies_tumbl/la-isla-siniestra-cover-knu.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 8,
                column: "Poster",
                value: "https://es.web.img2.acsta.net/r_1280_720/img/06/a3/06a3a4901ffc378b3a2b065ca15b3fbb.jpg");
        }
    }
}
