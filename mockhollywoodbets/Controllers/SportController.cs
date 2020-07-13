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

namespace MockHollywoodBets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class SportController : ControllerBase
    {

        private readonly ISportTreeRepository _sportTreeRepository;

        private readonly ILogger<SportController> _logger;

        public SportController(ILogger<SportController> logger, ISportTreeRepository sporttreerepository)
        {
            _logger = logger;
            _sportTreeRepository = sporttreerepository;
        }

        [HttpGet]
        public IActionResult Get(long? sportid)
        {
            try
            {
                if (sportid.HasValue)
                {

                    _logger.LogInformation("API Request hit: GET all Sports by SportId: " + sportid.Value);
                    var result = _sportTreeRepository.Get(sportid.Value);
                    if (result.ToList().Any())
                    {
                        return Ok(result);
                    }
                    else
                    {
                        _logger.LogInformation("API Request (GET all Sports by SportId: " + sportid.Value + " ) no entries found");
                        return NotFound("Bettype was not found with SportId: " + sportid.Value);
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit: GET all Sports by no criteria");
                    var result = _sportTreeRepository.GetAll();
                    return Ok(result);
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (GET all Sports by SportId) FAILED: ", e);
                return BadRequest();
            }

        }

    }
}