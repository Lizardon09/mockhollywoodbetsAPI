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

namespace CRUDMockHollywoodBets.Controllers
{
    [Route("api/CRUD/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class BettypeController : ControllerBase
    {
        private readonly IBettypeRepository _bettypeRepository;

        private readonly ILogger<BettypeController> _logger;

        public BettypeController(ILogger<BettypeController> logger, IBettypeRepository bettyperepository)
        {
            _logger = logger;
            _bettypeRepository = bettyperepository;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Bettype bettype)
        {
            try
            {
                if (bettype != null)
                {

                    _logger.LogInformation("API Request hit: INSERT Bettype : " + bettype.Name);
                    var result = _bettypeRepository.Add(bettype);

                    if (result == 0)
                    {
                        return Ok("{\"status\": \"Success\"}");
                    }
                    else
                    {
                        _logger.LogInformation("API Request (INSERT Bettype : " + bettype.Name + " ) not committed");
                        return NotFound("Failed: INSERT could not commit");
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit (INSERT Bettype) with null entry");
                    return BadRequest("Failed: null entry");
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (INSERT Bettype) FAILED: ", e);
                return BadRequest("Failed");
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] Bettype bettype)
        {
            try
            {
                if (bettype != null)
                {

                    _logger.LogInformation("API Request hit: UPDATE Bettype : " + bettype.Name);
                    var result = _bettypeRepository.Update(bettype);

                    if (result == 0)
                    {
                        return Ok("{\"status\": \"Success\"}");
                    }
                    else
                    {
                        _logger.LogInformation("API Request (UPDATE Bettype : " + bettype.Name + " ) not committed");
                        return NotFound("Failed: UPDATE could not commit");
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit (UPDATE Bettype) with null entry");
                    return BadRequest("Failed: null entry");
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (UPDATE Bettype) FAILED: ", e);
                return BadRequest("Failed");
            }
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] Bettype bettype)
        {
            try
            {
                if (bettype != null)
                {

                    _logger.LogInformation("API Request hit: DELETE Bettype : " + bettype.Name);
                    var result = _bettypeRepository.Delete(bettype);

                    if (result == 0)
                    {
                        return Ok("{\"status\": \"Success\"}");
                    }
                    else
                    {
                        _logger.LogInformation("API Request (DELETE Bettype : " + bettype.Name + " ) not committed");
                        return NotFound("Failed: DELETE could not commit");
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit (DELETE Bettype) with null entry");
                    return BadRequest("Failed: null entry");
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (DELETE Bettype) FAILED: ", e);
                return BadRequest("Failed");
            }
        }

        [HttpGet]
        public IActionResult Get(long? bettype)
        {
            try
            {
                if (bettype.HasValue)
                {

                    _logger.LogInformation("API Request hit: GET all Sports by SportId: " + bettype.Value);
                    var result = _bettypeRepository.GetBettype(bettype.Value);
                    if (result.ToList().Any())
                    {
                        return Ok(result);
                    }
                    else
                    {
                        _logger.LogInformation("API Request (GET all Sports by SportId: " + bettype.Value + " ) no entries found");
                        return NotFound("Bettype was not found with SportId: " + bettype.Value);
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit: GET all Sports by no criteria");
                    var result = _bettypeRepository.GetAll();
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