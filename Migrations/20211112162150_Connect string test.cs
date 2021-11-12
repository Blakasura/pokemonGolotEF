using Microsoft.EntityFrameworkCore.Migrations;

namespace pokemonGolot.Migrations
{
    public partial class Connectstringtest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "vida_pokemon",
                table: "Jugadors_Pokemons_Gimnasos");

            migrationBuilder.AddColumn<int>(
                name: "vida_pokemon",
                table: "Jugadors_Pokemons",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "vida_pokemon",
                table: "Jugadors_Pokemons");

            migrationBuilder.AddColumn<int>(
                name: "vida_pokemon",
                table: "Jugadors_Pokemons_Gimnasos",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
