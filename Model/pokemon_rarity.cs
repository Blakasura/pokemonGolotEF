using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore.Design;
using System.Text;

namespace ApiModel
{
    public class Legendary
    {
        public string form { get; set; }
        public int pokemon_id { get; set; }
        public string pokemon_name { get; set; }
        public string rarity { get; set; }
    }

    public class Mythic
    {
        public string form { get; set; }
        public int pokemon_id { get; set; }
        public string pokemon_name { get; set; }
        public string rarity { get; set; }
    }

    public class Standard
    {
        public string form { get; set; }
        public int pokemon_id { get; set; }
        public string pokemon_name { get; set; }
        public string rarity { get; set; }
    }

    public class pokemon_rarity
    {
        public List<Legendary> Legendary { get; set; }
        public List<Mythic> Mythic { get; set; }
        public List<Standard> Standard { get; set; }
    }

}