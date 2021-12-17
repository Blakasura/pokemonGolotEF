using Microsoft.EntityFrameworkCore.Migrations;

namespace pokemonGolot.Migrations
{
    public partial class AddedEvolucionstable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Pokemons_id_pokemon_evolucioid_pokemon",
                table: "Pokemons");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_id_pokemon_evolucioid_pokemon",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "id_pokemon_evolucioid_pokemon",
                table: "Pokemons");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "id_pokemon_evolucioid_pokemon",
                table: "Pokemons",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_id_pokemon_evolucioid_pokemon",
                table: "Pokemons",
                column: "id_pokemon_evolucioid_pokemon");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Pokemons_id_pokemon_evolucioid_pokemon",
                table: "Pokemons",
                column: "id_pokemon_evolucioid_pokemon",
                principalTable: "Pokemons",
                principalColumn: "id_pokemon",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
