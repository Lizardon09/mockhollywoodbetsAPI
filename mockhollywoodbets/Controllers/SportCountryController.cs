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
    public class SportCountryController : ControllerBase
    {

        private static DAL Datalayer { get; set; }

        private readonly ILogger<SportCountryController> _logger;

        public SportCountryController(ILogger<SportCountryController> logger)
        {
            _logger = logger;
            Datalayer = new DAL();
        }

        [HttpGet]
        public IEnumerable<Country> Get()
        {
            return Datalayer.Countries.ToArray();
        }

        [HttpGet("{id}")]
        public IEnumerable<Country> Get(long id)
        {
            
            return GetCountryBySport(id).ToArray();
        }

        private List<Country> GetCountryBySport(long sportID)
        {
            List<Country> countries = new List<Country>();

            foreach (var sportcountry in Datalayer.SportCountries)
            {
                if(sportcountry.SportID == sportID)
                {
                    countries.Add(Datalayer.GetCountryByID(sportcountry.CountryID));
                }
            }

            return countries;
        }


    }
}