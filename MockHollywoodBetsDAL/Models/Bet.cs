using System;
using System.Collections.Generic;
using System.Text;

namespace MockHollywoodBetsDAL.Models
{
    public partial class Bet
    {
        public int Id { get; set; }
        public int BetSlipId { get; set; }
        public int MarketId { get; set; }
        public int SportId { get; set; }
        public decimal? Odds { get; set; }
        public int TournamentId { get; set; }
        public DateTime? Date { get; set; }
        public int EventId { get; set; }
        public int BettypeId { get; set; }
        public decimal? Stake { get; set; }
        public decimal? Payout { get; set; }

        public virtual BetSlip BetSlip { get; set; }
        public virtual Bettype Bettype { get; set; }
        public virtual Event Event { get; set; }
        public virtual Market Market { get; set; }
        public virtual SportTree Sport { get; set; }
        public virtual Tournament Tournament { get; set; }
    }
}
