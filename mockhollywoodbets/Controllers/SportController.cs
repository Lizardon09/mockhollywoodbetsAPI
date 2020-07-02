using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MockHollywoodBets.Models2;
using MockHollywoodBets.Models;
using Microsoft.AspNetCore.Cors;
using MockHollywoodBets.DataManagers;
using MockHollywoodBets.DataManagers.Repository;
using MockHollywoodBets.DataManagers.Repository.Interfaces;

namespace MockHollywoodBets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class SportController : ControllerBase
    {
        private static DALLogic Datalayer { get; set; }

        private readonly ISportTreeRepository _sportTreeRepository;

        private readonly ILogger<SportController> _logger;

        public SportController(ILogger<SportController> logger, ISportTreeRepository sporttreerepository)
        {
            _logger = logger;
            Datalayer = new DALLogic();
            _sportTreeRepository = sporttreerepository;
        }

        //[HttpGet]
        //public IEnumerable<SportTree2> Get()
        //{
        //    return Datalayer.Sports.ToArray();
        //}

        // GET: api/Sport
        [HttpGet]
        public IQueryable<SportTree> Get()
        {
            return _sportTreeRepository.GetAll();
        }

        // GET: api/Sport/5
        [HttpGet("{id}")]
        public SportTree Get(long id)
        {
            return _sportTreeRepository.Get(id);
        }

    }
}