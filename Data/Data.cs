using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Model;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace Data
{
    public class Database : DbContext
    {
        // Cryptography VAR
        static var rsa;
        static CspParameters cspp = new CspParameters();
        //const string connStringFile = @".\Connection\\connString.enc";
        //const string keysFile = @".\Connection\\rsaKeys.txt";
        //const string fileDecrypted = @".\Connection\\decryptedString.txt";

	// Server credentials
	const string connStringFile = @"./Connection/connString.enc";
	const string keysFile = @"./Connection/rsaKeys.txt";
	const string fileDecrypted = @"./Connection/decryptedString.txt";


        // Import all the tables from Models

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
        public DbSet<Equip> Equips { get; set; }
        public DbSet<Evolucio> Evolucions { get; set; }
        public DbSet<Pokemon_Tipus> Pokemon_Tipus { get; set; }

        protected override async void OnModelCreating(ModelBuilder mdb)
        {
            // POKEMONS ////////////////////////////////////////////
            HttpClient pogoApi = new HttpClient();
            HttpClient pokeApi = new HttpClient();
            pogoApi.BaseAddress = new Uri("https://pogoapi.net/api/v1/");
            pokeApi.BaseAddress = new Uri("https://pokeapi.co/api/v2/");

            // Add an Accept header for JSON format.
            pogoApi.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            List<Pokemon> pokemons;
            List<Moviment> moviments;
            List<Tipus> tipus;
            List<Possible_Moviment> possibles_moviments;
            List<Pokemon_Tipus> pokemons_tipus;
            List<Evolucio> evolucions;

            pokemons = await data_loading.getPokemons(pogoApi);
            tipus = await data_loading.getTypes(pokeApi);
            moviments = await data_loading.getMoves(pogoApi, tipus);
            possibles_moviments = await data_loading.getPokemonMoves(pogoApi, pokemons, moviments);
            pokemons_tipus = await data_loading.getPokemonTypes(pogoApi, pokemons, tipus);
            evolucions = await data_loading.getPokemonEvolutions(pogoApi, pokemons);

            /////////////////////////////////////////// DATA Configuration ///////////////////////////////////////////

            mdb.Entity<Pokemon>()
                .HasData(pokemons);

            mdb.Entity<Tipus>()
                .HasData(tipus);

            mdb.Entity<Moviment>()
                .HasData(moviments);

            mdb.Entity<Possible_Moviment>()
                .HasData(possibles_moviments);

            mdb.Entity<Pokemon_Tipus>()
                .HasData(pokemons_tipus);

            mdb.Entity<Evolucio>()
                .HasData(evolucions);

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

            mdb.Entity<Moviment>()
                .HasOne(e => e.tipus)
                .WithMany(f => f.te_moviments)
                .HasForeignKey(e => e.tipus_id)
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

            mdb.Entity<Possible_Moviment>()
                .HasKey(c => new { c.pokemon_id, c.moviment_id });

            mdb.Entity<Possible_Moviment>()
                .HasOne(e => e.pokemon)
                .WithMany(f => f.te_moviments)
                .HasForeignKey(e => e.pokemon_id);

            mdb.Entity<Possible_Moviment>()
                .HasOne(e => e.moviment)
                .WithMany(f => f.poden_ser_de_pokemon)
                .HasForeignKey(e => e.moviment_id)
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

            mdb.Entity<Evolucio>()
               .HasKey(c => new { c.id_pokemon, c.id_pokemon_evolucio});

            mdb.Entity<Evolucio>()
                .HasOne(p => p.pokemon)
                .WithMany(f => f.te_evolucio)
                .HasForeignKey(p => p.id_pokemon);

            mdb.Entity<Evolucio>()
                .HasOne(p => p.evolucio)
                .WithMany(f => f.es_evolucio)
                .HasForeignKey(p => p.id_pokemon_evolucio);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseNpgsql("Host=localhost; Port=5432; Database=pokemonGolot; Username=postgres; Password=postgres");
            //System.IO.File.Delete(fileDecrypted);
        }


        public string decryptStringConn()
        {
            importKeys();
            return decryptFile(connStringFile);
        }

        public void importKeys() {
            StreamReader sr = new StreamReader(keysFile);
            string keytxt = sr.ReadToEnd();
            rsa = RSA.Create(cspp);
            rsa.FromXmlString(keytxt);
            rsa.PersistKeyInCsp = true;
            if (rsa.PublicOnly == true)
                Console.WriteLine("Key: " + cspp.KeyContainerName + " - Public Only");
            else
                Console.WriteLine("Key: " + cspp.KeyContainerName + " - Full Key Pair");
            sr.Close();
        }

        static string decryptFile(string inFile) 
        {
            // Create instance of Aes for
            // symetric decryption of the data.
            Aes aes = Aes.Create();

            // Create byte arrays to get the length of
            // the encrypted key and IV.
            // These values were stored as 4 bytes each
            // at the beginning of the encrypted package.
            byte[] LenK = new byte[4];
            byte[] LenIV = new byte[4];

            // Construct the file name for the decrypted file.
            string outFile = fileDecrypted;

            // Use FileStream objects to read the encrypted
            // file (inFs) and save the decrypted file (outFs).
            using (FileStream inFs = new FileStream(inFile, FileMode.Open))
            {

                inFs.Seek(0, SeekOrigin.Begin);
                inFs.Seek(0, SeekOrigin.Begin);
                inFs.Read(LenK, 0, 3);
                inFs.Seek(4, SeekOrigin.Begin);
                inFs.Read(LenIV, 0, 3);

                // Convert the lengths to integer values.
                int lenK = BitConverter.ToInt32(LenK, 0);
                int lenIV = BitConverter.ToInt32(LenIV, 0);

                // Determine the start postition of
                // the ciphter text (startC)
                // and its length(lenC).
                int startC = lenK + lenIV + 8;
                int lenC = (int)inFs.Length - startC;

                // Create the byte arrays for
                // the encrypted Aes key,
                // the IV, and the cipher text.
                byte[] KeyEncrypted = new byte[lenK];
                byte[] IV = new byte[lenIV];

                // Extract the key and IV
                // starting from index 8
                // after the length values.
                inFs.Seek(8, SeekOrigin.Begin);
                inFs.Read(KeyEncrypted, 0, lenK);
                inFs.Seek(8 + lenK, SeekOrigin.Begin);
                inFs.Read(IV, 0, lenIV);

                // Use RSACryptoServiceProvider
                // to decrypt the AES key.
                byte[] KeyDecrypted = rsa.Decrypt(KeyEncrypted, false);

                // Decrypt the key.
                ICryptoTransform transform = aes.CreateDecryptor(KeyDecrypted, IV);


                // Decrypt the cipher text from
                // from the FileSteam of the encrypted
                // file (inFs) into the FileStream
                // for the decrypted file (outFs).
                using (FileStream outFs = new FileStream(outFile, FileMode.Create))
                {

                    int count = 0;
                    int offset = 0;

                    // blockSizeBytes can be any arbitrary size.
                    int blockSizeBytes = aes.BlockSize / 8;
                    byte[] data = new byte[blockSizeBytes];

                    // By decrypting a chunk a time,
                    // you can save memory and
                    // accommodate large files.

                    // Start at the beginning
                    // of the cipher text.
                    inFs.Seek(startC, SeekOrigin.Begin);
                    using (CryptoStream outStreamDecrypted = new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                    {
                        do
                        {
                            count = inFs.Read(data, 0, blockSizeBytes);
                            offset += count;
                            outStreamDecrypted.Write(data, 0, count);
                        }
                        while (count > 0);

                        outStreamDecrypted.FlushFinalBlock();
                        outStreamDecrypted.Close();
                    }
                    outFs.Close();
                }   
                inFs.Close();
                return System.IO.File.ReadAllText(fileDecrypted);

               }      
        }

    }
}
