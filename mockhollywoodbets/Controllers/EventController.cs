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
    public class EventController : ControllerBase
    {

        private readonly IEventRepository _eventRepository;

        private readonly ILogger<EventController> _logger;

        public EventController(ILogger<EventController> logger, IEventRepository eventRepository)
        {
            _logger = logger;
            _eventRepository = eventRepository;
        }

        [HttpGet]
        public IActionResult Get(long? tournamentid)
        {
            try
            {
                if (tournamentid.HasValue)
                {

                    _logger.LogInformation("API Request hit: GET all Events by TournamentId: " + tournamentid.Value);
                    var result = _eventRepository.Get(tournamentid);
                    if (result.ToList().Any())
                    {
                        return Ok(result);
                    }
                    else
                    {
                        _logger.LogInformation("API Request (GET all Events by TournamentId: " + tournamentid.Value + " ) no entries found");
                        return NotFound("Bettype was not found with TournamentId: " + tournamentid.Value);
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit: GET all Events by no criteria");
                    var result = _eventRepository.GetAll();
                    return Ok(result);
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (GET all Events by TournamentId) FAILED: ", e);
                return BadRequest();
            }

        }

    }
}