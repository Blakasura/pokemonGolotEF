using Microsoft.EntityFrameworkCore.Migrations;

namespace pokemonGolot.Migrations
{
    public partial class AddedEvolucionstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Evolucio",
                columns: table => new
                {
                    id_pokemon = table.Column<int>(type: "integer", nullable: false),
                    id_pokemon_evolucio = table.Column<int>(type: "integer", nullable: false),
                    caramels_necessaris = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evolucio", x => new { x.id_pokemon, x.id_pokemon_evolucio });
                    table.ForeignKey(
                        name: "FK_Evolucio_Pokemons_id_pokemon",
                        column: x => x.id_pokemon,
                        principalTable: "Pokemons",
                        principalColumn: "id_pokemon",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evolucio_Pokemons_id_pokemon_evolucio",
                        column: x => x.id_pokemon_evolucio,
                        principalTable: "Pokemons",
                        principalColumn: "id_pokemon",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Evolucio_id_pokemon_evolucio",
                table: "Evolucio",
                column: "id_pokemon_evolucio");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evolucio");
        }
    }
}
