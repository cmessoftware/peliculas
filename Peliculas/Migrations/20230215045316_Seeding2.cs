using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Peliculas.Migrations
{
    /// <inheritdoc />
    public partial class Seeding2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalaCine_Cines_CineId",
                table: "SalaCine");

            migrationBuilder.DropForeignKey(
                name: "FK_SalaCine_Peliculas_PeliculaId",
                table: "SalaCine");

            migrationBuilder.DropTable(
                name: "SalasDeCine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalaCine",
                table: "SalaCine");

            migrationBuilder.RenameTable(
                name: "SalaCine",
                newName: "SalasCine");

            migrationBuilder.RenameIndex(
                name: "IX_SalaCine_PeliculaId",
                table: "SalasCine",
                newName: "IX_SalasCine_PeliculaId");

            migrationBuilder.RenameIndex(
                name: "IX_SalaCine_CineId",
                table: "SalasCine",
                newName: "IX_SalasCine_CineId");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio",
                table: "SalasCine",
                type: "decimal(5,2)",
                precision: 5,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalasCine",
                table: "SalasCine",
                column: "Id");

            migrationBuilder.InsertData(
                table: "SalasCine",
                columns: new[] { "Id", "CineId", "Nombre", "PeliculaId", "Precio", "Tipo" },
                values: new object[,]
                {
                    { 1, 4, "Sala 1", null, 0m, 2 },
                    { 2, 4, "Sala 2", null, 0m, 1 },
                    { 3, 4, "Sala 3", null, 0m, 1 },
                    { 4, 4, "Sala 1", null, 0m, 2 },
                    { 5, 4, "Sala 2", null, 0m, 1 },
                    { 6, 4, "Sala 3", null, 0m, 1 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_SalasCine_Cines_CineId",
                table: "SalasCine",
                column: "CineId",
                principalTable: "Cines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalasCine_Peliculas_PeliculaId",
                table: "SalasCine",
                column: "PeliculaId",
                principalTable: "Peliculas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalasCine_Cines_CineId",
                table: "SalasCine");

            migrationBuilder.DropForeignKey(
                name: "FK_SalasCine_Peliculas_PeliculaId",
                table: "SalasCine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalasCine",
                table: "SalasCine");

            migrationBuilder.DeleteData(
                table: "SalasCine",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SalasCine",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SalasCine",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SalasCine",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SalasCine",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SalasCine",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.RenameTable(
                name: "SalasCine",
                newName: "SalaCine");

            migrationBuilder.RenameIndex(
                name: "IX_SalasCine_PeliculaId",
                table: "SalaCine",
                newName: "IX_SalaCine_PeliculaId");

            migrationBuilder.RenameIndex(
                name: "IX_SalasCine_CineId",
                table: "SalaCine",
                newName: "IX_SalaCine_CineId");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio",
                table: "SalaCine",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldPrecision: 5,
                oldScale: 2);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalaCine",
                table: "SalaCine",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "SalasDeCine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CineId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalasDeCine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalasDeCine_Cines_CineId",
                        column: x => x.CineId,
                        principalTable: "Cines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SalasDeCine",
                columns: new[] { "Id", "CineId", "Nombre", "Precio", "Tipo" },
                values: new object[,]
                {
                    { 1, 4, "Sala 1", 0m, 2 },
                    { 2, 4, "Sala 2", 0m, 1 },
                    { 3, 4, "Sala 3", 0m, 1 },
                    { 4, 4, "Sala 1", 0m, 2 },
                    { 5, 4, "Sala 2", 0m, 1 },
                    { 6, 4, "Sala 3", 0m, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SalasDeCine_CineId",
                table: "SalasDeCine",
                column: "CineId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalaCine_Cines_CineId",
                table: "SalaCine",
                column: "CineId",
                principalTable: "Cines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalaCine_Peliculas_PeliculaId",
                table: "SalaCine",
                column: "PeliculaId",
                principalTable: "Peliculas",
                principalColumn: "Id");
        }
    }
}
