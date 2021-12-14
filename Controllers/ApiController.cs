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
            var myTask = Task.Run(() => context.Equip.ToList());
            List<Equip> equips = await myTask;
            return equips;
        }
        [HttpGet]
        [Route("Jugador|{username}|{contrasenya}")]
        public async Task<Boolean> LogIn(string username, string contrasenya)
        {
            var myTask = Task.Run(() => context.Jugadors.Where(j => j.nom_jugador.Equals(username) && j.contrasenya_jugador.Equals(contrasenya)).ToList());
            List<Jugador> player = await myTask;
            return (player.Count<Jugador>() != 0);
        }
    }
}