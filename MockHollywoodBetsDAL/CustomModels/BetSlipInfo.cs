using MockHollywoodBetsDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MockHollywoodBetsDAL.CustomModels
{
    public class BetSlipInfo
    {
        public BetSlip BetSlip { get; set; }
        public List<Bet> Bets { get; set; }

    }
}
