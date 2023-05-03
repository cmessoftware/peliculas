using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Peliculas.Web.Migrations
{
    public partial class fixgeneros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PeliculaId",
                table: "Generos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PeliculaId",
                table: "Generos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
