using System;
using System.Collections.Generic;

namespace MockHollywoodBetsDAL.Models
{
    public partial class SportTree
    {
        public SportTree()
        {
            SportCountry = new HashSet<SportCountry>();
            TournamentSc = new HashSet<TournamentSc>();
            Bet = new HashSet<Bet>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }

        public virtual ICollection<SportCountry> SportCountry { get; set; }
        public virtual ICollection<TournamentSc> TournamentSc { get; set; }
        public virtual ICollection<Bet> Bet { get; set; }
    }
}
