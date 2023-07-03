using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class allow_nulls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Users_MovieUserId",
                table: "Roles");

            migrationBuilder.RenameColumn(
                name: "MovieUserId",
                table: "Roles",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Roles_MovieUserId",
                table: "Roles",
                newName: "IX_Roles_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Users_UserId",
                table: "Roles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Users_UserId",
                table: "Roles");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Roles",
                newName: "MovieUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Roles_UserId",
                table: "Roles",
                newName: "IX_Roles_MovieUserId");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Users_MovieUserId",
                table: "Roles",
                column: "MovieUserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
