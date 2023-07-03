using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class UserDto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserLogin_Role_RoleId",
                table: "UserLogin");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLogin_Users_UserId",
                table: "UserLogin");

            migrationBuilder.DropIndex(
                name: "IX_UserLogin_RoleId",
                table: "UserLogin");

            migrationBuilder.DropIndex(
                name: "IX_UserLogin_UserId",
                table: "UserLogin");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "UserLogin");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserLogin");

            migrationBuilder.AddColumn<int>(
                name: "UserLoginId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserLoginId",
                table: "Users",
                column: "UserLoginId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserLogin_UserLoginId",
                table: "Users",
                column: "UserLoginId",
                principalTable: "UserLogin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserLogin_UserLoginId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserLoginId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserLoginId",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "UserLogin",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "UserLogin",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserLogin_RoleId",
                table: "UserLogin",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogin_UserId",
                table: "UserLogin",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogin_Role_RoleId",
                table: "UserLogin",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogin_Users_UserId",
                table: "UserLogin",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
