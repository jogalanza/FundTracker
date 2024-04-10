using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.API.Migrations
{
    /// <inheritdoc />
    public partial class InsertAccountKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Accounts",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "Accounts",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "Key",
                table: "Accounts");
        }
    }
}
