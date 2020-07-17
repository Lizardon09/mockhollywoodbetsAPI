using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MockHollywoodBetsDAL.CustomModels
{
    public class OddInfo
    {
        [Key]
        public int Id { get; set; }
        public int MarketBettypeId { get; set; }
        public string MarketName { get; set; }
        public string BettypeName { get; set; }
        public int EventId { get; set; }
        public string EventName { get; set; }
        public decimal Odds { get; set; }
    }
}
