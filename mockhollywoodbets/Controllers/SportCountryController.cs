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
using MockHollywoodBetsDAL.DataManagers.Repository;
using MockHollywoodBetsDAL.DataManagers.Repository.Interfaces;

namespace MockHollywoodBets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class SportCountryController : ControllerBase
    {

        private readonly ISportCountryRepository _sportcountryRepository;

        private readonly ILogger<SportCountryController> _logger;

        public SportCountryController(ILogger<SportCountryController> logger, ISportCountryRepository sportcountryRepository)
        {
            _logger = logger;
            _sportcountryRepository = sportcountryRepository;
        }

        [HttpGet]
        public IActionResult Get(long? sportid)
        {

            try
            {
                if (sportid.HasValue)
                {

                    _logger.LogInformation("API Request hit: GET all Countries by SportId: " + sportid.Value);
                    var result = _sportcountryRepository.GetAll(sportid);
                    if (result.ToList().Any())
                    {
                        return Ok(result);
                    }
                    else
                    {
                        _logger.LogInformation("API Request (GET all Countries by SportId: " + sportid.Value + " ) no entries found");
                        return NotFound("Bettype was not found with TournamentId: " + sportid.Value);
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit: GET all Countries by no criteria");
                    var result = _sportcountryRepository.GetAll();
                    return Ok(result);
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (GET all Countries by SportId) FAILED: ", e);
                return BadRequest();
            }

        }

    }
}