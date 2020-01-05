
using Microsoft.EntityFrameworkCore;
using ScoreKeeper.Datatypes;
using System.Collections.Generic;

namespace Intro
{
    public class GamekeeperDB : DbContext
    {
        public GamekeeperDB()
        {

        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamPlayer> TeamPlayers { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<PlayerGameStat> PlayerGameStats { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(local);Database=basketball;User Id=sa;Password=sa123!;");
        }
    }
}