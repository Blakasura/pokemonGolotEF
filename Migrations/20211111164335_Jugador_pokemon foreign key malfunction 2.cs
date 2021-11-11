using Microsoft.EntityFrameworkCore.Migrations;

namespace pokemonGolot.Migrations
{
    public partial class Jugador_pokemonforeignkeymalfunction2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jugadors_Pokemons_Jugadors_jugadorId",
                table: "Jugadors_Pokemons");

            migrationBuilder.DropIndex(
                name: "IX_Jugadors_Pokemons_jugadorId",
                table: "Jugadors_Pokemons");

            migrationBuilder.AddColumn<int>(
                name: "jugador_pokemon",
                table: "Jugadors",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Jugadors_jugador_pokemon",
                table: "Jugadors",
                column: "jugador_pokemon",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Jugadors_Jugadors_Pokemons_jugador_pokemon",
                table: "Jugadors",
                column: "jugador_pokemon",
                principalTable: "Jugadors_Pokemons",
                principalColumn: "id_jugador_pokemon",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jugadors_Jugadors_Pokemons_jugador_pokemon",
                table: "Jugadors");

            migrationBuilder.DropIndex(
                name: "IX_Jugadors_jugador_pokemon",
                table: "Jugadors");

            migrationBuilder.DropColumn(
                name: "jugador_pokemon",
                table: "Jugadors");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadors_Pokemons_jugadorId",
                table: "Jugadors_Pokemons",
                column: "jugadorId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Jugadors_Pokemons_Jugadors_jugadorId",
                table: "Jugadors_Pokemons",
                column: "jugadorId",
                principalTable: "Jugadors",
                principalColumn: "nom_jugador",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
