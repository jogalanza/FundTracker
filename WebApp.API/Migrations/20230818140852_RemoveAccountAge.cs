using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.API.Migrations
{
    /// <inheritdoc />
    public partial class RemoveAccountAge : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Accounts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Accounts",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Accounts",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
