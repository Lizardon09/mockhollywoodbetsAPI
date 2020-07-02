using System;
using System.Collections.Generic;

namespace MockHollywoodBets.Models
{
    public partial class Odds
    {
        public int Id { get; set; }
        public int? MarketBettypeId { get; set; }
        public int? EventId { get; set; }
        public decimal? Odds1 { get; set; }

        public virtual Event Event { get; set; }
        public virtual MarketBettype MarketBettype { get; set; }
    }
}
