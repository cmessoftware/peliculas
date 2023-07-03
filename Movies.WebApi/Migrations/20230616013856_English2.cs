using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class English2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalasCine_Cinemas_CineId",
                table: "SalasCine");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_SalasCine_RoomCinemaId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_UbicacionesEnSala_SalasCine_RoomCinemaId",
                table: "UbicacionesEnSala");

            migrationBuilder.DropTable(
                name: "ActorPelicula");

            migrationBuilder.DropTable(
                name: "GeneroPelicula");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UbicacionesEnSala",
                table: "UbicacionesEnSala");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalasCine",
                table: "SalasCine");

            migrationBuilder.RenameTable(
                name: "UbicacionesEnSala",
                newName: "RoomCinemaLocation");

            migrationBuilder.RenameTable(
                name: "SalasCine",
                newName: "RoomCinema");

            migrationBuilder.RenameColumn(
                name: "DNI",
                table: "Users",
                newName: "IdentificationNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Entradas_SalaCineId",
                table: "Tickets",
                newName: "IX_Tickets_RoomCinemaId");

            migrationBuilder.RenameIndex(
                name: "IX_Entradas_FuncionId",
                table: "Tickets",
                newName: "IX_Tickets_FunctionId");

            migrationBuilder.RenameIndex(
                name: "IX_Entradas_ClienteId",
                table: "Tickets",
                newName: "IX_Tickets_ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Funciones_PeliculaId",
                table: "Functions",
                newName: "IX_Functions_MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_Criticas_PeliculaId",
                table: "Critics",
                newName: "IX_Critics_MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_Comentarios_PeliculaId",
                table: "Comments",
                newName: "IX_Comments_MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_Cines_PeliculaId",
                table: "Cinemas",
                newName: "IX_Cinemas_MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_CineOfertas_CineId",
                table: "CinemaOffers",
                newName: "IX_CinemaOffers_CinemaId");

            migrationBuilder.RenameColumn(
                name: "CP",
                table: "Address",
                newName: "ZipCode");

            migrationBuilder.RenameColumn(
                name: "FotoURL",
                table: "Actors",
                newName: "UrlPhoto");

            migrationBuilder.RenameIndex(
                name: "IX_UbicacionesEnSala_SalaCineId",
                table: "RoomCinemaLocation",
                newName: "IX_RoomCinemaLocation_RoomCinemaId");

            migrationBuilder.RenameIndex(
                name: "IX_SalasCine_CineId",
                table: "RoomCinema",
                newName: "IX_RoomCinema_CinemaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomCinemaLocation",
                table: "RoomCinemaLocation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomCinema",
                table: "RoomCinema",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ActorMovie",
                columns: table => new
                {
                    ActorsId = table.Column<int>(type: "int", nullable: false),
                    MoviesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorMovie", x => new { x.ActorsId, x.MoviesId });
                    table.ForeignKey(
                        name: "FK_ActorMovie_Actors_ActorsId",
                        column: x => x.ActorsId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorMovie_Movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenderMovie",
                columns: table => new
                {
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenderMovie", x => new { x.GenderId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_GenderMovie_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenderMovie_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorMovie_MoviesId",
                table: "ActorMovie",
                column: "MoviesId");

            migrationBuilder.CreateIndex(
                name: "IX_GenderMovie_MoviesId",
                table: "GenderMovie",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomCinema_Cinemas_CineId",
                table: "RoomCinema",
                column: "CineId",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomCinemaLocation_RoomCinema_RoomCinemaId",
                table: "RoomCinemaLocation",
                column: "RoomCinemaId",
                principalTable: "RoomCinema",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_RoomCinema_RoomCinemaId",
                table: "Tickets",
                column: "RoomCinemaId",
                principalTable: "RoomCinema",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomCinema_Cinemas_CineId",
                table: "RoomCinema");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomCinemaLocation_RoomCinema_RoomCinemaId",
                table: "RoomCinemaLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_RoomCinema_RoomCinemaId",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "ActorMovie");

            migrationBuilder.DropTable(
                name: "GenderMovie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomCinemaLocation",
                table: "RoomCinemaLocation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomCinema",
                table: "RoomCinema");

            migrationBuilder.RenameTable(
                name: "RoomCinemaLocation",
                newName: "UbicacionesEnSala");

            migrationBuilder.RenameTable(
                name: "RoomCinema",
                newName: "SalasCine");

            migrationBuilder.RenameColumn(
                name: "IdentificationNumber",
                table: "Users",
                newName: "DNI");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_RoomCinemaId",
                table: "Tickets",
                newName: "IX_Entradas_SalaCineId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_FunctionId",
                table: "Tickets",
                newName: "IX_Entradas_FuncionId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_ClientId",
                table: "Tickets",
                newName: "IX_Entradas_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Functions_MovieId",
                table: "Functions",
                newName: "IX_Funciones_PeliculaId");

            migrationBuilder.RenameIndex(
                name: "IX_Critics_MovieId",
                table: "Critics",
                newName: "IX_Criticas_PeliculaId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_MovieId",
                table: "Comments",
                newName: "IX_Comentarios_PeliculaId");

            migrationBuilder.RenameIndex(
                name: "IX_Cinemas_MovieId",
                table: "Cinemas",
                newName: "IX_Cines_PeliculaId");

            migrationBuilder.RenameIndex(
                name: "IX_CinemaOffers_CinemaId",
                table: "CinemaOffers",
                newName: "IX_CineOfertas_CineId");

            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "Address",
                newName: "CP");

            migrationBuilder.RenameColumn(
                name: "UrlPhoto",
                table: "Actors",
                newName: "FotoURL");

            migrationBuilder.RenameIndex(
                name: "IX_RoomCinemaLocation_RoomCinemaId",
                table: "UbicacionesEnSala",
                newName: "IX_UbicacionesEnSala_SalaCineId");

            migrationBuilder.RenameIndex(
                name: "IX_RoomCinema_CinemaId",
                table: "SalasCine",
                newName: "IX_SalasCine_CineId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UbicacionesEnSala",
                table: "UbicacionesEnSala",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalasCine",
                table: "SalasCine",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ActorPelicula",
                columns: table => new
                {
                    ActoresId = table.Column<int>(type: "int", nullable: false),
                    PeliculasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorPelicula", x => new { x.ActoresId, x.PeliculasId });
                    table.ForeignKey(
                        name: "FK_ActorPelicula_Actors_ActoresId",
                        column: x => x.ActoresId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorPelicula_Movies_PeliculasId",
                        column: x => x.PeliculasId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GeneroPelicula",
                columns: table => new
                {
                    GenerosId = table.Column<int>(type: "int", nullable: false),
                    PeliculasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneroPelicula", x => new { x.GenerosId, x.PeliculasId });
                    table.ForeignKey(
                        name: "FK_GeneroPelicula_Genders_GenerosId",
                        column: x => x.GenerosId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GeneroPelicula_Movies_PeliculasId",
                        column: x => x.PeliculasId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorPelicula_PeliculasId",
                table: "ActorPelicula",
                column: "PeliculasId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneroPelicula_PeliculasId",
                table: "GeneroPelicula",
                column: "PeliculasId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalasCine_Cinemas_CineId",
                table: "SalasCine",
                column: "CineId",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_SalasCine_RoomCinemaId",
                table: "Tickets",
                column: "RoomCinemaId",
                principalTable: "SalasCine",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UbicacionesEnSala_SalasCine_RoomCinemaId",
                table: "UbicacionesEnSala",
                column: "RoomCinemaId",
                principalTable: "SalasCine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
