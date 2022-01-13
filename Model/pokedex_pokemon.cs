using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Model;

namespace pokemonGolot.Model
{
    public class pokedex_pokemon
    {
        public int id_pokemon { get; set; }
        public string nom_pokemon { get; set; }
        public string rarity { get; set; }
        public List<string> tipus { get; set; }
        public bool vist_per_jugador { get; set; }
        public int caramels { get; set; }

    }
}

