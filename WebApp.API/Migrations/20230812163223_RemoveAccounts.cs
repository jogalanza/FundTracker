using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.API.Migrations
{
    /// <inheritdoc />
    public partial class RemoveAccounts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Accounts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
