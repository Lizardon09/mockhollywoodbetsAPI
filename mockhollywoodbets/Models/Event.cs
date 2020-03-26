using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mockhollywoodbets.Models
{
    public class Event
    {
        public long TournamentID { get; set; }
        public long EventID { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }

        public Event()
        {

        }

        public Event(long tournamentid, long eventid, string eventname, DateTime eventdate)
        {
            this.TournamentID = tournamentid;
            this.EventID = eventid;
            this.EventName = eventname;
            this.EventDate = eventdate;
        }

    }
}
