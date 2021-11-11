﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace pokemonGolot.Migrations
{
    [DbContext(typeof(Database))]
    [Migration("20211111182155_Added REGAL table")]
    partial class AddedREGALtable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("GimnasJugador", b =>
                {
                    b.Property<int>("gimnasosid_gimnas")
                        .HasColumnType("integer");

                    b.Property<string>("jugadorsnom_jugador")
                        .HasColumnType("text");

                    b.HasKey("gimnasosid_gimnas", "jugadorsnom_jugador");

                    b.HasIndex("jugadorsnom_jugador");

                    b.ToTable("GimnasJugador");
                });

            modelBuilder.Entity("Model.Amistat", b =>
                {
                    b.Property<string>("JugadorId")
                        .HasColumnType("text");

                    b.Property<string>("JugadorId2")
                        .HasColumnType("text");

                    b.Property<bool>("activat_amistat")
                        .HasColumnType("boolean");

                    b.Property<bool>("intercanvi_amistat")
                        .HasColumnType("boolean");

                    b.Property<int>("nivell_amistat")
                        .HasColumnType("integer");

                    b.HasKey("JugadorId", "JugadorId2");

                    b.HasIndex("JugadorId2");

                    b.ToTable("Amistats");
                });

            modelBuilder.Entity("Model.Efectivitat", b =>
                {
                    b.Property<int>("tipusId")
                        .HasColumnType("integer");

                    b.Property<int>("tipusId2")
                        .HasColumnType("integer");

                    b.Property<double>("efectivitat")
                        .HasColumnType("double precision");

                    b.HasKey("tipusId", "tipusId2");

                    b.HasIndex("tipusId2");

                    b.ToTable("Efectivitats");
                });

            modelBuilder.Entity("Model.Enviat", b =>
                {
                    b.Property<int>("id_regal_pokeparada")
                        .HasColumnType("integer");

                    b.Property<string>("id_regal_jugador")
                        .HasColumnType("text");

                    b.Property<string>("id_jugador_enviat")
                        .HasColumnType("text");

                    b.Property<string>("jugador_enviatnom_jugador")
                        .HasColumnType("text");

                    b.Property<bool>("obert")
                        .HasColumnType("boolean");

                    b.Property<string>("regalid_jugador")
                        .HasColumnType("text");

                    b.Property<int?>("regalid_pokeparada")
                        .HasColumnType("integer");

                    b.HasKey("id_regal_pokeparada", "id_regal_jugador", "id_jugador_enviat");

                    b.HasIndex("jugador_enviatnom_jugador");

                    b.HasIndex("regalid_jugador", "regalid_pokeparada");

                    b.ToTable("Enviats");
                });

            modelBuilder.Entity("Model.Equip", b =>
                {
                    b.Property<string>("nom_equip")
                        .HasColumnType("text");

                    b.HasKey("nom_equip");

                    b.ToTable("Equip");
                });

            modelBuilder.Entity("Model.Gimnas", b =>
                {
                    b.Property<int>("id_gimnas")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("equipnom_equip")
                        .HasColumnType("text");

                    b.Property<int>("exp_gimnas")
                        .HasColumnType("integer");

                    b.Property<string>("ubicacio_gimnas")
                        .HasColumnType("text");

                    b.HasKey("id_gimnas");

                    b.HasIndex("equipnom_equip");

                    b.ToTable("Gimnasos");
                });

            modelBuilder.Entity("Model.Incursio", b =>
                {
                    b.Property<int>("id_incursio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int?>("gimnasid_gimnas")
                        .HasColumnType("integer");

                    b.Property<int?>("pokemonid_pokemon")
                        .HasColumnType("integer");

                    b.Property<string>("ubicacio_incursio")
                        .HasColumnType("text");

                    b.HasKey("id_incursio");

                    b.HasIndex("gimnasid_gimnas");

                    b.HasIndex("pokemonid_pokemon");

                    b.ToTable("Incursions");
                });

            modelBuilder.Entity("Model.Jugador", b =>
                {
                    b.Property<string>("nom_jugador")
                        .HasColumnType("text");

                    b.Property<string>("contrasenya_jugador")
                        .HasColumnType("text");

                    b.Property<string>("email_jugador")
                        .HasColumnType("text");

                    b.Property<string>("equipnom_equip")
                        .HasColumnType("text");

                    b.Property<int>("jugador_pokemon")
                        .HasColumnType("integer");

                    b.Property<int>("maxim_objectes_jugador")
                        .HasColumnType("integer");

                    b.Property<int>("maxim_pokemons_jugador")
                        .HasColumnType("integer");

                    b.Property<double>("nivell_jugador")
                        .HasColumnType("double precision");

                    b.HasKey("nom_jugador");

                    b.HasIndex("equipnom_equip");

                    b.HasIndex("jugador_pokemon")
                        .IsUnique();

                    b.ToTable("Jugadors");
                });

            modelBuilder.Entity("Model.Jugador_Pokemon", b =>
                {
                    b.Property<int>("id_jugador_pokemon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("IV_atac_jugador_pokemon")
                        .HasColumnType("integer");

                    b.Property<int>("IV_defensa_jugador_pokemon")
                        .HasColumnType("integer");

                    b.Property<int>("IV_vida_jugador_pokemon")
                        .HasColumnType("integer");

                    b.Property<string>("jugadorId")
                        .HasColumnType("text");

                    b.Property<int>("nivell_jugador_pokemon")
                        .HasColumnType("integer");

                    b.Property<int?>("pokemonid_pokemon")
                        .HasColumnType("integer");

                    b.Property<int>("punts_combat_jugador_pokemon")
                        .HasColumnType("integer");

                    b.HasKey("id_jugador_pokemon");

                    b.HasIndex("pokemonid_pokemon");

                    b.ToTable("Jugadors_Pokemons");
                });

            modelBuilder.Entity("Model.Jugador_Pokemon_Gimnas", b =>
                {
                    b.Property<int>("jugador_pokemonId")
                        .HasColumnType("integer");

                    b.Property<int>("gimnasId")
                        .HasColumnType("integer");

                    b.Property<int>("vida_pokemon")
                        .HasColumnType("integer");

                    b.HasKey("jugador_pokemonId", "gimnasId");

                    b.HasIndex("gimnasId");

                    b.ToTable("Jugadors_Pokemons_Gimnasos");
                });

            modelBuilder.Entity("Model.Missio", b =>
                {
                    b.Property<int>("id_misio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("descripcio_misio")
                        .HasColumnType("text");

                    b.Property<int>("objectiu_misio")
                        .HasColumnType("integer");

                    b.Property<int>("recompensa_misio")
                        .HasColumnType("integer");

                    b.Property<bool>("tipus_misio")
                        .HasColumnType("boolean");

                    b.HasKey("id_misio");

                    b.ToTable("Missions");
                });

            modelBuilder.Entity("Model.Missio_Jugador", b =>
                {
                    b.Property<string>("jugadorId")
                        .HasColumnType("text");

                    b.Property<int>("missioId")
                        .HasColumnType("integer");

                    b.Property<bool>("activa_missio")
                        .HasColumnType("boolean");

                    b.Property<int>("progres_missio")
                        .HasColumnType("integer");

                    b.HasKey("jugadorId", "missioId");

                    b.HasIndex("missioId");

                    b.ToTable("Missions_Jugadors");
                });

            modelBuilder.Entity("Model.Moviment", b =>
                {
                    b.Property<int>("id_moviment")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("delta_energia_pokemon_moviment")
                        .HasColumnType("integer");

                    b.Property<int>("duracio_moviment")
                        .HasColumnType("integer");

                    b.Property<double>("escalat_perduda_moviment")
                        .HasColumnType("double precision");

                    b.Property<string>("nom_moviment")
                        .HasColumnType("text");

                    b.Property<int>("potencia_moviment")
                        .HasColumnType("integer");

                    b.Property<int?>("tipusid_tipus")
                        .HasColumnType("integer");

                    b.HasKey("id_moviment");

                    b.HasIndex("tipusid_tipus");

                    b.ToTable("Moviments");
                });

            modelBuilder.Entity("Model.Objecte", b =>
                {
                    b.Property<string>("nom_objecte")
                        .HasColumnType("text");

                    b.Property<string>("descripcio_objecte")
                        .HasColumnType("text");

                    b.Property<double>("preu_objecte")
                        .HasColumnType("double precision");

                    b.HasKey("nom_objecte");

                    b.ToTable("Objectes");
                });

            modelBuilder.Entity("Model.Objecte_Jugador", b =>
                {
                    b.Property<string>("jugadorId")
                        .HasColumnType("text");

                    b.Property<string>("objecteId")
                        .HasColumnType("text");

                    b.Property<int>("quantitat")
                        .HasColumnType("integer");

                    b.HasKey("jugadorId", "objecteId");

                    b.HasIndex("objecteId");

                    b.ToTable("Objectes_Jugadors");
                });

            modelBuilder.Entity("Model.Ou", b =>
                {
                    b.Property<string>("tipus_ou")
                        .HasColumnType("text");

                    b.Property<string>("descripcio_ou")
                        .HasColumnType("text");

                    b.Property<double>("distancia_ou")
                        .HasColumnType("double precision");

                    b.HasKey("tipus_ou");

                    b.ToTable("Ous");
                });

            modelBuilder.Entity("Model.Ou_Jugador", b =>
                {
                    b.Property<string>("jugador_id")
                        .HasColumnType("text");

                    b.Property<string>("ou_id")
                        .HasColumnType("text");

                    b.Property<double>("distancia")
                        .HasColumnType("double precision");

                    b.HasKey("jugador_id", "ou_id");

                    b.HasIndex("ou_id");

                    b.ToTable("Ous_Jugadors");
                });

            modelBuilder.Entity("Model.Pokedex", b =>
                {
                    b.Property<int>("pokemonId")
                        .HasColumnType("integer");

                    b.Property<string>("jugadorId")
                        .HasColumnType("text");

                    b.Property<int>("caramels_pokedex")
                        .HasColumnType("integer");

                    b.Property<bool>("vist_pokedex")
                        .HasColumnType("boolean");

                    b.HasKey("pokemonId", "jugadorId");

                    b.HasIndex("jugadorId");

                    b.ToTable("Pokedexs");
                });

            modelBuilder.Entity("Model.Pokemon", b =>
                {
                    b.Property<int>("id_pokemon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("atac_pokemon")
                        .HasColumnType("integer");

                    b.Property<int>("defensa_pokemon")
                        .HasColumnType("integer");

                    b.Property<int?>("id_pokemon_evolucioid_pokemon")
                        .HasColumnType("integer");

                    b.Property<int>("max_cp_pokemon")
                        .HasColumnType("integer");

                    b.Property<string>("nom_pokemon")
                        .HasColumnType("text");

                    b.Property<string>("rarity")
                        .HasColumnType("text");

                    b.Property<int>("stamina_pokemon")
                        .HasColumnType("integer");

                    b.HasKey("id_pokemon");

                    b.HasIndex("id_pokemon_evolucioid_pokemon");

                    b.ToTable("Pokemons");
                });

            modelBuilder.Entity("Model.Pokemon_Moviment", b =>
                {
                    b.Property<int>("id_jugador_pokemon")
                        .HasColumnType("integer");

                    b.Property<int>("id_moviment")
                        .HasColumnType("integer");

                    b.HasKey("id_jugador_pokemon", "id_moviment");

                    b.HasIndex("id_moviment");

                    b.ToTable("Pokemon_Moviment");
                });

            modelBuilder.Entity("Model.Pokemon_Tipus", b =>
                {
                    b.Property<int>("pokemon_id")
                        .HasColumnType("integer");

                    b.Property<int>("tipus_id")
                        .HasColumnType("integer");

                    b.HasKey("pokemon_id", "tipus_id");

                    b.HasIndex("tipus_id");

                    b.ToTable("Pokemon_Tipus");
                });

            modelBuilder.Entity("Model.Pokeparada", b =>
                {
                    b.Property<int>("id_pokeparada")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("ubicacio_pokeparada")
                        .HasColumnType("text");

                    b.HasKey("id_pokeparada");

                    b.ToTable("Pokeparades");
                });

            modelBuilder.Entity("Model.Regal", b =>
                {
                    b.Property<string>("id_jugador")
                        .HasColumnType("text");

                    b.Property<int>("id_pokeparada")
                        .HasColumnType("integer");

                    b.HasKey("id_jugador", "id_pokeparada");

                    b.HasIndex("id_pokeparada");

                    b.ToTable("Regals");
                });

            modelBuilder.Entity("Model.Tipus", b =>
                {
                    b.Property<int>("id_tipus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("nom_tipus")
                        .HasColumnType("text");

                    b.HasKey("id_tipus");

                    b.ToTable("Tipus");
                });

            modelBuilder.Entity("MovimentPokemon", b =>
                {
                    b.Property<int>("movimentsid_moviment")
                        .HasColumnType("integer");

                    b.Property<int>("pokemonsid_pokemon")
                        .HasColumnType("integer");

                    b.HasKey("movimentsid_moviment", "pokemonsid_pokemon");

                    b.HasIndex("pokemonsid_pokemon");

                    b.ToTable("MovimentPokemon");
                });

            modelBuilder.Entity("GimnasJugador", b =>
                {
                    b.HasOne("Model.Gimnas", null)
                        .WithMany()
                        .HasForeignKey("gimnasosid_gimnas")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Jugador", null)
                        .WithMany()
                        .HasForeignKey("jugadorsnom_jugador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.Amistat", b =>
                {
                    b.HasOne("Model.Jugador", "jugador1")
                        .WithMany("fa_amistats")
                        .HasForeignKey("JugadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Jugador", "jugador2")
                        .WithMany("te_amistats")
                        .HasForeignKey("JugadorId2")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("jugador1");

                    b.Navigation("jugador2");
                });

            modelBuilder.Entity("Model.Efectivitat", b =>
                {
                    b.HasOne("Model.Tipus", "tipus1")
                        .WithMany("te_efectivitat")
                        .HasForeignKey("tipusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Tipus", "tipus2")
                        .WithMany("fa_efectivitat")
                        .HasForeignKey("tipusId2")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("tipus1");

                    b.Navigation("tipus2");
                });

            modelBuilder.Entity("Model.Enviat", b =>
                {
                    b.HasOne("Model.Jugador", "jugador_enviat")
                        .WithMany("rep_regal")
                        .HasForeignKey("jugador_enviatnom_jugador");

                    b.HasOne("Model.Regal", "regal")
                        .WithMany("estan_enviats")
                        .HasForeignKey("regalid_jugador", "regalid_pokeparada");

                    b.Navigation("jugador_enviat");

                    b.Navigation("regal");
                });

            modelBuilder.Entity("Model.Gimnas", b =>
                {
                    b.HasOne("Model.Equip", "equip")
                        .WithMany()
                        .HasForeignKey("equipnom_equip");

                    b.Navigation("equip");
                });

            modelBuilder.Entity("Model.Incursio", b =>
                {
                    b.HasOne("Model.Gimnas", "gimnas")
                        .WithMany()
                        .HasForeignKey("gimnasid_gimnas");

                    b.HasOne("Model.Pokemon", "pokemon")
                        .WithMany()
                        .HasForeignKey("pokemonid_pokemon");

                    b.Navigation("gimnas");

                    b.Navigation("pokemon");
                });

            modelBuilder.Entity("Model.Jugador", b =>
                {
                    b.HasOne("Model.Equip", "equip")
                        .WithMany()
                        .HasForeignKey("equipnom_equip");

                    b.HasOne("Model.Jugador_Pokemon", "id_jugador_pokemon")
                        .WithOne("jugador")
                        .HasForeignKey("Model.Jugador", "jugador_pokemon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("equip");

                    b.Navigation("id_jugador_pokemon");
                });

            modelBuilder.Entity("Model.Jugador_Pokemon", b =>
                {
                    b.HasOne("Model.Pokemon", "pokemon")
                        .WithMany()
                        .HasForeignKey("pokemonid_pokemon");

                    b.Navigation("pokemon");
                });

            modelBuilder.Entity("Model.Jugador_Pokemon_Gimnas", b =>
                {
                    b.HasOne("Model.Gimnas", "gimnas")
                        .WithMany("te_pokemons")
                        .HasForeignKey("gimnasId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Model.Jugador_Pokemon", "jugador_pokemon")
                        .WithMany("esta_a_gimnas")
                        .HasForeignKey("jugador_pokemonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("gimnas");

                    b.Navigation("jugador_pokemon");
                });

            modelBuilder.Entity("Model.Missio_Jugador", b =>
                {
                    b.HasOne("Model.Jugador", "jugadorM")
                        .WithMany("te_missio")
                        .HasForeignKey("jugadorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Model.Missio", "missio")
                        .WithMany("te_jugadors")
                        .HasForeignKey("missioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("jugadorM");

                    b.Navigation("missio");
                });

            modelBuilder.Entity("Model.Moviment", b =>
                {
                    b.HasOne("Model.Tipus", "tipus")
                        .WithMany()
                        .HasForeignKey("tipusid_tipus");

                    b.Navigation("tipus");
                });

            modelBuilder.Entity("Model.Objecte_Jugador", b =>
                {
                    b.HasOne("Model.Jugador", "jugador")
                        .WithMany("te_objectes")
                        .HasForeignKey("jugadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Objecte", "objecte")
                        .WithMany("pertany_a_jugador")
                        .HasForeignKey("objecteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("jugador");

                    b.Navigation("objecte");
                });

            modelBuilder.Entity("Model.Ou_Jugador", b =>
                {
                    b.HasOne("Model.Jugador", "jugador")
                        .WithMany("te_ou")
                        .HasForeignKey("jugador_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Ou", "ou")
                        .WithMany("pertany_a_jugador")
                        .HasForeignKey("ou_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("jugador");

                    b.Navigation("ou");
                });

            modelBuilder.Entity("Model.Pokedex", b =>
                {
                    b.HasOne("Model.Jugador", "jugador")
                        .WithMany("registrat_pokemon")
                        .HasForeignKey("jugadorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Model.Pokemon", "pokemon")
                        .WithMany("vist_per_jugador")
                        .HasForeignKey("pokemonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("jugador");

                    b.Navigation("pokemon");
                });

            modelBuilder.Entity("Model.Pokemon", b =>
                {
                    b.HasOne("Model.Pokemon", "id_pokemon_evolucio")
                        .WithMany()
                        .HasForeignKey("id_pokemon_evolucioid_pokemon");

                    b.Navigation("id_pokemon_evolucio");
                });

            modelBuilder.Entity("Model.Pokemon_Moviment", b =>
                {
                    b.HasOne("Model.Jugador_Pokemon", "jugador_pokemon")
                        .WithMany("te_moviments")
                        .HasForeignKey("id_jugador_pokemon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Moviment", "moviment")
                        .WithMany("son_de_pokemon")
                        .HasForeignKey("id_moviment")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("jugador_pokemon");

                    b.Navigation("moviment");
                });

            modelBuilder.Entity("Model.Pokemon_Tipus", b =>
                {
                    b.HasOne("Model.Pokemon", "pokemon")
                        .WithMany("te_tipus")
                        .HasForeignKey("pokemon_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Model.Tipus", "tipus")
                        .WithMany("te_pokemon")
                        .HasForeignKey("tipus_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("pokemon");

                    b.Navigation("tipus");
                });

            modelBuilder.Entity("Model.Regal", b =>
                {
                    b.HasOne("Model.Jugador", "jugador")
                        .WithMany("te_regal")
                        .HasForeignKey("id_jugador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Pokeparada", "pokeparada")
                        .WithMany("dona_regal")
                        .HasForeignKey("id_pokeparada")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("jugador");

                    b.Navigation("pokeparada");
                });

            modelBuilder.Entity("MovimentPokemon", b =>
                {
                    b.HasOne("Model.Moviment", null)
                        .WithMany()
                        .HasForeignKey("movimentsid_moviment")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Pokemon", null)
                        .WithMany()
                        .HasForeignKey("pokemonsid_pokemon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.Gimnas", b =>
                {
                    b.Navigation("te_pokemons");
                });

            modelBuilder.Entity("Model.Jugador", b =>
                {
                    b.Navigation("fa_amistats");

                    b.Navigation("registrat_pokemon");

                    b.Navigation("rep_regal");

                    b.Navigation("te_amistats");

                    b.Navigation("te_missio");

                    b.Navigation("te_objectes");

                    b.Navigation("te_ou");

                    b.Navigation("te_regal");
                });

            modelBuilder.Entity("Model.Jugador_Pokemon", b =>
                {
                    b.Navigation("esta_a_gimnas");

                    b.Navigation("jugador");

                    b.Navigation("te_moviments");
                });

            modelBuilder.Entity("Model.Missio", b =>
                {
                    b.Navigation("te_jugadors");
                });

            modelBuilder.Entity("Model.Moviment", b =>
                {
                    b.Navigation("son_de_pokemon");
                });

            modelBuilder.Entity("Model.Objecte", b =>
                {
                    b.Navigation("pertany_a_jugador");
                });

            modelBuilder.Entity("Model.Ou", b =>
                {
                    b.Navigation("pertany_a_jugador");
                });

            modelBuilder.Entity("Model.Pokemon", b =>
                {
                    b.Navigation("te_tipus");

                    b.Navigation("vist_per_jugador");
                });

            modelBuilder.Entity("Model.Pokeparada", b =>
                {
                    b.Navigation("dona_regal");
                });

            modelBuilder.Entity("Model.Regal", b =>
                {
                    b.Navigation("estan_enviats");
                });

            modelBuilder.Entity("Model.Tipus", b =>
                {
                    b.Navigation("fa_efectivitat");

                    b.Navigation("te_efectivitat");

                    b.Navigation("te_pokemon");
                });
#pragma warning restore 612, 618
        }
    }
}
