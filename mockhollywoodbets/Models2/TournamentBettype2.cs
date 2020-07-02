using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockHollywoodBets.Models2
{
    public class TournamentBettype2
    {
        public long TournamentID { get; set; }
        public List<long> BettypeID { get; set; }

        public TournamentBettype2()
        {

        }

        public TournamentBettype2(long tournamentid, List<long> bettypeids)
        {
            this.TournamentID = tournamentid;
            this.BettypeID = bettypeids;
        }

    }
}
