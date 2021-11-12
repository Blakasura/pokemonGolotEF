using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Model;

namespace Data
{
    public class Database : DbContext
    {

        // Importació de totes les taules

        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Moviment> Moviments { get; set; }
        public DbSet<Regal> Regals { get; set; }
        public DbSet<Incursio> Incursions { get; set; }
        public DbSet<Tipus> Tipus { get; set; }
        public DbSet<Jugador> Jugadors { get; set; }
        public DbSet<Objecte> Objectes { get; set; }
        public DbSet<Objecte_Jugador> Objectes_Jugadors { get; set; }
        public DbSet<Pokeparada> Pokeparades { get; set; }
        public DbSet<Gimnas> Gimnasos { get; set; }
        public DbSet<Missio> Missions { get; set; }
        public DbSet<Jugador_Pokemon> Jugadors_Pokemons { get; set; }
        public DbSet<Jugador_Pokemon_Gimnas> Jugadors_Pokemons_Gimnasos { get; set; }
        public DbSet<Amistat> Amistats { get; set; }
        public DbSet<Efectivitat> Efectivitats { get; set; }
        public DbSet<Pokedex> Pokedexs { get; set; }
        public DbSet<Missio_Jugador> Missions_Jugadors { get; set; }
        public DbSet<Ou> Ous { get; set; }
        public DbSet<Ou_Jugador> Ous_Jugadors { get; set; }
        public DbSet<Enviat> Enviats { get; set; }

        protected override void OnModelCreating(ModelBuilder mdb)
        {
            /////////////////////////////////////////// CONSTRAINTS Configuration ///////////////////////////////////////////

            mdb.Entity<Jugador_Pokemon_Gimnas>()
                .HasKey(c => new { c.jugador_pokemonId, c.gimnasId });

            mdb.Entity<Jugador_Pokemon_Gimnas>()
                .HasOne(e => e.jugador_pokemon)
                .WithMany(f => f.esta_a_gimnas)
                .HasForeignKey(e => e.jugador_pokemonId);

            mdb.Entity<Jugador_Pokemon_Gimnas>()
                .HasOne(e => e.gimnas)
                .WithMany(f => f.te_pokemons)
                .HasForeignKey(e => e.gimnasId)
                .OnDelete(DeleteBehavior.Restrict);

            mdb.Entity<Missio_Jugador>()
                .HasKey(c => new { c.jugadorId, c.missioId });

            mdb.Entity<Missio_Jugador>()
                .HasOne(e => e.jugadorM)
                .WithMany(f => f.te_missio)
                .HasForeignKey(e => e.jugadorId)
                .OnDelete(DeleteBehavior.Restrict);

            mdb.Entity<Missio_Jugador>()
                .HasOne(e => e.missio)
                .WithMany(f => f.te_jugadors)
                .HasForeignKey(e => e.missioId);

            mdb.Entity<Amistat>()
                .HasKey(c => new { c.JugadorId, c.JugadorId2 });

            mdb.Entity<Amistat>()
               .HasOne(e => e.jugador1)
               .WithMany(f => f.fa_amistats)
               .HasForeignKey(e => e.JugadorId);

            mdb.Entity<Amistat>()
                .HasOne(e => e.jugador2)
                .WithMany(f => f.te_amistats)
                .HasForeignKey(e => e.JugadorId2)
                .OnDelete(DeleteBehavior.Restrict);

            mdb.Entity<Efectivitat>()
                .HasKey(c => new { c.tipusId, c.tipusId2 });

            mdb.Entity<Efectivitat>()
                .HasOne(e => e.tipus1)
                .WithMany(f => f.te_efectivitat)
                .HasForeignKey(e => e.tipusId);

            mdb.Entity<Efectivitat>()
                .HasOne(e => e.tipus2)
                .WithMany(f => f.fa_efectivitat)
                .HasForeignKey(e => e.tipusId2)
                .OnDelete(DeleteBehavior.Restrict);

            mdb.Entity<Objecte_Jugador>()
                .HasKey(c => new { c.jugadorId, c.objecteId });

            mdb.Entity<Objecte_Jugador>()
                .HasOne(e => e.jugador)
                .WithMany(f => f.te_objectes)
                .HasForeignKey(e => e.jugadorId);

            mdb.Entity<Objecte_Jugador>()
                .HasOne(e => e.objecte)
                .WithMany(f => f.pertany_a_jugador)
                .HasForeignKey(e => e.objecteId)
                .OnDelete(DeleteBehavior.Restrict);

            mdb.Entity<Pokedex>()
                .HasKey(c => new { c.pokemonId, c.jugadorId });

            mdb.Entity<Pokedex>()
                .HasOne(e => e.pokemon)
                .WithMany(f => f.vist_per_jugador)
                .HasForeignKey(e => e.pokemonId);

            mdb.Entity<Pokedex>()
                .HasOne(e => e.jugador)
                .WithMany(f => f.registrat_pokemon)
                .HasForeignKey(e => e.jugadorId)
                .OnDelete(DeleteBehavior.Restrict);

            mdb.Entity<Regal>()
                .HasKey(c => new { c.id_jugador, c.id_pokeparada });

            mdb.Entity<Regal>()
                .HasOne(e => e.jugador)
                .WithMany(f => f.te_regal)
                .HasForeignKey(e => e.id_jugador);

            mdb.Entity<Regal>()
                .HasOne(e => e.pokeparada)
                .WithMany(f => f.dona_regal)
                .HasForeignKey(e => e.id_pokeparada)
                .OnDelete(DeleteBehavior.Restrict);

            mdb.Entity<Pokemon_Moviment>()
                .HasKey(c => new { c.id_jugador_pokemon, c.id_moviment });

            mdb.Entity<Pokemon_Moviment>()
                .HasOne(e => e.jugador_pokemon)
                .WithMany(f => f.te_moviments)
                .HasForeignKey(e => e.id_jugador_pokemon);

            mdb.Entity<Pokemon_Moviment>()
                .HasOne(e => e.moviment)
                .WithMany(f => f.son_de_pokemon)
                .HasForeignKey(e => e.id_moviment)
                .OnDelete(DeleteBehavior.Restrict);
            
            mdb.Entity<Jugador>()
                .HasOne(e => e.id_jugador_pokemon)
                .WithOne(e => e.jugador)
                .HasForeignKey<Jugador_Pokemon>(e => e.jugadorId);

            mdb.Entity<Jugador_Pokemon>()
                .HasOne(e => e.jugador)
                .WithOne(e => e.id_jugador_pokemon)
                .HasForeignKey<Jugador>(e => e.jugador_pokemon);

            mdb.Entity<Pokemon_Tipus>()
                .HasKey(c => new { c.pokemon_id, c.tipus_id });

            mdb.Entity<Pokemon_Tipus>()
                .HasOne(e => e.tipus)
                .WithMany(f => f.te_pokemon)
                .HasForeignKey(e => e.tipus_id);

            mdb.Entity<Pokemon_Tipus>()
                .HasOne(e => e.pokemon)
                .WithMany(f => f.te_tipus)
                .HasForeignKey(e => e.pokemon_id)
                .OnDelete(DeleteBehavior.Restrict);

            mdb.Entity<Ou_Jugador>()
                .HasKey(c => new { c.jugador_id, c.ou_id });

            mdb.Entity<Ou_Jugador>()
                .HasOne(e => e.jugador)
                .WithMany(f => f.te_ou)
                .HasForeignKey(e => e.jugador_id);

            mdb.Entity<Ou_Jugador>()
                .HasOne(e => e.ou)
                .WithMany(f => f.pertany_a_jugador)
                .HasForeignKey(e => e.ou_id)
                .OnDelete(DeleteBehavior.Restrict);

            mdb.Entity<Enviat>()
                .HasKey(c => new { c.id_regal_pokeparada,c.id_regal_jugador,  c.id_jugador_enviat });

            mdb.Entity<Enviat>()
                .HasOne(e => e.regal)
                .WithMany(f => f.estan_enviats)
                .HasForeignKey(e => new {e.id_regal_jugador, e.id_regal_pokeparada});

            mdb.Entity<Enviat>()
                .HasOne(e => e.jugador_enviat)
                .WithMany(f => f.rep_regal)
                .HasForeignKey(e => e.id_jugador_enviat)
                .OnDelete(DeleteBehavior.Restrict);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=172.24.127.4;Port=5432;Database=pokemonGolot;Username=postgres;Password=postgres");
        }
    }
}
