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
    [Route("api/CRUD/country")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class CountryController : ControllerBase
    {
        private readonly ISportCountryRepository _countryRepository;

        private readonly ILogger<CountryController> _logger;

        public CountryController(ILogger<CountryController> logger, ISportCountryRepository countryrepository)
        {
            _logger = logger;
            _countryRepository = countryrepository;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Country country)
        {
            try
            {
                if (country != null)
                {

                    _logger.LogInformation("API Request hit: INSERT Country : " + country.Name);
                    var result = _countryRepository.Add(country);

                    if (result == 0)
                    {
                        return Ok("{\"status\": \"Success\"}");
                    }
                    else
                    {
                        _logger.LogInformation("API Request (INSERT Country : " + country.Name + " ) not committed");
                        return NotFound("Failed: INSERT could not commit");
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit (INSERT Country) with null entry");
                    return BadRequest("Failed: null entry");
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (INSERT Country) FAILED: ", e);
                return BadRequest("Failed");
            }
        }

        [HttpPost]
        [Route("PostSportCountry")]
        public IActionResult PostSportCountry([FromBody] SportCountry sportCountry)
        {
            try
            {
                if (sportCountry != null)
                {

                    _logger.LogInformation("API Request hit: INSERT SportCountry : ");
                    var result = _countryRepository.AddSportCountry(sportCountry);

                    if (result == 0)
                    {
                        return Ok("{\"status\": \"Success\"}");
                    }
                    else
                    {
                        _logger.LogInformation("API Request (INSERT SportCountry : ) not committed");
                        return NotFound("Failed: INSERT could not commit");
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit (INSERT SportCountry) with null entry");
                    return BadRequest("Failed: null entry");
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (INSERT SportCountry) FAILED: ", e);
                return BadRequest("Failed");
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] Country country)
        {
            try
            {
                if (country != null)
                {

                    _logger.LogInformation("API Request hit: UPDATE Country : " + country.Name);
                    var result = _countryRepository.Update(country);

                    if (result == 0)
                    {
                        return Ok("{\"status\": \"Success\"}");
                    }
                    else
                    {
                        _logger.LogInformation("API Request (UPDATE Country : " + country.Name + " ) not committed");
                        return NotFound("Failed: UPDATE could not commit");
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit (UPDATE Country) with null entry");
                    return BadRequest("Failed: null entry");
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (UPDATE Country) FAILED: ", e);
                return BadRequest("Failed");
            }
        }

        [HttpPut]
        [Route("UpdateSportCountry")]
        public IActionResult UpdateSportCountry([FromBody] SportCountry sportCountry)
        {
            try
            {
                if (sportCountry != null)
                {

                    _logger.LogInformation("API Request hit: UPDATE SportCountry : " + sportCountry.SportCountryId);
                    var result = _countryRepository.UpdateSportCountry(sportCountry);

                    if (result == 0)
                    {
                        return Ok("{\"status\": \"Success\"}");
                    }
                    else
                    {
                        _logger.LogInformation("API Request (UPDATE SportCountry : " + sportCountry.SportCountryId + " ) not committed");
                        return NotFound("Failed: UPDATE could not commit");
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit (UPDATE SportCountry) with null entry");
                    return BadRequest("Failed: null entry");
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (UPDATE SportCountry) FAILED: ", e);
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

                    _logger.LogInformation("API Request hit: DELETE Country : " + id.Value);
                    var result = _countryRepository.Delete(id.Value);

                    if (result == 0)
                    {
                        return Ok("{\"status\": \"Success\"}");
                    }
                    else
                    {
                        _logger.LogInformation("API Request (DELETE Country : " + id.Value + " ) not committed");
                        return NotFound("Failed: DELETE could not commit");
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit (DELETE Country) with null entry");
                    return BadRequest("Failed: null entry");
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (DELETE Country) FAILED: ", e);
                return BadRequest("Failed");
            }
        }

        [HttpDelete]
        [Route("DeleteSportCountry")]
        public IActionResult DeleteSportCountry(long? id)
        {
            try
            {
                if (id.HasValue)
                {

                    _logger.LogInformation("API Request hit: DELETE SportCountry : " + id.Value);
                    var result = _countryRepository.DeleteSportCountry(id.Value);

                    if (result == 0)
                    {
                        return Ok("{\"status\": \"Success\"}");
                    }
                    else
                    {
                        _logger.LogInformation("API Request (DELETE SportCountry : " + id.Value + " ) not committed");
                        return NotFound("Failed: DELETE could not commit");
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit (DELETE SportCountry) with null entry");
                    return BadRequest("Failed: null entry");
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (DELETE SportCountry) FAILED: ", e);
                return BadRequest("Failed");
            }
        }

        [HttpGet]
        public IActionResult Get(long? countryid)
        {
            try
            {
                if (countryid.HasValue)
                {

                    _logger.LogInformation("API Request hit: GET all Country by Id: " + countryid.Value);
                    var result = _countryRepository.Get(countryid.Value);
                    if (result.ToList().Any())
                    {
                        return Ok(result);
                    }
                    else
                    {
                        _logger.LogInformation("API Request (GET all Country by Id: " + countryid.Value + " ) no entries found");
                        return NotFound("Country was not found with Id: " + countryid.Value);
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit: GET all Countries by no criteria");
                    var result = _countryRepository.GetAll();
                    return Ok(result);
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (GET all Country by Id) FAILED: ", e);
                return BadRequest();
            }

        }

        [HttpGet]
        [Route("GetAllSportCountryInfo")]
        public IActionResult GetAllSportCountryInfo(long? sportcountryid)
        {
            try
            {
                if (sportcountryid.HasValue)
                {

                    _logger.LogInformation("API Request hit: GET all SportCountryInfo by Id: " + sportcountryid.Value);
                    var result = _countryRepository.GetSportCountryInfo(sportcountryid.Value);
                    if (result.ToList().Any())
                    {
                        return Ok(result);
                    }
                    else
                    {
                        _logger.LogInformation("API Request (GET all Markets by SportCountryInfo: " + sportcountryid.Value + " ) no entries found");
                        return NotFound("TournamentBettypeInfo was not found with Id: " + sportcountryid.Value);
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit: GET all SportCountryInfo by no criteria");
                    var result = _countryRepository.GetAllSportCountryInfo();
                    return Ok(result);
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (GET all SportCountryInfo by Id) FAILED: ", e);
                return BadRequest("Failed");
            }

        }
    }
}