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
using System;

namespace CRUDMockHollywoodBets.Controllers
{
    [Route("api/CRUD/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class MarketController : ControllerBase
    {
        private readonly IMarketRepository _marketRepository;

        private readonly ILogger<MarketController> _logger;

        public MarketController(ILogger<MarketController> logger, IMarketRepository _marketrepository)
        {
            _logger = logger;
            _marketRepository = _marketrepository;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Market market)
        {
            try
            {
                if (market != null)
                {

                    _logger.LogInformation("API Request hit: INSERT Market : " + market.Name);
                    var result = _marketRepository.Add(market);

                    if (result == 0)
                    {
                        return Ok("{\"status\": \"Success\"}");
                    }
                    else
                    {
                        _logger.LogInformation("API Request (INSERT Market : " + market.Name + " ) not committed");
                        return NotFound("Failed: INSERT could not commit");
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit (INSERT Market) with null entry");
                    return BadRequest("Failed: null entry");
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (INSERT Market) FAILED: ", e);
                return BadRequest("Failed");
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] Market market)
        {
            try
            {
                if (market != null)
                {

                    _logger.LogInformation("API Request hit: UPDATE Market : " + market.Name);
                    var result = _marketRepository.Update(market);

                    if (result == 0)
                    {
                        return Ok("{\"status\": \"Success\"}");
                    }
                    else
                    {
                        _logger.LogInformation("API Request (UPDATE Market : " + market.Name + " ) not committed");
                        return NotFound("Failed: UPDATE could not commit");
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit (UPDATE Market) with null entry");
                    return BadRequest("Failed: null entry");
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (UPDATE Market) FAILED: ", e);
                return BadRequest("Failed");
            }
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] Market market)
        {
            try
            {
                if (market != null)
                {

                    _logger.LogInformation("API Request hit: DELETE Market : " + market.Name);
                    var result = _marketRepository.Delete(market);

                    if (result == 0)
                    {
                        return Ok("{\"status\": \"Success\"}");
                    }
                    else
                    {
                        _logger.LogInformation("API Request (DELETE Market : " + market.Name + " ) not committed");
                        return NotFound("Failed: DELETE could not commit");
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit (DELETE Market) with null entry");
                    return BadRequest("Failed: null entry");
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (DELETE Market) FAILED: ", e);
                return BadRequest("Failed");
            }
        }

        [HttpGet]
        public IActionResult Get(long? marketid)
        {
            try
            {
                if (marketid.HasValue)
                {

                    _logger.LogInformation("API Request hit: GET all Markets by Id: " + marketid.Value);
                    var result = _marketRepository.GetMarket(marketid.Value);
                    if (result.ToList().Any())
                    {
                        return Ok(result);
                    }
                    else
                    {
                        _logger.LogInformation("API Request (GET all Markets by SportId: " + marketid.Value + " ) no entries found");
                        return NotFound("Sport was not found with Id: " + marketid.Value);
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit: GET all Markets by no criteria");
                    var result = _marketRepository.GetAll();
                    return Ok(result);
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (GET all Markets by Id) FAILED: ", e);
                return BadRequest();
            }

        }
    }
}