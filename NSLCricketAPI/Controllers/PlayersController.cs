using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSLCricketAPI.Services.Players;

namespace NSLCricketAPI.Controllers
{
    [Route("api/players")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IPlayerRepository _playerService;

        public PlayersController(IPlayerRepository playerRepository)
        {
            _playerService = playerRepository;
        }

        [HttpGet]
        public IActionResult GetPlayers()
        {
            var players = _playerService.GetAllPlayers();
            return Ok(players);
        }

        [HttpGet("{id}")]
        public IActionResult GetPlayer(int id)
        {
            var player = _playerService.GetPlayer(id);

            if (player is null)
            {
                return NotFound();
            }

            return Ok(player);
        }

        //[HttpGet("{id?}")]
        //public IActionResult Players(int? id)
        //{
        //    var players = GetAllPlayers();

        //    if (id is not null)
        //    {
        //        players = players.Where(T => T.ID == id).ToList();
        //        return Ok(players);
        //    }
            
        //    return Ok(players);
        //}

        
    }
}
