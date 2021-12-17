using Microsoft.EntityFrameworkCore.Migrations;

namespace pokemonGolot.Migrations
{
    public partial class AddedEvolucionsdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evolucio_Pokemons_id_pokemon",
                table: "Evolucio");

            migrationBuilder.DropForeignKey(
                name: "FK_Evolucio_Pokemons_id_pokemon_evolucio",
                table: "Evolucio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Evolucio",
                table: "Evolucio");

            migrationBuilder.RenameTable(
                name: "Evolucio",
                newName: "Evolucions");

            migrationBuilder.RenameIndex(
                name: "IX_Evolucio_id_pokemon_evolucio",
                table: "Evolucions",
                newName: "IX_Evolucions_id_pokemon_evolucio");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Evolucions",
                table: "Evolucions",
                columns: new[] { "id_pokemon", "id_pokemon_evolucio" });

            migrationBuilder.AddForeignKey(
                name: "FK_Evolucions_Pokemons_id_pokemon",
                table: "Evolucions",
                column: "id_pokemon",
                principalTable: "Pokemons",
                principalColumn: "id_pokemon",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Evolucions_Pokemons_id_pokemon_evolucio",
                table: "Evolucions",
                column: "id_pokemon_evolucio",
                principalTable: "Pokemons",
                principalColumn: "id_pokemon",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evolucions_Pokemons_id_pokemon",
                table: "Evolucions");

            migrationBuilder.DropForeignKey(
                name: "FK_Evolucions_Pokemons_id_pokemon_evolucio",
                table: "Evolucions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Evolucions",
                table: "Evolucions");

            migrationBuilder.RenameTable(
                name: "Evolucions",
                newName: "Evolucio");

            migrationBuilder.RenameIndex(
                name: "IX_Evolucions_id_pokemon_evolucio",
                table: "Evolucio",
                newName: "IX_Evolucio_id_pokemon_evolucio");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Evolucio",
                table: "Evolucio",
                columns: new[] { "id_pokemon", "id_pokemon_evolucio" });

            migrationBuilder.AddForeignKey(
                name: "FK_Evolucio_Pokemons_id_pokemon",
                table: "Evolucio",
                column: "id_pokemon",
                principalTable: "Pokemons",
                principalColumn: "id_pokemon",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Evolucio_Pokemons_id_pokemon_evolucio",
                table: "Evolucio",
                column: "id_pokemon_evolucio",
                principalTable: "Pokemons",
                principalColumn: "id_pokemon",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
