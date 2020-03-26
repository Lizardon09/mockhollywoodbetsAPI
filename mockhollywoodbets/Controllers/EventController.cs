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
    public class EventController : ControllerBase
    {
        private static DAL Datalayer { get; set; }

        private readonly ILogger<EventController> _logger;

        public EventController(ILogger<EventController> logger)
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
        public IEnumerable<Event> Get(long? tournamentid)
        {

            return GetTournamentBySportCountry(tournamentid).ToArray();
        }

        private List<Event> GetTournamentBySportCountry(long? tournamentid)
        {

            return Datalayer.Events.FindAll(x => x.TournamentID == tournamentid);
        }
    }
}