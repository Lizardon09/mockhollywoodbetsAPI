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

namespace CRUDMockHollywoodBets.Controllers
{
    [Route("api/CRUD/bet")]
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

        [HttpGet]
        [Route("GetBetSlip")]
        public IActionResult GetBetSlip(long? id)
        {
            try
            {
                if (id.HasValue)
                {

                    _logger.LogInformation("API Request hit: GET all BetSlip by BetSlipId: " + id.Value);
                    var result = _betRepository.GetBetSlip(id.Value);
                    if (result.ToList().Any())
                    {
                        return Ok(result);
                    }
                    else
                    {
                        _logger.LogInformation("API Request (GET all BetSlip by BetSlipId: " + id.Value + " ) no entries found");
                        return NotFound("BetSlip was not found with BetSlipId: " + id.Value);
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit: GET all BetSlips by no criteria");
                    var result = _betRepository.GetAllBetSlip();
                    return Ok(result);
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (GET all BetSlip by BetSlipId) FAILED: ", e);
                return BadRequest();
            }

        }

        [HttpGet]
        [Route("GetBets")]
        public IActionResult GetBets(long? id)
        {
            try
            {
                if (id.HasValue)
                {

                    _logger.LogInformation("API Request hit: GET all Bet by BetSlipId: " + id.Value);
                    var result = _betRepository.GetBetInfo(id.Value);
                    if (result.ToList().Any())
                    {
                        return Ok(result);
                    }
                    else
                    {
                        _logger.LogInformation("API Request (GET all Bet by BetSlipId: " + id.Value + " ) no entries found");
                        return NotFound("Bets were not found with BetSlipId: " + id.Value);
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit: GET all Bets by no criteria");
                    var result = _betRepository.GetAllBets();
                    return Ok(result);
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (GET all Bets by BetSlipId) FAILED: ", e);
                return BadRequest();
            }

        }

    }
}