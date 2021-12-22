using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSLCricketAPI.Models;

namespace NSLCricketAPI.Services.Players
{
    public interface IPlayerRepository
    {
        public List<Player> GetAllPlayers();

        public Player GetPlayer(int id);
    }
}
