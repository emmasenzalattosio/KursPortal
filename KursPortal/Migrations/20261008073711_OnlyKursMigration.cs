using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KursPortal.Migrations
{
    /// <inheritdoc />
    public partial class OnlyKursMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kurse",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KursName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dozent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnzahlTeilnehmer = table.Column<int>(type: "int", nullable: false),
                    DauerInTagen = table.Column<int>(type: "int", nullable: false),
                    Inhalt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Beschreibung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lernziele = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kurse", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kurse");
        }
    }
}
