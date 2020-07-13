using System;
using System.Collections.Generic;

namespace MockHollywoodBetsDAL.Models
{
    public partial class Market
    {
        public Market()
        {
            MarketBettype = new HashSet<MarketBettype>();
            Bet = new HashSet<Bet>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MarketBettype> MarketBettype { get; set; }
        public virtual ICollection<Bet> Bet { get; set; }
    }
}
