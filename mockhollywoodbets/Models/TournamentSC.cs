using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockHollywoodBets.Models
{
    public class TournamentSC
    {
        public long Countrycode { get; set; }
        public long Sportcode { get; set; }
        public List<long> Tournamentcodes { get; set; }

        public TournamentSC(long countryid, long sportid, List<long> tournamentids)
        {
            this.Countrycode = countryid;
            this.Sportcode = sportid;
            this.Tournamentcodes = tournamentids;
        }
    }
}
