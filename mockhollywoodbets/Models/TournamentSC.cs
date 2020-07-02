using System;
using System.Collections.Generic;

namespace MockHollywoodBets.Models
{
    public partial class TournamentSc
    {
        public int Id { get; set; }
        public int? TournamentId { get; set; }
        public int? CountryId { get; set; }
        public int? SportId { get; set; }

        public virtual Country Country { get; set; }
        public virtual SportTree Sport { get; set; }
        public virtual Tournament Tournament { get; set; }
    }
}
