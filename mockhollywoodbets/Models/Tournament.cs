using System;
using System.Collections.Generic;

namespace MockHollywoodBets.Models
{
    public partial class Tournament
    {
        public Tournament()
        {
            Event = new HashSet<Event>();
            TournamentBettype = new HashSet<TournamentBettype>();
            TournamentSc = new HashSet<TournamentSc>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Event> Event { get; set; }
        public virtual ICollection<TournamentBettype> TournamentBettype { get; set; }
        public virtual ICollection<TournamentSc> TournamentSc { get; set; }
    }
}
