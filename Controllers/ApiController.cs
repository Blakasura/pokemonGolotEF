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
            var myTask = Task.Run(() => context.Pokemons.ToList());
            List<Pokemon> pokemons = await myTask;
            return pokemons;
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
        [Route("Jugador|user={username}|passwd={contrasenya}")]
        public async Task<Boolean> LogIn(string username, string contrasenya)
        {
            var myTask = Task.Run(() => context.Jugadors.Where(j => j.nom_jugador.Equals(username) && j.contrasenya_jugador.Equals(contrasenya)).ToList());
            List<Jugador> player = await myTask;
            return (player.Count<Jugador>() != 0);
        }
        [HttpPost]
        [Route("addPlayer")]
        public async Task<List<Jugador>> addPlayer([FromBody] Jugador newPlayer)
        {
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
            await context.SaveChangesAsync();
            return await this.GetJugadors();
        }
    }
}