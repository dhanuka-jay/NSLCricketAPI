using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NSLCricketAPI.Models;

namespace NSLCricketAPI.DataAccess
{
    public class NSLDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Performance> Performances { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=DHANUKA\\DB2019; Database=NSL; User Id=sa; Password=$ids1111$$AA";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Player Data
            modelBuilder.Entity<Player>().HasData(new Player[]
            {
                new Player
                {
                    ID = 1,
                    fName = "Sudeera",
                    lName = "Ilandarage",
                    joinedOn = DateTime.Now.AddDays(-20),
                    role = PlayerRoles.allRounder
                },
                new Player
                {
                    ID = 2,
                    fName = "Thilina",
                    lName = "Kalu Malli",
                    joinedOn = DateTime.Now.AddDays(-10),
                    role = PlayerRoles.keeper
                },
                new Player
                {
                    ID = 3,
                    fName = "Punya",
                    lName = "Abaya",
                    joinedOn = DateTime.Now.AddDays(-10),
                    role = PlayerRoles.viceCaptain
                },
                new Player
                {
                    ID = 4,
                    fName = "Shehan",
                    lName = "De Silva",
                    joinedOn = DateTime.Now.AddDays(-15),
                    role = PlayerRoles.captain
                }
            }
            );

            //Performance Data
            modelBuilder.Entity<Performance>().HasData(new Performance[]
            {
                new Performance
                {
                    Id = 1,
                    GameDay = DateTime.Now.AddDays(-4),
                    Runs = 28,
                    Overs = 0,
                    Wickets = 0,
                    PlayerId = 1
                },
                new Performance
                {
                    Id = 2,
                    GameDay = DateTime.Now.AddDays(-4),
                    Runs = 56,
                    Overs = 6,
                    Wickets = 2,
                    PlayerId = 4
                },
                new Performance
                {
                    Id = 3,
                    GameDay = DateTime.Now.AddDays(-4),
                    Runs = 9,
                    Overs = 3,
                    Wickets = 1,
                    PlayerId = 3
                }
            });
        }
    }
}
