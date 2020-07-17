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

        IQueryable<Market> GetMarket(long? marketid);
        IQueryable<Market> GetMarkets();

        int AddMarketBettype(MarketBettype entity);
        int UpdateMarketBettype(MarketBettype entity);
        int DeleteMarketBettype(long? id);

        IQueryable<MarketBettypeInfo> GetAllMarketBettypeInfo();
        IQueryable<MarketBettypeInfo> GetMarketBettypeInfo(long? marketbettypeid);

        int AddOdd(Odds entity);
        int UpdateOdd(Odds entity);
        int DeleteOdd(long? id);

        IQueryable<OddInfo> GetAllOddInfo();
        IQueryable<OddInfo> GetOddInfo(long? oddid);
    }
}
