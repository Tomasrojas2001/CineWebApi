using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccessData.Migrations
{
    public partial class newMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Peliculas",
                columns: table => new
                {
                    PeliculaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Poster = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Sinopsis = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Trailer = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peliculas", x => x.PeliculaId);
                });

            migrationBuilder.CreateTable(
                name: "Salas",
                columns: table => new
                {
                    SalaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salas", x => x.SalaId);
                });

            migrationBuilder.CreateTable(
                name: "Funciones",
                columns: table => new
                {
                    FuncionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Horario = table.Column<TimeSpan>(type: "time", nullable: false),
                    PeliculaId = table.Column<int>(type: "int", nullable: false),
                    SalaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funciones", x => x.FuncionId);
                    table.ForeignKey(
                        name: "FK_Funciones_Peliculas_PeliculaId",
                        column: x => x.PeliculaId,
                        principalTable: "Peliculas",
                        principalColumn: "PeliculaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Funciones_Salas_SalaId",
                        column: x => x.SalaId,
                        principalTable: "Salas",
                        principalColumn: "SalaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FuncionId = table.Column<int>(type: "int", nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => new { x.TicketId, x.FuncionId });
                    table.ForeignKey(
                        name: "FK_Tickets_Funciones_FuncionId",
                        column: x => x.FuncionId,
                        principalTable: "Funciones",
                        principalColumn: "FuncionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Peliculas",
                columns: new[] { "PeliculaId", "Poster", "Sinopsis", "Titulo", "Trailer" },
                values: new object[,]
                {
                    { 1, "https://lukewilliamsblog.files.wordpress.com/2012/05/seven-movie-poster-500w.jpg", "El veterano teniente Somerset(Morgan Freeman), del departamento de homicidios, está a punto de jubilarse y ser reemplazado por el ambicioso e impulsivo detective David Mills(Brad Pitt).", "seven", "https://www.youtube.com/watch?v=xhzBmjdehPA" },
                    { 2, "https://www.tuposter.com/pub/media/catalog/product/cache/image/91bbed04eb86c2a8aaef7fbfb2041b2a/t/i/titanic_cartel.png", "Jack (DiCaprio), un joven artista, gana en una partida de cartas un pasaje para viajar a América en el Titanic, el transatlántico más grande y seguro jamás construido.", "titanic", "https://www.youtube.com/watch?v=FiRVcExwBVA" },
                    { 3, "https://es.web.img3.acsta.net/r_1920_1080/pictures/18/06/12/12/12/0117051.jpg?coixp=49&coiyp=27", "Vito Corleone es el jefe de una de las familias que lideran la Cosa Nostra neoyorkina durante los años 40. Dos de sus hijos participan en las actividades ilícitas, mientras que Michael Corleone está distanciado del negocio familiar.", "el padrino 1", "https://www.youtube.com/watch?v=COQvkUmN6H8" },
                    { 4, "https://es.web.img3.acsta.net/r_1920_1080/medias/nmedia/18/89/67/45/20061512.jpg", "En la Tierra Media, el Señor Oscuro Sauron ordenó a los Elfos que forjaran los Grandes Anillos de Poder. Tres para los reyes Elfos, siete para los Señores Enanos, y nueve para los Hombres Mortales.", "el señor de los anillos: La comunidad del anillo", "https://www.youtube.com/watch?v=3GJp6p_mgPo" },
                    { 5, "https://es.web.img2.acsta.net/r_1280_720/medias/nmedia/00/02/46/23/affiche.jpg", "Durante la Segunda Guerra Mundial, Wladyslaw Szpilman, un célebre pianista judío de origen polaco, escapa a la deportación, pero se encuentra hacinado en el gueto de Varsovia, donde comparte con los demás sufrimientos, humillaciones y luchas heroicas.", "el pianista", "https://www.youtube.com/watch?v=yDA1mK6v-ME" },
                    { 6, "https://es.web.img3.acsta.net/r_1280_720/img/6b/c7/6bc7a13ca6446a603f160b4ab4414141.jpg", "Máximo, interpretado por el ya conocido Russell Crowe, es un General romano muy importante para el Emperador Marco Aurelio. Cómodo, el hijo de Marco Aurelio, está celoso del prestigio de Máximo y del amor que le profesa su padre.", "gladiador", "https://www.youtube.com/watch?v=lsDdsvKVbMo" },
                    { 7, "https://es.web.img2.acsta.net/r_1280_720/medias/nmedia/18/35/44/61/18402266.jpg", "Una película ambientada en la década de los 20 que trata sobre Howard Hughes, uno de los hombres más prestigiosos dentro del mundo de la aviación y del cine. Sus películas fueron éxitos de la época.", "el aviador", "https://www.youtube.com/watch?v=vkl-vTLlB0s" },
                    { 8, "https://es.web.img2.acsta.net/r_1280_720/img/06/a3/06a3a4901ffc378b3a2b065ca15b3fbb.jpg", "En 1954 el agente Teddy Daniels y su compañero Check Aule son enviados a la isla de Shutter Island a investigar en un hospital psiquiátrico donde están internados peligrosos criminales.", "la isla siniestra", "https://www.youtube.com/watch?v=95z6iWCjEgc" },
                    { 9, "https://es.web.img3.acsta.net/r_1280_720/medias/nmedia/00/00/00/33/spiderman.jpg", "Huérfano, Peter Parker fue criado por su tía May y su tío Ben en el barrio de Queens de Nueva York.Sin embargo, después de que le picara una araña modificada genéticamente, la agilidad y la fuerza de Peter aumentan gracias a esta picadura.", "el hombre araña", "https://www.youtube.com/watch?v=TYMMOjBUPMM" },
                    { 10, "https://es.web.img3.acsta.net/r_1280_720/img/21/01/2101e793fa60041b7295bf426ac37258.jpg", "Pese a la extinción de los dinosaurios, InGen ha logrado clonar diversas especies mediante la manipulación de segmentos de ADN de la propia sangre de estos, encontrada en mosquitos fosilizados.", "jurassic park", "https://www.youtube.com/watch?v=OsaphlwhhmY" }
                });

            migrationBuilder.InsertData(
                table: "Salas",
                columns: new[] { "SalaId", "Capacidad" },
                values: new object[,]
                {
                    { 1, 5 },
                    { 2, 15 },
                    { 3, 35 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Funciones_PeliculaId",
                table: "Funciones",
                column: "PeliculaId");

            migrationBuilder.CreateIndex(
                name: "IX_Funciones_SalaId",
                table: "Funciones",
                column: "SalaId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_FuncionId",
                table: "Tickets",
                column: "FuncionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Funciones");

            migrationBuilder.DropTable(
                name: "Peliculas");

            migrationBuilder.DropTable(
                name: "Salas");
        }
    }
}
