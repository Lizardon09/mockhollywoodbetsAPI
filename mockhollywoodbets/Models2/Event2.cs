using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockHollywoodBets.Models2
{
    public class Event2
    {
        public long TournamentID { get; set; }
        public long EventID { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }

        public Event2()
        {

        }

        public Event2(long tournamentid, long eventid, string eventname, DateTime eventdate)
        {
            this.TournamentID = tournamentid;
            this.EventID = eventid;
            this.EventName = eventname;
            this.EventDate = eventdate;
        }

    }
}
