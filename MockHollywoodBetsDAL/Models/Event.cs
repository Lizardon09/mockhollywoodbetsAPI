using System;
using System.Collections.Generic;

namespace MockHollywoodBetsDAL.Models
{
    public partial class Event
    {
        public Event()
        {
            Odds = new HashSet<Odds>();
            Bet = new HashSet<Bet>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? Date { get; set; }
        public int TournamentId { get; set; }

        public virtual Tournament Tournament { get; set; }
        public virtual ICollection<Odds> Odds { get; set; }
        public virtual ICollection<Bet> Bet { get; set; }
    }
}
