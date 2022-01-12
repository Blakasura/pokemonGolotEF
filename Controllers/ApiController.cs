using Microsoft.AspNetCore.Mvc;
using Data;
using Model;

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
            var myTask = Task.Run(() => context.Jugadors.ToList());
            List<Jugador> jugadors = await myTask;
            Console.WriteLine("[SERVER] Query 'Jugadors' executed correctly");
            return jugadors;
        }

        [HttpGet]
        [Route("Pokemons")]
        public async Task<List<Pokemon>> GetPokemons()
        {
            var myTask = Task.Run(() => context.Pokemons.OrderBy(p => p.id_pokemon).ToList());
            List<Pokemon> pokemons = await myTask;
            Console.WriteLine("[SERVER] Query 'Pokemons' executed correctly");
            return pokemons;
        }

        [HttpGet]
        [Route("Pokedex")]
        public async Task<List<Pokedex>> GetPokedex()
        {
            var myTask = Task.Run(() => context.Pokedexs.Where(j => j.jugadorId.Equals("xavi")).OrderBy(p => p.pokemonId).ToList());
            List<Pokedex> pokedex = await myTask;
            Console.WriteLine("[SERVER] Query 'Pokedex' executed correctly");
            return pokedex;

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
            var myTask = Task.Run(() => context.Jugadors.Where(j => j.nom_jugador.Equals(player.nom_jugador) && j.contrasenya_jugador.Equals(player.contrasenya_jugador)).ToList());
            List<Jugador> players = await myTask;
            Console.WriteLine("[SERVER] Query 'LogIn' executed correctly");
            return (players.Count<Jugador>() != 0);
        }

        [HttpPost]
        [Route("addPlayer")]
        public HttpResponseMessage addPlayer([FromBody] Jugador newPlayer)
        {
            //if (context.Jugadors.First(j => j.email_jugador == newPlayer.email_jugador) == null) 
            //{ 
                const int maxItems = 350;
                const int maxPokemon = 300;
                const int initialLevel = 1;

                // newPlayer.nom_jugador = username;
                // newPlayer.contrasenya_jugador = contrasenya;
                // newPlayer.email_jugador = email;
                newPlayer.nivell_jugador = initialLevel;
                newPlayer.maxim_objectes_jugador = maxItems;
                newPlayer.maxim_pokemons_jugador = maxPokemon;

                context.Jugadors.Add(newPlayer);
                context.SaveChangesAsync();
                Console.WriteLine("[SERVER] Query 'addPlayer' executed correctly");
                generatePlayer(newPlayer.nom_jugador);
                return new HttpResponseMessage(System.Net.HttpStatusCode.OK);

          //  } else { 

               // var response = new HttpResponseMessage(System.Net.HttpStatusCode.NotFound);
               // response.Content = new StringContent("Aquest correu electr�nic s'est� fent servir per un altre compte");
               // return response;
                
            //}
        }

        public async void generatePlayer(string player_id)
        {
            var task = Task.Run(() => context.Pokemons.OrderBy(p => p.id_pokemon).ToList());
            List<Pokemon> pokemons = await task;
            Console.WriteLine(pokemons.Count);
            Pokedex pokedex = new Pokedex();

            foreach (Pokemon pokemon in pokemons)
            {
                pokedex = new Pokedex();

                pokedex.jugadorId = player_id;
                pokedex.pokemonId = pokemon.id_pokemon;
                pokedex.vist_pokedex = 'n';
                pokedex.caramels_pokedex = 0;

                pokedex.pokemon = pokemon;

                context.Pokedexs.Add(pokedex);
            }

            context.SaveChanges();
            Console.WriteLine("[SERVER] Task 'generatePlayer' executed correctly");
        }

        /*public string Encrypt(string source, string key)
        {
            TripleDESCryptoServiceProvider desCryptoProvider = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider();
 
            byte[] byteHash;
            byte[] byteBuff;
 
            byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
            desCryptoProvider.Key = byteHash;
            desCryptoProvider.Mode = CipherMode.ECB; //CBC, CFB
            byteBuff = Encoding.UTF8.GetBytes(source);
 
            string encoded = 
                Convert.ToBase64String(desCryptoProvider.CreateEncryptor().TransformFinalBlock(byteBuff, 0, byteBuff.Length));
            return encoded;
        }*/
    }
}