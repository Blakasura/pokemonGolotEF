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
        [Route("addPlayer/{username}/{passwd}/{email}")]
        public async Task<List<Jugador>> AddPlayer(string username, string contrasenya, string email)
        {
            const int maxItems = 350;
            const int maxPokemon = 300;
            const int initialLevel = 1;

            Jugador newPlayer = new Jugador
            {
                nom_jugador = username,
                contrasenya_jugador = contrasenya,
                email_jugador = email,
                nivell_jugador = initialLevel,
                maxim_objectes_jugador = maxItems,
                maxim_pokemons_jugador = maxPokemon
            };
            var myTask = Task.Run(() => context.Jugadors.Add(newPlayer));
            await myTask;
            return await this.GetJugadors();
        }
    }
}