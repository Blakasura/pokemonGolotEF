using Microsoft.EntityFrameworkCore.Migrations;

namespace pokemonGolot.Migrations
{
    public partial class AddedREGALtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enviats",
                columns: table => new
                {
                    id_regal_pokeparada = table.Column<int>(type: "integer", nullable: false),
                    id_regal_jugador = table.Column<string>(type: "text", nullable: false),
                    id_jugador_enviat = table.Column<string>(type: "text", nullable: false),
                    obert = table.Column<bool>(type: "boolean", nullable: false),
                    regalid_jugador = table.Column<string>(type: "text", nullable: true),
                    regalid_pokeparada = table.Column<int>(type: "integer", nullable: true),
                    jugador_enviatnom_jugador = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enviats", x => new { x.id_regal_pokeparada, x.id_regal_jugador, x.id_jugador_enviat });
                    table.ForeignKey(
                        name: "FK_Enviats_Jugadors_jugador_enviatnom_jugador",
                        column: x => x.jugador_enviatnom_jugador,
                        principalTable: "Jugadors",
                        principalColumn: "nom_jugador",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Enviats_Regals_regalid_jugador_regalid_pokeparada",
                        columns: x => new { x.regalid_jugador, x.regalid_pokeparada },
                        principalTable: "Regals",
                        principalColumns: new[] { "id_jugador", "id_pokeparada" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ous_Jugadors",
                columns: table => new
                {
                    jugador_id = table.Column<string>(type: "text", nullable: false),
                    ou_id = table.Column<string>(type: "text", nullable: false),
                    distancia = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ous_Jugadors", x => new { x.jugador_id, x.ou_id });
                    table.ForeignKey(
                        name: "FK_Ous_Jugadors_Jugadors_jugador_id",
                        column: x => x.jugador_id,
                        principalTable: "Jugadors",
                        principalColumn: "nom_jugador",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ous_Jugadors_Ous_ou_id",
                        column: x => x.ou_id,
                        principalTable: "Ous",
                        principalColumn: "tipus_ou",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pokemon_Tipus",
                columns: table => new
                {
                    pokemon_id = table.Column<int>(type: "integer", nullable: false),
                    tipus_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon_Tipus", x => new { x.pokemon_id, x.tipus_id });
                    table.ForeignKey(
                        name: "FK_Pokemon_Tipus_Pokemons_pokemon_id",
                        column: x => x.pokemon_id,
                        principalTable: "Pokemons",
                        principalColumn: "id_pokemon",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pokemon_Tipus_Tipus_tipus_id",
                        column: x => x.tipus_id,
                        principalTable: "Tipus",
                        principalColumn: "id_tipus",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enviats_jugador_enviatnom_jugador",
                table: "Enviats",
                column: "jugador_enviatnom_jugador");

            migrationBuilder.CreateIndex(
                name: "IX_Enviats_regalid_jugador_regalid_pokeparada",
                table: "Enviats",
                columns: new[] { "regalid_jugador", "regalid_pokeparada" });

            migrationBuilder.CreateIndex(
                name: "IX_Ous_Jugadors_ou_id",
                table: "Ous_Jugadors",
                column: "ou_id");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_Tipus_tipus_id",
                table: "Pokemon_Tipus",
                column: "tipus_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enviats");

            migrationBuilder.DropTable(
                name: "Ous_Jugadors");

            migrationBuilder.DropTable(
                name: "Pokemon_Tipus");
        }
    }
}
