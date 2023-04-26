using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContatcsAPI.Migrations
{
    /// <inheritdoc />
    public partial class update_country : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Contacts");
        }
    }
}
