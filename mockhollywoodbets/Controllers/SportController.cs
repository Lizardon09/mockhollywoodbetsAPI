using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MockHollywoodBets.Models;
using Microsoft.AspNetCore.Cors;

namespace MockHollywoodBets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class SportController : ControllerBase
    {
        private static DAL Datalayer { get; set; }

        private readonly ILogger<SportController> _logger;

        public SportController(ILogger<SportController> logger)
        {
            _logger = logger;
            Datalayer = new DAL();
        }

        [HttpGet]
        public IEnumerable<SportTree> Get()
        {
            return Datalayer.Sports.ToArray();
        }

    }
}