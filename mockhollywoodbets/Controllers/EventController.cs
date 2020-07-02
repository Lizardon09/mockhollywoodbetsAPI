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
    public class EventController : ControllerBase
    {
        private static DALLogic Datalayer { get; set; }

        private readonly IEventRepository _eventRepository;

        private readonly ILogger<EventController> _logger;

        public EventController(ILogger<EventController> logger, IEventRepository eventRepository)
        {
            _logger = logger;
            Datalayer = new DALLogic();
            _eventRepository = eventRepository;
        }

        [HttpGet]
        public IQueryable<Event> Get(long? tournamentid)
        {
            if (tournamentid.HasValue)
            {
                return _eventRepository.Get(tournamentid);
            }

            else
            {
                return _eventRepository.GetAll();
            }

        }

        //[HttpGet]
        //public IEnumerable<Tournament> Get()
        //{
        //    return Datalayer.Tournaments.ToArray();
        //}

        //[HttpGet]
        //public IEnumerable<Event2> Get(long? tournamentid)
        //{

        //    return GetTournamentBySportCountry(tournamentid).ToArray();
        //}

        //private List<Event2> GetTournamentBySportCountry(long? tournamentid)
        //{

        //    return Datalayer.Events.FindAll(x => x.TournamentID == tournamentid);
        //}
    }
}