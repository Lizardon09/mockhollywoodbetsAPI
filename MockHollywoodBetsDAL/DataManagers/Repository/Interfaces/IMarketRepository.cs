using MockHollywoodBetsDAL.CustomModels;
using MockHollywoodBetsDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockHollywoodBetsDAL.DataManagers.Repository.Interfaces
{
    public interface IMarketRepository : IDataRepository<Market>
    {
        IQueryable<MarketOdd> Get(long? tournamentid);
        IQueryable<MarketOdd> GetAll();
    }
}
