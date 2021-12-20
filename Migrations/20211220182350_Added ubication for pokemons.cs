using Microsoft.EntityFrameworkCore.Migrations;

namespace pokemonGolot.Migrations
{
    public partial class Addedubicationforpokemons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ubicacio_pokemon",
                table: "Jugadors_Pokemons",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ubicacio_pokemon",
                table: "Jugadors_Pokemons");
        }
    }
}
