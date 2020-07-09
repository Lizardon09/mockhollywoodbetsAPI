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

namespace MockHollywoodBets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class TournamentController : ControllerBase
    {

        private readonly ITournamentRepository _tournamentRepository;

        private readonly ILogger<TournamentController> _logger;

        public TournamentController(ILogger<TournamentController> logger, ITournamentRepository tournamentRepository)
        {
            _logger = logger;
            _tournamentRepository = tournamentRepository;
        }


        // GET api/tournament
        // GET api/tournament?sportid={sportid}&countryid={countryid}
        [HttpGet]
        public IActionResult Get(long? sportid, long? countryid)
        {

            try
            {
                if (sportid.HasValue && countryid.HasValue)
                {

                    _logger.LogInformation("API Request hit: GET all Tournaments by SportId: " + sportid + " and CountryId: " + countryid);
                    var result = _tournamentRepository.Get(sportid, countryid);
                    if (result.ToList().Any())
                    {
                        return Ok(result);
                    }
                    else
                    {
                        _logger.LogInformation("API Request (GET all Tournaments by SportId: " + sportid + " and CountryId: " + countryid + " ) no entries found");
                        return NotFound("Tournaments were not found with SportId: " + sportid + " and CountryId: " + countryid);
                    }

                }
                else if (!sportid.HasValue && !countryid.HasValue)
                {
                    _logger.LogInformation("API Request hit: GET all Tournaments by no criteria");
                    var result = _tournamentRepository.GetAll();
                    return Ok(result);
                }

                else
                {
                    _logger.LogError("API Request (GET all Tournaments by SpoirtId and CountryId) FAILED: ");
                    return BadRequest("API Request (GET all Tournaments by SpoirtId and CountryId) FAILED: ");
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (GET all Tournaments by SpoirtId and CountryId) FAILED: ", e);
                return BadRequest("API Request (GET all Tournaments by SpoirtId and CountryId) FAILED: ");
            }
 
        }

    }
}