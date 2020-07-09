using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MockHollywoodBets.Models;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Cors;
using MockHollywoodBets.DataManagers;
using MockHollywoodBets.DataManagers.Repository.Interfaces;
using MockHollywoodBets.CustomModels;

namespace MockHollywoodBets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class MarketController : ControllerBase
    {

        private readonly IMarketRepository _marketRepository;

        private readonly ILogger<MarketController> _logger;

        public MarketController(ILogger<MarketController> logger, IMarketRepository marketRepository)
        {
            _logger = logger;
            _marketRepository = marketRepository;
        }

        [HttpGet]
        public IActionResult Get(long? tournamentid)
        {

            try
            {
                if (tournamentid.HasValue)
                {

                    _logger.LogInformation("API Request hit: GET all MarketOdds by TournamentId: " + tournamentid.Value);
                    var result = _marketRepository.Get(tournamentid);
                    if (result.ToList().Any())
                    {
                        return Ok(result);
                    }
                    else
                    {
                        _logger.LogInformation("API Request (GET all MarketOdds by TournamentId: " + tournamentid.Value + " ) no entries found");
                        return NotFound("MarketOdds were not found with TournamentId: " + tournamentid.Value);
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit: GET all MarketOdds by no criteria");
                    var result = _marketRepository.GetAll();
                    return Ok(result);
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (GET all MarketOdds by TournamentId) FAILED: ", e);
                return BadRequest();
            }

        }
    }
}