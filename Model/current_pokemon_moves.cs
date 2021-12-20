using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemonGolot.Model
{
    class current_pokemon_moves
    {
        public List<string> charged_moves { get; set; }
        public List<string> elite_charged_moves { get; set; }
        public List<string> elite_fast_moves { get; set; }
        public List<string> fast_moves { get; set; }
        public string form { get; set; }
        public int pokemon_id { get; set; }
        public string pokemon_name { get; set; }
    }
}
