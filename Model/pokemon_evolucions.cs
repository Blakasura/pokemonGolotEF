using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Evolution
    {
        public int candy_required { get; set; }
        public string form { get; set; }
        public int pokemon_id { get; set; }
        public string pokemon_name { get; set; }
        public string item_required { get; set; }
        public bool? no_candy_cost_if_traded { get; set; }
        public int? priority { get; set; }
        public string lure_required { get; set; }
        public double? buddy_distance_required { get; set; }
        public bool? must_be_buddy_to_evolve { get; set; }
        public bool? only_evolves_in_daytime { get; set; }
        public bool? only_evolves_in_nighttime { get; set; }
        public string gender_required { get; set; }
        public bool? upside_down { get; set; }
    }

    public class pokemon_evolucions
    {
        public List<Evolution> evolutions { get; set; }
        public string form { get; set; }
        public int pokemon_id { get; set; }
        public string pokemon_name { get; set; }
    }
}
