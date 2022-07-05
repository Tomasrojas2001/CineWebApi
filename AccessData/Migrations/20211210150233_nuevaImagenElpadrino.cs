using Microsoft.EntityFrameworkCore.Migrations;

namespace AccessData.Migrations
{
    public partial class nuevaImagenElpadrino : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 3,
                column: "Poster",
                value: "https://wc.wallpaperuse.com/wallp/8-85274_s.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 3,
                column: "Poster",
                value: "https://es.web.img3.acsta.net/r_1920_1080/pictures/18/06/12/12/12/0117051.jpg?coixp=49&coiyp=27");
        }
    }
}
