using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MockHollywoodBets.Models;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Cors;

namespace MockHollywoodBets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class BettypeController : ControllerBase
    {
        private static DAL Datalayer { get; set; }

        private readonly ILogger<BettypeController> _logger;

        public BettypeController(ILogger<BettypeController> logger)
        {
            _logger = logger;
            Datalayer = new DAL();
        }

        //[HttpGet]
        //public IEnumerable<Tournament> Get()
        //{
        //    return Datalayer.Tournaments.ToArray();
        //}

        [HttpGet]
        public IEnumerable<Bettype> Get(long? tournamentid)
        {

            return GetBettypeByTournament(tournamentid).ToArray();
        }

        private List<Bettype> GetBettypeByTournament(long? tournamentid)
        {
            return Datalayer.GetBettypeByTournament(tournamentid);
        }
    }
}