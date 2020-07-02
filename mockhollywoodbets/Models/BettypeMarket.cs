using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockHollywoodBets.Models
{
    public class BettypeMarket
    {
        public long BettypeID { get; set; }
        public List<long> MarketID { get; set; }

        public BettypeMarket()
        {

        }

        public BettypeMarket(long bettypeid, List<long> marketids)
        {
            this.BettypeID = bettypeid;
            this.MarketID = marketids;
        }

    }
}
