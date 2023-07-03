using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class ReafactoringUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Clients_ClientId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Clients_ClientId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Clients_ClientId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLogin_Address_AddressId",
                table: "UserLogin");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLogin_Clients_ClientId",
                table: "UserLogin");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "UserLogin");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "UserLogin");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "UserLogin");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "UserLogin",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_AddressId",
                table: "UserLogin",
                newName: "IX_UserLogin_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_UserLogin_ClientId",
                table: "UserLogin",
                newName: "IX_UserLogin_UserId");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Address",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Address_ClientId",
                table: "Address",
                newName: "IX_Address_UserId");

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "UserLogin",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DNI = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Users_UserId",
                table: "Address",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_ClientId",
                table: "Comments",
                column: "ClientId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Users_ClientId",
                table: "Tickets",
                column: "ClientId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogin_Address_AddressId",
                table: "UserLogin",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogin_Users_UserId",
                table: "UserLogin",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Users_UserId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_ClientId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Users_ClientId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLogin_Address_AddressId",
                table: "UserLogin");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLogin_Users_UserId",
                table: "UserLogin");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UserLogin",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_UserLogin_UserId",
                table: "UserLogin",
                newName: "IX_UserLogin_ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_UserLogin_AddressId",
                table: "UserLogin",
                newName: "IX_Users_AddressId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Address",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Address_UserId",
                table: "Address",
                newName: "IX_Address_ClientId");

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "UserLogin",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "UserLogin",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "UserLogin",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "UserLogin",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DNI = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Clients_ClientId",
                table: "Address",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Clients_ClientId",
                table: "Comments",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Clients_ClientId",
                table: "Tickets",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogin_Address_AddressId",
                table: "UserLogin",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogin_Clients_ClientId",
                table: "UserLogin",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id");
        }
    }
}
