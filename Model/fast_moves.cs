using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Design;
using System.Text;

namespace ApiModel
{
    public class fast_moves
    {
        public string stamina_loss_scaler { get; set; }
        public string name { get; set; }
        public int power { get; set; }
        public int duration { get; set; }
        public int energy_delta { get; set; }
        public string type { get; set; }
    }
}