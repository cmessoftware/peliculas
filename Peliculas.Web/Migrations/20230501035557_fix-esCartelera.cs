using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Peliculas.Web.Migrations
{
    public partial class fixesCartelera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EnCartelara",
                table: "Peliculas",
                newName: "EnCartelera");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EnCartelera",
                table: "Peliculas",
                newName: "EnCartelara");
        }
    }
}
