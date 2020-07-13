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
    public class EventController : ControllerBase
    {
        private readonly IEventRepository _eventRepository;

        private readonly ILogger<EventController> _logger;

        public EventController(ILogger<EventController> logger, IEventRepository _eventrepository)
        {
            _logger = logger;
            _eventRepository = _eventrepository;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Event entity)
        {
            try
            {
                if (entity != null)
                {

                    _logger.LogInformation("API Request hit: INSERT Event : " + entity.Name);
                    var result = _eventRepository.Add(entity);

                    if (result == 0)
                    {
                        return Ok("{\"status\": \"Success\"}");
                    }
                    else
                    {
                        _logger.LogInformation("API Request (INSERT Event : " + entity.Name + " ) not committed");
                        return NotFound("Failed: INSERT could not commit");
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit (INSERT Event) with null entry");
                    return BadRequest("Failed: null entry");
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (INSERT Event) FAILED: ", e);
                return BadRequest("Failed");
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] Event entity)
        {
            try
            {
                if (entity != null)
                {

                    _logger.LogInformation("API Request hit: UPDATE Event : " + entity.Name);
                    var result = _eventRepository.Update(entity);

                    if (result == 0)
                    {
                        return Ok("{\"status\": \"Success\"}");
                    }
                    else
                    {
                        _logger.LogInformation("API Request (UPDATE Event : " + entity.Name + " ) not committed");
                        return NotFound("Failed: UPDATE could not commit");
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit (UPDATE Event) with null entry");
                    return BadRequest("Failed: null entry");
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (UPDATE Event) FAILED: ", e);
                return BadRequest("Failed");
            }
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] Event entity)
        {
            try
            {
                if (entity != null)
                {

                    _logger.LogInformation("API Request hit: DELETE Event : " + entity.Name);
                    var result = _eventRepository.Delete(entity);

                    if (result == 0)
                    {
                        return Ok("{\"status\": \"Success\"}");
                    }
                    else
                    {
                        _logger.LogInformation("API Request (DELETE Event : " + entity.Name + " ) not committed");
                        return NotFound("Failed: DELETE could not commit");
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit (DELETE Event) with null entry");
                    return BadRequest("Failed: null entry");
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (DELETE Event) FAILED: ", e);
                return BadRequest("Failed");
            }
        }

        [HttpGet]
        public IActionResult Get(long? eventid)
        {
            try
            {
                if (eventid.HasValue)
                {

                    _logger.LogInformation("API Request hit: GET all Events by Id: " + eventid.Value);
                    var result = _eventRepository.GetEvent(eventid.Value);
                    if (result.ToList().Any())
                    {
                        return Ok(result);
                    }
                    else
                    {
                        _logger.LogInformation("API Request (GET all Events by SportId: " + eventid.Value + " ) no entries found");
                        return NotFound("Events was not found with Id: " + eventid.Value);
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
                _logger.LogError("API Request (GET all Events by Id) FAILED: ", e);
                return BadRequest();
            }

        }
    }
}