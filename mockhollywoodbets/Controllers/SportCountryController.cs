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
using MockHollywoodBets.DataManagers.Repository;
using MockHollywoodBets.DataManagers.Repository.Interfaces;

namespace MockHollywoodBets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class SportCountryController : ControllerBase
    {

        private static DALLogic Datalayer { get; set; }

        private readonly ISportCountryRepository _sportcountryRepository;

        private readonly ILogger<SportCountryController> _logger;

        public SportCountryController(ILogger<SportCountryController> logger, ISportCountryRepository sportcountryRepository)
        {
            _logger = logger;
            Datalayer = new DALLogic();
            _sportcountryRepository = sportcountryRepository;
        }

        [HttpGet]
        public IQueryable<Country> Get()
        {
            return _sportcountryRepository.GetAll();
        }

        [HttpGet("{sportid}")]
        public IQueryable<Country> Get(long sportid)
        {
            return _sportcountryRepository.GetAll(sportid);
        }

        //[HttpGet]
        //public IEnumerable<Country> Get()
        //{
        //    return Datalayer.Countries.ToArray();
        //}

        //[HttpGet]
        //public IEnumerable<Country2> Get(long? sportid)
        //{
        //    if (sportid.HasValue)
        //    {
        //        return GetCountryBySport(sportid).ToArray();
        //    }
        //    else
        //    {
        //        return Datalayer.Countries.ToArray();
        //    }
        //}

        //private List<Country2> GetCountryBySport(long? sportID)
        //{
        //    foreach (var sportcountry in Datalayer.SportCountries)
        //    {
        //        if (sportcountry.SportID == sportID)
        //        {
        //            return Datalayer.GetCountryByID(sportcountry.CountryID);
        //        }
        //    }

        //    return new List<Country2>();
        //}


    }
}