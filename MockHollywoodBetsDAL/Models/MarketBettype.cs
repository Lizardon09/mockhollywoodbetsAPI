using System;
using System.Collections.Generic;

namespace MockHollywoodBetsDAL.Models
{
    public partial class MarketBettype
    {
        public MarketBettype()
        {
            Odds = new HashSet<Odds>();
        }

        public int Id { get; set; }
        public int? MarketId { get; set; }
        public int? BettypeId { get; set; }

        public virtual Bettype Bettype { get; set; }
        public virtual Market Market { get; set; }
        public virtual ICollection<Odds> Odds { get; set; }
    }
}
