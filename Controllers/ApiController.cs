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
            return jugadors;
        }

        [HttpGet]
        [Route("Pokemons")]
        public async Task<List<Pokemon>> GetPokemons()
        {
            var myTask = Task.Run(() => context.Pokemons.OrderBy(p => p.id_pokemon).ToList());
            List<Pokemon> pokemons = await myTask;
            Console.WriteLine("PROVA");
            return pokemons;
        }

        [HttpGet]
        [Route("Moviments")]
        public async Task<List<Moviment>> GetMoviments()
        {
            var myTask = Task.Run(() => context.Moviments.OrderBy(m => m.id_moviment).ToList());
            List<Moviment> moviments = await myTask;
            return moviments;
        }

        [HttpGet]
        [Route("Evolucions")]
        public async Task<List<Evolucio>> GetEvolucions()
        {
            var myTask = Task.Run(() => context.Evolucions.OrderBy(e => e.id_pokemon).ToList());
            List<Evolucio> Evolucions = await myTask;
            return Evolucions;
        }

        [HttpGet]
        [Route("TipusPokemons")]
        public async Task<List<Pokemon_Tipus>> GetPokemonTypes()
        {
            var myTask = Task.Run(() => context.Pokemon_Tipus.ToList());
            List<Pokemon_Tipus> Pokemon_Tipus = await myTask;
            return Pokemon_Tipus;
        }

        [HttpGet]
        [Route("Tipus")]
        public async Task<List<Tipus>> GetPokemonTypes()
        {
            var myTask = Task.Run(() => context.Tipus.ToList());
            List<Tipus> Tipus = await myTask;
            return Tipus;
        }

        [HttpGet]
        [Route("Equips")]
        public async Task<List<Equip>> GetEquips()
        {
            var myTask = Task.Run(() => context.Equips.ToList());
            List<Equip> equips = await myTask;
            return equips;
        }
        
        [HttpGet]
        [Route("LogIn")]
        public async Task<Boolean> LogIn([FromBody] Jugador player)
        {
            var myTask = Task.Run(() => context.Jugadors.Where(j => j.nom_jugador.Equals(player.nom_jugador) && j.contrasenya_jugador.Equals(player.contrasenya_jugador)).ToList());
            List<Jugador> players = await myTask;
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
                return new HttpResponseMessage(System.Net.HttpStatusCode.OK);

          //  } else { 

               // var response = new HttpResponseMessage(System.Net.HttpStatusCode.NotFound);
               // response.Content = new StringContent("Aquest correu electrònic s'està fent servir per un altre compte");
               // return response;
                
            //}

        }
    }
}