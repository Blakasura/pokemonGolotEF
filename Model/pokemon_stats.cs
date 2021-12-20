using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore.Design;
using System.Text;

namespace ApiModel
{
    public class pokemon_stats
    {
        public int base_attack { get; set; }
        public int base_defense { get; set; }
        public int base_stamina { get; set; }
        public string form { get; set; }
        public int pokemon_id { get; set; }
        public string pokemon_name { get; set; }

    }
}