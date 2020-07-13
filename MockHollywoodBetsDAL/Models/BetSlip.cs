using System;
using System.Collections.Generic;
using System.Text;

namespace MockHollywoodBetsDAL.Models
{
    public partial class BetSlip
    {
        public BetSlip()
        {
            Bet = new HashSet<Bet>();
        }

        public int Id { get; set; }
        public decimal? TotalStake { get; set; }
        public decimal? TotalPayout { get; set; }
        public decimal? FinalOdds { get; set; }
        public int AccountId { get; set; }

        public virtual Account Account { get; set; }
        public virtual ICollection<Bet> Bet { get; set; }
    }
}
