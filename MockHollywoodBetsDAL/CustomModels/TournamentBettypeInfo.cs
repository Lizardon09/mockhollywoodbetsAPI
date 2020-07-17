using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MockHollywoodBetsDAL.CustomModels
{
    public class TournamentBettypeInfo
    {
        [Key]
        public int Id { get; set; }
        public int TournamentId { get; set; }
        public string TournamentName { get; set; }
        public int BettypeId { get; set; }
        public string BettypeName { get; set; }
    }
}
