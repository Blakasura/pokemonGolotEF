using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace pokemonGolot.Migrations
{
    public partial class FirstDBTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equip",
                columns: table => new
                {
                    nom_equip = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equip", x => x.nom_equip);
                });

            migrationBuilder.CreateTable(
                name: "Missions",
                columns: table => new
                {
                    id_misio = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcio_misio = table.Column<string>(type: "text", nullable: true),
                    objectiu_misio = table.Column<int>(type: "integer", nullable: false),
                    recompensa_misio = table.Column<int>(type: "integer", nullable: false),
                    tipus_misio = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Missions", x => x.id_misio);
                });

            migrationBuilder.CreateTable(
                name: "Objectes",
                columns: table => new
                {
                    nom_objecte = table.Column<string>(type: "text", nullable: false),
                    descripcio_objecte = table.Column<string>(type: "text", nullable: true),
                    preu_objecte = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objectes", x => x.nom_objecte);
                });

            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    id_pokemon = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nom_pokemon = table.Column<string>(type: "text", nullable: true),
                    stamina_pokemon = table.Column<int>(type: "integer", nullable: false),
                    atac_pokemon = table.Column<int>(type: "integer", nullable: false),
                    defensa_pokemon = table.Column<int>(type: "integer", nullable: false),
                    max_cp_pokemon = table.Column<int>(type: "integer", nullable: false),
                    rarity = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.id_pokemon);
                });

            migrationBuilder.CreateTable(
                name: "Pokeparades",
                columns: table => new
                {
                    id_pokeparada = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ubicacio_pokeparada = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokeparades", x => x.id_pokeparada);
                });

            migrationBuilder.CreateTable(
                name: "Regals",
                columns: table => new
                {
                    id_regal = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regals", x => x.id_regal);
                });

            migrationBuilder.CreateTable(
                name: "Tipus",
                columns: table => new
                {
                    id_tipus = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nom_tipus = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipus", x => x.id_tipus);
                });

            migrationBuilder.CreateTable(
                name: "Gimnasos",
                columns: table => new
                {
                    id_gimnas = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ubicacio_gimnas = table.Column<string>(type: "text", nullable: true),
                    exp_gimnas = table.Column<int>(type: "integer", nullable: false),
                    equipnom_equip = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gimnasos", x => x.id_gimnas);
                    table.ForeignKey(
                        name: "FK_Gimnasos_Equip_equipnom_equip",
                        column: x => x.equipnom_equip,
                        principalTable: "Equip",
                        principalColumn: "nom_equip",
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
                name: "Jugadors",
                columns: table => new
                {
                    nom_jugador = table.Column<string>(type: "text", nullable: false),
                    email_jugador = table.Column<string>(type: "text", nullable: true),
                    contrasenya_jugador = table.Column<string>(type: "text", nullable: true),
                    nivell_jugador = table.Column<double>(type: "double precision", nullable: false),
                    maxim_objectes_jugador = table.Column<int>(type: "integer", nullable: false),
                    maxim_pokemons_jugador = table.Column<int>(type: "integer", nullable: false),
                    pokemonid_pokemon = table.Column<int>(type: "integer", nullable: true),
                    equipnom_equip = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jugadors", x => x.nom_jugador);
                    table.ForeignKey(
                        name: "FK_Jugadors_Equip_equipnom_equip",
                        column: x => x.equipnom_equip,
                        principalTable: "Equip",
                        principalColumn: "nom_equip",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Jugadors_Pokemons_pokemonid_pokemon",
                        column: x => x.pokemonid_pokemon,
                        principalTable: "Pokemons",
                        principalColumn: "id_pokemon",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Efectivitats",
                columns: table => new
                {
                    tipusId = table.Column<int>(type: "integer", nullable: false),
                    tipusId2 = table.Column<int>(type: "integer", nullable: false),
                    efectivitat = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Efectivitats", x => new { x.tipusId, x.tipusId2 });
                    table.ForeignKey(
                        name: "FK_Efectivitats_Tipus_tipusId",
                        column: x => x.tipusId,
                        principalTable: "Tipus",
                        principalColumn: "id_tipus",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Efectivitats_Tipus_tipusId2",
                        column: x => x.tipusId2,
                        principalTable: "Tipus",
                        principalColumn: "id_tipus",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Moviments",
                columns: table => new
                {
                    id_moviment = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    duracio_moviment = table.Column<int>(type: "integer", nullable: false),
                    delta_energia_pokemon_moviment = table.Column<int>(type: "integer", nullable: false),
                    nom_moviment = table.Column<string>(type: "text", nullable: true),
                    potencia_moviment = table.Column<int>(type: "integer", nullable: false),
                    escalat_perduda_moviment = table.Column<double>(type: "double precision", nullable: false),
                    tipusid_tipus = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moviments", x => x.id_moviment);
                    table.ForeignKey(
                        name: "FK_Moviments_Tipus_tipusid_tipus",
                        column: x => x.tipusid_tipus,
                        principalTable: "Tipus",
                        principalColumn: "id_tipus",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Incursions",
                columns: table => new
                {
                    id_incursio = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ubicacio_incursio = table.Column<string>(type: "text", nullable: true),
                    pokemonid_pokemon = table.Column<int>(type: "integer", nullable: true),
                    gimnasid_gimnas = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incursions", x => x.id_incursio);
                    table.ForeignKey(
                        name: "FK_Incursions_Gimnasos_gimnasid_gimnas",
                        column: x => x.gimnasid_gimnas,
                        principalTable: "Gimnasos",
                        principalColumn: "id_gimnas",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incursions_Pokemons_pokemonid_pokemon",
                        column: x => x.pokemonid_pokemon,
                        principalTable: "Pokemons",
                        principalColumn: "id_pokemon",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Acompanyants",
                columns: table => new
                {
                    id_acompanyant = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    data_inici = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    data_final = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    distancia_acompanyant = table.Column<double>(type: "double precision", nullable: false),
                    captures_acompanyant = table.Column<int>(type: "integer", nullable: false),
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
                name: "Amistats",
                columns: table => new
                {
                    JugadorId = table.Column<string>(type: "text", nullable: false),
                    JugadorId2 = table.Column<string>(type: "text", nullable: false),
                    nivell_amistat = table.Column<int>(type: "integer", nullable: false),
                    intercanvi_amistat = table.Column<bool>(type: "boolean", nullable: false),
                    activat_amistat = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amistats", x => new { x.JugadorId, x.JugadorId2 });
                    table.ForeignKey(
                        name: "FK_Amistats_Jugadors_JugadorId",
                        column: x => x.JugadorId,
                        principalTable: "Jugadors",
                        principalColumn: "nom_jugador",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Amistats_Jugadors_JugadorId2",
                        column: x => x.JugadorId2,
                        principalTable: "Jugadors",
                        principalColumn: "nom_jugador",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GimnasJugador",
                columns: table => new
                {
                    gimnasosid_gimnas = table.Column<int>(type: "integer", nullable: false),
                    jugadorsnom_jugador = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GimnasJugador", x => new { x.gimnasosid_gimnas, x.jugadorsnom_jugador });
                    table.ForeignKey(
                        name: "FK_GimnasJugador_Gimnasos_gimnasosid_gimnas",
                        column: x => x.gimnasosid_gimnas,
                        principalTable: "Gimnasos",
                        principalColumn: "id_gimnas",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GimnasJugador_Jugadors_jugadorsnom_jugador",
                        column: x => x.jugadorsnom_jugador,
                        principalTable: "Jugadors",
                        principalColumn: "nom_jugador",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jugadors_Pokemons",
                columns: table => new
                {
                    id_jugador_pokemon = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    punts_combat_jugador_pokemon = table.Column<int>(type: "integer", nullable: false),
                    IV_atac_jugador_pokemon = table.Column<int>(type: "integer", nullable: false),
                    IV_defensa_jugador_pokemon = table.Column<int>(type: "integer", nullable: false),
                    IV_vida_jugador_pokemon = table.Column<int>(type: "integer", nullable: false),
                    nivell_jugador_pokemon = table.Column<int>(type: "integer", nullable: false),
                    jugadornom_jugador = table.Column<string>(type: "text", nullable: true),
                    pokemonid_pokemon = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jugadors_Pokemons", x => x.id_jugador_pokemon);
                    table.ForeignKey(
                        name: "FK_Jugadors_Pokemons_Jugadors_jugadornom_jugador",
                        column: x => x.jugadornom_jugador,
                        principalTable: "Jugadors",
                        principalColumn: "nom_jugador",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Jugadors_Pokemons_Pokemons_pokemonid_pokemon",
                        column: x => x.pokemonid_pokemon,
                        principalTable: "Pokemons",
                        principalColumn: "id_pokemon",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Missions_Jugadors",
                columns: table => new
                {
                    jugadorId = table.Column<string>(type: "text", nullable: false),
                    missioId = table.Column<int>(type: "integer", nullable: false),
                    progres_missio = table.Column<int>(type: "integer", nullable: false),
                    activa_missio = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Missions_Jugadors", x => new { x.jugadorId, x.missioId });
                    table.ForeignKey(
                        name: "FK_Missions_Jugadors_Jugadors_jugadorId",
                        column: x => x.jugadorId,
                        principalTable: "Jugadors",
                        principalColumn: "nom_jugador",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Missions_Jugadors_Missions_missioId",
                        column: x => x.missioId,
                        principalTable: "Missions",
                        principalColumn: "id_misio",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Objectes_Jugadors",
                columns: table => new
                {
                    jugadorId = table.Column<string>(type: "text", nullable: false),
                    objecteId = table.Column<string>(type: "text", nullable: false),
                    quantitat = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objectes_Jugadors", x => new { x.jugadorId, x.objecteId });
                    table.ForeignKey(
                        name: "FK_Objectes_Jugadors_Jugadors_jugadorId",
                        column: x => x.jugadorId,
                        principalTable: "Jugadors",
                        principalColumn: "nom_jugador",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Objectes_Jugadors_Objectes_objecteId",
                        column: x => x.objecteId,
                        principalTable: "Objectes",
                        principalColumn: "nom_objecte",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pokedexs",
                columns: table => new
                {
                    pokemonId = table.Column<int>(type: "integer", nullable: false),
                    jugadorId = table.Column<string>(type: "text", nullable: false),
                    vist_pokedex = table.Column<bool>(type: "boolean", nullable: false),
                    caramels_pokedex = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokedexs", x => new { x.pokemonId, x.jugadorId });
                    table.ForeignKey(
                        name: "FK_Pokedexs_Jugadors_jugadorId",
                        column: x => x.jugadorId,
                        principalTable: "Jugadors",
                        principalColumn: "nom_jugador",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pokedexs_Pokemons_pokemonId",
                        column: x => x.pokemonId,
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
                    obert_regal_enviat = table.Column<bool>(type: "boolean", nullable: false),
                    jugadornom_jugador = table.Column<string>(type: "text", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "MovimentPokemon",
                columns: table => new
                {
                    movimentsid_moviment = table.Column<int>(type: "integer", nullable: false),
                    pokemonsid_pokemon = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovimentPokemon", x => new { x.movimentsid_moviment, x.pokemonsid_pokemon });
                    table.ForeignKey(
                        name: "FK_MovimentPokemon_Moviments_movimentsid_moviment",
                        column: x => x.movimentsid_moviment,
                        principalTable: "Moviments",
                        principalColumn: "id_moviment",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovimentPokemon_Pokemons_pokemonsid_pokemon",
                        column: x => x.pokemonsid_pokemon,
                        principalTable: "Pokemons",
                        principalColumn: "id_pokemon",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jugadors_Pokemons_Gimnasos",
                columns: table => new
                {
                    jugador_pokemonId = table.Column<int>(type: "integer", nullable: false),
                    gimnasId = table.Column<int>(type: "integer", nullable: false),
                    vida_pokemon = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jugadors_Pokemons_Gimnasos", x => new { x.jugador_pokemonId, x.gimnasId });
                    table.ForeignKey(
                        name: "FK_Jugadors_Pokemons_Gimnasos_Gimnasos_gimnasId",
                        column: x => x.gimnasId,
                        principalTable: "Gimnasos",
                        principalColumn: "id_gimnas",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Jugadors_Pokemons_Gimnasos_Jugadors_Pokemons_jugador_pokemo~",
                        column: x => x.jugador_pokemonId,
                        principalTable: "Jugadors_Pokemons",
                        principalColumn: "id_jugador_pokemon",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Acompanyants_jugadornom_jugador",
                table: "Acompanyants",
                column: "jugadornom_jugador");

            migrationBuilder.CreateIndex(
                name: "IX_Acompanyants_pokemonid_pokemon",
                table: "Acompanyants",
                column: "pokemonid_pokemon");

            migrationBuilder.CreateIndex(
                name: "IX_Amistats_JugadorId2",
                table: "Amistats",
                column: "JugadorId2");

            migrationBuilder.CreateIndex(
                name: "IX_Efectivitats_tipusId2",
                table: "Efectivitats",
                column: "tipusId2");

            migrationBuilder.CreateIndex(
                name: "IX_Evolucio_pokemonId2",
                table: "Evolucio",
                column: "pokemonId2");

            migrationBuilder.CreateIndex(
                name: "IX_GimnasJugador_jugadorsnom_jugador",
                table: "GimnasJugador",
                column: "jugadorsnom_jugador");

            migrationBuilder.CreateIndex(
                name: "IX_Gimnasos_equipnom_equip",
                table: "Gimnasos",
                column: "equipnom_equip");

            migrationBuilder.CreateIndex(
                name: "IX_Incursions_gimnasid_gimnas",
                table: "Incursions",
                column: "gimnasid_gimnas");

            migrationBuilder.CreateIndex(
                name: "IX_Incursions_pokemonid_pokemon",
                table: "Incursions",
                column: "pokemonid_pokemon");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadors_equipnom_equip",
                table: "Jugadors",
                column: "equipnom_equip");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadors_pokemonid_pokemon",
                table: "Jugadors",
                column: "pokemonid_pokemon");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadors_Pokemons_jugadornom_jugador",
                table: "Jugadors_Pokemons",
                column: "jugadornom_jugador");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadors_Pokemons_pokemonid_pokemon",
                table: "Jugadors_Pokemons",
                column: "pokemonid_pokemon");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadors_Pokemons_Gimnasos_gimnasId",
                table: "Jugadors_Pokemons_Gimnasos",
                column: "gimnasId");

            migrationBuilder.CreateIndex(
                name: "IX_Missions_Jugadors_missioId",
                table: "Missions_Jugadors",
                column: "missioId");

            migrationBuilder.CreateIndex(
                name: "IX_MovimentPokemon_pokemonsid_pokemon",
                table: "MovimentPokemon",
                column: "pokemonsid_pokemon");

            migrationBuilder.CreateIndex(
                name: "IX_Moviments_tipusid_tipus",
                table: "Moviments",
                column: "tipusid_tipus");

            migrationBuilder.CreateIndex(
                name: "IX_Objectes_Jugadors_objecteId",
                table: "Objectes_Jugadors",
                column: "objecteId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokedexs_jugadorId",
                table: "Pokedexs",
                column: "jugadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Regals_enviats_jugadornom_jugador",
                table: "Regals_enviats",
                column: "jugadornom_jugador");

            migrationBuilder.CreateIndex(
                name: "IX_Regals_enviats_regalid_regal",
                table: "Regals_enviats",
                column: "regalid_regal");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Acompanyants");

            migrationBuilder.DropTable(
                name: "Amistats");

            migrationBuilder.DropTable(
                name: "Efectivitats");

            migrationBuilder.DropTable(
                name: "Evolucio");

            migrationBuilder.DropTable(
                name: "GimnasJugador");

            migrationBuilder.DropTable(
                name: "Incursions");

            migrationBuilder.DropTable(
                name: "Jugadors_Pokemons_Gimnasos");

            migrationBuilder.DropTable(
                name: "Missions_Jugadors");

            migrationBuilder.DropTable(
                name: "MovimentPokemon");

            migrationBuilder.DropTable(
                name: "Objectes_Jugadors");

            migrationBuilder.DropTable(
                name: "Pokedexs");

            migrationBuilder.DropTable(
                name: "Pokeparades");

            migrationBuilder.DropTable(
                name: "Regals_enviats");

            migrationBuilder.DropTable(
                name: "Gimnasos");

            migrationBuilder.DropTable(
                name: "Jugadors_Pokemons");

            migrationBuilder.DropTable(
                name: "Missions");

            migrationBuilder.DropTable(
                name: "Moviments");

            migrationBuilder.DropTable(
                name: "Objectes");

            migrationBuilder.DropTable(
                name: "Regals");

            migrationBuilder.DropTable(
                name: "Jugadors");

            migrationBuilder.DropTable(
                name: "Tipus");

            migrationBuilder.DropTable(
                name: "Equip");

            migrationBuilder.DropTable(
                name: "Pokemons");
        }
    }
}
