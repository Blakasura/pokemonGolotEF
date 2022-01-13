using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pokemonGolotEF.Migrations
{
    public partial class changedvistfrombooleantochar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<char>(
                name: "vist_pokedex",
                table: "Pokedexs",
                type: "character(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "vist_pokedex",
                table: "Pokedexs",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(char),
                oldType: "character(1)");
        }
    }
}
