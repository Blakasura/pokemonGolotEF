using Microsoft.AspNetCore.Mvc;
using Data;
using Model;
using Security;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Controllers
{
    [ApiController]
    [Route("")]
    public class ApiController : Controller
    {
        public static Database context = new Database();

        [HttpGet]
        [Route("Jugadors")]
        public async Task<List<Jugador>> GetJugadors()
        {
            var myTask = Task.Run(() => context.Jugadors.AsNoTracking().ToList());
            List<Jugador> jugadors = await myTask;
            List<Jugador> result = new List<Jugador>();
            Jugador j;

            foreach (Jugador jugador in jugadors) {

                if (jugador.nom_jugador != "xavi") {
                    j = new Jugador();
                    j.nom_jugador = Encryption.Decrypt(jugador.nom_jugador);
                    j.email_jugador = Encryption.Decrypt(jugador.email_jugador);
                    j.nivell_jugador = jugador.nivell_jugador;
                    j.maxim_pokemons_jugador = jugador.maxim_pokemons_jugador;
                    j.maxim_objectes_jugador = jugador.maxim_objectes_jugador;
                    result.Add(j);
                }
            }
            Console.WriteLine("[SERVER] Query 'Jugadors' executed correctly");
            //context.SaveChanges();
            return result;
        }

        [HttpPost]
        [Route("Jugadors/ActualitzarJugador")]
        public HttpResponseMessage UpdateJugador(Jugador jugador)
        {
            if (jugador.nom_jugador != "xavi")
            {
                string nom_jugador_encriptat = Encryption.Crypt(jugador.nom_jugador);
                var j = context.Jugadors.SingleOrDefault(j => j.nom_jugador == nom_jugador_encriptat);
                if (j != null)
                {
                    j.email_jugador = Encryption.Crypt(jugador.email_jugador);
                    j.contrasenya_jugador = jugador.contrasenya_jugador;
                    context.SaveChanges();
                }
            }
            
            Console.WriteLine("[SERVER] Query 'Jugadors/ActualitzarJugador' executed correctly");
            return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
        }

        [HttpGet]
        [Route("Pokemons")]
        public async Task<List<Pokemon>> GetPokemons()
        {
            var myTask = Task.Run(() => context.Pokemons.Where(p=> p.id_pokemon <=  384).OrderBy(p => p.id_pokemon).ToList());
            List<Pokemon> pokemons = await myTask;
            Console.WriteLine("[SERVER] Query 'Pokemons' executed correctly");
            return pokemons;
        }

        [HttpGet]
        [Route("Jugadors/Pokemons")]
        public async Task<List<Jugador_Pokemon>> GetPokemonsJugador(Jugador jugador)
        {
            if (jugador.nom_jugador != "xavi")
            {
                var myTask = Task.Run(() => context.Jugadors_Pokemons.Where(p => Encryption.Decrypt(p.jugador.nom_jugador) == jugador.nom_jugador).OrderBy(p => p.pokemon.id_pokemon).ToList());
                List<Jugador_Pokemon> pokemons = await myTask;
                Console.WriteLine("[SERVER] Query 'Jugadors/Pokemons' executed correctly");
                return pokemons;
            }
            else {
                return null;
            }
        }

        [HttpGet]
        [Route("Moviments")]
        public async Task<List<Moviment>> GetMoviments()
        {
            var myTask = Task.Run(() => context.Moviments.OrderBy(m => m.id_moviment).ToList());
            List<Moviment> moviments = await myTask;
            Console.WriteLine("[SERVER] Query 'Moviments' executed correctly");
            return moviments;
        }

        [HttpGet]
        [Route("Evolucions")]
        public async Task<List<Evolucio>> GetEvolucions()
        {
            var myTask = Task.Run(() => context.Evolucions.OrderBy(e => e.id_pokemon).ToList());
            List<Evolucio> Evolucions = await myTask;
            Console.WriteLine("[SERVER] Query 'Evolucions' executed correctly");
            return Evolucions;
        }

        [HttpGet]
        [Route("TipusPokemons")]
        public async Task<List<Pokemon_Tipus>> GetPokemonTypes()
        {
            var myTask = Task.Run(() => context.Pokemon_Tipus.ToList());
            List<Pokemon_Tipus> Pokemon_Tipus = await myTask;
            Console.WriteLine("[SERVER] Query 'TipusPokemons' executed correctly");
            return Pokemon_Tipus;
        }

        [HttpGet]
        [Route("Tipus")]
        public async Task<List<Tipus>> GetTipus()
        {
            var myTask = Task.Run(() => context.Tipus.ToList());
            List<Tipus> Tipus = await myTask;
            Console.WriteLine("[SERVER] Query 'Tipus' executed correctly");
            return Tipus;
        }

        [HttpGet]
        [Route("Equips")]
        public async Task<List<Equip>> GetEquips()
        {
            var myTask = Task.Run(() => context.Equips.ToList());
            List<Equip> equips = await myTask;
            Console.WriteLine("[SERVER] Query 'Equips' executed correctly");
            return equips;
        }
        
        [HttpPost]
        [Route("LogIn")]
        public async Task<Boolean> LogIn([FromBody] Jugador player)
        {
            var myTask = Task.Run(() => context.Jugadors.Where(j => j.nom_jugador.Equals(Encryption.Crypt(player.nom_jugador)) && j.contrasenya_jugador.Equals(player.contrasenya_jugador)).ToList());
            List<Jugador> players = await myTask;
            Console.WriteLine("[SERVER] Query 'LogIn' executed correctly");
            return (players.Count<Jugador>() != 0);
        }

        [HttpGet]
        [Route("Pokeparades")]
        public async Task<List<Pokeparada>> GetPokeparades()
        {
            var myTask = Task.Run(() => context.Pokeparades.ToList());
            List<Pokeparada> pokeparades = await myTask;
            Console.WriteLine("[SERVER] Query 'Pokeparades' executed correctly");
            return pokeparades;
        }

        [HttpPost]
        [Route("Pokeparades/Crear")]
        public HttpResponseMessage addPokeparada([FromBody] Pokeparada newPokeparada)
        {
                newPokeparada.id_pokeparada = context.Pokeparades.Count() + 1;

                context.Pokeparades.Add(newPokeparada);
                context.SaveChangesAsync();
                return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
        }

        [HttpPost]
        [Route("PokemonPerJugador")]
        public async Task<HttpResponseMessage> addPokemonPerJugadorAsync(string id_jugador, int id_pokemon, string coordinates)
        {
            Random random = new Random();
            Jugador_Pokemon nou_pokemon = new Jugador_Pokemon();

            var myTask = Task.Run(() => context.Pokemons.Where(p => p.id_pokemon == id_pokemon).ToList());
            List<Pokemon> pokemon = await myTask;
            var myTask2 = Task.Run(() => context.Jugadors.Where(p => Encryption.Decrypt(p.nom_jugador) == id_jugador).ToList());
            List<Jugador> jugador = await myTask2;

            if (jugador != null && pokemon != null)
            {
                nou_pokemon.pokemon = pokemon[0];
                nou_pokemon.ubicacio_pokemon = coordinates;
                nou_pokemon.jugadorId = id_jugador;
                nou_pokemon.jugador = jugador[0];
                nou_pokemon.IV_atac_jugador_pokemon = random.Next(15);
                nou_pokemon.IV_vida_jugador_pokemon = random.Next(15);
                nou_pokemon.IV_defensa_jugador_pokemon = random.Next(15);
                nou_pokemon.punts_combat_jugador_pokemon = random.Next(1000, 4000);

                context.Jugadors_Pokemons.Add(nou_pokemon);
                await context.SaveChangesAsync();
                return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            }
            else {
                return new HttpResponseMessage(System.Net.HttpStatusCode.Forbidden);
            }

        }


        [HttpGet]
        [Route("Pokedex")]
        public async Task<List<pokedex_pokemon>> GetPokedex(string jugador_id)
        { 
            var getPokemons = Task.Run(() => context.Pokemons.OrderBy(p => p.id_pokemon).ToList());
            List<Pokemon> pokemons = await getPokemons;

            var getPokedex = Task.Run(() => context.Pokedexs.Where(j => j.jugadorId.Equals(Encryption.Crypt(jugador_id))).OrderBy(p => p.pokemonId).ToList());
            List<Pokedex> pokedex = await getPokedex;

            var getTipus = Task.Run(() => context.Tipus.ToList());
            List<Tipus> tipus = await getTipus;
            List<int> id_tipus_finals;
            Tipus tipus_a_afegir;

            var getPokemonTipus = Task.Run(() => context.Pokemon_Tipus.ToList());
            List<Pokemon_Tipus> pokemons_tipus = await getPokemonTipus;
            List<Pokemon_Tipus> tipus_de_pokemons; 
            List<String> nom_tipus_finals;
     
            List<pokedex_pokemon> pokedex_pokemons = new List<pokedex_pokemon>();  
            pokedex_pokemon pokedex_pokemon = new pokedex_pokemon();


            foreach (Pokemon pokemon in pokemons) {
                pokedex_pokemon = new pokedex_pokemon();
                id_tipus_finals = new List<int>();
                tipus_de_pokemons = new List<Pokemon_Tipus>();
                nom_tipus_finals = new List<string>();

                pokedex_pokemon.id_pokemon = pokemon.id_pokemon;
                pokedex_pokemon.nom_pokemon = pokemon.nom_pokemon;
                pokedex_pokemon.rarity = pokemon.rarity;

                tipus_de_pokemons = pokemons_tipus.FindAll(pt => pt.pokemon_id == pokemon.id_pokemon);

                foreach(Pokemon_Tipus pk in tipus_de_pokemons)
                { 
                    id_tipus_finals.Add(pk.tipus_id);
                }

                foreach (int i in id_tipus_finals)
                {
                    nom_tipus_finals.Add(tipus.Find(tp => tp.id_tipus == i).nom_tipus);
                }

                pokedex_pokemon.tipus = nom_tipus_finals;

                try
                { 
                    pokedex_pokemon.vist_per_jugador = pokedex.Find(pk => pk.pokemonId == pokemon.id_pokemon).vist_pokedex;
                    pokedex_pokemon.caramels = pokedex.Find(pk => pk.pokemonId == pokemon.id_pokemon).caramels_pokedex;
                }
                catch (Exception e) { 
                    pokedex_pokemon.vist_per_jugador = 'n';
                    pokedex_pokemon.caramels = 0;

                }
                pokedex_pokemons.Add(pokedex_pokemon);

            }

            return pokedex_pokemons;
         
        }

        [HttpPost]
        [Route("addPlayer")]
        public HttpResponseMessage addPlayer([FromBody] Jugador newPlayer)
        {

                const int maxItems = 350;
                const int maxPokemon = 300;
                const int initialLevel = 1;

                newPlayer.nom_jugador = Encryption.Crypt(newPlayer.nom_jugador);
                newPlayer.contrasenya_jugador = newPlayer.contrasenya_jugador;
                newPlayer.email_jugador = Encryption.Crypt(newPlayer.email_jugador);
                newPlayer.nivell_jugador = initialLevel;
                newPlayer.maxim_objectes_jugador = maxItems;
                newPlayer.maxim_pokemons_jugador = maxPokemon;
                context.Jugadors.Add(newPlayer);
                context.SaveChangesAsync();
                Console.WriteLine("[SERVER] Query 'addPlayer' executed correctly");
                return new HttpResponseMessage(System.Net.HttpStatusCode.OK);

        }

    }
}