using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MockHollywoodBets.Models2;
using MockHollywoodBets.Models;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Cors;
using MockHollywoodBets.DataManagers;
using MockHollywoodBets.DataManagers.Repository.Interfaces;
using MockHollywoodBets.CustomModels;

namespace MockHollywoodBets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class MarketController : ControllerBase
    {
        private static DALLogic Datalayer { get; set; }

        private readonly IMarketRepository _marketRepository;

        private readonly ILogger<MarketController> _logger;

        public MarketController(ILogger<MarketController> logger, IMarketRepository marketRepository)
        {
            _logger = logger;
            Datalayer = new DALLogic();
            _marketRepository = marketRepository;
        }

        [HttpGet]
        public IQueryable<MarketOdd> Get(long? tournamentid)
        {
            if (tournamentid.HasValue)
            {
                return _marketRepository.Get(tournamentid);
            }
            else
            {
                return _marketRepository.GetAll();
            }
        }
    }
}