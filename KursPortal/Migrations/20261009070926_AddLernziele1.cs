using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KursPortal.Migrations
{
    /// <inheritdoc />
    public partial class AddLernziele1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lernziele",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KursID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lernziele", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Lernziele_Kurse_KursID",
                        column: x => x.KursID,
                        principalTable: "Kurse",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lernziele_KursID",
                table: "Lernziele",
                column: "KursID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lernziele");
        }
    }
}
