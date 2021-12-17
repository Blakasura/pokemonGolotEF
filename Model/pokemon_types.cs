using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemonGolot.Model
{
    public class pokemon_types
    {
        public string form { get; set; }
        public int pokemon_id { get; set; }
        public string pokemon_name { get; set; }
        public List<string> type { get; set; }
    }
}
