using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mockhollywoodbets.Models;
using System.Web.Http.Cors;

namespace mockhollywoodbets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class SportController : ControllerBase
    {

        private List<SportTree> GetSports()
        {
            return new List<SportTree>()
            {
                new SportTree(1, "Betgames Africa", "https://new.hollywoodbets.net/assets/images/icons/Betgames.svg"),
                new SportTree(2, "Live In-Play", "https://new.hollywoodbets.net/assets/images/icons/live-in-play.svg"),
                new SportTree(3, "Sport Exotics", "https://new.hollywoodbets.net/assets/images/icons/sport-exotics.svg"),
                new SportTree(4, "Horse Racing", "https://new.hollywoodbets.net/assets/images/icons/horse-racing.svg"),
                new SportTree(5, "Soccer", "https://new.hollywoodbets.net/assets/images/icons/soccer.svg"),
                new SportTree(6, "Lucky Numbers", "https://new.hollywoodbets.net/assets/images/icons/lucky-numbers.svg"),
                new SportTree(7, "Rugby", "https://new.hollywoodbets.net/assets/images/icons/rugby.svg"),
                new SportTree(8, "Cricket", "https://new.hollywoodbets.net/assets/images/icons/cricket.svg"),
                new SportTree(9, "Golf", "https://new.hollywoodbets.net/assets/images/icons/golf.svg"),
                new SportTree(10, "Aussie Rules", "https://new.hollywoodbets.net/assets/images/icons/aussie-rules.svg"),
                new SportTree(11, "Bandy", "https://new.hollywoodbets.net/assets/images/icons/bandy.svg"),
                new SportTree(12, "BasketBall", "https://new.hollywoodbets.net/assets/images/icons/basketball.svg"),
                new SportTree(13, "Bowls", "https://new.hollywoodbets.net/assets/images/icons/bowls.svg"),
                new SportTree(14, "Boxing", "https://new.hollywoodbets.net/assets/images/icons/boxing.svg"),
                new SportTree(15, "Darts", "https://new.hollywoodbets.net/assets/images/icons/darts.svg"),
                new SportTree(16, "Futsal", "https://new.hollywoodbets.net/assets/images/icons/futsal.svg"),
                new SportTree(17, "Ice Hockey", "https://new.hollywoodbets.net/assets/images/icons/ice-hockey.svg"),
                new SportTree(18, "MMA", "https://new.hollywoodbets.net/assets/images/icons/mma.svg"),
                new SportTree(19, "Motorsport", "https://new.hollywoodbets.net/assets/images/icons/motorsport.svg"),
                new SportTree(20, "Table Tennis", "https://new.hollywoodbets.net/assets/images/icons/sport-exotics.svg"),
                new SportTree(21, "Vollyball", "https://new.hollywoodbets.net/assets/images/icons/volleyball.svg")
            };
        }

        private readonly ILogger<SportController> _logger;

        public SportController(ILogger<SportController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<SportTree> Get()
        {
            var rng = new Random();
            return GetSports().ToArray();
        }

    }
}