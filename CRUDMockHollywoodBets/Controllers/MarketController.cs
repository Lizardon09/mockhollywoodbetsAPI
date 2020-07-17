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
    [Route("api/CRUD/market")]
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

        [HttpPost]
        [Route("PostMarketBettype")]
        public IActionResult PostMarketBettype([FromBody] MarketBettype marketBettype)
        {
            try
            {
                if (marketBettype != null)
                {

                    _logger.LogInformation("API Request hit: INSERT MarketBettype : ");
                    var result = _marketRepository.AddMarketBettype(marketBettype);

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

        [HttpPost]
        [Route("PostOdd")]
        public IActionResult PostOdd([FromBody] Odds odds)
        {
            try
            {
                if (odds != null)
                {

                    _logger.LogInformation("API Request hit: INSERT Odds : ");
                    var result = _marketRepository.AddOdd(odds);

                    if (result == 0)
                    {
                        return Ok("{\"status\": \"Success\"}");
                    }
                    else
                    {
                        _logger.LogInformation("API Request (INSERT Odds : ) not committed");
                        return NotFound("Failed: INSERT could not commit");
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit (INSERT Odds) with null entry");
                    return BadRequest("Failed: null entry");
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (INSERT Odds) FAILED: ", e);
                return BadRequest(e);
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

        [HttpPut]
        [Route("UpdateMarketBettype")]
        public IActionResult UpdateMarketBettype([FromBody] MarketBettype marketbettype)
        {
            try
            {
                if (marketbettype != null)
                {

                    _logger.LogInformation("API Request hit: UPDATE MarketBettype : " + marketbettype.Id);
                    var result = _marketRepository.UpdateMarketBettype(marketbettype);

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
        [Route("UpdateOdd")]
        public IActionResult UpdateOdd([FromBody] Odds odd)
        {
            try
            {
                if (odd != null)
                {

                    _logger.LogInformation("API Request hit: UPDATE Odds : " + odd.Id);
                    var result = _marketRepository.UpdateOdd(odd);

                    if (result == 0)
                    {
                        return Ok("{\"status\": \"Success\"}");
                    }
                    else
                    {
                        _logger.LogInformation("API Request (UPDATE Odds : " + odd.Id + " ) not committed");
                        return NotFound("Failed: UPDATE could not commit");
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit (UPDATE Odds) with null entry");
                    return BadRequest("Failed: null entry");
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (UPDATE Odds) FAILED: ", e);
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
                    var result = _marketRepository.DeleteMarketBettype(id.Value);

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
        [Route("DeleteOdd")]
        public IActionResult DeleteOdd(long? id)
        {
            try
            {
                if (id.HasValue)
                {

                    _logger.LogInformation("API Request hit: DELETE Odds : " + id.Value);
                    var result = _marketRepository.DeleteOdd(id.Value);

                    if (result == 0)
                    {
                        return Ok("{\"status\": \"Success\"}");
                    }
                    else
                    {
                        _logger.LogInformation("API Request (DELETE Odds : " + id.Value + " ) not committed");
                        return NotFound("Failed: DELETE could not commit");
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit (DELETE Odds) with null entry");
                    return BadRequest("Failed: null entry");
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (DELETE Odds) FAILED: ", e);
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

                    _logger.LogInformation("API Request hit: DELETE Market : " + id.Value);
                    var result = _marketRepository.Delete(id.Value);

                    if (result == 0)
                    {
                        return Ok("{\"status\": \"Success\"}");
                    }
                    else
                    {
                        _logger.LogInformation("API Request (DELETE Market : " + id.Value + " ) not committed");
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
                    var result = _marketRepository.GetMarkets();
                    return Ok(result);
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (GET all Markets by Id) FAILED: ", e);
                return BadRequest("Failed");
            }

        }

        [HttpGet]
        [Route("GetAllMarketBettypeInfo")]
        public IActionResult GetAllMarketBettypeInfo(long? marketbettypeid)
        {
            try
            {
                if (marketbettypeid.HasValue)
                {

                    _logger.LogInformation("API Request hit: GET all MarketBettypeInfo by Id: " + marketbettypeid.Value);
                    var result = _marketRepository.GetMarketBettypeInfo(marketbettypeid.Value);
                    if (result.ToList().Any())
                    {
                        return Ok(result);
                    }
                    else
                    {
                        _logger.LogInformation("API Request (GET all Markets by MarketBettypeInfo: " + marketbettypeid.Value + " ) no entries found");
                        return NotFound("MarketBettypeInfo was not found with Id: " + marketbettypeid.Value);
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit: GET all MarketBettypeInfo by no criteria");
                    var result = _marketRepository.GetAllMarketBettypeInfo();
                    return Ok(result);
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (GET all MarketBettypeInfo by Id) FAILED: ", e);
                return BadRequest("Failed");
            }

        }

        [HttpGet]
        [Route("GetAllOddInfo")]
        public IActionResult GetAllOddInfo(long? oddid)
        {
            try
            {
                if (oddid.HasValue)
                {

                    _logger.LogInformation("API Request hit: GET all OddInfo by Id: " + oddid.Value);
                    var result = _marketRepository.GetOddInfo(oddid.Value);
                    if (result.ToList().Any())
                    {
                        return Ok(result);
                    }
                    else
                    {
                        _logger.LogInformation("API Request (GET all Markets by OddInfo: " + oddid.Value + " ) no entries found");
                        return NotFound("TournamentBettypeInfo was not found with Id: " + oddid.Value);
                    }

                }
                else
                {
                    _logger.LogInformation("API Request hit: GET all OddInfo by no criteria");
                    var result = _marketRepository.GetAllOddInfo();
                    return Ok(result);
                }
            }

            catch (Exception e)
            {
                _logger.LogError("API Request (GET all OddInfo by Id) FAILED: ", e);
                return BadRequest("Failed");
            }

        }
    }
}