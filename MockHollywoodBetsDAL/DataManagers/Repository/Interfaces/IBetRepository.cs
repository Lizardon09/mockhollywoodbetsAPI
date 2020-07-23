using MockHollywoodBetsDAL.CustomModels;
using MockHollywoodBetsDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MockHollywoodBetsDAL.DataManagers.Repository.Interfaces
{
    public interface IBetRepository : IDataRepository<BetSlipInfo>
    {
        IQueryable<BetSlip> GetAllBetSlip();
        IQueryable<BetSlip> GetBetSlip(long? betslipid);

        IQueryable<BetInfo> GetAllBets();
        IQueryable<BetInfo> GetBetInfo(long? betslipid);

    }
}
