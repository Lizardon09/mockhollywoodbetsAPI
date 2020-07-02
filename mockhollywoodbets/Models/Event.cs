﻿using System;
using System.Collections.Generic;

namespace MockHollywoodBets.Models
{
    public partial class Event
    {
        public Event()
        {
            Odds = new HashSet<Odds>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? Date { get; set; }
        public int TournamentId { get; set; }

        public virtual Tournament Tournament { get; set; }
        public virtual ICollection<Odds> Odds { get; set; }
    }
}
