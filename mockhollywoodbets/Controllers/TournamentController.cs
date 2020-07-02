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
    public class TournamentController : ControllerBase
    {
        private static DALLogic Datalayer { get; set; }

        private readonly ITournamentRepository _tournamentRepository;

        private readonly ILogger<TournamentController> _logger;

        public TournamentController(ILogger<TournamentController> logger, ITournamentRepository tournamentRepository)
        {
            _logger = logger;
            Datalayer = new DALLogic();
            _tournamentRepository = tournamentRepository;
        }


        // GET api/tournament
        // GET api/tournament?sportid={sportid}&countryid={countryid}
        [HttpGet]
        public IQueryable<Tournament> Get(long? sportid, long? countryid)
        {
            if(sportid.HasValue && countryid.HasValue)
            {
                return _tournamentRepository.Get(sportid, countryid);
            }

            else
            {
                return _tournamentRepository.GetAll();
            }
 
        }

        //[HttpGet]
        //public IEnumerable<Tournament> Get()
        //{
        //    return Datalayer.Tournaments.ToArray();
        //}

        //[HttpGet]
        //public IEnumerable<Tournament2> Get(long? sportid, long? countryid)
        //{

        //    return GetTournamentBySportCountry(sportid, countryid).ToArray();
        //}

        //private List<Tournament2> GetTournamentBySportCountry(long? sportid, long? countryid)
        //{

        //    return Datalayer.GetTournamentsByCountrySport(countryid, sportid);
        //}

    }
}