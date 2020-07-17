using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockHollywoodBetsDAL.Models;

namespace MockHollywoodBetsDAL.DataManagers.Repository.Interfaces
{
    public interface IBettypeRepository : IDataRepository<Bettype>
    {
        IQueryable<Bettype> Get(long? tournamentid);
        IQueryable<Bettype> GetBettype(long? bettypeid);
        int Delete(long? entity);

        int AddTournamentBettype(TournamentBettype entity);
        int UpdateTournamentBettype(TournamentBettype entity);
        int DeleteTournamentBettype(long? id);

        int AddMarketBettype(MarketBettype entity);
        int UpdateMarketBettype(MarketBettype entity);
        int DeleteMarketBettype(long? id);
    }
}
