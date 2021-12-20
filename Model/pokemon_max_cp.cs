using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore.Design;
using System.Text;

namespace ApiModel
{
    public class pokemon_max_cp
    {
        public string form { get; set; }
        public int max_cp { get; set; }
        public int pokemon_id { get; set; }
        public string pokemon_name { get; set; }
    }
}