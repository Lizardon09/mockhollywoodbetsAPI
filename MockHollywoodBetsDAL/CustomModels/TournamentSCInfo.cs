using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MockHollywoodBetsDAL.CustomModels
{
    public class TournamentSCInfo
    {
        [Key]
        public int Id { get; set; }
        public int TournamentId { get; set; }
        public string TournamentName { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public int SportId { get; set; }
        public string SportName { get; set; }
    }
}
