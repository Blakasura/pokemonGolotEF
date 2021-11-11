using Microsoft.EntityFrameworkCore.Migrations;

namespace pokemonGolot.Migrations
{
    public partial class AddedOUtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ous",
                columns: table => new
                {
                    tipus_ou = table.Column<string>(type: "text", nullable: false),
                    descripcio_ou = table.Column<string>(type: "text", nullable: true),
                    distancia_ou = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ous", x => x.tipus_ou);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ous");
        }
    }
}
