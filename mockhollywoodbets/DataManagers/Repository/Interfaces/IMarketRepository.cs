using MockHollywoodBets.CustomModels;
using MockHollywoodBets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockHollywoodBets.DataManagers.Repository.Interfaces
{
    public interface IMarketRepository : IDataRepository<Market>
    {
        IQueryable<MarketOdd> Get(long? tournamentid);
        IQueryable<MarketOdd> GetAll();
    }
}
