using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockHollywoodBetsDAL.CustomModels;
using MockHollywoodBetsDAL.Models;

namespace MockHollywoodBetsDAL.DataManagers.Repository.Interfaces
{
    public interface ITournamentRepository : IDataRepository<Tournament>
    {
        IQueryable<Tournament> Get(long? sportid, long? countryid);
        IQueryable<Tournament> GetTournament(long? tournamentid);

        int AddTournamentSC(TournamentSc entity);
        int UpdateTournamentSC(TournamentSc entity);
        int DeleteTournamentSC(long? id);

        int AddTournamentBettype(TournamentBettype entity);
        int UpdateTournamentBettype(TournamentBettype entity);
        int DeleteTournamentBettype(long? id);

        IQueryable<TournamentBettypeInfo> GetAllTournamentBettypeInfo();
        IQueryable<TournamentBettypeInfo> GetTournamentBettypeInfo(long? tournamentbettypeid);

        IQueryable<TournamentSCInfo> GetAllTournamentSCInfo();
        IQueryable<TournamentSCInfo> GetTournamentSCInfo(long? tournamentscid);
    }
}
