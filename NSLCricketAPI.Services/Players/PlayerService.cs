using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NSLCricketAPI.Models;

namespace NSLCricketAPI.Services.Players
{
    public class PlayerService : IPlayerRepository
    {
        public List<Player> GetAllPlayers()
        {
            var allPlayers = new List<Player>();

            var player1 = new Player
            {
                ID = 1,
                fName = "Sudeera",
                lName = "Ilandarage",
                joinedOn = DateTime.Now,
                role = PlayerRoles.allRounder
            };

            allPlayers.Add(player1);

            var player2 = new Player
            {
                ID = 2,
                fName = "Thilina",
                lName = "Kalu Malli",
                joinedOn = DateTime.Now.AddDays(-10),
                role = PlayerRoles.keeper
            };

            allPlayers.Add(player2);

            var player3 = new Player
            {
                ID = 3,
                fName = "Punya",
                lName = "Abaya",
                joinedOn = DateTime.Now,
                role = PlayerRoles.captain
            };

            allPlayers.Add(player3);

            return allPlayers;
        }

        public Player GetPlayer(int id)
        {
            throw new NotImplementedException();
        }
    }
}
