using System;
using System.Collections.Generic;

namespace MockHollywoodBetsDAL.Models
{
    public partial class TournamentBettype
    {
        public int Id { get; set; }
        public int? TournamentId { get; set; }
        public int? BettypeId { get; set; }

        public virtual Bettype Bettype { get; set; }
        public virtual Tournament Tournament { get; set; }
    }
}
