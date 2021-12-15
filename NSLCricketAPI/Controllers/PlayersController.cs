using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSLCricketAPI.Services;

namespace NSLCricketAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private IPlayerRepository _playerService;

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

        [HttpGet("{ID}")]
        public IActionResult GetPlayer(int ID)
        {
            var players = _playerService.GetAllPlayers();
            return Ok(players.Where(T => T.ID.Equals(ID)).ToList());
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
