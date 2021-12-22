using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSLCricketAPI.DataAccess;
using NSLCricketAPI.Models;

namespace NSLCricketAPI.Services.Players
{
    public class PlayerDbService : IPlayerRepository
    {
        private protected NSLDbContext _context = new NSLDbContext();

        public List<Player> GetAllPlayers()
        {
            return _context.Players.ToList();
        }

        public Player GetPlayer(int id)
        {
            var player = _context.Players.Find(id);
            return player;
        }
    }
}
