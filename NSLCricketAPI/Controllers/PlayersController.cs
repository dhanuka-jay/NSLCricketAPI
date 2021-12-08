using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NSLCricketAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        [HttpGet]
        public IActionResult Players()
        {
            var players = new string[] { "Sudheera_1", "Punyna", "Duviya", "Lalith2" };
            return Ok(players);
        }

        [HttpPost]
        public IActionResult AddPlayer()
        {
            //var players = new string[] { "Sudheera", "Punyna", "Duviya" };
            return BadRequest();
        }
    }
}
