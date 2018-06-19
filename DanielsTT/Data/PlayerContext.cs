using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DanielsTT.Models
{
    public class PlayerContext : DbContext
    {
        public PlayerContext (DbContextOptions<PlayerContext> options)
            : base(options)
        {
        }

        public DbSet<DanielsTT.Models.Player> Player { get; set; }
        public DbSet<DanielsTT.Models.Teams> Teams { get; set; }
    }
}
