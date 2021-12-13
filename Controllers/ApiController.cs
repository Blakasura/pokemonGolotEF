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
    }
}