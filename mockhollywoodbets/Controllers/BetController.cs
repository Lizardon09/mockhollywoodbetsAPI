using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MockHollywoodBetsDAL.Models;
using Microsoft.AspNetCore.Cors;
using MockHollywoodBetsDAL.DataManagers;
using MockHollywoodBetsDAL.DataManagers.Repository;
using MockHollywoodBetsDAL.DataManagers.Repository.Interfaces;
using MockHollywoodBetsDAL.CustomModels;

namespace MockHollywoodBets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class BetController : ControllerBase
    {
        private readonly IBetRepository _betRepository;

        private readonly ILogger<BetController> _logger;

        public BetController(ILogger<BetController> logger, IBetRepository betrepository)
        {
            _logger = logger;
            _betRepository = betrepository;
        }

        [HttpPost]
        public IActionResult Post([FromBody] BetSlipInfo betSlipInfo)
        {
            try
            {
                if (betSlipInfo != null)
                {

                    _logger.LogInformation("API Request hit: INSERT BetSlip with Bets : ");
                    var result = _betRepository.Add(betSlipInfo);

                    if (result == betSlipInfo.Bets.Count()+1)
                    {
                        return Ok("{\"status\": \"Success\"}");
                    }
                    else
                    {
                        _logger.LogInformation("API Request (INSERT BetSlip with Bets : ) not committed");
                        return NotFound("Failed: INSERT could not commit");
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit (INSERT BetSlip with Bets) with null entry");
                    return BadRequest("Failed: null entry");
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (INSERT BetSlip with Bets) FAILED: ", e);
                return BadRequest(e);
            }
        }
    }
}