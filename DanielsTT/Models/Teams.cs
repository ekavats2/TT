using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DanielsTT.Models
{
    public class Teams
    {   [Key]
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public string TeamRegion { get; set; }

        public ICollection<Player> Team { get; set; }

    }
}
