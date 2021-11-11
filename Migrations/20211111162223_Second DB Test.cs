using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace pokemonGolot.Migrations
{
    public partial class SecondDBTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jugadors_Pokemons_pokemonid_pokemon",
                table: "Jugadors");

            migrationBuilder.DropForeignKey(
                name: "FK_Jugadors_Pokemons_Jugadors_jugadornom_jugador",
                table: "Jugadors_Pokemons");

            migrationBuilder.DropTable(
                name: "Acompanyants");

            migrationBuilder.DropTable(
                name: "Evolucio");

            migrationBuilder.DropTable(
                name: "Regals_enviats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Regals",
                table: "Regals");

            migrationBuilder.DropIndex(
                name: "IX_Jugadors_Pokemons_jugadornom_jugador",
                table: "Jugadors_Pokemons");

            migrationBuilder.DropIndex(
                name: "IX_Jugadors_pokemonid_pokemon",
                table: "Jugadors");

            migrationBuilder.DropColumn(
                name: "pokemonid_pokemon",
                table: "Jugadors");

            migrationBuilder.RenameColumn(
                name: "id_regal",
                table: "Regals",
                newName: "id_pokeparada");

            migrationBuilder.RenameColumn(
                name: "jugadornom_jugador",
                table: "Jugadors_Pokemons",
                newName: "jugadorId");

            migrationBuilder.AlterColumn<int>(
                name: "id_pokeparada",
                table: "Regals",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<string>(
                name: "id_jugador",
                table: "Regals",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "id_pokemon_evolucioid_pokemon",
                table: "Pokemons",
                type: "integer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Regals",
                table: "Regals",
                columns: new[] { "id_jugador", "id_pokeparada" });

            migrationBuilder.CreateIndex(
                name: "IX_Regals_id_pokeparada",
                table: "Regals",
                column: "id_pokeparada");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_id_pokemon_evolucioid_pokemon",
                table: "Pokemons",
                column: "id_pokemon_evolucioid_pokemon");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Pokemons_id_pokemon_evolucioid_pokemon",
                table: "Pokemons",
                column: "id_pokemon_evolucioid_pokemon",
                principalTable: "Pokemons",
                principalColumn: "id_pokemon",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Regals_Jugadors_id_jugador",
                table: "Regals",
                column: "id_jugador",
                principalTable: "Jugadors",
                principalColumn: "nom_jugador",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Regals_Pokeparades_id_pokeparada",
                table: "Regals",
                column: "id_pokeparada",
                principalTable: "Pokeparades",
                principalColumn: "id_pokeparada",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jugadors_Pokemons_Jugadors_jugadorId",
                table: "Jugadors_Pokemons");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Pokemons_id_pokemon_evolucioid_pokemon",
                table: "Pokemons");

            migrationBuilder.DropForeignKey(
                name: "FK_Regals_Jugadors_id_jugador",
                table: "Regals");

            migrationBuilder.DropForeignKey(
                name: "FK_Regals_Pokeparades_id_pokeparada",
                table: "Regals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Regals",
                table: "Regals");

            migrationBuilder.DropIndex(
                name: "IX_Regals_id_pokeparada",
                table: "Regals");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_id_pokemon_evolucioid_pokemon",
                table: "Pokemons");

            migrationBuilder.DropIndex(
                name: "IX_Jugadors_Pokemons_jugadorId",
                table: "Jugadors_Pokemons");

            migrationBuilder.DropColumn(
                name: "id_jugador",
                table: "Regals");

            migrationBuilder.DropColumn(
                name: "id_pokemon_evolucioid_pokemon",
                table: "Pokemons");

            migrationBuilder.RenameColumn(
                name: "id_pokeparada",
                table: "Regals",
                newName: "id_regal");

            migrationBuilder.RenameColumn(
                name: "jugadorId",
                table: "Jugadors_Pokemons",
                newName: "jugadornom_jugador");

            migrationBuilder.AlterColumn<int>(
                name: "id_regal",
                table: "Regals",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "pokemonid_pokemon",
                table: "Jugadors",
                type: "integer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Regals",
                table: "Regals",
                column: "id_regal");

            migrationBuilder.CreateTable(
                name: "Acompanyants",
                columns: table => new
                {
                    id_acompanyant = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    captures_acompanyant = table.Column<int>(type: "integer", nullable: false),
                    data_final = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    data_inici = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    distancia_acompanyant = table.Column<double>(type: "double precision", nullable: false),
                    jugadornom_jugador = table.Column<string>(type: "text", nullable: true),
                    pokemonid_pokemon = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acompanyants", x => x.id_acompanyant);
                    table.ForeignKey(
                        name: "FK_Acompanyants_Jugadors_jugadornom_jugador",
                        column: x => x.jugadornom_jugador,
                        principalTable: "Jugadors",
                        principalColumn: "nom_jugador",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Acompanyants_Pokemons_pokemonid_pokemon",
                        column: x => x.pokemonid_pokemon,
                        principalTable: "Pokemons",
                        principalColumn: "id_pokemon",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Evolucio",
                columns: table => new
                {
                    pokemonId = table.Column<int>(type: "integer", nullable: false),
                    pokemonId2 = table.Column<int>(type: "integer", nullable: false),
                    caramels_evolucions = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evolucio", x => new { x.pokemonId, x.pokemonId2 });
                    table.ForeignKey(
                        name: "FK_Evolucio_Pokemons_pokemonId",
                        column: x => x.pokemonId,
                        principalTable: "Pokemons",
                        principalColumn: "id_pokemon",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evolucio_Pokemons_pokemonId2",
                        column: x => x.pokemonId2,
                        principalTable: "Pokemons",
                        principalColumn: "id_pokemon",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Regals_enviats",
                columns: table => new
                {
                    id_regal_enviat = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    jugadornom_jugador = table.Column<string>(type: "text", nullable: true),
                    obert_regal_enviat = table.Column<bool>(type: "boolean", nullable: false),
                    regalid_regal = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regals_enviats", x => x.id_regal_enviat);
                    table.ForeignKey(
                        name: "FK_Regals_enviats_Jugadors_jugadornom_jugador",
                        column: x => x.jugadornom_jugador,
                        principalTable: "Jugadors",
                        principalColumn: "nom_jugador",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Regals_enviats_Regals_regalid_regal",
                        column: x => x.regalid_regal,
                        principalTable: "Regals",
                        principalColumn: "id_regal",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jugadors_Pokemons_jugadornom_jugador",
                table: "Jugadors_Pokemons",
                column: "jugadornom_jugador");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadors_pokemonid_pokemon",
                table: "Jugadors",
                column: "pokemonid_pokemon");

            migrationBuilder.CreateIndex(
                name: "IX_Acompanyants_jugadornom_jugador",
                table: "Acompanyants",
                column: "jugadornom_jugador");

            migrationBuilder.CreateIndex(
                name: "IX_Acompanyants_pokemonid_pokemon",
                table: "Acompanyants",
                column: "pokemonid_pokemon");

            migrationBuilder.CreateIndex(
                name: "IX_Evolucio_pokemonId2",
                table: "Evolucio",
                column: "pokemonId2");

            migrationBuilder.CreateIndex(
                name: "IX_Regals_enviats_jugadornom_jugador",
                table: "Regals_enviats",
                column: "jugadornom_jugador");

            migrationBuilder.CreateIndex(
                name: "IX_Regals_enviats_regalid_regal",
                table: "Regals_enviats",
                column: "regalid_regal");

            migrationBuilder.AddForeignKey(
                name: "FK_Jugadors_Pokemons_pokemonid_pokemon",
                table: "Jugadors",
                column: "pokemonid_pokemon",
                principalTable: "Pokemons",
                principalColumn: "id_pokemon",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jugadors_Pokemons_Jugadors_jugadornom_jugador",
                table: "Jugadors_Pokemons",
                column: "jugadornom_jugador",
                principalTable: "Jugadors",
                principalColumn: "nom_jugador",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
