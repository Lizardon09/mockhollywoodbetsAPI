using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MockHollywoodBetsDAL.Models;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Cors;
using MockHollywoodBetsDAL.DataManagers;
using MockHollywoodBetsDAL.DataManagers.Repository.Interfaces;

namespace MockHollywoodBets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class BettypeController : ControllerBase
    {

        private readonly IBettypeRepository _bettypeRepository;
        
        private readonly ILogger<BettypeController> _logger;

        public BettypeController(ILogger<BettypeController> logger, IBettypeRepository bettypeRepository)
        {
            _logger = logger;
            _bettypeRepository = bettypeRepository;
        }

        [HttpGet]
        public IActionResult Get(long? tournamentid)
        {
            try
            {
                if (tournamentid.HasValue)
                {

                        _logger.LogInformation("API Request hit: GET all Bettypes by TournamentId: "+tournamentid.Value);
                        var result = _bettypeRepository.Get(tournamentid);
                        if (result.ToList().Any())
                        {
                            return Ok(result);
                        }
                        else
                        {
                            _logger.LogInformation("API Request (GET all Bettypes by TournamentId: "+tournamentid.Value+" ) no entries found");
                            return NotFound("Bettype was not found with TournamentId: "+tournamentid.Value);
                        }

                }
                else
                {
                    _logger.LogInformation("API Request hit: GET all Bettypes by no criteria");
                    var result = _bettypeRepository.GetAll();
                    return Ok(result);
                }
            }

            catch(Exception e)
            {
                _logger.LogError("API Request (GET all Bettypes by TournamentId) FAILED: " , e);
                return BadRequest();
            }
            
        }

    }
}