using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Amanda.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedTimestamp",
                table: "Users",
                newName: "date_time");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "date_time",
                table: "Users",
                newName: "CreatedTimestamp");
        }
    }
}
