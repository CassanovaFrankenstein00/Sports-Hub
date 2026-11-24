using Microsoft.EntityFrameworkCore;
using Sports_Hub.Models;

namespace Sports_Hub.Data
{
    public class SportsHubContext : DbContext
    {
        public SportsHubContext(DbContextOptions<SportsHubContext> options)
            : base(options)
        {
        }

        public DbSet<League> Leagues { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<League>().HasData(
                new League { LeagueId = 1, LeagueName = "NFL", Sport = "Football" },
                new League { LeagueId = 2, LeagueName = "NBA", Sport = "Basketball" },
                new League { LeagueId = 3, LeagueName = "MLB", Sport = "Baseball" },
                new League { LeagueId = 4, LeagueName = "NHL", Sport = "Hockey" }
            );
        }
    }
}