using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Amanda.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MyDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Senha",
                table: "Users",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Users",
                newName: "Username");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "password",
                table: "Users",
                newName: "Senha");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Users",
                newName: "Nome");
        }
    }
}
