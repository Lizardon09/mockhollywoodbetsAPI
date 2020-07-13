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

        [HttpDelete]
        public IActionResult Delete([FromBody] Country country)
        {
            try
            {
                if (country != null)
                {

                    _logger.LogInformation("API Request hit: DELETE Country : " + country.Name);
                    var result = _countryRepository.Delete(country);

                    if (result == 0)
                    {
                        return Ok("{\"status\": \"Success\"}");
                    }
                    else
                    {
                        _logger.LogInformation("API Request (DELETE Country : " + country.Name + " ) not committed");
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
    }
}