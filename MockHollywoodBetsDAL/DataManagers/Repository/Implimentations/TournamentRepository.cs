using Microsoft.EntityFrameworkCore;
using MockHollywoodBetsDAL.DataManagers.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockHollywoodBetsDAL.Models;
using Dapper;
using MockHollywoodBetsDAL.CustomModels;

namespace MockHollywoodBetsDAL.DataManagers.Repository.Implimentations
{
    public class TournamentRepository : ITournamentRepository
    {

        private IDataBase _dbService;

        public TournamentRepository(IDataBase dbService)
        {
            _dbService = dbService;
        }

        public int Add(Tournament entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.InsertTournament {entity.Name}");
                return result + 1;
            }
        }

        public int Update(Tournament entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.UpdateTournament {entity.Id},{entity.Name}");
                return result + 1;
            }
        }

        public int Delete(long? id)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.DeleteTournament {id}");
                return result + 1;
            }
        }

        public int AddTournamentSC(TournamentSc entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.InsertTournamentSC {entity.TournamentId},{entity.CountryId},{entity.SportId}");
                return result + 1;
            }
        }

        public int AddTournamentBettype(TournamentBettype entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.InsertTournamentBettype {entity.TournamentId},{entity.BettypeId}");
                return result + 1;
            }
        }

        public int UpdateTournamentBettype(TournamentBettype entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.UpdateTournamentBettype {entity.Id},{entity.TournamentId},{entity.BettypeId}");
                return result + 1;
            }
        }

        public int UpdateTournamentSC(TournamentSc entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.UpdateTournamentSC {entity.Id},{entity.TournamentId},{entity.CountryId},{entity.SportId}");
                return result + 1;
            }
        }

        public int DeleteTournamentBettype(long? id)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.DeleteTournamentBettype {id}");
                return result + 1;
            }
        }

        public int DeleteTournamentSC(long? id)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.DeleteTournamentSC {id}");
                return result + 1;
            }
        }

        public Tournament Get(long id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Tournament> Get(long? sportid, long? countryid)
        {
            return _dbService.dbContext().Tournament.FromSqlInterpolated($"EXECUTE dbo.GetTournamentBySC {sportid},{countryid}").AsQueryable();
        }

        public IQueryable<Tournament> GetAll()
        {
            return _dbService.dbContext().Tournament.FromSqlInterpolated($"EXECUTE dbo.GetAllTournaments").AsQueryable();
        }

        public IQueryable<Tournament> GetTournament(long? tournamentid)
        {
            return _dbService.dbContext().Tournament.FromSqlInterpolated($"EXECUTE dbo.GetTournamentByTournamentId {tournamentid}").AsQueryable();
        }

        public IQueryable<TournamentBettypeInfo> GetAllTournamentBettypeInfo()
        {
            return _dbService.dbContext().TournamentBettypeInfo.FromSqlInterpolated($"EXECUTE dbo.GetAllTournamentBettypeInfo").AsQueryable();
        }

        public IQueryable<TournamentBettypeInfo> GetTournamentBettypeInfo(long? tournamentbettypeid)
        {
            return _dbService.dbContext().TournamentBettypeInfo.FromSqlInterpolated($"EXECUTE dbo.GetTournamentBettypeInfoById {tournamentbettypeid}").AsQueryable();
        }

        public IQueryable<TournamentSCInfo> GetAllTournamentSCInfo()
        {
            return _dbService.dbContext().TournamentSCInfo.FromSqlInterpolated($"EXECUTE dbo.GetAllTournamentSCInfo").AsQueryable();
        }

        public IQueryable<TournamentSCInfo> GetTournamentSCInfo(long? tournamentscid)
        {
            return _dbService.dbContext().TournamentSCInfo.FromSqlInterpolated($"EXECUTE dbo.GetTournamentSCInfoById {tournamentscid}").AsQueryable();
        }
    }
}
