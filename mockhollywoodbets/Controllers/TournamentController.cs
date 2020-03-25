using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mockhollywoodbets.Models;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Cors;

namespace mockhollywoodbets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class TournamentController : ControllerBase
    {
        private static DAL Datalayer { get; set; }

        private readonly ILogger<TournamentController> _logger;

        public TournamentController(ILogger<TournamentController> logger)
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
        public IEnumerable<Tournament> Get(long? sportid, long? countryid)
        {

            return GetTournamentBySportCountry(sportid, countryid).ToArray();
        }

        private List<Tournament> GetTournamentBySportCountry(long? sportid, long? countryid)
        {

            return Datalayer.GetTournamentsByCountrySport(countryid, sportid);
        }

    }
}