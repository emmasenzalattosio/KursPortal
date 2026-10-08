using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KursPortal.Migrations
{
    /// <inheritdoc />
    public partial class OnlyKursMigration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lernziele",
                table: "Kurse");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Lernziele",
                table: "Kurse",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
