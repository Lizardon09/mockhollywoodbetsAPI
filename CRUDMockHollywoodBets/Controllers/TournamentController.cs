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
    public class TournamentController : ControllerBase
    {
        private readonly ITournamentRepository _tournamentRepository;

        private readonly ILogger<TournamentController> _logger;

        public TournamentController(ILogger<TournamentController> logger, ITournamentRepository _tournamentrepository)
        {
            _logger = logger;
            _tournamentRepository = _tournamentrepository;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Tournament tournament)
        {
            try
            {
                if (tournament != null)
                {

                    _logger.LogInformation("API Request hit: INSERT Tournament : " + tournament.Name);
                    var result = _tournamentRepository.Add(tournament);

                    if (result == 0)
                    {
                        return Ok("{\"status\": \"Success\"}");
                    }
                    else
                    {
                        _logger.LogInformation("API Request (INSERT Tournament : " + tournament.Name + " ) not committed");
                        return NotFound("Failed: INSERT could not commit");
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit (INSERT Tournament) with null entry");
                    return BadRequest("Failed: null entry");
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (INSERT Tournament) FAILED: ", e);
                return BadRequest("Failed");
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] Tournament tournament)
        {
            try
            {
                if (tournament != null)
                {

                    _logger.LogInformation("API Request hit: UPDATE Tournament : " + tournament.Name);
                    var result = _tournamentRepository.Update(tournament);

                    if (result == 0)
                    {
                        return Ok("{\"status\": \"Success\"}");
                    }
                    else
                    {
                        _logger.LogInformation("API Request (UPDATE Tournament : " + tournament.Name + " ) not committed");
                        return NotFound("Failed: UPDATE could not commit");
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit (UPDATE Tournament) with null entry");
                    return BadRequest("Failed: null entry");
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (UPDATE Tournament) FAILED: ", e);
                return BadRequest("Failed");
            }
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] Tournament tournament)
        {
            try
            {
                if (tournament != null)
                {

                    _logger.LogInformation("API Request hit: DELETE Tournament : " + tournament.Name);
                    var result = _tournamentRepository.Delete(tournament);

                    if (result == 0)
                    {
                        return Ok("{\"status\": \"Success\"}");
                    }
                    else
                    {
                        _logger.LogInformation("API Request (DELETE Tournament : " + tournament.Name + " ) not committed");
                        return NotFound("Failed: DELETE could not commit");
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit (DELETE Tournament) with null entry");
                    return BadRequest("Failed: null entry");
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (DELETE Tournament) FAILED: ", e);
                return BadRequest("Failed");
            }
        }

        [HttpGet]
        public IActionResult Get(long? tournamentid)
        {
            try
            {
                if (tournamentid.HasValue)
                {

                    _logger.LogInformation("API Request hit: GET all Tournaments by Id: " + tournamentid.Value);
                    var result = _tournamentRepository.GetTournament(tournamentid.Value);
                    if (result.ToList().Any())
                    {
                        return Ok(result);
                    }
                    else
                    {
                        _logger.LogInformation("API Request (GET all Tournaments by SportId: " + tournamentid.Value + " ) no entries found");
                        return NotFound("Sport was not found with Id: " + tournamentid.Value);
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit: GET all Tournaments by no criteria");
                    var result = _tournamentRepository.GetAll();
                    return Ok(result);
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (GET all Tournaments by Id) FAILED: ", e);
                return BadRequest();
            }

        }
    }
}