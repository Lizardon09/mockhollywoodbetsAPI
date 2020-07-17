using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MockHollywoodBetsDAL.CustomModels
{
    public class MarketBettypeInfo
    {

        [Key]
        public int Id { get; set; }
        public int MarketId { get; set; }
        public string MarketName { get; set; }
        public int BettypeId { get; set; }
        public string BettypeName { get; set; }

    }

}
