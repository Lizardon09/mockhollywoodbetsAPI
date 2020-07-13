using System;
using System.Collections.Generic;

namespace MockHollywoodBetsDAL.Models
{
    public partial class Bettype
    {
        public Bettype()
        {
            MarketBettype = new HashSet<MarketBettype>();
            TournamentBettype = new HashSet<TournamentBettype>();
            Bet = new HashSet<Bet>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MarketBettype> MarketBettype { get; set; }
        public virtual ICollection<TournamentBettype> TournamentBettype { get; set; }
        public virtual ICollection<Bet> Bet { get; set; }

    }
}
