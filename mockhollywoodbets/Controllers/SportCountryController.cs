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
    public class SportCountryController : ControllerBase
    {

        private static DAL Datalayer { get; set; }

        private readonly ILogger<SportCountryController> _logger;

        public SportCountryController(ILogger<SportCountryController> logger)
        {
            _logger = logger;
            Datalayer = new DAL();
        }

        //[HttpGet]
        //public IEnumerable<Country> Get()
        //{
        //    return Datalayer.Countries.ToArray();
        //}

        [HttpGet]
        public IEnumerable<Country> Get(long? sportid)
        {
            if (sportid.HasValue)
            {
                return GetCountryBySport(sportid).ToArray();
            }
            else
            {
                return Datalayer.Countries.ToArray();
            }
        }

        private List<Country> GetCountryBySport(long? sportID)
        {
            foreach (var sportcountry in Datalayer.SportCountries)
            {
                if(sportcountry.SportID == sportID)
                {
                    return Datalayer.GetCountryByID(sportcountry.CountryID);
                }
            }

            return new List<Country>();
        }


    }
}