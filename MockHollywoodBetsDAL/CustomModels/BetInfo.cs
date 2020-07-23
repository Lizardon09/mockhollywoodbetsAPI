using System;
using System.Collections.Generic;
using System.Text;

namespace MockHollywoodBetsDAL.CustomModels
{
    public class BetInfo
    {
        public int Id { get; set; }
        public int BetSlipId { get; set; }
        public string MarketName { get; set; }
        public string SportName { get; set; }
        public string TournamentName { get; set; }
        public string EventName { get; set; }
        public DateTime? EventDate { get; set; }
        public string BettypeName { get; set; }
        public decimal? Odds { get; set; }
        public DateTime? BetDate { get; set; }
        public decimal? Stake { get; set; }
        public decimal? Payout { get; set; }
    }
}
