using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockHollywoodBets.Models
{
    public class TournamentBettype
    {
        public long TournamentID { get; set; }
        public List<long> BettypeID { get; set; }

        public TournamentBettype()
        {

        }

        public TournamentBettype(long tournamentid, List<long> bettypeids)
        {
            this.TournamentID = tournamentid;
            this.BettypeID = bettypeids;
        }

    }
}
