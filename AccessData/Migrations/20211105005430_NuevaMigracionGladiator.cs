using Microsoft.EntityFrameworkCore.Migrations;

namespace AccessData.Migrations
{
    public partial class NuevaMigracionGladiator : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 6,
                column: "Trailer",
                value: "https://www.youtube.com/embed/uvbavW31adA");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 6,
                column: "Trailer",
                value: "https://www.youtube.com/embed/uePBwv_s6gM");
        }
    }
}
