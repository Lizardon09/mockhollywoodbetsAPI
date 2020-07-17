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
    [Route("api/CRUD/tournament")]
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

        [HttpPost]
        [Route("PostTournamentSC")]
        public IActionResult PostTournamentSC([FromBody] TournamentSc tournamentSc)
        {
            try
            {
                if (tournamentSc != null)
                {

                    _logger.LogInformation("API Request hit: INSERT TournamentSc : ");
                    var result = _tournamentRepository.AddTournamentSC(tournamentSc);

                    if (result == 0)
                    {
                        return Ok("{\"status\": \"Success\"}");
                    }
                    else
                    {
                        _logger.LogInformation("API Request (INSERT TournamentSc : ) not committed");
                        return NotFound("Failed: INSERT could not commit");
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit (INSERT TournamentSc) with null entry");
                    return BadRequest("Failed: null entry");
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (INSERT TournamentSc) FAILED: ", e);
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
                    var result = _tournamentRepository.AddTournamentBettype(tournamentBettype);

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

        [HttpPut]
        [Route("UpdateTournamentBettype")]
        public IActionResult UpdateTournamentBettype([FromBody] TournamentBettype tournamentbettype)
        {
            try
            {
                if (tournamentbettype != null)
                {

                    _logger.LogInformation("API Request hit: UPDATE TournamentBettype : " + tournamentbettype.Id);
                    var result = _tournamentRepository.UpdateTournamentBettype(tournamentbettype);

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

        [HttpPut]
        [Route("UpdateTournamentSC")]
        public IActionResult UpdateTournamentSC([FromBody] TournamentSc tournamentsc)
        {
            try
            {
                if (tournamentsc != null)
                {

                    _logger.LogInformation("API Request hit: UPDATE TournamentSC : " + tournamentsc.Id);
                    var result = _tournamentRepository.UpdateTournamentSC(tournamentsc);

                    if (result == 0)
                    {
                        return Ok("{\"status\": \"Success\"}");
                    }
                    else
                    {
                        _logger.LogInformation("API Request (UPDATE TournamentSC : " + tournamentsc.Id + " ) not committed");
                        return NotFound("Failed: UPDATE could not commit");
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit (UPDATE TournamentSC) with null entry");
                    return BadRequest("Failed: null entry");
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (UPDATE TournamentSC) FAILED: ", e);
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

                    _logger.LogInformation("API Request hit: DELETE Tournament : " + id.Value);
                    var result = _tournamentRepository.Delete(id.Value);

                    if (result == 0)
                    {
                        return Ok("{\"status\": \"Success\"}");
                    }
                    else
                    {
                        _logger.LogInformation("API Request (DELETE Tournament : " + id.Value + " ) not committed");
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

        [HttpDelete]
        [Route("DeleteTournamentBettype")]
        public IActionResult DeleteTournamentBettype(long? id)
        {
            try
            {
                if (id.HasValue)
                {

                    _logger.LogInformation("API Request hit: DELETE TournamentBettype : " + id.Value);
                    var result = _tournamentRepository.DeleteTournamentBettype(id.Value);

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

        [HttpDelete]
        [Route("DeleteTournamentSC")]
        public IActionResult DeleteTournamentSC(long? id)
        {
            try
            {
                if (id.HasValue)
                {

                    _logger.LogInformation("API Request hit: DELETE TournamentSC : " + id.Value);
                    var result = _tournamentRepository.DeleteTournamentSC(id.Value);

                    if (result == 0)
                    {
                        return Ok("{\"status\": \"Success\"}");
                    }
                    else
                    {
                        _logger.LogInformation("API Request (DELETE TournamentSC : " + id.Value + " ) not committed");
                        return NotFound("Failed: DELETE could not commit");
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit (DELETE TournamentSC) with null entry");
                    return BadRequest("Failed: null entry");
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (DELETE TournamentSC) FAILED: ", e);
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

        [HttpGet]
        [Route("GetAllTournamentBettypeInfo")]
        public IActionResult GetAllTournamentBettypeInfo(long? tournamentbettypeid)
        {
            try
            {
                if (tournamentbettypeid.HasValue)
                {

                    _logger.LogInformation("API Request hit: GET all TournamentBettypeInfo by Id: " + tournamentbettypeid.Value);
                    var result = _tournamentRepository.GetTournamentBettypeInfo(tournamentbettypeid.Value);
                    if (result.ToList().Any())
                    {
                        return Ok(result);
                    }
                    else
                    {
                        _logger.LogInformation("API Request (GET all Markets by TournamentBettypeInfo: " + tournamentbettypeid.Value + " ) no entries found");
                        return NotFound("TournamentBettypeInfo was not found with Id: " + tournamentbettypeid.Value);
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit: GET all TournamentBettypeInfo by no criteria");
                    var result = _tournamentRepository.GetAllTournamentBettypeInfo();
                    return Ok(result);
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (GET all TournamentBettypeInfo by Id) FAILED: ", e);
                return BadRequest("Failed");
            }

        }

        [HttpGet]
        [Route("GetAllTournamentSCInfo")]
        public IActionResult GetAllTournamentSCInfo(long? tournamentscid)
        {
            try
            {
                if (tournamentscid.HasValue)
                {

                    _logger.LogInformation("API Request hit: GET all TournamentSCInfo by Id: " + tournamentscid.Value);
                    var result = _tournamentRepository.GetTournamentBettypeInfo(tournamentscid.Value);
                    if (result.ToList().Any())
                    {
                        return Ok(result);
                    }
                    else
                    {
                        _logger.LogInformation("API Request (GET all Markets by TournamentSCInfo: " + tournamentscid.Value + " ) no entries found");
                        return NotFound("TournamentSCInfo was not found with Id: " + tournamentscid.Value);
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit: GET all TournamentSCInfo by no criteria");
                    var result = _tournamentRepository.GetAllTournamentSCInfo();
                    return Ok(result);
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (GET all TournamentSCInfo by Id) FAILED: ", e);
                return BadRequest("Failed");
            }

        }

    }
}