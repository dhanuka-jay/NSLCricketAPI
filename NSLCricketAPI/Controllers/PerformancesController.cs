using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NSLCricketAPI.Services.Performances;

namespace NSLCricketAPI.Controllers
{
    [Route("api/performances")]
    [ApiController]
    public class PerformancesController : ControllerBase
    {
        private readonly IPerformanceRepository _performanceService;
        public PerformancesController(IPerformanceRepository performanceService)
        {
            _performanceService = performanceService;
        }

        [HttpGet]
        public IActionResult GetPerformances()
        {
            var performances = _performanceService.GetAllPerformances();
            return Ok(performances);
        }

        [HttpGet("{id}")]
        public IActionResult GetPerformance(int id)
        {
            var perfornamce = _performanceService.GetPerformance(id);

            if (perfornamce is null)
            {
                return NotFound();
            }

            return Ok(perfornamce);
        }
    }
}
