using System;
using System.Collections.Generic;

namespace MockHollywoodBetsDAL.Models
{
    public partial class Country
    {
        public Country()
        {
            SportCountry = new HashSet<SportCountry>();
            TournamentSc = new HashSet<TournamentSc>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }

        public virtual ICollection<SportCountry> SportCountry { get; set; }
        public virtual ICollection<TournamentSc> TournamentSc { get; set; }
    }
}