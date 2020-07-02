using System;
using System.Collections.Generic;

namespace MockHollywoodBets.Models
{
    public partial class Market
    {
        public Market()
        {
            MarketBettype = new HashSet<MarketBettype>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MarketBettype> MarketBettype { get; set; }
    }
}
