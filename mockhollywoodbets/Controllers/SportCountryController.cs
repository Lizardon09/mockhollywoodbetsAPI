using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mockhollywoodbets.Models;
using Microsoft.Extensions.Logging;

namespace mockhollywoodbets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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

            foreach (var valuepair in Datalayer.SportCountryAssoc)
            {
                if (valuepair.Key == sportID)
                {
                    countries.Add(Datalayer.GetCountryByID(valuepair.Value));
                }
            }

            return countries;
        }


    }
}