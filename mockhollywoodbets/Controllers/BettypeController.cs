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

namespace MockHollywoodBets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class BettypeController : ControllerBase
    {
        private static DALLogic Datalayer { get; set; }

        private readonly IBettypeRepository _bettypeRepository;
        
        private readonly ILogger<BettypeController> _logger;

        public BettypeController(ILogger<BettypeController> logger, IBettypeRepository bettypeRepository)
        {
            _logger = logger;
            Datalayer = new DALLogic();
            _bettypeRepository = bettypeRepository;
        }

        [HttpGet]
        public IQueryable<Bettype> Get(long? tournamentid)
        {
            if (tournamentid.HasValue)
            {
                return _bettypeRepository.Get(tournamentid);
            }
            else
            {
                return _bettypeRepository.GetAll();
            }
        }

        //[HttpGet]
        //public IEnumerable<Tournament> Get()
        //{
        //    return Datalayer.Tournaments.ToArray();
        //}

        //[HttpGet]
        //public IEnumerable<Bettype2> Get(long? tournamentid)
        //{

        //    return GetBettypeByTournament(tournamentid).ToArray();
        //}

        //private List<Bettype2> GetBettypeByTournament(long? tournamentid)
        //{
        //    return Datalayer.GetBettypeByTournament(tournamentid);
        //}
    }
}