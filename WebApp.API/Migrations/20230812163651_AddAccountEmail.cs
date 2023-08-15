using Microsoft.EntityFrameworkCore.Migrations;
using WebApp.Model;

#nullable disable

namespace WebApp.API.Migrations
{
    /// <inheritdoc />
    public partial class AddAccountEmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Account>("Email", "Accounts", type: "text", nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn("Email", "Accounts");
        }
    }
}
