using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MockHollywoodBetsDAL.CustomModels
{
    public class MarketOdd
    {
        [Key]
        public int OddsId { get; set; }
        public int EventId { get; set; }
        public decimal Odds { get; set; }
        public int BettypeId { get; set; }
        public int MarketId { get; set; }
        public string MarketName { get; set; }

    }
}
