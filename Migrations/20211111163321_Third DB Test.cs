using Microsoft.EntityFrameworkCore.Migrations;

namespace pokemonGolot.Migrations
{
    public partial class ThirdDBTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokemon_Moviment",
                columns: table => new
                {
                    id_jugador_pokemon = table.Column<int>(type: "integer", nullable: false),
                    id_moviment = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon_Moviment", x => new { x.id_jugador_pokemon, x.id_moviment });
                    table.ForeignKey(
                        name: "FK_Pokemon_Moviment_Jugadors_Pokemons_id_jugador_pokemon",
                        column: x => x.id_jugador_pokemon,
                        principalTable: "Jugadors_Pokemons",
                        principalColumn: "id_jugador_pokemon",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pokemon_Moviment_Moviments_id_moviment",
                        column: x => x.id_moviment,
                        principalTable: "Moviments",
                        principalColumn: "id_moviment",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_Moviment_id_moviment",
                table: "Pokemon_Moviment",
                column: "id_moviment");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemon_Moviment");
        }
    }
}
