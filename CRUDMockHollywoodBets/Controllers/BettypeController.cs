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
    [Route("api/CRUD/bettype")]
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

        [HttpPost]
        [Route("PostTournamentBettype")]
        public IActionResult PostTournamentBettype([FromBody] TournamentBettype tournamentBettype)
        {
            try
            {
                if (tournamentBettype != null)
                {

                    _logger.LogInformation("API Request hit: INSERT TournamentBettype : ");
                    var result = _bettypeRepository.AddTournamentBettype(tournamentBettype);

                    if (result == 0)
                    {
                        return Ok("{\"status\": \"Success\"}");
                    }
                    else
                    {
                        _logger.LogInformation("API Request (INSERT TournamentBettype : ) not committed");
                        return NotFound("Failed: INSERT could not commit");
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit (INSERT TournamentBettype) with null entry");
                    return BadRequest("Failed: null entry");
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (INSERT TournamentBettype) FAILED: ", e);
                return BadRequest("Failed");
            }
        }

        [HttpPost]
        [Route("PostMarketBettype")]
        public IActionResult PostMarketBettype([FromBody] MarketBettype marketBettype)
        {
            try
            {
                if (marketBettype != null)
                {

                    _logger.LogInformation("API Request hit: INSERT MarketBettype : ");
                    var result = _bettypeRepository.AddMarketBettype(marketBettype);

                    if (result == 0)
                    {
                        return Ok("{\"status\": \"Success\"}");
                    }
                    else
                    {
                        _logger.LogInformation("API Request (INSERT MarketBettype : ) not committed");
                        return NotFound("Failed: INSERT could not commit");
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit (INSERT MarketBettype) with null entry");
                    return BadRequest("Failed: null entry");
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (INSERT MarketBettype) FAILED: ", e);
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

        [HttpPut]
        [Route("UpdateMarketBettype")]
        public IActionResult UpdateMarketBettype([FromBody] MarketBettype marketbettype)
        {
            try
            {
                if (marketbettype != null)
                {

                    _logger.LogInformation("API Request hit: UPDATE MarketBettype : " + marketbettype.Id);
                    var result = _bettypeRepository.UpdateMarketBettype(marketbettype);

                    if (result == 0)
                    {
                        return Ok("{\"status\": \"Success\"}");
                    }
                    else
                    {
                        _logger.LogInformation("API Request (UPDATE MarketBettype : " + marketbettype.Id + " ) not committed");
                        return NotFound("Failed: UPDATE could not commit");
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit (UPDATE MarketBettype) with null entry");
                    return BadRequest("Failed: null entry");
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (UPDATE MarketBettype) FAILED: ", e);
                return BadRequest("Failed");
            }
        }

        [HttpPut]
        [Route("UpdateTournamentBettype")]
        public IActionResult UpdateTournamentBettype([FromBody] TournamentBettype tournamentbettype)
        {
            try
            {
                if (tournamentbettype != null)
                {

                    _logger.LogInformation("API Request hit: UPDATE TournamentBettype : " + tournamentbettype.Id);
                    var result = _bettypeRepository.UpdateTournamentBettype(tournamentbettype);

                    if (result == 0)
                    {
                        return Ok("{\"status\": \"Success\"}");
                    }
                    else
                    {
                        _logger.LogInformation("API Request (UPDATE TournamentBettype : " + tournamentbettype.Id + " ) not committed");
                        return NotFound("Failed: UPDATE could not commit");
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit (UPDATE TournamentBettype) with null entry");
                    return BadRequest("Failed: null entry");
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (UPDATE TournamentBettype) FAILED: ", e);
                return BadRequest("Failed");
            }
        }

        [HttpDelete]
        public IActionResult Delete(long? id)
        {
            try
            {
                if (id.HasValue)
                {

                    _logger.LogInformation("API Request hit: DELETE Bettype : " + id.Value);
                    var result = _bettypeRepository.Delete(id.Value);

                    if (result == 0)
                    {
                        return Ok("{\"status\": \"Success\"}");
                    }
                    else
                    {
                        _logger.LogInformation("API Request (DELETE Bettype : " + id.Value + " ) not committed");
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

        [HttpDelete]
        [Route("DeleteMarketBettype")]
        public IActionResult DeleteMarketBettype(long? id)
        {
            try
            {
                if (id.HasValue)
                {

                    _logger.LogInformation("API Request hit: DELETE MarketBettype : " + id.Value);
                    var result = _bettypeRepository.DeleteMarketBettype(id.Value);

                    if (result == 0)
                    {
                        return Ok("{\"status\": \"Success\"}");
                    }
                    else
                    {
                        _logger.LogInformation("API Request (DELETE MarketBettype : " + id.Value + " ) not committed");
                        return NotFound("Failed: DELETE could not commit");
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit (DELETE MarketBettype) with null entry");
                    return BadRequest("Failed: null entry");
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (DELETE MarketBettype) FAILED: ", e);
                return BadRequest("Failed");
            }
        }

        [HttpDelete]
        [Route("DeleteTournamentBettype")]
        public IActionResult DeleteTournamentBettype(long? id)
        {
            try
            {
                if (id.HasValue)
                {

                    _logger.LogInformation("API Request hit: DELETE TournamentBettype : " + id.Value);
                    var result = _bettypeRepository.DeleteTournamentBettype(id.Value);

                    if (result == 0)
                    {
                        return Ok("{\"status\": \"Success\"}");
                    }
                    else
                    {
                        _logger.LogInformation("API Request (DELETE TournamentBettype : " + id.Value + " ) not committed");
                        return NotFound("Failed: DELETE could not commit");
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit (DELETE TournamentBettype) with null entry");
                    return BadRequest("Failed: null entry");
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (DELETE TournamentBettype) FAILED: ", e);
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