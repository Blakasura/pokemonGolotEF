using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Design;
using System.Text;

namespace ApiModel
{
    public class pokedex_api
    {
        public int id_pokemon { get; set; }
        public string nom_pokemon { get; set; }
        public string rarity { get; set; }
        public char status { get; set; }
    }
}