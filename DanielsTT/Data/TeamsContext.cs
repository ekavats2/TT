using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DanielsTT.Models
{
    public class TeamsContext : DbContext
    {
        public TeamsContext (DbContextOptions<TeamsContext> options)
            : base(options)
        {
        }

        public DbSet<DanielsTT.Models.Teams> Teams { get; set; }
    }
}
